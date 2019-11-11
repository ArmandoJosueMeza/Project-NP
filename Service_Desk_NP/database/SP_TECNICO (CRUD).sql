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

CREATE PROCEDURE SP_AGREGAR_TECNICO(	@IDENTIDAD_TECNICO	NVARCHAR(15), 
										@NOMBRE_TECNICO		NVARCHAR(50), 
										@APELLIDO_TECNICO	NVARCHAR(50), 
										@TELEFONO			NVARCHAR(9))
AS
BEGIN
	INSERT INTO Personas.Tecnico(	Identidad_Tecnico,
									Nombre_Tecnico,
									Apellido_Tecnico,
									Telefono)

	VALUES						(	@IDENTIDAD_TECNICO,
									@NOMBRE_TECNICO,
									@APELLIDO_TECNICO,
									@TELEFONO)
END
GO


/* Actualizar Tecnico */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_ACTUALIZAR_TECNICO')
BEGIN
	DROP PROCEDURE SP_ACTUALIZAR_TECNICO
END
GO

CREATE PROCEDURE SP_ACTUALIZAR_TECNICO(
										@IDENTIDAD_TECNICO	VARCHAR(15), 
										@NOMBRE_TECNICO		NVARCHAR(50), 
										@APELLIDO_TECNICO	NVARCHAR(50), 
										@TELEFONO			VARCHAR(9))
AS
BEGIN
	UPDATE Personas.Tecnico SET	Identidad_Tecnico=	@IDENTIDAD_TECNICO,
								Nombre_Tecnico=		@NOMBRE_TECNICO, 
								Apellido_Tecnico=	@APELLIDO_TECNICO, 
								Telefono=			@TELEFONO
								WHERE Identidad_Tecnico=	@IDENTIDAD_TECNICO;
END 
GO

/* Eliminar Tecnico */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_ELIMINAR_TECNICO')
BEGIN
	DROP PROCEDURE SP_ELIMINAR_TECNICO
END
GO

CREATE PROCEDURE SP_ELIMINAR_TECNICO(	@NOMBRE_TECNICO		NVARCHAR(50),
										@IDENTIDAD_TECNICO	NVARCHAR(15) )
AS
BEGIN
	DECLARE @ID_TECNICO INT;
	SET @ID_TECNICO = (SELECT IDTecnico FROM Personas.Tecnico WHERE Nombre_Tecnico=@NOMBRE_TECNICO AND Identidad_Tecnico=@IDENTIDAD_TECNICO);

	DELETE FROM Personas.Tecnico WHERE IDTecnico = @ID_TECNICO;
END