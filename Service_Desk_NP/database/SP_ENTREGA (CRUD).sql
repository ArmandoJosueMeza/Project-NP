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
/* Agregar Entrega */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_AGREGAR_ENTREGA')
BEGIN
	DROP PROCEDURE SP_AGREGAR_ENTREGA
END
GO

CREATE PROCEDURE SP_AGREGAR_ENTREGA(	@ID_TICKET_ENTREGA	INT, 
										@ID_CLIENTE			INT, 
										@ID_ARTICULO		INT, 
										@ID_TECNICO			INT,
										@ID_ESTADO			INT,
										@FECHA_ENTREGA		DATE,
										@TRABAJO_REALIZADO	TEXT,
										@REPUESTO			TEXT,
										@GARANTIA			NVARCHAR(15))
AS
BEGIN
	INSERT INTO Registros.Entrega(	IDTicket_Entrega,
									IDCliente,
									IDArticulo,
									IDTecnico_Asignado, 
									IDEstado,
									Fecha_Entrega,
									Trabajo_Realizado,
									Repuesto,
									Garantia)

	VALUES						(	@ID_TICKET_ENTREGA,
									@ID_CLIENTE,
									@ID_ARTICULO, 
									@ID_TECNICO, 
									@ID_ESTADO, 
									@FECHA_ENTREGA,
									@TRABAJO_REALIZADO,
									@REPUESTO,
									@GARANTIA);
	--IF 
	UPDATE Registros.Ticket SET IDEstado = @ID_ESTADO WHERE Registros.Ticket.IDTicket = @ID_TICKET_ENTREGA
END
GO


/* Actualizar Entrega */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_ACTUALIZAR_ENTREGA')
BEGIN
	DROP PROCEDURE SP_ACTUALIZAR_ENTREGA
END
GO

CREATE PROCEDURE SP_ACTUALIZAR_ENTREGA(	
										@ID_TICKET_ENTREGA	INT,
										@ID_CLIENTE			INT, 
										@ID_ARTICULO		INT, 
										@ID_TECNICO			INT, 
										@ID_ESTADO			INT,
										@FECHA_ENTREGA		DATE,
										@TRABAJO_REALIZADO	TEXT,
										@REPUESTO			TEXT,
										@GARANTIA			NVARCHAR(15))
AS
BEGIN
	UPDATE Registros.Entrega SET	IDTicket_Entrega=	@ID_TICKET_ENTREGA,
									IDCliente=			@ID_CLIENTE,
									IDArticulo=			@ID_ARTICULO, 
									IDTecnico_Asignado=	@ID_TECNICO, 
									IDEstado=			@ID_ESTADO,
									Fecha_Entrega=		@FECHA_ENTREGA,
									Trabajo_Realizado=	@TRABAJO_REALIZADO,
									Repuesto=			@REPUESTO,
									Garantia =			@GARANTIA
									WHERE IDTicket_Entrega=	@ID_TICKET_ENTREGA;

	UPDATE Registros.Ticket SET IDEstado = @ID_ESTADO WHERE Registros.Ticket.IDTicket = @ID_TICKET_ENTREGA
END 
GO

/* Eliminar Entrega */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_ELIMINAR_ENTREGA')
BEGIN
	DROP PROCEDURE SP_ELIMINAR_ENTREGA
END
GO

CREATE PROCEDURE SP_ELIMINAR_ENTREGA (@ID_TICKET_ENTREGA INT)
AS
BEGIN
	DECLARE @ID_ENTREGA INT;
	SET @ID_ENTREGA = (SELECT IDEntrega FROM Registros.Entrega WHERE IDTicket_Entrega=@ID_TICKET_ENTREGA);

	DELETE FROM Registros.Entrega WHERE IDEntrega = @ID_ENTREGA;
END

