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

CREATE PROCEDURE SP_MOSTRAR_TICKET(@TIPO_FILTRO NVARCHAR(50), @CRITERIO NVARCHAR(50))
AS

IF @TIPO_FILTRO = 'TODOS'
	BEGIN
		SELECT * FROM V_TICKETS 
	END
ELSE
	BEGIN
		IF(@TIPO_FILTRO= 'No. Ticket')
			SELECT * FROM V_TICKETS WHERE "No. Ticket" LIKE @CRITERIO
		ELSE IF(@TIPO_FILTRO = 'Estado')
			SELECT * FROM V_TICKETS WHERE UPPER(Estado) LIKE UPPER(@CRITERIO)
		ELSE IF (@TIPO_FILTRO = 'No. Cliente')
			SELECT * FROM V_TICKETS WHERE UPPER("No. Cliente") LIKE UPPER(@CRITERIO)
		ELSE IF (@TIPO_FILTRO = 'Equipo')
			SELECT * FROM V_TICKETS WHERE UPPER("Descripción del equipo") LIKE UPPER(@CRITERIO)
	END
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

-----------------------------------------------------------------------------------
/* Datos Ticket */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_DATOS_TICKET')
BEGIN
	DROP PROCEDURE SP_DATOS_TICKET
END
GO

CREATE PROCEDURE SP_DATOS_TICKET(@NO_TICKET NVARCHAR(8))
AS
	SELECT 
		TIC.No_Ticket, 
		CLI.No_Cliente,
		CLI.Nombre_Cliente, 
		CLI.Apellido_Cliente,
		CLI.Telefono, 
		CLI.Correo_Electronico,
		EQU.No_Serie,		
		EQU.Equipo,		
		EQU.Marca,
		EQU.Modelo,
		TEC.No_Tecnico,			 
		TEC.Nombre_Tecnico,		
		TEC.Apellido_Tecnico,	
		UPPER(FORMAT (TIC.Fecha_Ticket, N'dddd dd MMMM yyyy', 'es')) AS "Fecha",
		EST.Tipo_Estado,			
		TIC.Problema_Reportado,	
		TIC.Observaciones

		FROM (((Registros.Ticket AS TIC 
		INNER JOIN Personas.Cliente AS CLI		ON TIC.No_Cliente = CLI.No_Cliente)
		INNER JOIN Equipos.Equipo AS EQU		ON TIC.No_Serie = EQU.No_Serie)
		INNER JOIN Registros.Estado AS EST		ON TIC.IDEstado = EST.IDEstado)
		INNER JOIN Personas.Tecnico AS TEC		ON TIC.No_Tecnico_Asignado = TEC.No_Tecnico

	WHERE No_Ticket = @NO_TICKET
GO
