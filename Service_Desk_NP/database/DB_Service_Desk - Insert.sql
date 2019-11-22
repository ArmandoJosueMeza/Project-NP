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
VALUES						( 'Vivamus', 'Lorem', 'In vel', 'Vestibulum ', '9652-XXXX', 'tempus_odio@gmail.com');
GO

INSERT INTO Personas.Cliente(Nombre_Cliente, Apellido_Cliente, Empresa, Ubicacion, Telefono, Correo_Electronico)
VALUES						('Hendrerit', 'Velit', 'Neque', 'Aliquam ', '9174-XXXX', 'vitae@gmail.com');
GO

INSERT INTO Personas.Cliente(Nombre_Cliente, Apellido_Cliente, Empresa, Ubicacion, Telefono, Correo_Electronico)
VALUES						('Iaculis', 'Maecenas', 'Ornare', 'Risus ', '9012-XXXX', 'eleifend@gmail.com');
GO

INSERT INTO Personas.Cliente(Nombre_Cliente, Apellido_Cliente, Empresa, Ubicacion, Telefono, Correo_Electronico)
VALUES						('Leo', 'Malesuada', '', 'Sagittis ', '9877-XXXX', 'morbi@gmail.com');
GO

INSERT INTO Personas.Cliente(Nombre_Cliente, Apellido_Cliente, Empresa, Ubicacion, Telefono, Correo_Electronico)
VALUES						('Nisl', 'Volutpat', 'Iaculis', 'Amet ', '9827-XXXX', 'elementum@gmail.com');
GO

/* TABLA EQUIPO */
INSERT INTO Equipos.Equipo(No_Cliente, No_Serie, Equipo, Marca, Modelo, Clave_Acceso)
VALUES						('001', 'Pellentesque', 'Adipiscing', 'DELL', 'Est', 'Integer');
GO

INSERT INTO Equipos.Equipo(No_Cliente, No_Serie, Equipo, Marca, Modelo, Clave_Acceso)
VALUES						('002', 'Pharetra', 'Ultrices', 'HP', 'Nam', '');
GO

INSERT INTO Equipos.Equipo(No_Cliente, No_Serie, Equipo, Marca, Modelo, Clave_Acceso)
VALUES						('003', 'Amet', 'Aliquet', 'ASUS', 'Porta', 'Purus**');
GO

INSERT INTO Equipos.Equipo(No_Cliente, No_Serie, Equipo, Marca, Modelo, Clave_Acceso)
VALUES						('004', 'Arcu', 'Semper', 'SAMSUNG', 'Scelerisque', '');
GO

INSERT INTO Equipos.Equipo(No_Cliente, No_Serie, Equipo, Marca, Modelo, Clave_Acceso)
VALUES						('005', 'Nunc', 'Amet', 'EPSON', 'Nullam', '');
GO

INSERT INTO Equipos.Equipo(No_Cliente, No_Serie, Equipo, Marca, Modelo, Clave_Acceso)
VALUES						('002', 'Pulvinar', 'Commodo', 'TOSHIBA', 'Tincidunt', 'Dis');
GO

INSERT INTO Equipos.Equipo(No_Cliente, No_Serie, Equipo, Marca, Modelo, Clave_Acceso)
VALUES						('002', 'Ultrices', 'Aenean', 'LENOVO', 'Nunc', 'elementum');
GO

INSERT INTO Equipos.Equipo(No_Cliente, No_Serie, Equipo, Marca, Modelo, Clave_Acceso)
VALUES						('004', 'Viverra', 'Quis', 'ACER', 'Neque', 'Imperdiet');
GO

INSERT INTO Equipos.Equipo(No_Cliente, No_Serie, Equipo, Marca, Modelo, Clave_Acceso)
VALUES						('004', 'Nibh', 'Vel', 'CHROMEBOOK', 'Eget', '');
GO

INSERT INTO Equipos.Equipo(No_Cliente, No_Serie, Equipo, Marca, Modelo, Clave_Acceso)
VALUES						('004', 'NBA', 'Vel', 'UPS', 'Eget', '');
GO

/* TABLA ESTADO */
INSERT INTO Registros.Estado(Tipo_Estado)
VALUES						('PENDIENTE');
GO

INSERT INTO Registros.Estado(Tipo_Estado)
VALUES						('EN PROCESO');
GO

