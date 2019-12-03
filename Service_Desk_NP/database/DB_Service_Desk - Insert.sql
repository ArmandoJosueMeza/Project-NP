USE master
GO


USE BD_SERVICE_DESK
GO


/* Pruebas de insercion */

/* TABLA USUARIOS */
INSERT INTO Personas.Usuario(Nombre_Usuario, Apellido_Usuario, Correo_Usuario,  Nombre_Acceso, Clave_Usuario)
VALUES						('Jonatan', 'Amaya', 'jamaya@network.com', 'JAmaya', 'JAmaya');

GO

INSERT INTO Personas.Usuario(Nombre_Usuario, Apellido_Usuario, Correo_Usuario,  Nombre_Acceso, Clave_Usuario)
VALUES						('Francisco', 'Ramos', 'framos@network.com','FRamos', 'FRamos');
GO


/* TABLA TECNICO */
INSERT INTO Personas.Tecnico(Nombre_Tecnico, Apellido_Tecnico, Telefono,  Correo_Tecnico)
VALUES						('Jonatan', 'Amaya', '965236XX', 'jamaya@network.com');
GO

INSERT INTO Personas.Tecnico(Nombre_Tecnico, Apellido_Tecnico, Telefono, Correo_Tecnico)
VALUES						('Francisco', 'Ramos', '277386XX', 'framos@network.com');
GO


/* TABLA CLIENTE */
INSERT INTO Personas.Cliente(Nombre_Cliente, Apellido_Cliente, Empresa, Ubicacion, Telefono, Correo_Electronico)
VALUES						( 'Luis', 'Lopez', 'Aquafeed', 'Aldea el Borbotón, San Francisco de Yojoa, Cortés ', '2650-4123', 'luis.lopez@aquafeedhn.com');
GO

INSERT INTO Personas.Cliente(Nombre_Cliente, Apellido_Cliente, Empresa, Ubicacion, Telefono, Correo_Electronico)
VALUES						('Maria', 'Fajardo', 'Comercial Nicole', 'Barrio Lempira, 4 Ave. entre 8 y 9 Calle, Local 72, San Pedro Sula, Cortés. ', '2553-5833', 'comercialnicole@hotmail.com');
GO

INSERT INTO Personas.Cliente(Nombre_Cliente, Apellido_Cliente, Empresa, Ubicacion, Telefono, Correo_Electronico)
VALUES						('Maria', 'Maecenas', 'Comercial Tadisa', 'Bo. Hipódromo, 7 y 8 Calle Ave. Juan Pablo Segundo, San Pero Sula, Cortés ', '2557-8389', 'comercialtadisa@hotmail.com');
GO


/* TABLA EQUIPO */
INSERT INTO Equipos.Equipo(No_Cliente, No_Serie, Equipo, Marca, Modelo, Clave_Acceso)
VALUES						('001', 'VNB8J1PH50', 'Impresora', 'HP', 'Color Laser Jet Pro MFP/277dw', 'NINGUNA');
GO

INSERT INTO Equipos.Equipo(No_Cliente, No_Serie, Equipo, Marca, Modelo, Clave_Acceso)
VALUES						('002', '5199PP1', 'Desktop', 'DELL', 'Latitude 5450', 'NINGUNA');
GO

INSERT INTO Equipos.Equipo(No_Cliente, No_Serie, Equipo, Marca, Modelo, Clave_Acceso)
VALUES						('003', 'R9-057GRM18', 'Laptop', 'Lenovo', 'Thinkpad L380 YOGA', 'Purus**');
GO


/* TABLA ESTADO */
INSERT INTO Registros.Estado(Tipo_Estado)
VALUES						('PENDIENTE');
GO

INSERT INTO Registros.Estado(Tipo_Estado)
VALUES						('EN PROCESO');
GO

INSERT INTO Registros.Estado(Tipo_Estado)
VALUES						('FINALIZADO');
GO

/* TABLA TICKET */

INSERT INTO Registros.Ticket(No_Cliente, No_Serie, No_Tecnico_Asignado, Fecha_Ticket, IDEstado, Problema_Reportado, Observaciones)
VALUES						('001', 'VNB8J1PH50', '001', '2019/11/18', 1, 'Se atasca el papel', 'NINGUNA');
GO

INSERT INTO Registros.Ticket(No_Cliente, No_Serie, No_Tecnico_Asignado,Fecha_Ticket, IDEstado, Problema_Reportado, Observaciones)
VALUES						('002', '5199PP1', '001',  '2019/11/19', 1, 'No enciende', 'Capacitores sobrecargados');
GO

INSERT INTO Registros.Ticket(No_Cliente, No_Serie, No_Tecnico_Asignado, Fecha_Ticket, IDEstado, Problema_Reportado, Observaciones)
VALUES						('003', 'R9-057GRM18', '002',  '2019/11/20', 1, 'Lectora de CD no funcona', 'Carcasa rallada');
GO

/* TABLA ENTREGA */

INSERT INTO Registros.Entrega(No_Ticket, No_Cliente, No_Serie, No_Tecnico_Asignado,  IDEstado, Fecha_Entrega, Trabajo_Realizado, Repuesto, Garantia)
VALUES						('TIK-0001', '001', 'VNB8J1PH50', '001', 1, '2019/11/23', 'Cambio de toner', 'Tonner', '3 meses');
GO

INSERT INTO Registros.Entrega(No_Ticket, No_Cliente, No_Serie, No_Tecnico_Asignado, IDEstado, Fecha_Entrega, Trabajo_Realizado, Repuesto, Garantia)
VALUES						('TIK-0002', '002', '5199PP1', '002', 2, '2019/11/24', 'Cambio de tarjeta madre', 'Tarjeta madre', '3 meses');
GO

