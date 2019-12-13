/*
	CREATE DATA BASE SERVICE DESK NETWORK PLACE
*/

USE MASTER
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
---------------------------------------------------------
CREATE SCHEMA Personas
GO

CREATE SCHEMA Equipos
GO

CREATE SCHEMA Registros
GO
----------------------------------------------------------

/*
	DEFINICION DE LAS TABLAS NECESARIAS A UTULIZAR EN EL SISTEMA
*/
-------------------------------------------------------------------------------
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
-------------------------------------------------------------------------------------------------------------
/* TABLA USUARIO */
IF EXISTS(SELECT * FROM sys.databases WHERE name='Personas.Usuario')
BEGIN
	DROP TABLE Personas.Usuario
END
GO

CREATE TABLE Personas.Usuario
(
	IDUsuario			INT				IDENTITY(1,1),	
	No_Usuario			AS				(RIGHT ('000' + CONVERT (NVARCHAR, IDUsuario), (3))) PERSISTED CONSTRAINT PK_Personas_Usuario_ID PRIMARY KEY CLUSTERED,
	Nombre_Login		NVARCHAR(50)	NOT NULL,
	Clave_Login			NVARCHAR(50)	NOT NULL,
	Nombre_Usuario		NVARCHAR(50)	NOT NULL,
	Apellido_Usuario	NVARCHAR(50)	NOT NULL,
	Puesto				NVARCHAR(50)	NOT NULL,	
	Correo_Usuario		NVARCHAR(50)	NOT NULL
)
GO
----------------------------------------------------------------------------------------------
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
-------------------------------------------------------------------------------------------------
/* TABLA EQUIPOS */
IF EXISTS(SELECT * FROM sys.databases WHERE name='Articulos.Articulo')
BEGIN
	DROP TABLE Equipos.Equipo
END
GO

CREATE TABLE Equipos.Equipo
(
	IDEquipo			INT				IDENTITY(1,1),	
	No_Equipo			AS				(RIGHT ('000' + CONVERT (NVARCHAR, IDEquipo), (3))) PERSISTED,
	No_Cliente			NVARCHAR(3)		NOT NULL,
	Equipo				NVARCHAR(50)	NOT NULL,
	Marca				NVARCHAR(50)	NOT NULL,
	Modelo				NVARCHAR(50)	NOT NULL,
	No_Serie			NVARCHAR(50)	CONSTRAINT PK_Equipos_Equipo_NO_SERIE PRIMARY KEY CLUSTERED,
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
	Tipo_Estado	NVARCHAR(20)		NOT NULL,
)
GO
----------------------------------------------------------------------------------------------
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
	Fecha_Ticket				DATE						NOT NULL,
	IDEstado					INT							NOT NULL,
	Problema_Reportado			TEXT						NOT NULL, 
	Observaciones				TEXT						NOT NULL
)
GO
--------------------------------------------------------------------------------------------------
/* TABLA ENTREGA */
IF EXISTS(SELECT * FROM sys.databases WHERE name='Registros.Entrega')
BEGIN
	DROP TABLE Registros.Entrega
END
GO

CREATE TABLE Registros.Entrega 
(
	IDEntrega					INT IDENTITY(1,1),
	No_Entrega					AS ('ETR-' + RIGHT ('0000' + CONVERT (NVARCHAR, IDEntrega), (4))) PERSISTED CONSTRAINT PK_Registros_Entrega_ID PRIMARY KEY CLUSTERED, 
	No_Ticket					NVARCHAR(8)					NOT NULL,
	No_Cliente					NVARCHAR(3) NOT NULL,
	No_Serie					NVARCHAR(50)				NOT NULL,
	No_Tecnico_Asignado			NVARCHAR(3)					NOT NULL,
	IDEstado					INT							NOT NULL,
	Fecha_Entrega				DATE						NOT NULL,
	Trabajo_Realizado			TEXT						NOT NULL,
	Repuesto					TEXT						NOT NULL,
	Garantia					NVARCHAR(15)				NOT NULL,
)
GO
------------------------------------------------------------------------------------

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
--------------------------------------------------------------------------------------
/* TABLA TICKET */
/* Ticket - Cliente */
ALTER TABLE		Registros.Ticket
ADD CONSTRAINT	FK_Registros_Ticket$TIENE_UN$Personas_Cliente
FOREIGN KEY		(No_Cliente) 
REFERENCES		Personas.Cliente(No_Cliente)
ON DELETE NO ACTION
ON UPDATE NO ACTION;
GO
-------------------------------------------------------------------------------------
/* Ticket - Articulo */
ALTER TABLE		Registros.Ticket
ADD CONSTRAINT	FK_Registros_Ticket$TIENE_UN$Articulos_Articulo
FOREIGN KEY		(No_Serie) 
REFERENCES		Equipos.Equipo(No_Serie)
ON DELETE NO ACTION
ON UPDATE NO ACTION;
GO
-------------------------------------------------------------------------------------
/* Ticket - Estado */
ALTER TABLE		Registros.Ticket
ADD CONSTRAINT	FK_Registros_Ticket$TIENE_UN$Registros_Estado
FOREIGN KEY		(IDEstado) 
REFERENCES		Registros.Estado(IDEstado)
ON DELETE NO ACTION
ON UPDATE NO ACTION;
GO
-------------------------------------------------------------------------------------
/* Ticket - Tecnico */
ALTER TABLE		Registros.Ticket
ADD CONSTRAINT	FK_Registros_Ticket$TIENE_UN$Personas_Tecnico
FOREIGN KEY		(No_Tecnico_Asignado) 
REFERENCES		Personas.Tecnico(No_Tecnico)
ON DELETE NO ACTION
ON UPDATE NO ACTION;
GO
------------------------------------------------------------------------------------
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

-----------------------------------------------------------------------
/* VISTAS */

/* CLIENTE */
IF EXISTS(SELECT * FROM sys.databases WHERE name='V_CLIENTES')
BEGIN
	DROP VIEW V_CLIENTES
END
GO

