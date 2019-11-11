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

/* TABLA ARTICULO */
/* Agregar Articulo */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_AGREGAR_ARTICULO')
BEGIN
	DROP PROCEDURE SP_AGREGAR_ARTICULO
END
GO

CREATE PROCEDURE SP_AGREGAR_ARTICULO(	@ID_CLIENTE		INT, 
										@NO_SERIE		NVARCHAR(50), 
										@ARTICULO		NVARCHAR(50), 
										@MARCA			NVARCHAR(50),
										@MODELO			NVARCHAR(50),
										@CLAVE_ACCESO	NVARCHAR(50))
AS
BEGIN
	INSERT INTO Articulos.Articulo(	IDCliente,
									No_Serie,
									Articulo, 
									Marca, 
									Modelo,
									Clave_Acceso)

	VALUES						(	@ID_CLIENTE,
									@NO_SERIE, 
									@ARTICULO, 
									@MARCA, 
									@MODELO,
									@CLAVE_ACCESO);
END
GO


/* Actualizar Articulo */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_ACTUALIZAR_ARTICULO')
BEGIN
	DROP PROCEDURE SP_ACTUALIZAR_ARTICULO
END
GO

CREATE PROCEDURE SP_ACTUALIZAR_ARTICULO(	
											@ID_CLIENTE		INT, 
											@NO_SERIE		NVARCHAR(50), 
											@ARTICULO		NVARCHAR(50), 
											@MARCA			NVARCHAR(50),
											@MODELO			NVARCHAR(50),
											@CLAVE_ACCESO	NVARCHAR(50))
AS
BEGIN
	UPDATE Articulos.Articulo SET	IDCliente=		@ID_CLIENTE,
									No_Serie=		@NO_SERIE, 
									Articulo=		@ARTICULO, 
									Marca=			@MARCA,
									Modelo=			@MODELO,
									Clave_Acceso=	@CLAVE_ACCESO
									WHERE No_Serie=	@NO_SERIE AND Articulo= @ARTICULO;
END 
GO

/* Eliminar Articulo */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_ELIMINAR_ARTICULO')
BEGIN
	DROP PROCEDURE SP_ELIMINAR_ARTICULO
END
GO

CREATE PROCEDURE SP_ELIMINAR_ARTICULO(	@NO_SERIE	NVARCHAR(50),
										@ARTICULO	NVARCHAR(50) )
AS
BEGIN
	DECLARE @ID_ARTICULO INT;
	SET @ID_ARTICULO = (SELECT IDArticulo FROM Articulos.Articulo WHERE No_Serie=@NO_SERIE and Articulo=@ARTICULO);

	DELETE FROM Articulos.Articulo WHERE IDArticulo = @ID_ARTICULO;
END

