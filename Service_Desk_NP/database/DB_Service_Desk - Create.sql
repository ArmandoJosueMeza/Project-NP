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
		* Personas: Clientes, Usuarios, Tecnicos
		* Articulos: Articulo
		* Registro: Acciones, Ticket, Entrega

*/


CREATE SCHEMA Personas
GO

CREATE SCHEMA Articulos
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
	Identidad_Cliente	NVARCHAR(15)	CONSTRAINT PK_Personas_Cliente_ID PRIMARY KEY CLUSTERED,											
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
	Identidad_Usuario	NVARCHAR(15)	CONSTRAINT PK_Personas_Usuario_ID PRIMARY KEY CLUSTERED,
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
	Identidad_Tecnico	NVARCHAR(15)	CONSTRAINT PK_Personas_Tecnico_ID PRIMARY KEY CLUSTERED,
	Nombre_Tecnico		NVARCHAR(50)	NOT NULL,
	Apellido_Tecnico	NVARCHAR(50)	NOT NULL,
	Telefono			NVARCHAR(9)		NOT NULL,
	Correo_Tecnico		NVARCHAR(50)	NOT NULL
)
GO


/* TABLA ARTICULO */
IF EXISTS(SELECT * FROM sys.databases WHERE name='Articulos.Articulo')
BEGIN
	DROP TABLE Articulos.Articulo
END
GO


CREATE TABLE Articulos.Articulo
(
	No_Serie			NVARCHAR(50)	CONSTRAINT PK_Articulos_Articulo_ID PRIMARY KEY CLUSTERED,
	Identidad_Cliente	NVARCHAR(15)	NOT NULL,
	Articulo			NVARCHAR(50)	NOT NULL,
	Marca				NVARCHAR(50)	NOT NULL,
	Modelo				NVARCHAR(50)	NOT NULL,
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
	IDTicket					INT IDENTITY(1,1) CONSTRAINT PK_Registros_Ticket_ID PRIMARY KEY CLUSTERED,
	No_Ticket					AS ('TIK' + RIGHT ('0000' + CONVERT (VARCHAR, IDTicket), (4))), 
	Identidad_Cliente			NVARCHAR(15)				NOT NULL,
	No_Serie					NVARCHAR(50)				NOT NULL,
	Identidad_Tecnico_Asignado	NVARCHAR(15)				NOT NULL,
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
	
	IDEntrega					INT IDENTITY(1,1) CONSTRAINT PK_Registros_Entrega_ID PRIMARY KEY CLUSTERED,
	No_Entrega					AS ('ETR' + RIGHT ('0000' + CONVERT (VARCHAR, IDEntrega), (4))), 
	Ticket_Entrega				INT							NOT NULL,
	Identidad_Cliente			NVARCHAR(15)				NOT NULL,
	No_Serie					NVARCHAR(50)				NOT NULL,
	Identidad_Tecnico_Asignado	NVARCHAR(15)				NOT NULL,
	IDEstado					INT							NOT NULL,
	Fecha_Entrega				DATETIME DEFAULT GETDATE()	NOT NULL,
	Trabajo_Realizado			TEXT						NOT NULL,
	Repuesto					TEXT						NOT NULL,
	Garantia					NVARCHAR(15)				NOT NULL,
)
GO


/* LLAVES PRIMARIAS */
/* TABLA TICKET */
/*ALTER TABLE Registros.Ticket ALTER COLUMN No_Ticket  NOT NULL;
GO*/



/* LLAVES FORANEAS */
/* TABLA ARTICULO */
/* Articulo - Cliente */
ALTER TABLE		Articulos.Articulo
ADD CONSTRAINT	FK_Articulos_Articulo$TIENE_UN$Personas_Cliente
FOREIGN KEY		(Identidad_Cliente) 
REFERENCES		Personas.Cliente(Identidad_Cliente)
ON DELETE NO ACTION
ON UPDATE NO ACTION;
GO

/* TABLA TICKET */
/* Ticket - Cliente */
ALTER TABLE		Registros.Ticket
ADD CONSTRAINT	FK_Registros_Ticket$TIENE_UN$Personas_Cliente
FOREIGN KEY		(Identidad_Cliente) 
REFERENCES		Personas.Cliente(Identidad_Cliente)
ON DELETE NO ACTION
ON UPDATE NO ACTION;
GO

/* Ticket - Articulo */
ALTER TABLE		Registros.Ticket
ADD CONSTRAINT	FK_Registros_Ticket$TIENE_UN$Articulos_Articulo
FOREIGN KEY		(No_Serie) 
REFERENCES		Articulos.Articulo(No_Serie)
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
FOREIGN KEY		(Identidad_Tecnico_Asignado) 
REFERENCES		Personas.Tecnico(Identidad_Tecnico)
ON DELETE NO ACTION
ON UPDATE NO ACTION;
GO