CREATE VIEW V_CLIENTES
AS 
SELECT 
	CLI.No_Cliente AS			"No. Cliente", 
	CLI.Nombre_Cliente AS		"Nombre", 
	CLI.Apellido_Cliente AS		"Apellido", 
	CLI.Empresa,
	CLI.Ubicacion AS			"Ubicación",
	CLI.Telefono AS				"Numero de teléfono",
	CLI.Correo_Electronico AS	"Correo electrónico"
FROM Personas.Cliente AS "CLI" 
GO
------------------------------------------------------------------------------------
/* TECNICO */
IF EXISTS(SELECT * FROM sys.databases WHERE name='V_TECNICOS')
BEGIN
	DROP VIEW V_TECNICOS
END
GO

CREATE VIEW V_TECNICOS
AS 
SELECT 
	TEC.No_Tecnico AS		"No. Tecnico",
	TEC.Nombre_Tecnico AS	"Nombre",
	TEC.Apellido_Tecnico AS	"Apellido",
	TEC.Telefono AS			"Numero de teléfono",
	TEC.Correo_Tecnico AS	"Correo electrónico"
FROM Personas.Tecnico AS "TEC" 
GO
------------------------------------------------------------------------------
/* TICKET - VISTA */
IF EXISTS(SELECT * FROM sys.databases WHERE name='V_TICKETS')
BEGIN
	DROP VIEW V_TICKETS
END
GO

CREATE VIEW V_TICKETS
AS 
SELECT 
TIC.No_Ticket AS			"No. Ticket",
CLI.No_Cliente AS			"No. Cliente",
CLI.Nombre_Cliente AS		"Nombre",
CLI.Apellido_Cliente AS		"Apellido",
EQU.No_Serie AS				"No. Serie", 
EQU.Equipo AS				"Descripción del equipo",
EQU.Marca,
EQU.Modelo,
TEC.No_Tecnico AS			"No. Tecnico Asignado", 
TEC.Nombre_Tecnico AS		"Nombre del Tenico",
TEC.Apellido_Tecnico AS		"Apellido del Tecnico",
UPPER(FORMAT (TIC.Fecha_Ticket, N'dddd dd MMMM yyyy', 'es')) AS "Fecha de ingreso",
--TIC.Fecha_Ticket AS			"Fecha de ingreso",
EST.Tipo_Estado AS			"Estado",
TIC.Problema_Reportado AS	"Problema reportado",
TIC.Observaciones

FROM (((Registros.Ticket AS TIC 
INNER JOIN Personas.Cliente AS CLI		ON TIC.No_Cliente = CLI.No_Cliente)
INNER JOIN Equipos.Equipo AS EQU		ON TIC.No_Serie = EQU.No_Serie)
INNER JOIN Registros.Estado AS EST		ON TIC.IDEstado = EST.IDEstado)
INNER JOIN Personas.Tecnico AS TEC		ON TIC.No_Tecnico_Asignado = TEC.No_Tecnico
GO
-----------------------------------------------------------------------------------------
/* ENTREGA - VISTA */
IF EXISTS(SELECT * FROM sys.databases WHERE name='V_ENTREGAS')
BEGIN
	DROP VIEW V_ENTREGAS
END
GO

CREATE VIEW V_ENTREGAS 
AS 
SELECT
ENT.No_Entrega AS			"No. Entrega",
TIC.No_Ticket AS			"No. Ticket",

CLI.No_Cliente AS			"No. Cliente",
CLI.Nombre_Cliente AS		"Nombre",
CLI.Apellido_Cliente AS		"Apellido",

EQU.No_Serie AS				"No. Serie",
EQU.Equipo AS				"Descripción del equipo",
EQU.Marca,
EQU.Modelo,

TEC.No_Tecnico AS			"No. Tecnico Asignado", 
TEC.Nombre_Tecnico AS		"Nombre del Tenico",
TEC.Apellido_Tecnico AS		"Apellido del Tecnico", 

EST.Tipo_Estado AS			"Estado",

UPPER(FORMAT (ENT.Fecha_Entrega, N'dddd dd MMMM yyyy', 'es')) AS "Fecha de ingreso",

ENT.Trabajo_Realizado AS	"Trabajo realizado",
ENT.Repuesto AS				"Repuestos utilizados",
ENT.Garantia

FROM ((((Registros.Entrega AS ENT 
INNER JOIN Registros.Ticket AS TIC		ON ENT.No_Ticket = TIC.No_Ticket)
INNER JOIN Personas.Cliente AS CLI		ON ENT.No_Cliente = CLI.No_Cliente)
INNER JOIN Equipos.Equipo AS EQU		ON ENT.No_Serie = EQU.No_Serie)
INNER JOIN Registros.Estado AS EST		ON ENT.IDEstado = EST.IDEstado)
INNER JOIN Personas.Tecnico AS TEC		ON ENT.No_Tecnico_Asignado = TEC.No_Tecnico
GO
-----------------------------------------------------------------------------------------------------
/* TICKET PENDIENTE */
IF EXISTS(SELECT * FROM sys.databases WHERE name='V_TICKETS_PENDIENTES')
BEGIN
	DROP VIEW V_TICKETS_PENDIENTES
END
GO

CREATE VIEW V_TICKETS_PENDIENTES
AS 
SELECT 
TIC.No_Ticket AS			"No. Ticket",
EST.Tipo_Estado AS			"Estado",
UPPER(FORMAT (TIC.Fecha_Ticket, N'dddd dd MMMM yyyy', 'es')) AS "Fecha de ingreso",
CLI.No_Cliente AS			"No. Cliente",
CLI.Nombre_Cliente AS		"Nombre",
CLI.Apellido_Cliente AS		"Apellido",
EQU.Equipo AS				"Descripción del equipo",
EQU.Marca,
EQU.Modelo,
EQU.No_Serie AS				"No. Serie", 
TIC.Problema_Reportado AS	"Problema reportado",
TIC.Observaciones,
TEC.No_Tecnico AS			"No. Tecnico Asignado", 
TEC.Nombre_Tecnico AS		"Nombre del Tenico",
TEC.Apellido_Tecnico AS		"Apellido del Tecnico"

