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

/* TABLA EQUIPO */
/* Mostrar Equipo */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_MOSTRAR_EQUIPO')
BEGIN
	DROP PROCEDURE SP_MOSTRAR_EQUIPO
END
GO

CREATE PROCEDURE SP_MOSTRAR_EQUIPO
AS
SELECT 
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
										@CLAVE_ACCESO	NVARCHAR(50))
AS
UPDATE Equipos.Equipo SET	No_Cliente=		@NO_CLIENTE, 
							Equipo=			@EQUIPO,
							Marca=			@MARCA, 
							Modelo=			@MODELO,
							No_Serie=		@NO_SERIE,
							Clave_Acceso=	@CLAVE_ACCESO
							WHERE No_Serie=	@NO_SERIE;
GO

/* Eliminar Articulo */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_ELIMINAR_EQUIPO')
BEGIN
	DROP PROCEDURE SP_ELIMINAR_EQUIPO
END
GO

CREATE PROCEDURE SP_ELIMINAR_EQUIPO(@NO_SERIE	NVARCHAR(50))
AS
	DELETE FROM Equipos.Equipo WHERE No_Serie = @NO_SERIE;
GO
