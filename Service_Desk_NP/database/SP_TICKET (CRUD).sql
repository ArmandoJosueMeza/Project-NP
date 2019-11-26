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
/* Mostrar Ticket */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_MOSTRAR_TICKET')
BEGIN
	DROP PROCEDURE SP_MOSTRAR_TICKET
END
GO

CREATE PROCEDURE SP_MOSTRAR_TICKET
AS
SELECT * FROM V_TICKETS
GO

/* Agregar Ticket */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_AGREGAR_TICKET')
BEGIN
	DROP PROCEDURE SP_AGREGAR_TICKET
END
GO

CREATE PROCEDURE SP_AGREGAR_TICKET(	@NO_CLIENTE				NVARCHAR(3), 
									@NO_SERIE				NVARCHAR(50), 
									@NO_TECNICO_ASIGNADO	NVARCHAR(3), 
									@FECHA_TICKET			DATE,
									@ID_ESTADO				INT,
									@PROBLEMA_REPORTADO		TEXT,
									@OBSERVACIONES			TEXT)
AS
INSERT INTO Registros.Ticket VALUES	(	@NO_CLIENTE,
										@NO_SERIE, 
										@NO_TECNICO_ASIGNADO, 
										@FECHA_TICKET,
										@ID_ESTADO,
										@PROBLEMA_REPORTADO,
										@OBSERVACIONES);
GO


/* Actualizar Ticket */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_ACTUALIZAR_TICKET')
BEGIN
	DROP PROCEDURE SP_ACTUALIZAR_TICKET
END
GO

CREATE PROCEDURE SP_ACTUALIZAR_TICKET(	@NO_CLIENTE				NVARCHAR(3), 
										@NO_SERIE				NVARCHAR(50), 
										@NO_TECNICO_ASIGNADO	NVARCHAR(3), 
										@FECHA_TICKET			DATE,
										@ID_ESTADO				INT,
										@PROBLEMA_REPORTADO		TEXT,
										@OBSERVACIONES			TEXT,
										@NO_TICKET				NVARCHAR(8))
AS
UPDATE Registros.Ticket SET No_Cliente=				@NO_CLIENTE,
							No_Serie=				@NO_SERIE, 
							No_Tecnico_Asignado=	@NO_TECNICO_ASIGNADO, 
							Fecha_Ticket=			@FECHA_TICKET,
							IDEstado=				@ID_ESTADO,
							Problema_Reportado=		@PROBLEMA_REPORTADO,
							Observaciones =			@OBSERVACIONES
							WHERE No_Ticket=		@NO_TICKET;
GO

/* Eliminar Ticket */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_ELIMINAR_TICKET')
BEGIN
	DROP PROCEDURE SP_ELIMINAR_TICKET
END
GO

CREATE PROCEDURE SP_ELIMINAR_TICKET(@NO_TICKET	NVARCHAR(8))
AS
	DELETE FROM Registros.Ticket WHERE No_Ticket = @NO_TICKET;
GO
