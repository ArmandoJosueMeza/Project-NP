USE master
GO

/* 
	Creacion de la base de datos para que el QUERY sea de una sola ejecucion 
*/
IF EXISTS(SELECT * FROM sys.databases WHERE name='BD_SERVICE_DESK')
BEGIN
	DROP DATABASE BD_SERVICE_DESK
END
GO

CREATE DATABASE BD_SERVICE_DESK
GO

/*	Utilizacion de la base de datos BD SERVICE DESK, para el software 
	Mesa de ayuda en el area de Servicio Tecnico Domicilio de la 
	empresa Network Place. 
*/
USE BD_SERVICE_DESK
GO

/*
	Estructura de los esquemas principales a utilizar los cuales son:
		* Personas:	Clientes, Usuarios, Tecnicos
		* Equipos:	Equipo
		* Registro:	Acciones, Ticket, Entrega

*/

CREATE SCHEMA Personas
GO

CREATE SCHEMA Equipos
GO

CREATE SCHEMA Registros
GO

/* TABLA CLIENTE */
IF EXISTS(SELECT * FROM sys.databases WHERE name='Personas.Cliente')
BEGIN
	DROP TABLE Personas.Cliente
END
GO

CREATE TABLE Personas.Cliente
(
	IDCliente			INT				IDENTITY(1,1),	
	No_Cliente			AS				(RIGHT ('000' + CONVERT (NVARCHAR, IDCliente), (3))) PERSISTED CONSTRAINT PK_Personas_Cliente_ID PRIMARY KEY CLUSTERED, 										
	Nombre_Cliente		NVARCHAR(50)	NOT NULL,
	Apellido_Cliente	NVARCHAR(50)	NOT NULL,
	Empresa				NVARCHAR(50)			,
	Ubicacion			TEXT			NOT NULL,
	Telefono			NVARCHAR(9)		NOT NULL,
	Correo_Electronico	NVARCHAR(50)	
)
GO

/* TABLA USUARIO */
IF EXISTS(SELECT * FROM sys.databases WHERE name='Personas.Usuario')
BEGIN
	DROP TABLE Personas.Usuario
END
GO

CREATE TABLE Personas.Usuario
(
	IDUsuario			INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
	Nombre_Usuario		NVARCHAR(50)	NOT NULL,
	Apellido_Usuario	NVARCHAR(50)	NOT NULL,
	Correo_Usuario		NVARCHAR(50)	NOT NULL,
	Nombre_Acceso		NVARCHAR(50)	NOT NULL,	
	Clave_Usuario		NVARCHAR(50)	NOT NULL
)
GO

/* TABLA TECNICO */
IF EXISTS(SELECT * FROM sys.databases WHERE name='Personas.Tecnico')
BEGIN
	DROP TABLE Personas.Tecnico
END
GO

CREATE TABLE Personas.Tecnico
(
	IDTecnico			INT				IDENTITY(1,1),	
	No_Tecnico			AS				(RIGHT ('000' + CONVERT (NVARCHAR, IDTecnico), (3))) PERSISTED CONSTRAINT PK_Personas_Tecnico_ID PRIMARY KEY CLUSTERED,
	Nombre_Tecnico		NVARCHAR(50)	NOT NULL,
	Apellido_Tecnico	NVARCHAR(50)	NOT NULL,
	Telefono			NVARCHAR(9)		NOT NULL,
	Correo_Tecnico		NVARCHAR(50)	NOT NULL
)
GO


/* TABLA ARTICULO */
IF EXISTS(SELECT * FROM sys.databases WHERE name='Articulos.Articulo')
BEGIN
	DROP TABLE Equipos.Equipo
END
GO


CREATE TABLE Equipos.Equipo
(
	No_Cliente			NVARCHAR(3)		NOT NULL,
	Equipo				NVARCHAR(50)	NOT NULL,
	Marca				NVARCHAR(50)	NOT NULL,
	Modelo				NVARCHAR(50)	NOT NULL,
	No_Serie			NVARCHAR(50)	CONSTRAINT PK_Articulos_Articulo_ID PRIMARY KEY CLUSTERED,
	Clave_Acceso		NVARCHAR(50)	
)
GO

/* TABLA ESTADO-TICKET */
IF EXISTS(SELECT * FROM sys.databases WHERE name='Registros.Estado')
BEGIN
	DROP TABLE Registros.Estado
END
GO

