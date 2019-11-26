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
/* Mostrar Usuario */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_MOSTRAR_USUARIO')
BEGIN
	DROP PROCEDURE SP_MOSTRAR_USUARIO
END
GO

CREATE PROCEDURE SP_MOSTRAR_USUARIO
AS
SELECT * FROM V_USUARIOS
GO

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
INSERT INTO Personas.Usuario VALUES	(	@NOMBRE_USUARIO,
										@APELLIDO_USUARIO,
										@CORREO,
										@NOMBRE_ACCESO,
										@CLAVE_USUARIO)
GO


/* Actualizar Usuario */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_ACTUALIZAR_USUARIO')
BEGIN
	DROP PROCEDURE SP_ACTUALIZAR_USUARIO
END
GO

CREATE PROCEDURE SP_ACTUALIZAR_USUARIO( @NOMBRE_USUARIO		NVARCHAR(50), 
										@APELLIDO_USUARIO	NVARCHAR(50), 
										@CORREO				NVARCHAR(50),
										@NOMBRE_ACCESO		NVARCHAR(50),
										@CLAVE_USUARIO		NVARCHAR(50),
										@ID_USUARIO			INT)
AS
UPDATE Personas.Usuario SET	Nombre_Usuario=		@NOMBRE_USUARIO, 
							Apellido_Usuario=	@APELLIDO_USUARIO, 
							Correo_Usuario=		@CORREO,
							Nombre_Acceso=		@NOMBRE_ACCESO
							WHERE IDUsuario=	@ID_USUARIO;
GO

/* Eliminar Usuario */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_ELIMINAR_USUARIO')
BEGIN
	DROP PROCEDURE SP_ELIMINAR_USUARIO
END
GO

CREATE PROCEDURE SP_ELIMINAR_USUARIO(@ID_USUARIO	INT)
AS
	DELETE FROM Personas.Usuario WHERE IDUsuario = @ID_USUARIO;
GO