FROM (((Registros.Ticket AS TIC 
INNER JOIN Personas.Cliente AS CLI		ON TIC.No_Cliente = CLI.No_Cliente)
INNER JOIN Equipos.Equipo AS EQU		ON TIC.No_Serie = EQU.No_Serie)
INNER JOIN Registros.Estado AS EST		ON TIC.IDEstado = EST.IDEstado)
INNER JOIN Personas.Tecnico AS TEC		ON TIC.No_Tecnico_Asignado = TEC.No_Tecnico
WHERE EST.Tipo_Estado = 'PENDIENTE'
GO
-------------------------------------------------------------------------------------------
/* TICKET EN PROCESO */
IF EXISTS(SELECT * FROM sys.databases WHERE name='V_TICKETS_PROCESO')
BEGIN
	DROP VIEW V_TICKETS_PROCESO
END
GO

CREATE VIEW V_TICKETS_PROCESO
AS 
SELECT 
TIC.No_Ticket AS			"No. Ticket",
EST.Tipo_Estado AS			"Estado",
UPPER(FORMAT (TIC.Fecha_Ticket, N'dddd dd MMMM yyyy', 'es')) AS "Fecha de ingreso",
CLI.No_Cliente AS			"No. Cliente",
CLI.Nombre_Cliente AS		"Nombre",
CLI.Apellido_Cliente AS		"Apellido",
EQU.Equipo AS				"Descripción del equipo",
EQU.Marca,
EQU.Modelo,
EQU.No_Serie AS				"No. Serie", 
TIC.Problema_Reportado AS	"Problema reportado",
TIC.Observaciones,
TEC.No_Tecnico AS			"No. Tecnico Asignado", 
TEC.Nombre_Tecnico AS		"Nombre del Tenico",
TEC.Apellido_Tecnico AS		"Apellido del Tecnico"

FROM (((Registros.Ticket AS TIC 
INNER JOIN Personas.Cliente AS CLI		ON TIC.No_Cliente = CLI.No_Cliente)
INNER JOIN Equipos.Equipo AS EQU		ON TIC.No_Serie = EQU.No_Serie)
INNER JOIN Registros.Estado AS EST		ON TIC.IDEstado = EST.IDEstado)
INNER JOIN Personas.Tecnico AS TEC		ON TIC.No_Tecnico_Asignado = TEC.No_Tecnico
WHERE EST.Tipo_Estado = 'EN PROCESO'
GO
------------------------------------------------------------------------------------------------
/* TICKET RESUELTO */
IF EXISTS(SELECT * FROM sys.databases WHERE name='V_TICKETS_FINALIZADOS')
BEGIN
	DROP VIEW V_TICKETS_FINALIZADOS
END
GO

CREATE VIEW V_TICKETS_FINALIZADOS
AS 
SELECT 
TIC.No_Ticket AS			"No. Ticket",
EST.Tipo_Estado AS			"Estado",
UPPER(FORMAT (TIC.Fecha_Ticket, N'dddd dd MMMM yyyy', 'es')) AS "Fecha de ingreso",
CLI.No_Cliente AS			"No. Cliente",
CLI.Nombre_Cliente AS		"Nombre",
CLI.Apellido_Cliente AS		"Apellido",
EQU.Equipo AS				"Descripción del equipo",
EQU.Marca,
EQU.Modelo,
EQU.No_Serie AS				"No. Serie", 
TIC.Problema_Reportado AS	"Problema reportado",
TIC.Observaciones,
TEC.No_Tecnico AS			"No. Tecnico Asignado", 
TEC.Nombre_Tecnico AS		"Nombre del Tenico",
TEC.Apellido_Tecnico AS		"Apellido del Tecnico"

FROM (((Registros.Ticket AS TIC 
INNER JOIN Personas.Cliente AS CLI		ON TIC.No_Cliente = CLI.No_Cliente)
INNER JOIN Equipos.Equipo AS EQU		ON TIC.No_Serie = EQU.No_Serie)
INNER JOIN Registros.Estado AS EST		ON TIC.IDEstado = EST.IDEstado)
INNER JOIN Personas.Tecnico AS TEC		ON TIC.No_Tecnico_Asignado = TEC.No_Tecnico
WHERE EST.Tipo_Estado = 'FINALIZADO'
GO
-------------------------------------------------------------------------------------------------------

/*
	INSERT DATABASE SERVICE DESK NETWORK PLACE
*/

USE BD_SERVICE_DESK
GO

/* Pruebas de insercion */

/* TABLA USUARIOS */
INSERT INTO Personas.Usuario(Nombre_Login, Clave_Login, Nombre_Usuario, Apellido_Usuario, Puesto, Correo_Usuario)
VALUES						('Administrador', 'admin@1234', 'Francisco', 'Ramos', 'Jefe de departamento', 'framos@networkhn.com');
GO

INSERT INTO Personas.Usuario(Nombre_Login, Clave_Login, Nombre_Usuario, Apellido_Usuario, Puesto, Correo_Usuario)
VALUES						('Jonatan', 'jamaya', 'Jonatan', 'Amaya', 'Tecnico', 'jamaya@networkhn.com');
GO

INSERT INTO Personas.Usuario(Nombre_Login, Clave_Login, Nombre_Usuario, Apellido_Usuario, Puesto, Correo_Usuario)
VALUES						('Josue', 'jmeza', 'Josue', 'Meza', 'Tecnico', 'jmeza@networkhn.com');
GO
--------------------------------------------------------------------------------------------------------------------------------------
/* TABLA TECNICO */
INSERT INTO Personas.Tecnico(Nombre_Tecnico, Apellido_Tecnico, Telefono,  Correo_Tecnico)
VALUES						('Jonatan', 'Amaya', '965236XX', 'jamaya@network.com');
GO

INSERT INTO Personas.Tecnico(Nombre_Tecnico, Apellido_Tecnico, Telefono, Correo_Tecnico)
VALUES						('Francisco', 'Ramos', '277386XX', 'framos@network.com');
GO
----------------------------------------------------------------------------------------------------------------

/* TABLA CLIENTE */
INSERT INTO Personas.Cliente(Nombre_Cliente, Apellido_Cliente, Empresa, Ubicacion, Telefono, Correo_Electronico)
VALUES						( 'Luis', 'Lopez', 'Aquafeed', 'Aldea el Borbotón, San Francisco de Yojoa, Cortés ', '2650-4123', 'luis.lopez@aquafeedhn.com');
GO

