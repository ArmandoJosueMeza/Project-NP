USE master
GO 

USE BD_SERVICE_DESK
GO

CREATE VIEW V_TECNICOS
AS 
SELECT 
TEC.No_Tecnico AS		"No. Tecnico",
TEC.Nombre_Tecnico AS	"Nombre",
TEC.Apellido_Tecnico AS	"Apellido",
TEC.Telefono AS			"Numero de teléfono",
TEC.Correo_Tecnico AS	"Correo electrónico"
FROM Personas.Tecnico AS "TEC" 
GO

CREATE VIEW V_CLIENTES
AS 
SELECT 
CLI.No_Cliente AS			"No. Cliente", 
CLI.Nombre_Cliente AS		"Nombre", 
CLI.Apellido_Cliente AS		"Apellido", 
CLI.Empresa,
CLI.Ubicacion AS			"Ubicación",
CLI.Telefono AS				"Numero de teléfono",
CLI.Correo_Electronico AS	"Correo electrónico"
FROM Personas.Cliente AS "CLI" 
GO

/* TICKET - VISTA */
CREATE VIEW V_TICKETS
AS 
SELECT 
TIC.No_Ticket AS			"No. Ticket",
CLI.No_Cliente AS			"No. Cliente",
CLI.Nombre_Cliente AS		"Nombre",
CLI.Apellido_Cliente AS		"Apellido",
EQU.No_Serie AS				"No. Serie", 
EQU.Equipo AS				"Descripción del equipo",
EQU.Marca,
EQU.Modelo,
TEC.No_Tecnico AS			"No. Tecnico Asignado", 
TEC.Nombre_Tecnico AS		"Nombre del Tenico",
TEC.Apellido_Tecnico AS		"Apellido del Tecnico",
UPPER(FORMAT (TIC.Fecha_Ticket, N'dddd dd MMMM yyyy', 'es')) AS "Fecha de ingreso",
--TIC.Fecha_Ticket AS			"Fecha de ingreso",
EST.Tipo_Estado AS			"Estado",
TIC.Problema_Reportado AS	"Problema reportado",
TIC.Observaciones

FROM (((Registros.Ticket AS TIC 
INNER JOIN Personas.Cliente AS CLI		ON TIC.No_Cliente = CLI.No_Cliente)
INNER JOIN Equipos.Equipo AS EQU		ON TIC.No_Serie = EQU.No_Serie)
INNER JOIN Registros.Estado AS EST		ON TIC.IDEstado = EST.IDEstado)
INNER JOIN Personas.Tecnico AS TEC		ON TIC.No_Tecnico_Asignado = TEC.No_Tecnico
GO

/* ENTREGA - VISTA */
CREATE VIEW V_ENTREGAS 
AS 
SELECT
ENT.No_Entrega AS			"No. Entrega",
TIC.No_Ticket AS			"No. Ticket",

CLI.No_Cliente AS			"No. Cliente",
CLI.Nombre_Cliente AS		"Nombre",
CLI.Apellido_Cliente AS		"Apellido",

EQU.No_Serie AS				"No. Serie",
EQU.Equipo AS				"Descripción del equipo",
EQU.Marca,
EQU.Modelo,

TEC.No_Tecnico AS			"No. Tecnico Asignado", 
TEC.Nombre_Tecnico AS		"Nombre del Tenico",
TEC.Apellido_Tecnico AS		"Apellido del Tecnico", 

EST.Tipo_Estado AS			"Estado",

UPPER(FORMAT (ENT.Fecha_Entrega, N'dddd dd MMMM yyyy', 'es')) AS "Fecha de ingreso",

ENT.Trabajo_Realizado AS	"Trabajo realizado",
ENT.Repuesto AS				"Repuestos utilizados",
ENT.Garantia

FROM ((((Registros.Entrega AS ENT 
INNER JOIN Registros.Ticket AS TIC		ON ENT.No_Ticket = TIC.No_Ticket)
INNER JOIN Personas.Cliente AS CLI		ON ENT.No_Cliente = CLI.No_Cliente)
INNER JOIN Equipos.Equipo AS EQU		ON ENT.No_Serie = EQU.No_Serie)
INNER JOIN Registros.Estado AS EST		ON ENT.IDEstado = EST.IDEstado)
INNER JOIN Personas.Tecnico AS TEC		ON ENT.No_Tecnico_Asignado = TEC.No_Tecnico
GO


