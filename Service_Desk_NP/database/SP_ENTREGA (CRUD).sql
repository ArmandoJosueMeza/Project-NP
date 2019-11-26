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

/* TABLA ENTREGA */
/* Mostrar entrega */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_MOSTRAR_ENTREGA')
BEGIN
	DROP PROCEDURE SP_MOSTRAR_ENTREGA
END
GO

CREATE PROCEDURE SP_MOSTRAR_ENTREGA
AS
SELECT * FROM V_ENTREGAS
GO

/* Agregar Entrega */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_AGREGAR_ENTREGA')
BEGIN
	DROP PROCEDURE SP_AGREGAR_ENTREGA
END
GO

CREATE PROCEDURE SP_AGREGAR_ENTREGA(	@NO_TICKET_ENTREGA		NVARCHAR(8),
										@NO_CLIENTE				NVARCHAR(3), 
										@NO_SERIE				NVARCHAR(50), 
										@NO_TECNICO_ASIGNADO	NVARCHAR(3),
										@ID_ESTADO				INT,
										@FECHA_ENTREGA			DATE,
										@TRABAJO_REALIZADO		TEXT,
										@REPUESTO				TEXT,
										@GARANTIA				NVARCHAR(15))
AS

INSERT INTO Registros.Entrega VALUES(	@NO_TICKET_ENTREGA,
										@NO_CLIENTE,
										@NO_SERIE, 
										@NO_TECNICO_ASIGNADO, 
										@ID_ESTADO, 
										@FECHA_ENTREGA,
										@TRABAJO_REALIZADO,
										@REPUESTO,
										@GARANTIA);

UPDATE Registros.Ticket SET IDEstado = @ID_ESTADO WHERE Registros.Ticket.No_Ticket = @NO_TICKET_ENTREGA
GO


/* Actualizar Entrega */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_ACTUALIZAR_ENTREGA')
BEGIN
	DROP PROCEDURE SP_ACTUALIZAR_ENTREGA
END
GO

CREATE PROCEDURE SP_ACTUALIZAR_ENTREGA(	@NO_TICKET_ENTREGA		NVARCHAR(8),
										@NO_CLIENTE				NVARCHAR(3), 
										@NO_SERIE				NVARCHAR(50), 
										@NO_TECNICO_ASIGNADO	NVARCHAR(3),
										@ID_ESTADO				INT,
										@FECHA_ENTREGA			DATE,
										@TRABAJO_REALIZADO		TEXT,
										@REPUESTO				TEXT,
										@GARANTIA				NVARCHAR(15),
										@NO_ENTREGA				NVARCHAR(8))
AS

UPDATE Registros.Entrega SET	No_Ticket=				@NO_TICKET_ENTREGA,
								No_Cliente=				@NO_CLIENTE,
								No_Serie=				@NO_SERIE, 
								No_Tecnico_Asignado=	@NO_TECNICO_ASIGNADO, 
								IDEstado=				@ID_ESTADO,
								Fecha_Entrega=			@FECHA_ENTREGA,
								Trabajo_Realizado=		@TRABAJO_REALIZADO,
								Repuesto=				@REPUESTO,
								Garantia =				@GARANTIA
								WHERE No_Entrega=		@NO_ENTREGA

UPDATE Registros.Ticket SET IDEstado = @ID_ESTADO WHERE Registros.Ticket.No_Ticket = @NO_TICKET_ENTREGA
GO

/* Eliminar Entrega */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_ELIMINAR_ENTREGA')
BEGIN
	DROP PROCEDURE SP_ELIMINAR_ENTREGA
END
GO

CREATE PROCEDURE SP_ELIMINAR_ENTREGA(@NO_ENTREGA	NVARCHAR(8))
AS
	DELETE FROM Registros.Entrega WHERE No_Entrega = @NO_ENTREGA;
GO