INSERT INTO Personas.Cliente(Nombre_Cliente, Apellido_Cliente, Empresa, Ubicacion, Telefono, Correo_Electronico)
VALUES						('Maria', 'Fajardo', 'Comercial Nicole', 'Barrio Lempira, 4 Ave. entre 8 y 9 Calle, Local 72, San Pedro Sula, Cortés. ', '2553-5833', 'comercialnicole@hotmail.com');
GO

INSERT INTO Personas.Cliente(Nombre_Cliente, Apellido_Cliente, Empresa, Ubicacion, Telefono, Correo_Electronico)
VALUES						('Maria', 'Maecenas', 'Comercial Tadisa', 'Bo. Hipódromo, 7 y 8 Calle Ave. Juan Pablo Segundo, San Pero Sula, Cortés ', '2557-8389', 'comercialtadisa@hotmail.com');
GO
-----------------------------------------------------------------------------------------------------------------------------

/* TABLA EQUIPO */
INSERT INTO Equipos.Equipo(No_Cliente, No_Serie, Equipo, Marca, Modelo, Clave_Acceso)
VALUES						('001', 'VNB8J1PH50', 'Impresora', 'HP', 'Color Laser Jet Pro MFP/277dw', 'NINGUNA');
GO

INSERT INTO Equipos.Equipo(No_Cliente, No_Serie, Equipo, Marca, Modelo, Clave_Acceso)
VALUES						('002', '5199PP1', 'Desktop', 'DELL', 'Latitude 5450', 'NINGUNA');
GO

INSERT INTO Equipos.Equipo(No_Cliente, No_Serie, Equipo, Marca, Modelo, Clave_Acceso)
VALUES						('003', 'R9-057GRM18', 'Laptop', 'Lenovo', 'Thinkpad L380 YOGA', 'Purus**');
GO
----------------------------------------------------------------------------------------------------------------------

/* TABLA ESTADO */
INSERT INTO Registros.Estado(Tipo_Estado)
VALUES						('PENDIENTE');
GO

INSERT INTO Registros.Estado(Tipo_Estado)
VALUES						('EN PROCESO');
GO

INSERT INTO Registros.Estado(Tipo_Estado)
VALUES						('FINALIZADO');
GO
----------------------------------------------------------------------------------------------------------------------

/* TABLA TICKET */
INSERT INTO Registros.Ticket(No_Cliente, No_Serie, No_Tecnico_Asignado, Fecha_Ticket, IDEstado, Problema_Reportado, Observaciones)
VALUES						('001', 'VNB8J1PH50', '001', '2019/11/18', 1, 'Se atasca el papel', 'NINGUNA');
GO

INSERT INTO Registros.Ticket(No_Cliente, No_Serie, No_Tecnico_Asignado,Fecha_Ticket, IDEstado, Problema_Reportado, Observaciones)
VALUES						('002', '5199PP1', '001',  '2019/11/19', 1, 'No enciende', 'Capacitores sobrecargados');
GO

INSERT INTO Registros.Ticket(No_Cliente, No_Serie, No_Tecnico_Asignado, Fecha_Ticket, IDEstado, Problema_Reportado, Observaciones)
VALUES						('003', 'R9-057GRM18', '002',  '2019/11/20', 1, 'Lectora de CD no funcona', 'Carcasa rallada');
GO
-------------------------------------------------------------------------------------------------------------------------

/* TABLA ENTREGA */
INSERT INTO Registros.Entrega(No_Ticket, No_Cliente, No_Serie, No_Tecnico_Asignado,  IDEstado, Fecha_Entrega, Trabajo_Realizado, Repuesto, Garantia)
VALUES						('TIK-0001', '001', 'VNB8J1PH50', '001', 1, '2019/11/23', 'Cambio de toner', 'Tonner', '3 meses');
GO

INSERT INTO Registros.Entrega(No_Ticket, No_Cliente, No_Serie, No_Tecnico_Asignado, IDEstado, Fecha_Entrega, Trabajo_Realizado, Repuesto, Garantia)
VALUES						('TIK-0002', '002', '5199PP1', '002', 2, '2019/11/24', 'Cambio de tarjeta madre', 'Tarjeta madre', '3 meses');
GO
------------------------------------------------------------------------------------------------------------------------

/* 
	STORE PROCEDURE DATABASE SERVICE DESK NETWORK PLACE
*/

--------------------------------------------------------------------
/*
	Creacion de PROCEDURE necesarios para la base de datos en 
	Mesa de ayuda en el area de Servicio Tecnico Domicilio de la 
	empresa Network Place.

	Creacion de CRUD mediante utilizacion de PROCEDURE
*/
--------------------------------------------------------------------

USE BD_SERVICE_DESK
GO 

/* TABLA CLIENTE */

/* Mostrar Cliente */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_MOSTRAR_CLIENTE')
BEGIN
	DROP PROCEDURE SP_MOSTRAR_CLIENTE
END
GO

CREATE PROCEDURE SP_MOSTRAR_CLIENTE(@TIPO_FILTRO		NVARCHAR(50), 
									@CRITERIO			NVARCHAR(50))
AS
IF @TIPO_FILTRO = 'TODOS'
	BEGIN
		SELECT * FROM V_CLIENTES 
	END
ELSE
	BEGIN
		IF(@TIPO_FILTRO= 'Nombre')
			SELECT * FROM V_CLIENTES WHERE Nombre LIKE @CRITERIO
		ELSE IF(@TIPO_FILTRO = 'Apellido')
			SELECT * FROM V_CLIENTES WHERE Apellido LIKE @CRITERIO
		ELSE IF(@TIPO_FILTRO = 'No. Cliente')
			SELECT * FROM V_CLIENTES WHERE "No. Cliente" LIKE @CRITERIO
	END
GO

/* Agregar Cliente */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_AGREGAR_CLIENTE')
BEGIN
	DROP PROCEDURE SP_AGREGAR_CLIENTE
END
GO