/* TABLA ENTREGA */
/* Entrega - Ticket */

ALTER TABLE		Registros.Entrega
ADD CONSTRAINT	FK_Registros_Entrega$TIENE_UN$Registros_Ticket
FOREIGN KEY		(Ticket_Entrega) 
REFERENCES		Registros.Ticket(IDTicket)
ON DELETE NO ACTION
ON UPDATE NO ACTION;
GO

ALTER TABLE		Registros.Entrega
ADD CONSTRAINT	FK_Registros_Entrega$TIENE_UN$Personas_Cliente
FOREIGN KEY		(Identidad_Cliente) 
REFERENCES		Personas.Cliente(Identidad_Cliente)
ON DELETE NO ACTION
ON UPDATE NO ACTION;
GO

ALTER TABLE		Registros.Entrega
ADD CONSTRAINT	FK_Registros_Entrega$TIENE_UN$Articulos_Articulo
FOREIGN KEY		(No_Serie) 
REFERENCES		Articulos.Articulo(No_Serie)
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
FOREIGN KEY		(Identidad_Tecnico_Asignado) 
REFERENCES		Personas.Tecnico(Identidad_Tecnico)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

/* LLAVES UNICAS */

/* TABLA CLIENTE */
/* Numero de Identidad del Cliente */
ALTER TABLE Personas.Cliente
	ADD CONSTRAINT AK_Personas_Identidad_Cliente
	UNIQUE NONCLUSTERED (Identidad_Cliente);
GO

/* TABLA USUARIO */
/* Numero de Identidad del Usuario */
ALTER TABLE Personas.Usuario
	ADD CONSTRAINT AK_Personas_Identidad_Usuario
	UNIQUE NONCLUSTERED (Identidad_Usuario);
GO
/* Nombre de Usuario */
ALTER TABLE Personas.Usuario
	ADD CONSTRAINT AK_Personas_Nombre_Usuario
	UNIQUE NONCLUSTERED (Nombre_Acceso);
GO
/*Clave de Acceso del Usuario */
ALTER TABLE Personas.Usuario
	ADD CONSTRAINT AK_Personas_Clave
	UNIQUE NONCLUSTERED (Clave_Usuario);
GO

/* TABLA TECNICO */
/* Numero de Identidad del Tecnico */
ALTER TABLE Personas.Tecnico
	ADD CONSTRAINT AK_Personas_Identidad_Tecnico
	UNIQUE NONCLUSTERED (Identidad_Tecnico);
GO

/* TABLA ARTICULO */
/* Numero de Serie */
ALTER TABLE Articulos.Articulo
	ADD CONSTRAINT AK_Articulos_No_Serie
	UNIQUE NONCLUSTERED (No_Serie);
GO

/* TABLA TICKET */
/* Numero de Ticket */
ALTER TABLE Registros.Ticket
	ADD CONSTRAINT AK_Registros_No_Ticket
	UNIQUE NONCLUSTERED (No_Ticket);
GO

/* TABLA ENTREGA */
/* Numero de Entrega */
ALTER TABLE Registros.Entrega
	ADD CONSTRAINT AK_Registros_No_Entrega
	UNIQUE NONCLUSTERED (No_Entrega);
GO

--------------------------------------------------------------------
/*
	Creacion de PROCEDURE necesarios para la base de datos en 
	Mesa de ayuda en el area de Servicio Tecnico Domicilio de la 
	empresa Network Place.

	Creacion de CRUD mediante utilizacion de PROCEDURE
*/
--------------------------------------------------------------------

/* VISTAS */

/* ARTICULO - CLIENTE */
CREATE VIEW V_ARTICULOS_CLIENTES
AS 
SELECT 


CLI.Identidad_Cliente, 
CLI.Nombre_Cliente, 
CLI.Apellido_Cliente, 
ART.No_Serie, 
ART.Articulo,
ART.Marca,
ART.Modelo,
ART.Clave_Acceso

FROM Articulos.Articulo as "ART" 
JOIN Personas.Cliente AS "CLI" ON ART.Identidad_Cliente= CLI.Identidad_Cliente
GO



/* TICKET - VISTA */
CREATE VIEW V_TICKET
AS 
SELECT 

TIC.No_Ticket,
EST.Tipo_Estado,
TIC.Fecha_Ticket,
CLI.Identidad_Cliente,
CLI.Nombre_Cliente,
CLI.Apellido_Cliente,
ART.No_Serie,
ART.Articulo,
TIC.Problema_Reportado,
TIC.Observaciones,
TEC.Nombre_Tecnico,
TEC.Apellido_Tecnico

FROM (((Registros.Ticket AS TIC 
INNER JOIN Personas.Cliente AS CLI		ON TIC.Identidad_Cliente = CLI.Identidad_Cliente)
INNER JOIN Articulos.Articulo AS ART	ON TIC.No_Serie = ART.No_Serie)
INNER JOIN Registros.Estado AS EST		ON TIC.IDEstado = EST.IDEstado)
INNER JOIN Personas.Tecnico AS TEC		ON TIC.Identidad_Tecnico_Asignado = TEC.Identidad_Tecnico