INSERT INTO Registros.Estado(Tipo_Estado)
VALUES						('RESUELTO');
GO

/* TABLA TICKET */

INSERT INTO Registros.Ticket(No_Cliente, No_Serie, No_Tecnico_Asignado, Fecha_Ticket, IDEstado, Problema_Reportado, Observaciones)
VALUES						('001', 'Pellentesque', '001', '2019/11/2', 1, 'posuere', 'gravida');
GO

INSERT INTO Registros.Ticket(No_Cliente, No_Serie, No_Tecnico_Asignado,Fecha_Ticket, IDEstado, Problema_Reportado, Observaciones)
VALUES						('001', 'Pharetra', '001',  '2019/11/2', 1, 'tempus', 'quisque');
GO

INSERT INTO Registros.Ticket(No_Cliente, No_Serie, No_Tecnico_Asignado, Fecha_Ticket, IDEstado, Problema_Reportado, Observaciones)
VALUES						('001', 'Amet', '001',  '2019/11/2', 1, 'donec', 'tempor');
GO

INSERT INTO Registros.Ticket(No_Cliente, No_Serie, No_Tecnico_Asignado,  Fecha_Ticket, IDEstado, Problema_Reportado, Observaciones)
VALUES						('003', 'Arcu', '001',  '2019/11/2', 1, 'eget', 'quam');
GO

INSERT INTO Registros.Ticket(No_Cliente, No_Serie, No_Tecnico_Asignado,  Fecha_Ticket, IDEstado, Problema_Reportado, Observaciones)
VALUES						('003', 'Nunc', '001',  '2019/11/3', 2, 'congue', 'blandit');
GO

INSERT INTO Registros.Ticket(No_Cliente, No_Serie, No_Tecnico_Asignado,  Fecha_Ticket, IDEstado, Problema_Reportado, Observaciones)
VALUES						('004', 'Pulvinar', '002',  '2019/11/3', 2, 'vulputate', 'sed');
GO

INSERT INTO Registros.Ticket(No_Cliente, No_Serie, No_Tecnico_Asignado,  Fecha_Ticket, IDEstado, Problema_Reportado, Observaciones)
VALUES						('004', 'Ultrices', '002',  '2019/11/3', 2, 'integer', 'nunc');
GO

INSERT INTO Registros.Ticket(No_Cliente, No_Serie, No_Tecnico_Asignado, Fecha_Ticket, IDEstado, Problema_Reportado, Observaciones)
VALUES						('004', 'Viverra', '002', '2019/11/3', 3, 'iaculis', 'diam');
GO

INSERT INTO Registros.Ticket(No_Cliente, No_Serie, No_Tecnico_Asignado, Fecha_Ticket, IDEstado, Problema_Reportado, Observaciones)
VALUES						('002', 'Nibh', '001',  '2019/11/3', 3, 'urna', 'natoque');
GO

INSERT INTO Registros.Ticket(No_Cliente, No_Serie, No_Tecnico_Asignado,  Fecha_Ticket, IDEstado, Problema_Reportado, Observaciones)
VALUES						('005', 'NBA', '002', '2019/11/3', 3, 'varius', 'pulvinar');
GO

/* TABLA ENTREGA */

INSERT INTO Registros.Entrega(No_Ticket, No_Cliente, No_Serie, No_Tecnico_Asignado,  IDEstado, Fecha_Entrega, Trabajo_Realizado, Repuesto, Garantia)
VALUES						('TIK-0001', '001', 'Nibh', '001', 3, '2019/11/2', 'accumsan', 'cras', 'nunc');
GO

INSERT INTO Registros.Entrega(No_Ticket, No_Cliente, No_Serie, No_Tecnico_Asignado, IDEstado, Fecha_Entrega, Trabajo_Realizado, Repuesto, Garantia)
VALUES						('TIK-0004', '002', 'NBA', '002', 3, '2019/11/2', 'tortor', 'vitae', 'etiam');
GO

INSERT INTO Registros.Entrega(No_Ticket, No_Cliente, No_Serie, No_Tecnico_Asignado, IDEstado, Fecha_Entrega, Trabajo_Realizado, Repuesto, Garantia)
VALUES						('TIK-0003', '003', 'Viverra', '001', 3, '2019/11/2', 'suspendisse', 'quam', 'mollis');
GO