CREATE TABLE Registros.Estado
(
	IDEstado	INT IDENTITY(1,1)	CONSTRAINT PK_Registros_Estado_ID PRIMARY KEY CLUSTERED,
	Tipo_Estado	NVARCHAR(15)		NOT NULL,
)
GO


/* TABLA TICKET */
IF EXISTS(SELECT * FROM sys.databases WHERE name='Registros.Ticket')
BEGIN
	DROP TABLE Registros.Ticket
END
GO

CREATE TABLE Registros.Ticket
(
	IDTicket					INT							IDENTITY(1,1),
	No_Ticket					AS							('TIK-' + RIGHT ('0000' + CONVERT (NVARCHAR, IDTicket), (4))) PERSISTED CONSTRAINT PK_Registros_Ticket_ID PRIMARY KEY CLUSTERED, 
	No_Cliente					NVARCHAR(3)					NOT NULL,
	No_Serie					NVARCHAR(50)				NOT NULL,
	No_Tecnico_Asignado			NVARCHAR(3)					NOT NULL,
	Fecha_Ticket				DATETIME DEFAULT GETDATE()	NOT NULL,
	IDEstado					INT							NOT NULL,
	Problema_Reportado			TEXT						NOT NULL, 
	Observaciones				TEXT						NOT NULL
)
GO

/* TABLA ENTREGA */
IF EXISTS(SELECT * FROM sys.databases WHERE name='Registros.Entrega')
BEGIN
	DROP TABLE Registros.Entrega
END
GO

CREATE TABLE Registros.Entrega 
(
	IDEntrega					INT IDENTITY(1,1),
	No_Entrega					AS ('ETR-' + RIGHT ('0000' + CONVERT (VARCHAR, IDEntrega), (4))) PERSISTED CONSTRAINT PK_Registros_Entrega_ID PRIMARY KEY CLUSTERED, 
	No_Ticket					NVARCHAR(8)					NOT NULL,
	No_Cliente					NVARCHAR(3) NOT NULL,
	No_Serie					NVARCHAR(50)				NOT NULL,
	No_Tecnico_Asignado			NVARCHAR(3)					NOT NULL,
	IDEstado					INT							NOT NULL,
	Fecha_Entrega				DATETIME DEFAULT GETDATE()	NOT NULL,
	Trabajo_Realizado			TEXT						NOT NULL,
	Repuesto					TEXT						NOT NULL,
	Garantia					NVARCHAR(15)				NOT NULL,
)
GO


/* LLAVES FORANEAS */
/* TABLA EQUIPO */
/* Articulo - Cliente */
ALTER TABLE		Equipos.Equipo
ADD CONSTRAINT	FK_Equipos_Equipo$TIENE_UN$Personas_Cliente
FOREIGN KEY		(No_Cliente) 
REFERENCES		Personas.Cliente(No_Cliente)
ON DELETE NO ACTION
ON UPDATE NO ACTION;
GO

/* TABLA TICKET */
/* Ticket - Cliente */
ALTER TABLE		Registros.Ticket
ADD CONSTRAINT	FK_Registros_Ticket$TIENE_UN$Personas_Cliente
FOREIGN KEY		(No_Cliente) 
REFERENCES		Personas.Cliente(No_Cliente)
ON DELETE NO ACTION
ON UPDATE NO ACTION;
GO

/* Ticket - Articulo */
ALTER TABLE		Registros.Ticket
ADD CONSTRAINT	FK_Registros_Ticket$TIENE_UN$Articulos_Articulo
FOREIGN KEY		(No_Serie) 
REFERENCES		Equipos.Equipo(No_Serie)
ON DELETE NO ACTION
ON UPDATE NO ACTION;
GO

/* Ticket - Estado */
ALTER TABLE		Registros.Ticket
ADD CONSTRAINT	FK_Registros_Ticket$TIENE_UN$Registros_Estado
FOREIGN KEY		(IDEstado) 
REFERENCES		Registros.Estado(IDEstado)
ON DELETE NO ACTION
ON UPDATE NO ACTION;
GO

/* Ticket - Tecnico */
ALTER TABLE		Registros.Ticket
ADD CONSTRAINT	FK_Registros_Ticket$TIENE_UN$Personas_Tecnico
FOREIGN KEY		(No_Tecnico_Asignado) 
REFERENCES		Personas.Tecnico(No_Tecnico)
ON DELETE NO ACTION
ON UPDATE NO ACTION;
GO

/* TABLA ENTREGA */
/* Entrega - Ticket */

