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

CREATE PROCEDURE SP_AGREGAR_USUARIO(	@NOMBRE_USUARIO		NVARCHAR(50), 
										@APELLIDO_USUARIO	NVARCHAR(50), 
										@CORREO				NVARCHAR(50),
										@NOMBRE_ACCESO		NVARCHAR(50),
										@CLAVE_USUARIO		NVARCHAR(50))
AS
BEGIN
	INSERT INTO Personas.Usuario(	
									Nombre_Usuario,
									Apellido_Usuario,
									Correo_Usuario,
									Nombre_Acceso,
									Clave_Usuario)

	VALUES						(	@NOMBRE_USUARIO,
									@APELLIDO_USUARIO,
									@CORREO,
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

CREATE PROCEDURE SP_ACTUALIZAR_USUARIO( @ID_USUARIO			INT,
										@NOMBRE_USUARIO		NVARCHAR(50), 
										@APELLIDO_USUARIO	NVARCHAR(50), 
										@CORREO				NVARCHAR(50),
										@NOMBRE_ACCESO		NVARCHAR(50),
										@CLAVE_USUARIO		NVARCHAR(50))
AS
BEGIN
	UPDATE Personas.Usuario SET	Nombre_Usuario=		@NOMBRE_USUARIO, 
								Apellido_Usuario=	@APELLIDO_USUARIO, 
								Correo_Usuario=		@CORREO,
								Nombre_Acceso=		@NOMBRE_ACCESO
								WHERE IDUsuario=	@ID_USUARIO;
END 
GO

/* Eliminar Usuario */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_ELIMINAR_USUARIO')
BEGIN
	DROP PROCEDURE SP_ELIMINAR_USUARIO
END
GO

CREATE PROCEDURE SP_ELIMINAR_USUARIO( @NOMBRE_ACCESO	NVARCHAR(50) )
AS
BEGIN
	
	SET @NOMBRE_ACCESO = (SELECT Nombre_Acceso FROM Personas.Usuario WHERE Nombre_Acceso=@NOMBRE_ACCESO);

	DELETE FROM Personas.Usuario WHERE Nombre_Acceso = @NOMBRE_ACCESO;
END