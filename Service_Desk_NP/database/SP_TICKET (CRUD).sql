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

CREATE PROCEDURE SP_AGREGAR_TICKET(	@NO_CLIENTE				NVARCHAR(3), 
									@NO_SERIE				NVARCHAR(50), 
									@NO_TECNICO_ASIGNADO	NVARCHAR(3), 
									@FECHA_TICKET			DATE,
									@ID_ESTADO				INT,
									@PROBLEMA_REPORTADO		TEXT,
									@OBSERVACIONES			TEXT)
AS
BEGIN
	INSERT INTO Registros.Ticket(	No_Cliente,
									No_Serie,
									No_Tecnico_Asignado, 
									Fecha_Ticket,
									IDEstado,
									Problema_Reportado,
									Observaciones)

	VALUES						(	@NO_CLIENTE,
									@NO_SERIE, 
									@NO_TECNICO_ASIGNADO, 
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

CREATE PROCEDURE SP_ACTUALIZAR_TICKET(	@NO_TICKET				NVARCHAR(8), 
										@NO_CLIENTE				NVARCHAR(3), 
										@NO_SERIE				NVARCHAR(50), 
										@NO_TECNICO_ASIGNADO	NVARCHAR(15), 
										@FECHA_TICKET			DATE,
										@ID_ESTADO				INT,
										@PROBLEMA_REPORTADO		NVARCHAR(50),
										@OBSERVACIONES			TEXT)
AS
BEGIN
	UPDATE Registros.Ticket SET No_Cliente=				@NO_CLIENTE,
								No_Serie=				@NO_SERIE, 
								No_Tecnico_Asignado=	@NO_TECNICO_ASIGNADO, 
								Fecha_Ticket=			@FECHA_TICKET,
								IDEstado=				@ID_ESTADO,
								Problema_Reportado=		@PROBLEMA_REPORTADO,
								Observaciones =			@OBSERVACIONES
								WHERE No_Ticket=		@NO_TICKET;
END 
GO

/* Eliminar Ticket */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_ELIMINAR_TICKET')
BEGIN
	DROP PROCEDURE SP_ELIMINAR_TICKET
END
GO

CREATE PROCEDURE SP_ELIMINAR_TICKET( @NO_TICKET NVARCHAR(8))
AS
BEGIN
	SET @NO_TICKET = (SELECT No_Ticket FROM Registros.Ticket WHERE No_Ticket=@NO_TICKET);

	DELETE FROM Registros.Ticket WHERE No_Ticket = @NO_TICKET;
END