CREATE PROCEDURE SP_AGREGAR_CLIENTE(	@NOMBRE_CLIENTE		NVARCHAR(50), 
										@APELLIDO_CLIENTE	NVARCHAR(50), 
										@EMPRESA			VARCHAR(50), 
										@UBICACION			TEXT, 
										@TELEFONO			NVARCHAR(9), 
										@CORREO				NVARCHAR(50))
AS
INSERT INTO Personas.Cliente VALUES	(	@NOMBRE_CLIENTE,
										@APELLIDO_CLIENTE,
										@EMPRESA,
										@UBICACION,
										@TELEFONO,
										@CORREO)
GO


/* Actualizar Cliente */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_ACTUALIZAR_CLIENTE')
BEGIN
	DROP PROCEDURE SP_ACTUALIZAR_CLIENTE
END
GO

CREATE PROCEDURE SP_ACTUALIZAR_CLIENTE(	@NOMBRE_CLIENTE		NVARCHAR(50), 
										@APELLIDO_CLIENTE	NVARCHAR(50), 
										@EMPRESA			VARCHAR(50), 
										@UBICACION			TEXT, 
										@TELEFONO			NVARCHAR(9), 
										@CORREO				NVARCHAR(50),
										@NO_CLIENTE			NVARCHAR(3))
AS
UPDATE Personas.Cliente SET	Nombre_Cliente=		@NOMBRE_CLIENTE, 
							Apellido_Cliente=	@APELLIDO_CLIENTE, 
							Empresa=			@EMPRESA, 
							Ubicacion=			@UBICACION, 
							Telefono=			@TELEFONO, 
							Correo_Electronico=	@CORREO
							WHERE No_Cliente=	@NO_CLIENTE;
GO

/* Eliminar Cliente */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_ELIMINAR_CLIENTE')
BEGIN
	DROP PROCEDURE SP_ELIMINAR_CLIENTE
END
GO

CREATE PROCEDURE SP_ELIMINAR_CLIENTE(@NO_CLIENTE	NVARCHAR(3))
AS
	DELETE FROM Personas.Cliente WHERE No_Cliente = @NO_CLIENTE;
GO

---------------------------------------------------------------------------------------------------------------------------
USE BD_SERVICE_DESK
GO 

/* TABLA ENTREGA */
/* Mostrar entrega */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_MOSTRAR_ENTREGA')
BEGIN
	DROP PROCEDURE SP_MOSTRAR_ENTREGA
END
GO

CREATE PROCEDURE SP_MOSTRAR_ENTREGA (@TIPO_FILTRO NVARCHAR(50), @CRITERIO NVARCHAR(50))
AS
IF @TIPO_FILTRO = 'TODOS'
	BEGIN
		SELECT * FROM V_ENTREGAS 
	END
ELSE
	BEGIN
		IF(@TIPO_FILTRO= 'No. Ticket')
			SELECT * FROM V_ENTREGAS WHERE "No. Ticket" LIKE @CRITERIO
		ELSE IF(@TIPO_FILTRO = 'Estado')
			SELECT * FROM V_ENTREGAS WHERE UPPER(Estado) LIKE UPPER(@CRITERIO)
		ELSE IF (@TIPO_FILTRO = 'No. Cliente')
			SELECT * FROM V_ENTREGAS WHERE UPPER("No. Cliente") LIKE UPPER(@CRITERIO)
		ELSE IF (@TIPO_FILTRO = 'Equipo')
			SELECT * FROM V_ENTREGAS WHERE UPPER("Descripción del equipo") LIKE UPPER(@CRITERIO)
	END
GO


/* Agregar Entrega */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_AGREGAR_ENTREGA')
BEGIN
	DROP PROCEDURE SP_AGREGAR_ENTREGA
END
GO

CREATE PROCEDURE SP_AGREGAR_ENTREGA(	@NO_TICKET_ENTREGA		NVARCHAR(8),
										@NO_CLIENTE				NVARCHAR(3), 
										@NO_SERIE				NVARCHAR(50), 
										@NO_TECNICO_ASIGNADO	NVARCHAR(3),
										@ID_ESTADO				INT,
										@FECHA_ENTREGA			DATE,
										@TRABAJO_REALIZADO		TEXT,
										@REPUESTO				TEXT,
										@GARANTIA				NVARCHAR(15))
AS

INSERT INTO Registros.Entrega VALUES(	@NO_TICKET_ENTREGA,
										@NO_CLIENTE,
										@NO_SERIE, 
										@NO_TECNICO_ASIGNADO, 
										@ID_ESTADO, 
										@FECHA_ENTREGA,
										@TRABAJO_REALIZADO,
										@REPUESTO,
										@GARANTIA);

UPDATE Registros.Ticket SET IDEstado = @ID_ESTADO WHERE Registros.Ticket.No_Ticket = @NO_TICKET_ENTREGA
GO


/* Actualizar Entrega */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_ACTUALIZAR_ENTREGA')
BEGIN
	DROP PROCEDURE SP_ACTUALIZAR_ENTREGA
END
GO

CREATE PROCEDURE SP_ACTUALIZAR_ENTREGA(	@NO_TICKET_ENTREGA		NVARCHAR(8),
										@NO_CLIENTE				NVARCHAR(3), 
										@NO_SERIE				NVARCHAR(50), 
										@NO_TECNICO_ASIGNADO	NVARCHAR(3),
										@ID_ESTADO				INT,
										@FECHA_ENTREGA			DATE,
										@TRABAJO_REALIZADO		TEXT,
										@REPUESTO				TEXT,
										@GARANTIA				NVARCHAR(15),
										@NO_ENTREGA				NVARCHAR(8))
AS

UPDATE Registros.Entrega SET	No_Ticket=				@NO_TICKET_ENTREGA,
								No_Cliente=				@NO_CLIENTE,
								No_Serie=				@NO_SERIE, 
								No_Tecnico_Asignado=	@NO_TECNICO_ASIGNADO, 
								IDEstado=				@ID_ESTADO,
								Fecha_Entrega=			@FECHA_ENTREGA,
								Trabajo_Realizado=		@TRABAJO_REALIZADO,
								Repuesto=				@REPUESTO,
								Garantia =				@GARANTIA
								WHERE No_Entrega=		@NO_ENTREGA

