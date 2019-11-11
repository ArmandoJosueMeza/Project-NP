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
	IDCliente			INT IDENTITY(1, 1) CONSTRAINT PK_Personas_Cliente_ID PRIMARY KEY CLUSTERED, 
	Identidad_Cliente	NVARCHAR(15)	NOT NULL,											
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
	IDUsuario			INT IDENTITY(1, 1) CONSTRAINT PK_Personas_Usuario_ID PRIMARY KEY CLUSTERED,
	Identidad_Usuario	NVARCHAR(15)	NOT NULL,
	Nombre_Usuario		NVARCHAR(50)	NOT NULL,
	Apellido_Usuario	NVARCHAR(50)	NOT NULL,	
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
	IDTecnico			INT IDENTITY(1, 1) CONSTRAINT PK_Personas_Tecnico_ID PRIMARY KEY CLUSTERED,
	Identidad_Tecnico	NVARCHAR(15)	NOT NULL,
	Nombre_Tecnico		NVARCHAR(50)	NOT NULL,
	Apellido_Tecnico	NVARCHAR(50)	NOT NULL,
	Telefono			NVARCHAR(9)		NOT NULL
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
	IDArticulo		INT IDENTITY(1,1) CONSTRAINT PK_Articulos_Articulo_ID PRIMARY KEY CLUSTERED,
	IDCliente		INT				NOT NULL,
	No_Serie		VARCHAR(50)		NOT NULL,
	Articulo		NVARCHAR(50)	NOT NULL,
	Marca			NVARCHAR(50)	NOT NULL,
	Modelo			NVARCHAR(50)	NOT NULL,
	Clave_Acceso	NVARCHAR(50)	
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
	IDEstado	INT IDENTITY(1,1) CONSTRAINT PK_Registros_Estado_ID PRIMARY KEY CLUSTERED,
	Tipo_Estado	NVARCHAR(15)	NOT NULL,
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
	IDTicket			INT IDENTITY(1,1) CONSTRAINT PK_Registros_Pedido_Id PRIMARY KEY CLUSTERED,
	IDCliente			INT							NOT NULL,
	IDArticulo			INT							NOT NULL,
	IDTecnico_Asignado	INT							NOT NULL,
	No_Orden			NVARCHAR(50)				NOT NULL,
	Fecha_Ticket		DATETIME DEFAULT GETDATE()	NOT NULL,
	IDEstado			INT							NOT NULL,
	Problema_Reportado	TEXT						NOT NULL, 
	Observaciones		TEXT						NOT NULL
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
	IDEntrega			INT IDENTITY(1,1) CONSTRAINT PK_Registros_Entrega_ID PRIMARY KEY CLUSTERED,
	IDTicket_Entrega	INT							NOT NULL,
	IDCliente			INT							NOT NULL,
	IDArticulo			INT							NOT NULL,
	IDTecnico_Asignado	INT							NOT NULL,
	IDEstado			INT							NOT NULL,
	Fecha_Entrega		DATETIME DEFAULT GETDATE()	NOT NULL,
	Trabajo_Realizado	TEXT						NOT NULL,
	Repuesto			TEXT						NOT NULL,
	Garantia			NVARCHAR(15)				NOT NULL,
)
GO

/* Llaves Foreanes de las tablas */
/* TABLA ARTICULO */
ALTER TABLE		Articulos.Articulo
ADD CONSTRAINT	FK_Articulos_Articulo$TIENE_UN$Personas_Cliente
FOREIGN KEY		(IDCliente) 
REFERENCES		Personas.Cliente(IDCliente)
ON DELETE NO ACTION
ON UPDATE NO ACTION;
GO

/* TABLA TICKET */
ALTER TABLE		Registros.Ticket
ADD CONSTRAINT	FK_Registros_Ticket$TIENE_UN$Personas_Cliente
FOREIGN KEY		(IDCliente) 
REFERENCES		Personas.Cliente(IDCliente)
ON DELETE NO ACTION
ON UPDATE NO ACTION;
GO

ALTER TABLE		Registros.Ticket
ADD CONSTRAINT	FK_Registros_Ticket$TIENE_UN$Articulos_Articulo
FOREIGN KEY		(IDArticulo) 
REFERENCES		Articulos.Articulo(IDArticulo)
ON DELETE NO ACTION
ON UPDATE NO ACTION;
GO

ALTER TABLE		Registros.Ticket
ADD CONSTRAINT	FK_Registros_Ticket$TIENE_UN$Registros_Estado
FOREIGN KEY		(IDEstado) 
REFERENCES		Registros.Estado(IDEstado)
ON DELETE NO ACTION
ON UPDATE NO ACTION;
GO

ALTER TABLE		Registros.Ticket
ADD CONSTRAINT	FK_Registros_Ticket$TIENE_UN$Personas_Tecnico
FOREIGN KEY		(IDTecnico_Asignado) 
REFERENCES		Personas.Tecnico(IDTecnico)
ON DELETE NO ACTION
ON UPDATE NO ACTION;
GO