GO



/* ENTREGA - VISTA */
CREATE VIEW V_ENTREGA 
AS 
SELECT

ENT.No_Entrega,
TIC.No_Ticket,
CLI.Identidad_Cliente,
CLI.Nombre_Cliente,
CLI.Apellido_Cliente,
EST.Tipo_Estado,
ART.No_Serie,
ART.Articulo,
ART.Marca,
ENT.Fecha_Entrega,
ENT.Trabajo_Realizado,
ENT.Repuesto,
TEC.Nombre_Tecnico,
TEC.Apellido_Tecnico

FROM ((((Registros.Entrega AS ENT 
INNER JOIN Registros.Ticket AS TIC		ON ENT.Ticket_Entrega = TIC.IDTicket)
INNER JOIN Personas.Cliente AS CLI		ON ENT.Identidad_Cliente = CLI.Identidad_Cliente)
INNER JOIN Articulos.Articulo AS ART	ON ENT.No_Serie = ART.No_Serie)
INNER JOIN Registros.Estado AS EST		ON ENT.IDEstado = EST.IDEstado)
INNER JOIN Personas.Tecnico AS TEC		ON ENT.Identidad_Tecnico_Asignado = TEC.Identidad_Tecnico
GO


/* TICKET PENDIENTE */
CREATE VIEW V_TICKET_PENDIENTE
AS 
SELECT 

TIC.No_Ticket,
EST.Tipo_Estado,
TIC.Fecha_Ticket,
CLI.Identidad_Cliente,
CLI.Nombre_Cliente,
CLI.Apellido_Cliente,
ART.No_Serie,
ART.Articulo,
TIC.Problema_Reportado,
TIC.Observaciones,
TEC.Nombre_Tecnico,
TEC.Apellido_Tecnico

FROM (((Registros.Ticket AS TIC 
INNER JOIN Personas.Cliente AS CLI		ON TIC.Identidad_Cliente = CLI.Identidad_Cliente)
INNER JOIN Articulos.Articulo AS ART	ON TIC.No_Serie = ART.No_Serie)
INNER JOIN Registros.Estado AS EST		ON TIC.IDEstado = EST.IDEstado)
INNER JOIN Personas.Tecnico AS TEC		ON TIC.Identidad_Tecnico_Asignado = TEC.Identidad_Tecnico
WHERE EST.Tipo_Estado = 'PENDIENTE'
GO

/* TICKET EN PROCESO */
CREATE VIEW V_TICKET_PROCESO
AS 
SELECT 

TIC.No_Ticket,
EST.Tipo_Estado,
TIC.Fecha_Ticket,
CLI.Identidad_Cliente,
CLI.Nombre_Cliente,
CLI.Apellido_Cliente,
ART.No_Serie,
ART.Articulo,
TIC.Problema_Reportado,
TIC.Observaciones,
TEC.Nombre_Tecnico,
TEC.Apellido_Tecnico

FROM (((Registros.Ticket AS TIC 
INNER JOIN Personas.Cliente AS CLI		ON TIC.Identidad_Cliente = CLI.Identidad_Cliente)
INNER JOIN Articulos.Articulo AS ART	ON TIC.No_Serie = ART.No_Serie)
INNER JOIN Registros.Estado AS EST		ON TIC.IDEstado = EST.IDEstado)
INNER JOIN Personas.Tecnico AS TEC		ON TIC.Identidad_Tecnico_Asignado = TEC.Identidad_Tecnico
WHERE EST.Tipo_Estado = 'EN PROCESO'
GO


/* TICKET RESUELTO */

CREATE VIEW V_TICKET_RESUELTO
AS 
SELECT 

TIC.No_Ticket,
EST.Tipo_Estado,
TIC.Fecha_Ticket,
CLI.Identidad_Cliente,
CLI.Nombre_Cliente,
CLI.Apellido_Cliente,
ART.No_Serie,
ART.Articulo,
TIC.Problema_Reportado,
TIC.Observaciones,
TEC.Nombre_Tecnico,
TEC.Apellido_Tecnico

FROM (((Registros.Ticket AS TIC 
INNER JOIN Personas.Cliente AS CLI		ON TIC.Identidad_Cliente = CLI.Identidad_Cliente)
INNER JOIN Articulos.Articulo AS ART	ON TIC.No_Serie = ART.No_Serie)
INNER JOIN Registros.Estado AS EST		ON TIC.IDEstado = EST.IDEstado)
INNER JOIN Personas.Tecnico AS TEC		ON TIC.Identidad_Tecnico_Asignado = TEC.Identidad_Tecnico
WHERE EST.Tipo_Estado = 'RESUELTO'
GO