ALTER TABLE		Registros.Entrega
ADD CONSTRAINT	FK_Registros_Entrega$TIENE_UN$Registros_Ticket
FOREIGN KEY		(No_Ticket) 
REFERENCES		Registros.Ticket(No_Ticket)
ON DELETE NO ACTION
ON UPDATE NO ACTION;
GO

ALTER TABLE		Registros.Entrega
ADD CONSTRAINT	FK_Registros_Entrega$TIENE_UN$Personas_Cliente
FOREIGN KEY		(No_Cliente) 
REFERENCES		Personas.Cliente(No_Cliente)
ON DELETE NO ACTION
ON UPDATE NO ACTION;
GO

ALTER TABLE		Registros.Entrega
ADD CONSTRAINT	FK_Registros_Entrega$TIENE_UN$Articulos_Articulo
FOREIGN KEY		(No_Serie) 
REFERENCES		Equipos.Equipo(No_Serie)
ON DELETE NO ACTION
ON UPDATE NO ACTION;
GO

ALTER TABLE		Registros.Entrega
ADD CONSTRAINT	FK_Registros_Entrega$TIENE_UN$Registros_Estado
FOREIGN KEY		(IDEstado) 
REFERENCES		Registros.Estado(IDEstado)
ON DELETE NO ACTION
ON UPDATE NO ACTION;
GO

ALTER TABLE		Registros.Entrega
ADD CONSTRAINT	FK_Registros_Entrega$TIENE_UN$Personas_Tecnico
FOREIGN KEY		(No_Tecnico_Asignado) 
REFERENCES		Personas.Tecnico(No_Tecnico)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

/* LLAVES UNICAS */

/* Nombre de Usuario */
ALTER TABLE Personas.Usuario
	ADD CONSTRAINT AK_Personas_Usuario_Nombre_Usuario
	UNIQUE NONCLUSTERED (Nombre_Acceso);
GO
/*Clave de Acceso del Usuario */
ALTER TABLE Personas.Usuario
	ADD CONSTRAINT AK_Personas_Usuario_Clave
	UNIQUE NONCLUSTERED (Clave_Usuario);
GO

/* VISTAS */

/* CLIENTE */
CREATE VIEW V_CLIENTES
AS 
SELECT 
CLI.No_Cliente, 
CLI.Nombre_Cliente, 
CLI.Apellido_Cliente, 
CLI.Empresa,
CLI.Ubicacion,
CLI.Telefono,
CLI.Correo_Electronico
FROM Personas.Cliente as "CLI" 
GO

/* TECNICO */
CREATE VIEW V_TECNICOS
AS 
SELECT 
TEC.No_Tecnico,
TEC.Nombre_Tecnico,
TEC.Apellido_Tecnico,
TEC.Telefono,
TEC.Correo_Tecnico
FROM Personas.Tecnico as "TEC" 
GO

/* EQUIPOS - CLIENTE */
CREATE VIEW V_EQUIPOS_CLIENTES
AS 
SELECT 
CLI.No_Cliente, 
CLI.Nombre_Cliente, 
CLI.Apellido_Cliente, 
EQU.Equipo,
EQU.Marca,
EQU.Modelo,
EQU.No_Serie, 
EQU.Clave_Acceso

FROM Equipos.Equipo as "EQU" 
JOIN Personas.Cliente AS "CLI" ON EQU.No_Cliente= CLI.No_Cliente
GO

/* TICKET - VISTA */
CREATE VIEW V_TICKET
AS 
SELECT 
TIC.No_Ticket,
EST.Tipo_Estado,
TIC.Fecha_Ticket,
CLI.No_Cliente,
CLI.Nombre_Cliente,
CLI.Apellido_Cliente,
EQU.Equipo,
EQU.Marca,
EQU.Modelo,
EQU.No_Serie, 
TIC.Problema_Reportado,
TIC.Observaciones,
TEC.Nombre_Tecnico,
TEC.Apellido_Tecnico

FROM (((Registros.Ticket AS TIC 
INNER JOIN Personas.Cliente AS CLI		ON TIC.No_Cliente = CLI.No_Cliente)
INNER JOIN Equipos.Equipo AS EQU		ON TIC.No_Serie = EQU.No_Serie)
INNER JOIN Registros.Estado AS EST		ON TIC.IDEstado = EST.IDEstado)
INNER JOIN Personas.Tecnico AS TEC		ON TIC.No_Tecnico_Asignado = TEC.No_Tecnico
GO



