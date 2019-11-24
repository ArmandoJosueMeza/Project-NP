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

IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_MOSTRAR_CLIENTE')
BEGIN
	DROP PROCEDURE SP_MOSTRAR_CLIENTE
END
GO

CREATE PROCEDURE SP_MOSTRAR_CLIENTE
AS
SELECT * FROM V_CLIENTES
GO


/* TABLA CLIENTE */
/* Agregar Cliente */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_AGREGAR_CLIENTE')
BEGIN
	DROP PROCEDURE SP_AGREGAR_CLIENTE
END
GO

CREATE PROCEDURE SP_AGREGAR_CLIENTE(	@NOMBRE_CLIENTE		NVARCHAR(50), 
										@APELLIDO_CLIENTE	NVARCHAR(50), 
										@EMPRESA			VARCHAR(50), 
										@UBICACION			TEXT, 
										@TELEFONO			NVARCHAR(9), 
										@CORREO				NVARCHAR(50))
AS
BEGIN
	INSERT INTO Personas.Cliente (	Nombre_Cliente,
									Apellido_Cliente,
									Empresa,
									Ubicacion,
									Telefono,
									Correo_Electronico)

	VALUES						(	@NOMBRE_CLIENTE,
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

CREATE PROCEDURE SP_ACTUALIZAR_CLIENTE(	@NO_CLIENTE			NVARCHAR(3), 
										@NOMBRE_CLIENTE		NVARCHAR(50), 
										@APELLIDO_CLIENTE	NVARCHAR(50), 
										@EMPRESA			VARCHAR(50), 
										@UBICACION			TEXT, 
										@TELEFONO			NVARCHAR(9), 
										@CORREO				NVARCHAR(50))
AS
BEGIN
	UPDATE Personas.Cliente SET	Nombre_Cliente=		@NOMBRE_CLIENTE, 
								Apellido_Cliente=	@APELLIDO_CLIENTE, 
								Empresa=			@EMPRESA, 
								Ubicacion=			@UBICACION, 
								Telefono=			@TELEFONO, 
								Correo_Electronico=	@CORREO
								WHERE No_Cliente=	@NO_CLIENTE AND Nombre_Cliente = @NOMBRE_CLIENTE;
END 
GO

/* Eliminar Cliente */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_ELIMINAR_CLIENTE')
BEGIN
	DROP PROCEDURE SP_ELIMINAR_CLIENTE
END
GO

CREATE PROCEDURE SP_ELIMINAR_CLIENTE(	@NO_CLIENTE	NVARCHAR(15),
										@NOMBRE_CLIENTE		NVARCHAR(50))
AS
BEGIN
	SET @NO_CLIENTE = (SELECT No_Cliente FROM Personas.Cliente WHERE No_Cliente=@NO_CLIENTE AND Nombre_Cliente=@NOMBRE_CLIENTE );
	DELETE FROM Personas.Cliente WHERE No_Cliente = @NO_CLIENTE;
END