/* TABLA ENTREGA */
ALTER TABLE		Registros.Entrega
ADD CONSTRAINT	FK_Registros_Entrega$TIENE_UN$Registros_Ticket
FOREIGN KEY		(IDTicket_Entrega) 
REFERENCES		Registros.Ticket(IDTicket)
ON DELETE NO ACTION
ON UPDATE NO ACTION;
GO

ALTER TABLE		Registros.Entrega
ADD CONSTRAINT	FK_Registros_Entrega$TIENE_UN$Personas_Cliente
FOREIGN KEY		(IDCliente) 
REFERENCES		Personas.Cliente(IDCliente)
ON DELETE NO ACTION
ON UPDATE NO ACTION;
GO

ALTER TABLE		Registros.Entrega
ADD CONSTRAINT	FK_Registros_Entrega$TIENE_UN$Articulos_Articulo
FOREIGN KEY		(IDArticulo) 
REFERENCES		Articulos.Articulo(IDArticulo)
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
FOREIGN KEY		(IDTecnico_Asignado) 
REFERENCES		Personas.Tecnico(IDTecnico)
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
/* Numero de Orden */
ALTER TABLE Registros.Ticket
	ADD CONSTRAINT AK_Registros_No_Orden
	UNIQUE NONCLUSTERED (No_Orden);
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

ART.IDArticulo,
CLI.Identidad_Cliente, 
CLI.Nombre_Cliente, 
CLI.Apellido_Cliente, 
ART.No_Serie, 
ART.Articulo,
ART.Marca,
ART.Modelo,
ART.Clave_Acceso

FROM Articulos.Articulo as "ART" 
JOIN Personas.Cliente AS "CLI" ON ART.IDCliente= CLI.IDCliente
GO

/* TICKET - VISTA */
CREATE VIEW V_TICKET
AS 
SELECT 
TIC.IDTicket,
TIC.No_Orden,
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
INNER JOIN Personas.Cliente AS CLI		ON TIC.IDCliente = CLI.IDCliente)
INNER JOIN Articulos.Articulo AS ART	ON TIC.IDArticulo = ART.IDArticulo)
INNER JOIN Registros.Estado AS EST		ON TIC.IDEstado = EST.IDEstado)
INNER JOIN Personas.Tecnico AS TEC		ON TIC.IDTecnico_Asignado = TEC.IDTecnico

GO

/* ENTREGA - VISTA */
CREATE VIEW V_ENTREGA 
AS 
SELECT
ENT.IDEntrega,
TIC.No_Orden,
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
INNER JOIN Registros.Ticket AS TIC		ON ENT.IDTicket_Entrega = TIC.IDTicket)
INNER JOIN Personas.Cliente AS CLI		ON ENT.IDCliente = CLI.IDCliente)
INNER JOIN Articulos.Articulo AS ART	ON ENT.IDArticulo = ART.IDArticulo)
INNER JOIN Registros.Estado AS EST		ON ENT.IDEstado = EST.IDEstado)
INNER JOIN Personas.Tecnico AS TEC		ON ENT.IDTecnico_Asignado = TEC.IDTecnico
GO

/* TICKET PENDIENTE */
CREATE VIEW V_TICKET_PENDIENTE
AS 
SELECT 
TIC.IDTicket,
TIC.No_Orden,
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
INNER JOIN Personas.Cliente AS CLI		ON TIC.IDCliente = CLI.IDCliente)
INNER JOIN Articulos.Articulo AS ART	ON TIC.IDArticulo = ART.IDArticulo)
INNER JOIN Registros.Estado AS EST		ON TIC.IDEstado = EST.IDEstado)
INNER JOIN Personas.Tecnico AS TEC		ON TIC.IDTecnico_Asignado = TEC.IDTecnico
WHERE EST.Tipo_Estado = 'PENDIENTE'
GO

/* TICKET EN PROCESO */
CREATE VIEW V_TICKET_PROCESO
AS 
SELECT 
TIC.IDTicket,
TIC.No_Orden,
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
INNER JOIN Personas.Cliente AS CLI		ON TIC.IDCliente = CLI.IDCliente)
INNER JOIN Articulos.Articulo AS ART	ON TIC.IDArticulo = ART.IDArticulo)
INNER JOIN Registros.Estado AS EST		ON TIC.IDEstado = EST.IDEstado)
INNER JOIN Personas.Tecnico AS TEC		ON TIC.IDTecnico_Asignado = TEC.IDTecnico
WHERE EST.Tipo_Estado = 'EN PROCESO'
GO


/* TICKET RESUELTO */

CREATE VIEW V_TICKET_RESUELTO
AS 
SELECT 
TIC.IDTicket,
TIC.No_Orden,
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
INNER JOIN Personas.Cliente AS CLI		ON TIC.IDCliente = CLI.IDCliente)
INNER JOIN Articulos.Articulo AS ART	ON TIC.IDArticulo = ART.IDArticulo)
INNER JOIN Registros.Estado AS EST		ON TIC.IDEstado = EST.IDEstado)
INNER JOIN Personas.Tecnico AS TEC		ON TIC.IDTecnico_Asignado = TEC.IDTecnico
WHERE EST.Tipo_Estado = 'RESUELTO'
GO