UPDATE Registros.Ticket SET IDEstado = @ID_ESTADO WHERE Registros.Ticket.No_Ticket = @NO_TICKET_ENTREGA
GO

/* Eliminar Entrega */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_ELIMINAR_ENTREGA')
BEGIN
	DROP PROCEDURE SP_ELIMINAR_ENTREGA
END
GO

CREATE PROCEDURE SP_ELIMINAR_ENTREGA(@NO_ENTREGA	NVARCHAR(8))
AS
	DELETE FROM Registros.Entrega WHERE No_Entrega = @NO_ENTREGA;
GO
------------------------------------------------------------------------------------------------------
/* Datos Ticket */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_DATOS_ENTREGA')
BEGIN
	DROP PROCEDURE SP_DATOS_ENTREGA
END
GO

CREATE PROCEDURE SP_DATOS_ENTREGA(@NO_ENTREGA NVARCHAR(8))
AS
	SELECT
		ENT.No_Entrega,
		TIC.No_Ticket,

		CLI.No_Cliente,
		CLI.Nombre_Cliente,
		CLI.Apellido_Cliente,
		CLI.Telefono, 
		CLI.Correo_Electronico,

		EQU.No_Serie,
		EQU.Equipo,
		EQU.Marca,
		EQU.Modelo,

		TEC.No_Tecnico, 
		TEC.Nombre_Tecnico,
		TEC.Apellido_Tecnico, 

		EST.Tipo_Estado,

		UPPER(FORMAT (ENT.Fecha_Entrega, N'dddd dd MMMM yyyy', 'es')) AS "Fecha",

		ENT.Trabajo_Realizado,
		ENT.Repuesto,
		ENT.Garantia

		FROM ((((Registros.Entrega AS ENT 
		INNER JOIN Registros.Ticket AS TIC		ON ENT.No_Ticket = TIC.No_Ticket)
		INNER JOIN Personas.Cliente AS CLI		ON ENT.No_Cliente = CLI.No_Cliente)
		INNER JOIN Equipos.Equipo AS EQU		ON ENT.No_Serie = EQU.No_Serie)
		INNER JOIN Registros.Estado AS EST		ON ENT.IDEstado = EST.IDEstado)
		INNER JOIN Personas.Tecnico AS TEC		ON ENT.No_Tecnico_Asignado = TEC.No_Tecnico

	WHERE No_Entrega = @NO_ENTREGA
GO
--------------------------------------------------------------------------------------------------------------------------------

USE BD_SERVICE_DESK
GO 
/* TABLA EQUIPO */
/* Mostrar Equipo */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_MOSTRAR_EQUIPO')
BEGIN
	DROP PROCEDURE SP_MOSTRAR_EQUIPO
END
GO

CREATE PROCEDURE SP_MOSTRAR_EQUIPO (@TIPO_FILTRO		NVARCHAR(50), 
									@CRITERIO			NVARCHAR(50))									 
AS
IF @TIPO_FILTRO = 'TODOS'
	BEGIN
		SELECT 
		EQU.No_Equipo AS		"No. Equipo",
		CLI.No_Cliente AS		"No. Cliente", 
		CLI.Nombre_Cliente AS	"Nombre", 
		CLI.Apellido_Cliente AS	"Apellido",
		EQU.No_Serie AS			"No. Serie", 
		EQU.Equipo AS			"Descripción del equipo",
		EQU.Marca,
		EQU.Modelo,
		EQU.Clave_Acceso AS		"Clave de acceso"

		FROM Equipos.Equipo AS "EQU"
		JOIN Personas.Cliente AS "CLI" ON EQU.No_Cliente= CLI.No_Cliente
		ORDER BY CLI.No_Cliente
	END
ELSE
	BEGIN
		IF(@TIPO_FILTRO= 'No. Cliente')
			SELECT 
				EQU.No_Equipo AS		"No. Equipo",
				CLI.No_Cliente AS		"No. Cliente", 
				CLI.Nombre_Cliente AS	"Nombre", 
				CLI.Apellido_Cliente AS	"Apellido",
				EQU.No_Serie AS			"No. Serie", 
				EQU.Equipo AS			"Descripción del equipo",
				EQU.Marca,
				EQU.Modelo,
				EQU.Clave_Acceso AS		"Clave de acceso"

				FROM Equipos.Equipo AS "EQU"
				JOIN Personas.Cliente AS "CLI" ON EQU.No_Cliente= CLI.No_Cliente

				WHERE CLI. No_Cliente LIKE @CRITERIO
				ORDER BY CLI.No_Cliente


		ELSE IF(@TIPO_FILTRO = 'No. Serie')
			SELECT 
				EQU.No_Equipo AS		"No. Equipo",
				CLI.No_Cliente AS		"No. Cliente", 
				CLI.Nombre_Cliente AS	"Nombre", 
				CLI.Apellido_Cliente AS	"Apellido",
				EQU.No_Serie AS			"No. Serie", 
				EQU.Equipo AS			"Descripción del equipo",
				EQU.Marca,
				EQU.Modelo,
				EQU.Clave_Acceso AS		"Clave de acceso"

				FROM Equipos.Equipo AS "EQU"
				JOIN Personas.Cliente AS "CLI" ON EQU.No_Cliente= CLI.No_Cliente

				WHERE EQU.No_Serie LIKE @CRITERIO
				ORDER BY CLI.No_Cliente

		ELSE IF(@TIPO_FILTRO = 'Marca')
			SELECT
				EQU.No_Equipo AS		"No. Equipo",
				CLI.No_Cliente AS		"No. Cliente", 
				CLI.Nombre_Cliente AS	"Nombre", 
				CLI.Apellido_Cliente AS	"Apellido",
				EQU.No_Serie AS			"No. Serie", 
				EQU.Equipo AS			"Descripción del equipo",
				EQU.Marca,
				EQU.Modelo,
				EQU.Clave_Acceso AS		"Clave de acceso"

				FROM Equipos.Equipo AS "EQU"
				JOIN Personas.Cliente AS "CLI" ON EQU.No_Cliente= CLI.No_Cliente

				WHERE EQU.Marca LIKE @CRITERIO
				ORDER BY CLI.No_Cliente
	END
