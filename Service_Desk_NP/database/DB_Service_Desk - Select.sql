USE master
GO

/*	Utilizacion de la base de datos BD SERVICE DESK, para el software 
	Mesa de ayuda en el area de Servicio Tecnico Domicilio de la 
	empresa Network Place. 
*/
USE BD_SERVICE_DESK
GO


/* TABLA USUARIO */

SELECT * FROM Personas.Usuario
GO

/* TABLA TECNICO */
SELECT * FROM Personas.Tecnico
GO

/* TABLA CLIENTE */
SELECT * FROM Personas.Cliente
GO

/* VISTAS */

/* TABLA ARTICULO */

/* ARTICULO - CLIENTE */
SELECT * FROM V_ARTICULOS_CLIENTES
GO

/* TABLA TICKET */

/* TABLA TICKET DATA */
SELECT * FROM V_TICKET
GO

/* TABLA ENTREGA */

/* SELECT * FROM Registros.Entrega
GO */ 

SELECT * FROM V_ENTREGA
GO


/* TICKET - PENDIENTE */ 

SELECT * FROM V_TICKET_PENDIENTE
GO

/* TICKET - EN PROCESO */ 

SELECT * FROM V_TICKET_PROCESO
GO

/* TICKET - RESUELTO */ 
SELECT * FROM V_TICKET_RESUELTO
GO