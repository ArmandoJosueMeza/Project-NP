--------------------------------------------------------------------
/*
	Creacion de PROCEDURE necesarios para la base de datos en 
	Mesa de ayuda en el area de Servicio Tecnico Domicilio de la 
	empresa Network Place.

	Creacion de CRUD mediante utilizacion de PROCEDURE
*/
--------------------------------------------------------------------

/* TABLA TICKET */

/* Mostrar Ticket Pendientes */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_MOSTRAR_PENDIENTE')
BEGIN
	DROP PROCEDURE SP_MOSTRAR_PENDIENTE
END
GO

CREATE PROCEDURE SP_MOSTRAR_PENDIENTE
AS
	SELECT * FROM V_TICKETS_PENDIENTES
GO
------------------------------------------------------------------------------

-------------------------------------------------------------------------------
/* Mostrar Ticket En Proceso */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_MOSTRAR_PROCESO')
BEGIN
	DROP PROCEDURE SP_MOSTRAR_PROCESO
END
GO

CREATE PROCEDURE SP_MOSTRAR_PROCESO
AS
	SELECT * FROM V_TICKETS_PROCESO
GO
-------------------------------------------------------------------------------

-------------------------------------------------------------------------------
/* Mostrar Ticket Finalizado */
IF EXISTS(SELECT * FROM sys.databases WHERE name='SP_MOSTRAR_FINALIZADO')
BEGIN
	DROP PROCEDURE SP_MOSTRAR_FINALIZADO
END
GO

CREATE PROCEDURE SP_MOSTRAR_FINALIZADO
AS
	SELECT * FROM V_TICKETS_FINALIZADOS
GO
-----------------------------------------------------------------------------