GO

/* Agregar Equipo */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_AGREGAR_EQUIPO')
BEGIN
	DROP PROCEDURE SP_AGREGAR_EQUIPO
END
GO

CREATE PROCEDURE SP_AGREGAR_EQUIPO(	@NO_CLIENTE		NVARCHAR(3),
									@EQUIPO			NVARCHAR(50), 
									@MARCA			NVARCHAR(50),
									@MODELO			NVARCHAR(50),
									@NO_SERIE		NVARCHAR(50), 
									@CLAVE_ACCESO	NVARCHAR(50))
AS
INSERT INTO Equipos.Equipo VALUES(	@NO_CLIENTE, 
									@EQUIPO,
									@MARCA, 
									@MODELO, 
									@NO_SERIE,
									@CLAVE_ACCESO);
GO

/* Actualizar Equipo */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_ACTUALIZAR_EQUIPO')
BEGIN
	DROP PROCEDURE SP_ACTUALIZAR_EQUIPO
END
GO

CREATE PROCEDURE SP_ACTUALIZAR_EQUIPO(	@NO_CLIENTE		NVARCHAR(3),
										@EQUIPO			NVARCHAR(50), 
										@MARCA			NVARCHAR(50),
										@MODELO			NVARCHAR(50),
										@NO_SERIE		NVARCHAR(50), 
										@CLAVE_ACCESO	NVARCHAR(50),
										@NO_EQUIPO		NVARCHAR(3))
AS
UPDATE Equipos.Equipo SET	No_Cliente=		@NO_CLIENTE, 
							Equipo=			@EQUIPO,
							Marca=			@MARCA, 
							Modelo=			@MODELO,
							No_Serie=		@NO_SERIE,
							Clave_Acceso=	@CLAVE_ACCESO
							WHERE No_Equipo=	@NO_EQUIPO;
GO

/* Eliminar Equipo */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_ELIMINAR_EQUIPO')
BEGIN
	DROP PROCEDURE No. Equipo
END
GO

CREATE PROCEDURE SP_ELIMINAR_EQUIPO(@NO_EQUIPO	NVARCHAR(3))
AS
	DELETE FROM Equipos.Equipo WHERE No_Equipo = @NO_EQUIPO;
GO
----------------------------------------------------------------------------------------------------------

/* TABLA TICKET */

/* Mostrar Ticket Pendientes */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_MOSTRAR_PENDIENTE')
BEGIN
	DROP PROCEDURE SP_MOSTRAR_PENDIENTE
END
GO

CREATE PROCEDURE SP_MOSTRAR_PENDIENTE
AS
	SELECT * FROM V_TICKETS_PENDIENTES
GO
------------------------------------------------------------------------------

-------------------------------------------------------------------------------
/* Mostrar Ticket En Proceso */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_MOSTRAR_PROCESO')
BEGIN
	DROP PROCEDURE SP_MOSTRAR_PROCESO
END
GO

CREATE PROCEDURE SP_MOSTRAR_PROCESO
AS
	SELECT * FROM V_TICKETS_PROCESO
GO
-------------------------------------------------------------------------------

-------------------------------------------------------------------------------
/* Mostrar Ticket Finalizado */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_MOSTRAR_FINALIZADO')
BEGIN
	DROP PROCEDURE SP_MOSTRAR_FINALIZADO
END
GO

CREATE PROCEDURE SP_MOSTRAR_FINALIZADO
AS
	SELECT * FROM V_TICKETS_FINALIZADOS
GO
-----------------------------------------------------------------------------

USE BD_SERVICE_DESK
GO 

/* TABLA TECNICO */

/* Mostrar Tecnico */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_MOSTRAR_TECNICO')
BEGIN
	DROP PROCEDURE SP_MOSTRAR_TECNICO
END
GO

CREATE PROCEDURE SP_MOSTRAR_TECNICO(@TIPO_FILTRO		NVARCHAR(50), 
									@CRITERIO			NVARCHAR(50))
AS
IF @TIPO_FILTRO = 'TODOS'
	BEGIN
		SELECT * FROM V_TECNICOS
	END
ELSE
	BEGIN
		IF(@TIPO_FILTRO= 'Nombre')
			SELECT * FROM V_TECNICOS WHERE Nombre LIKE @CRITERIO
		ELSE IF(@TIPO_FILTRO = 'Apellido')
			SELECT * FROM V_TECNICOS WHERE Apellido LIKE @CRITERIO
		ELSE IF(@TIPO_FILTRO = 'No. Tecnico')
			SELECT * FROM V_TECNICOS WHERE "No. Tecnico" LIKE @CRITERIO
	END

GO

/* Agregar Tecnico */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_AGREGAR_TECNICO')
BEGIN
	DROP PROCEDURE SP_AGREGAR_TECNICO
END
GO

CREATE PROCEDURE SP_AGREGAR_TECNICO(	@NOMBRE_TECNICO		NVARCHAR(50), 
										@APELLIDO_TECNICO	NVARCHAR(50), 
										@TELEFONO			NVARCHAR(9),
										@CORREO				NVARCHAR(50))
AS
BEGIN
	INSERT INTO Personas.Tecnico(	Nombre_Tecnico,
									Apellido_Tecnico,
									Telefono,
									Correo_Tecnico)

	VALUES						(	@NOMBRE_TECNICO,
									@APELLIDO_TECNICO,
									@TELEFONO,
									@CORREO)
END
GO


/* Actualizar Tecnico */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_ACTUALIZAR_TECNICO')
BEGIN
	DROP PROCEDURE SP_ACTUALIZAR_TECNICO
END
GO

CREATE PROCEDURE SP_ACTUALIZAR_TECNICO(	@NOMBRE_TECNICO		NVARCHAR(50), 
										@APELLIDO_TECNICO	NVARCHAR(50), 
										@TELEFONO			NVARCHAR(9),
										@CORREO				NVARCHAR(50),
										@NO_TECNICO			NVARCHAR(3))