/* ENTREGA - VISTA */
CREATE VIEW V_ENTREGA 
AS 
SELECT
ENT.No_Entrega,
TIC.No_Ticket,
CLI.No_Cliente,
CLI.Nombre_Cliente,
CLI.Apellido_Cliente,
EST.Tipo_Estado,
EQU.Equipo,
EQU.Marca,
EQU.Modelo,
EQU.No_Serie, 
ENT.Fecha_Entrega,
ENT.Trabajo_Realizado,
ENT.Repuesto,
TEC.Nombre_Tecnico,
TEC.Apellido_Tecnico

FROM ((((Registros.Entrega AS ENT 
INNER JOIN Registros.Ticket AS TIC		ON ENT.No_Ticket = TIC.No_Ticket)
INNER JOIN Personas.Cliente AS CLI		ON ENT.No_Cliente = CLI.No_Cliente)
INNER JOIN Equipos.Equipo AS EQU		ON ENT.No_Serie = EQU.No_Serie)
INNER JOIN Registros.Estado AS EST		ON ENT.IDEstado = EST.IDEstado)
INNER JOIN Personas.Tecnico AS TEC		ON ENT.No_Tecnico_Asignado = TEC.No_Tecnico
GO


/* TICKET PENDIENTE */
CREATE VIEW V_TICKET_PENDIENTE
AS 
SELECT 
TIC.No_Ticket,
EST.Tipo_Estado,
TIC.Fecha_Ticket,
CLI.No_Cliente,
CLI.Nombre_Cliente,
CLI.Apellido_Cliente,
EQU.Equipo,
EQU.Marca,
EQU.Modelo,
EQU.No_Serie, 
TIC.Problema_Reportado,
TIC.Observaciones,
TEC.Nombre_Tecnico,
TEC.Apellido_Tecnico

FROM (((Registros.Ticket AS TIC 
INNER JOIN Personas.Cliente AS CLI		ON TIC.No_Cliente = CLI.No_Cliente)
INNER JOIN Equipos.Equipo AS EQU		ON TIC.No_Serie = EQU.No_Serie)
INNER JOIN Registros.Estado AS EST		ON TIC.IDEstado = EST.IDEstado)
INNER JOIN Personas.Tecnico AS TEC		ON TIC.No_Tecnico_Asignado = TEC.No_Tecnico
WHERE EST.Tipo_Estado = 'PENDIENTE'
GO

/* TICKET EN PROCESO */
CREATE VIEW V_TICKET_PROCESO
AS 
SELECT 
TIC.No_Ticket,
EST.Tipo_Estado,
TIC.Fecha_Ticket,
CLI.No_Cliente,
CLI.Nombre_Cliente,
CLI.Apellido_Cliente,
EQU.Equipo,
EQU.Marca,
EQU.Modelo,
EQU.No_Serie, 
TIC.Problema_Reportado,
TIC.Observaciones,
TEC.Nombre_Tecnico,
TEC.Apellido_Tecnico

FROM (((Registros.Ticket AS TIC 
INNER JOIN Personas.Cliente AS CLI		ON TIC.No_Cliente = CLI.No_Cliente)
INNER JOIN Equipos.Equipo AS EQU		ON TIC.No_Serie = EQU.No_Serie)
INNER JOIN Registros.Estado AS EST		ON TIC.IDEstado = EST.IDEstado)
INNER JOIN Personas.Tecnico AS TEC		ON TIC.No_Tecnico_Asignado = TEC.No_Tecnico
WHERE EST.Tipo_Estado = 'EN PROCESO'
GO


/* TICKET RESUELTO */

CREATE VIEW V_TICKET_RESUELTO
AS 
SELECT 
TIC.No_Ticket,
EST.Tipo_Estado,
TIC.Fecha_Ticket,
CLI.No_Cliente,
CLI.Nombre_Cliente,
CLI.Apellido_Cliente,
EQU.Equipo,
EQU.Marca,
EQU.Modelo,
EQU.No_Serie, 
TIC.Problema_Reportado,
TIC.Observaciones,
TEC.Nombre_Tecnico,
TEC.Apellido_Tecnico

FROM (((Registros.Ticket AS TIC 
INNER JOIN Personas.Cliente AS CLI		ON TIC.No_Cliente = CLI.No_Cliente)
INNER JOIN Equipos.Equipo AS EQU		ON TIC.No_Serie = EQU.No_Serie)
INNER JOIN Registros.Estado AS EST		ON TIC.IDEstado = EST.IDEstado)
INNER JOIN Personas.Tecnico AS TEC		ON TIC.No_Tecnico_Asignado = TEC.No_Tecnico
WHERE EST.Tipo_Estado = 'RESUELTO'
GO