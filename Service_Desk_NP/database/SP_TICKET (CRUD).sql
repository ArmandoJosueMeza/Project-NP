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

/* TABLA TICKET */
/* Agregar Ticket */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_AGREGAR_TICKET')
BEGIN
	DROP PROCEDURE SP_AGREGAR_TICKET
END
GO

CREATE PROCEDURE SP_AGREGAR_TICKET( @ID_CLIENTE			INT, 
									@ID_ARTICULO		INT, 
									@ID_TECNICO			INT, 
									@NO_ORDEN			NVARCHAR(50),
									@FECHA_TICKET		DATE,
									@ID_ESTADO			INT,
									@PROBLEMA_REPORTADO	NVARCHAR(50),
									@OBSERVACIONES		TEXT)
AS
BEGIN
	INSERT INTO Registros.Ticket(	IDCliente,
									IDArticulo,
									IDTecnico_Asignado, 
									No_Orden, 
									Fecha_Ticket,
									IDEstado,
									Problema_Reportado,
									Observaciones)

	VALUES						(	@ID_CLIENTE,
									@ID_ARTICULO, 
									@ID_TECNICO, 
									@NO_ORDEN, 
									@FECHA_TICKET,
									@ID_ESTADO,
									@PROBLEMA_REPORTADO,
									@OBSERVACIONES);
END
GO


/* Actualizar Ticket */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_ACTUALIZAR_TICKET')
BEGIN
	DROP PROCEDURE SP_ACTUALIZAR_TICKET
END
GO

CREATE PROCEDURE SP_ACTUALIZAR_TICKET(
										@ID_CLIENTE			INT, 
										@ID_ARTICULO		INT, 
										@ID_TECNICO			INT, 
										@NO_ORDEN			NVARCHAR(50),
										@FECHA_TICKET		DATE,
										@ID_ESTADO			INT,
										@PROBLEMA_REPORTADO	TEXT,
										@OBSERVACIONES		TEXT )
AS
BEGIN
	UPDATE Registros.Ticket SET IDCliente=			@ID_CLIENTE,
								IDArticulo=			@ID_ARTICULO, 
								IDTecnico_Asignado=	@ID_TECNICO, 
								No_Orden=			@NO_ORDEN,
								Fecha_Ticket=		@FECHA_TICKET,
								IDEstado=			@ID_ESTADO,
								Problema_Reportado=	@PROBLEMA_REPORTADO,
								Observaciones =		@OBSERVACIONES
								WHERE No_Orden=	@NO_ORDEN;
END 
GO

/* Eliminar Ticket */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_ELIMINAR_TICKET')
BEGIN
	DROP PROCEDURE SP_ELIMINAR_TICKET
END
GO

CREATE PROCEDURE SP_ELIMINAR_TICKET( @NO_ORDEN	NVARCHAR(50))
AS
BEGIN
	DECLARE @IDTICKET INT;
	SET @IDTICKET = (SELECT IDTicket FROM Registros.Ticket WHERE No_Orden=@NO_ORDEN);

	DELETE FROM Registros.Ticket WHERE IDTicket = @IDTICKET;
END