AS
UPDATE Personas.Tecnico SET	Nombre_Tecnico=		@NOMBRE_TECNICO, 
							Apellido_Tecnico=	@APELLIDO_TECNICO, 
							Telefono=			@TELEFONO,
							Correo_Tecnico=		@CORREO
							WHERE No_Tecnico=	@NO_TECNICO;
GO

/* Eliminar Tecnico */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_ELIMINAR_TECNICO')
BEGIN
	DROP PROCEDURE SP_ELIMINAR_TECNICO
END
GO

CREATE PROCEDURE SP_ELIMINAR_TECNICO(@NO_TECNICO	NVARCHAR(3))
AS
	DELETE FROM Personas.Tecnico WHERE No_Tecnico = @NO_TECNICO;
GO
------------------------------------------------------------------------------------------------------------------------

USE BD_SERVICE_DESK
GO 

/* TABLA TICKET */
/* Mostrar Ticket */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_MOSTRAR_TICKET')
BEGIN
	DROP PROCEDURE SP_MOSTRAR_TICKET
END
GO

CREATE PROCEDURE SP_MOSTRAR_TICKET(@TIPO_FILTRO NVARCHAR(50), @CRITERIO NVARCHAR(50))
AS

IF @TIPO_FILTRO = 'TODOS'
	BEGIN
		SELECT * FROM V_TICKETS 
	END
ELSE
	BEGIN
		IF(@TIPO_FILTRO= 'No. Ticket')
			SELECT * FROM V_TICKETS WHERE "No. Ticket" LIKE @CRITERIO
		ELSE IF(@TIPO_FILTRO = 'Estado')
			SELECT * FROM V_TICKETS WHERE UPPER(Estado) LIKE UPPER(@CRITERIO)
		ELSE IF (@TIPO_FILTRO = 'No. Cliente')
			SELECT * FROM V_TICKETS WHERE UPPER("No. Cliente") LIKE UPPER(@CRITERIO)
		ELSE IF (@TIPO_FILTRO = 'Equipo')
			SELECT * FROM V_TICKETS WHERE UPPER("Descripción del equipo") LIKE UPPER(@CRITERIO)
	END
GO

/* Agregar Ticket */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_AGREGAR_TICKET')
BEGIN
	DROP PROCEDURE SP_AGREGAR_TICKET
END
GO



CREATE PROCEDURE SP_AGREGAR_TICKET(	@NO_CLIENTE				NVARCHAR(3), 
									@NO_SERIE				NVARCHAR(50), 
									@NO_TECNICO_ASIGNADO	NVARCHAR(3), 
									@FECHA_TICKET			DATE,
									@ID_ESTADO				INT,
									@PROBLEMA_REPORTADO		TEXT,
									@OBSERVACIONES			TEXT)
AS
INSERT INTO Registros.Ticket VALUES	(	@NO_CLIENTE,
										@NO_SERIE, 
										@NO_TECNICO_ASIGNADO, 
										@FECHA_TICKET,
										@ID_ESTADO,
										@PROBLEMA_REPORTADO,
										@OBSERVACIONES);
GO


/* Actualizar Ticket */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_ACTUALIZAR_TICKET')
BEGIN
	DROP PROCEDURE SP_ACTUALIZAR_TICKET
END
GO

CREATE PROCEDURE SP_ACTUALIZAR_TICKET(	@NO_CLIENTE				NVARCHAR(3), 
										@NO_SERIE				NVARCHAR(50), 
										@NO_TECNICO_ASIGNADO	NVARCHAR(3), 
										@FECHA_TICKET			DATE,
										@ID_ESTADO				INT,
										@PROBLEMA_REPORTADO		TEXT,
										@OBSERVACIONES			TEXT,
										@NO_TICKET				NVARCHAR(8))
AS
UPDATE Registros.Ticket SET No_Cliente=				@NO_CLIENTE,
							No_Serie=				@NO_SERIE, 
							No_Tecnico_Asignado=	@NO_TECNICO_ASIGNADO, 
							Fecha_Ticket=			@FECHA_TICKET,
							IDEstado=				@ID_ESTADO,
							Problema_Reportado=		@PROBLEMA_REPORTADO,
							Observaciones =			@OBSERVACIONES
							WHERE No_Ticket=		@NO_TICKET;
GO

/* Eliminar Ticket */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_ELIMINAR_TICKET')
BEGIN
	DROP PROCEDURE SP_ELIMINAR_TICKET
END
GO

CREATE PROCEDURE SP_ELIMINAR_TICKET(@NO_TICKET	NVARCHAR(8))
AS
	DELETE FROM Registros.Ticket WHERE No_Ticket = @NO_TICKET;
GO

-----------------------------------------------------------------------------------
/* Datos Ticket */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_DATOS_TICKET')
BEGIN
	DROP PROCEDURE SP_DATOS_TICKET
END
GO

CREATE PROCEDURE SP_DATOS_TICKET(@NO_TICKET NVARCHAR(8))
AS
	SELECT 
		TIC.No_Ticket, 
		CLI.No_Cliente,
		CLI.Nombre_Cliente, 
		CLI.Apellido_Cliente,
		CLI.Telefono, 
		CLI.Correo_Electronico,
		EQU.No_Serie,		
		EQU.Equipo,		
		EQU.Marca,
		EQU.Modelo,
		TEC.No_Tecnico,			 
		TEC.Nombre_Tecnico,		
		TEC.Apellido_Tecnico,	
		UPPER(FORMAT (TIC.Fecha_Ticket, N'dddd dd MMMM yyyy', 'es')) AS "Fecha",
		EST.Tipo_Estado,			
		TIC.Problema_Reportado,	
		TIC.Observaciones

		FROM (((Registros.Ticket AS TIC 
		INNER JOIN Personas.Cliente AS CLI		ON TIC.No_Cliente = CLI.No_Cliente)
		INNER JOIN Equipos.Equipo AS EQU		ON TIC.No_Serie = EQU.No_Serie)
		INNER JOIN Registros.Estado AS EST		ON TIC.IDEstado = EST.IDEstado)
		INNER JOIN Personas.Tecnico AS TEC		ON TIC.No_Tecnico_Asignado = TEC.No_Tecnico

	WHERE No_Ticket = @NO_TICKET
GO
