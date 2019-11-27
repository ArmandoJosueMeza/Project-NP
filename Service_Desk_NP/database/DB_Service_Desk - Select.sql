USE master
GO

/*	Utilizacion de la base de datos BD SERVICE DESK, para el software 
	Mesa de ayuda en el area de Servicio Tecnico Domicilio de la 
	empresa Network Place. 
*/
USE BD_SERVICE_DESK
GO


/* TABLA USUARIO */
SELECT * FROM V_USUARIOS
GO

/* TABLA CLIENTE */
SELECT * FROM V_CLIENTES
GO

/* TABLA TECNICO */
SELECT * FROM V_TECNICOS
GO

/* EQUIPOS - CLIENTE */


/* TABLA TICKET*/
SELECT * FROM V_TICKETS
GO

/* TABLA ENTREGA */

SELECT * FROM V_ENTREGAS
GO

/* TICKET - PENDIENTE */ 

SELECT * FROM V_TICKETS_PENDIENTES
GO

/* TICKET - EN PROCESO */ 

SELECT * FROM V_TICKETS_PROCESO
GO

/* TICKET - RESUELTO */ 
SELECT * FROM V_TICKETS_RESUELTOS
GO