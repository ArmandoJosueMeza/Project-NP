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
/* Agregar Cliente */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_AGREGAR_CLIENTE')
BEGIN
	DROP PROCEDURE SP_AGREGAR_CLIENTE
END
GO

CREATE PROCEDURE SP_AGREGAR_CLIENTE(	@IDENTIDAD_CLIENTE	NVARCHAR(15), 
										@NOMBRE_CLIENTE		NVARCHAR(50), 
										@APELLIDO_CLIENTE	NVARCHAR(50), 
										@EMPRESA			VARCHAR(50), 
										@UBICACION			TEXT, 
										@TELEFONO			NVARCHAR(9), 
										@CORREO				NVARCHAR(50))
AS
BEGIN
	INSERT INTO Personas.Cliente (	Identidad_Cliente,
									Nombre_Cliente,
									Apellido_Cliente,
									Empresa,
									Ubicacion,
									Telefono,
									Correo_Electronico)

	VALUES						(	@IDENTIDAD_CLIENTE,
									@NOMBRE_CLIENTE,
									@APELLIDO_CLIENTE,
									@EMPRESA,
									@UBICACION,
									@TELEFONO,
									@UBICACION)
END
GO


/* Actualizar Cliente */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_ACTUALIZAR_CLIENTE')
BEGIN
	DROP PROCEDURE SP_ACTUALIZAR_CLIENTE
END
GO

CREATE PROCEDURE SP_ACTUALIZAR_CLIENTE(	
										@IDENTIDAD_CLIENTE	VARCHAR(15), 
										@NOMBRE_CLIENTE		NVARCHAR(50), 
										@APELLIDO_CLIENTE	NVARCHAR(50), 
										@EMPRESA			VARCHAR(50), 
										@UBICACION			TEXT, 
										@TELEFONO			VARCHAR(9), 
										@CORREO				NVARCHAR(50))
AS
BEGIN
	UPDATE Personas.Cliente SET	Identidad_Cliente=	@IDENTIDAD_CLIENTE,
								Nombre_Cliente=		@NOMBRE_CLIENTE, 
								Apellido_Cliente=	@APELLIDO_CLIENTE, 
								Empresa=			@EMPRESA, 
								Ubicacion=			@UBICACION, 
								Telefono=			@TELEFONO, 
								Correo_Electronico=	@CORREO
								WHERE Identidad_Cliente=	@IDENTIDAD_CLIENTE AND Nombre_Cliente = @NOMBRE_CLIENTE;
END 
GO

/* Eliminar Cliente */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_ELIMINAR_CLIENTE')
BEGIN
	DROP PROCEDURE SP_ELIMINAR_CLIENTE
END
GO

CREATE PROCEDURE SP_ELIMINAR_CLIENTE(	@NOMBRE_CLIENTE		NVARCHAR(50),
										@IDENTIDAD_CLIENTE	NVARCHAR(15) )
AS
BEGIN
	DECLARE @ID_CLIENTE INT;
	SET @ID_CLIENTE = (SELECT IDCLiente FROM Personas.Cliente WHERE Nombre_Cliente=@NOMBRE_CLIENTE and Identidad_Cliente=@IDENTIDAD_CLIENTE);

	DELETE FROM Personas.Cliente WHERE IDCliente = @ID_CLIENTE;
END

