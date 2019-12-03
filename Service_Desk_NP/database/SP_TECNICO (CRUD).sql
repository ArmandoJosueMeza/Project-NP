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