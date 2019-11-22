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
BEGIN
	INSERT INTO Equipos.Equipo(	No_Cliente,
								Equipo, 
								Marca, 
								Modelo,
								No_Serie,
								Clave_Acceso)

	VALUES						(	@NO_CLIENTE, 
									@EQUIPO,
									@MARCA, 
									@MODELO, 
									@NO_SERIE,
									@CLAVE_ACCESO);
END
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
BEGIN
	UPDATE Equipos.Equipo SET	No_Cliente=		@NO_CLIENTE, 
								Equipo=			@EQUIPO,
								Marca=			@MARCA, 
								Modelo=			@MODELO,
								No_Serie=		@NO_SERIE,
								Clave_Acceso=	@CLAVE_ACCESO
								WHERE No_Serie=	@NO_SERIE AND Equipo= @EQUIPO;
END 
GO

/* Eliminar Articulo */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_ELIMINAR_EQUIPO')
BEGIN
	DROP PROCEDURE SP_ELIMINAR_EQUIPO
END
GO

CREATE PROCEDURE SP_ELIMINAR_EQUIPO(	@NO_SERIE	NVARCHAR(50),
										@EQUIPO		NVARCHAR(50) )
AS
BEGIN
	
	SET @NO_SERIE = (SELECT No_Serie FROM Equipos.Equipo WHERE No_Serie=@NO_SERIE AND Equipo= @EQUIPO);
	DELETE FROM Equipos.Equipo WHERE No_Serie = @NO_SERIE;
END