/* TICKET PENDIENTE */
CREATE VIEW V_TICKETS_PENDIENTES
AS 
SELECT 
TIC.No_Ticket AS			"No. Ticket",
EST.Tipo_Estado AS			"Estado",
UPPER(FORMAT (TIC.Fecha_Ticket, N'dddd dd MMMM yyyy', 'es')) AS "Fecha de ingreso",
CLI.No_Cliente AS			"No. Cliente",
CLI.Nombre_Cliente AS		"Nombre",
CLI.Apellido_Cliente AS		"Apellido",
EQU.Equipo AS				"Descripción del equipo",
EQU.Marca,
EQU.Modelo,
EQU.No_Serie AS				"No. Serie", 
TIC.Problema_Reportado AS	"Problema reportado",
TIC.Observaciones,
TEC.No_Tecnico AS			"No. Tecnico Asignado", 
TEC.Nombre_Tecnico AS		"Nombre del Tenico",
TEC.Apellido_Tecnico AS		"Apellido del Tecnico"

FROM (((Registros.Ticket AS TIC 
INNER JOIN Personas.Cliente AS CLI		ON TIC.No_Cliente = CLI.No_Cliente)
INNER JOIN Equipos.Equipo AS EQU		ON TIC.No_Serie = EQU.No_Serie)
INNER JOIN Registros.Estado AS EST		ON TIC.IDEstado = EST.IDEstado)
INNER JOIN Personas.Tecnico AS TEC		ON TIC.No_Tecnico_Asignado = TEC.No_Tecnico
WHERE EST.Tipo_Estado = 'PENDIENTE'
GO

/* TICKET EN PROCESO */
CREATE VIEW V_TICKETS_PROCESO
AS 
SELECT 
TIC.No_Ticket AS			"No. Ticket",
EST.Tipo_Estado AS			"Estado",
UPPER(FORMAT (TIC.Fecha_Ticket, N'dddd dd MMMM yyyy', 'es')) AS "Fecha de ingreso",
CLI.No_Cliente AS			"No. Cliente",
CLI.Nombre_Cliente AS		"Nombre",
CLI.Apellido_Cliente AS		"Apellido",
EQU.Equipo AS				"Descripción del equipo",
EQU.Marca,
EQU.Modelo,
EQU.No_Serie AS				"No. Serie", 
TIC.Problema_Reportado AS	"Problema reportado",
TIC.Observaciones,
TEC.No_Tecnico AS			"No. Tecnico Asignado", 
TEC.Nombre_Tecnico AS		"Nombre del Tenico",
TEC.Apellido_Tecnico AS		"Apellido del Tecnico"

FROM (((Registros.Ticket AS TIC 
INNER JOIN Personas.Cliente AS CLI		ON TIC.No_Cliente = CLI.No_Cliente)
INNER JOIN Equipos.Equipo AS EQU		ON TIC.No_Serie = EQU.No_Serie)
INNER JOIN Registros.Estado AS EST		ON TIC.IDEstado = EST.IDEstado)
INNER JOIN Personas.Tecnico AS TEC		ON TIC.No_Tecnico_Asignado = TEC.No_Tecnico
WHERE EST.Tipo_Estado = 'EN PROCESO'
GO


/* TICKET RESUELTO */

CREATE VIEW V_TICKETS_FINALIZADOS
AS 
SELECT 
TIC.No_Ticket AS			"No. Ticket",
EST.Tipo_Estado AS			"Estado",
UPPER(FORMAT (TIC.Fecha_Ticket, N'dddd dd MMMM yyyy', 'es')) AS "Fecha de ingreso",
CLI.No_Cliente AS			"No. Cliente",
CLI.Nombre_Cliente AS		"Nombre",
CLI.Apellido_Cliente AS		"Apellido",
EQU.Equipo AS				"Descripción del equipo",
EQU.Marca,
EQU.Modelo,
EQU.No_Serie AS				"No. Serie", 
TIC.Problema_Reportado AS	"Problema reportado",
TIC.Observaciones,
TEC.No_Tecnico AS			"No. Tecnico Asignado", 
TEC.Nombre_Tecnico AS		"Nombre del Tenico",
TEC.Apellido_Tecnico AS		"Apellido del Tecnico"

FROM (((Registros.Ticket AS TIC 
INNER JOIN Personas.Cliente AS CLI		ON TIC.No_Cliente = CLI.No_Cliente)
INNER JOIN Equipos.Equipo AS EQU		ON TIC.No_Serie = EQU.No_Serie)
INNER JOIN Registros.Estado AS EST		ON TIC.IDEstado = EST.IDEstado)
INNER JOIN Personas.Tecnico AS TEC		ON TIC.No_Tecnico_Asignado = TEC.No_Tecnico
WHERE EST.Tipo_Estado = 'FINALIZADO'
GO