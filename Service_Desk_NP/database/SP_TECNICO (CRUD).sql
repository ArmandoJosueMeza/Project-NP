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

/* TABLA TECNICO */
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

CREATE PROCEDURE SP_ACTUALIZAR_TECNICO(	@NO_TECNICO			NVARCHAR(3), 
										@NOMBRE_TECNICO		NVARCHAR(50), 
										@APELLIDO_TECNICO	NVARCHAR(50), 
										@TELEFONO			NVARCHAR(9),
										@CORREO				NVARCHAR(50))
AS
BEGIN
	UPDATE Personas.Tecnico SET	Nombre_Tecnico=		@NOMBRE_TECNICO, 
								Apellido_Tecnico=	@APELLIDO_TECNICO, 
								Telefono=			@TELEFONO,
								Correo_Tecnico=		@CORREO
								WHERE No_Tecnico=	@NO_TECNICO;
END 
GO

/* Eliminar Tecnico */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_ELIMINAR_TECNICO')
BEGIN
	DROP PROCEDURE SP_ELIMINAR_TECNICO
END
GO

CREATE PROCEDURE SP_ELIMINAR_TECNICO(	@NO_TECNICO		NVARCHAR(3),
										@NOMBRE_TECNICO	NVARCHAR(50))
AS
BEGIN
	SET @NO_TECNICO = (SELECT No_Tecnico FROM Personas.Tecnico WHERE No_Tecnico=@NO_TECNICO and Nombre_Tecnico=@NOMBRE_TECNICO );
	DELETE FROM Personas.Tecnico WHERE No_Tecnico = @NO_TECNICO;
END