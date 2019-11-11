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

/* TABLA USUARIO */
/* Agregar Usuario */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_AGREGAR_USUARIO')
BEGIN
	DROP PROCEDURE SP_AGREGAR_USUARIO
END
GO

CREATE PROCEDURE SP_AGREGAR_USUARIO(	@IDENTIDAD_USUARIO	NVARCHAR(15), 
										@NOMBRE_USUARIO		NVARCHAR(50), 
										@APELLIDO_USUARIO	NVARCHAR(50), 
										@NOMBRE_ACCESO		NVARCHAR(50),
										@CLAVE_USUARIO		NVARCHAR(50))
AS
BEGIN
	INSERT INTO Personas.Usuario(	Identidad_Usuario,
									Nombre_Usuario,
									Apellido_Usuario,
									Nombre_Acceso,
									Clave_Usuario)

	VALUES						(	@IDENTIDAD_USUARIO,
									@NOMBRE_USUARIO,
									@APELLIDO_USUARIO,
									@NOMBRE_ACCESO,
									@CLAVE_USUARIO)
END
GO


/* Actualizar Usuario */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_ACTUALIZAR_USUARIO')
BEGIN
	DROP PROCEDURE SP_ACTUALIZAR_USUARIO
END
GO

CREATE PROCEDURE SP_ACTUALIZAR_USUARIO(
										@IDENTIDAD_USUARIO	VARCHAR(15), 
										@NOMBRE_USUARIO		NVARCHAR(50), 
										@APELLIDO_USUARIO	NVARCHAR(50), 
										@NOMBRE_ACCESO		NVARCHAR(50),
										@CLAVE_USUARIO		VARCHAR(50))
AS
BEGIN
	UPDATE Personas.Usuario SET	Identidad_Usuario=	@IDENTIDAD_USUARIO,
								Nombre_Usuario=		@NOMBRE_USUARIO, 
								Apellido_Usuario=	@APELLIDO_USUARIO, 
								Nombre_Acceso=		@NOMBRE_ACCESO
								WHERE Identidad_Usuario=	@IDENTIDAD_USUARIO;
END 
GO

/* Eliminar Tecnico */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_ELIMINAR_USUARIO')
BEGIN
	DROP PROCEDURE SP_ELIMINAR_USUARIO
END
GO

CREATE PROCEDURE SP_ELIMINAR_USUARIO(	@NOMBRE_ACCESO	NVARCHAR(50),
										@IDENTIDAD_USUARIO	NVARCHAR(15) )
AS
BEGIN
	DECLARE @ID_USUARIO INT;
	SET @ID_USUARIO = (SELECT IDUsuario FROM Personas.Usuario WHERE Nombre_Acceso=@NOMBRE_ACCESO AND @IDENTIDAD_USUARIO=@IDENTIDAD_USUARIO);

	DELETE FROM Personas.Usuario WHERE IDUsuario = @ID_USUARIO;
END