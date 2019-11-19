USE master
GO


USE BD_SERVICE_DESK
GO


/* Pruebas de insercion */

/* TABLA USUARIOS */
INSERT INTO Personas.Usuario(Identidad_Usuario, Nombre_Usuario, Apellido_Usuario, Correo_Usuario,  Nombre_Acceso, Clave_Usuario)
VALUES						('0801-19XX-XXXXX', 'Jonatan', 'Amaya', 'jamaya@network.com', 'JAmaya', 'JAmaya');

GO

INSERT INTO Personas.Usuario(Identidad_Usuario, Nombre_Usuario, Apellido_Usuario, Correo_Usuario,  Nombre_Acceso, Clave_Usuario)
VALUES						('0802-19XX-XXXXX', 'Francisco', 'Ramos', 'framos@network.com','FRamos', 'FRamos');
GO


/* TABLA TECNICO */
INSERT INTO Personas.Tecnico(Nombre_Tecnico, Apellido_Tecnico, Telefono, Identidad_Tecnico, Correo_Tecnico)
VALUES						('Jonatan', 'Amaya', '965236XX','0801-19XX-XXXXX', 'jamaya@network.com');
GO

INSERT INTO Personas.Tecnico(Nombre_Tecnico, Apellido_Tecnico, Telefono, Identidad_Tecnico, Correo_Tecnico)
VALUES						('Francisco', 'Ramos', '277386XX','0802-19XX-XXXXX', 'framos@network.com');
GO


/* TABLA CLIENTE */
INSERT INTO Personas.Cliente(Identidad_Cliente, Nombre_Cliente, Apellido_Cliente, Empresa, Ubicacion, Telefono, Correo_Electronico)
VALUES						('0305-19XX-XXXXX', 'Vivamus', 'Lorem', 'In vel', 'Vestibulum ', '9652-XXXX', 'tempus_odio@gmail.com');
GO

INSERT INTO Personas.Cliente(Identidad_Cliente, Nombre_Cliente, Apellido_Cliente, Empresa, Ubicacion, Telefono, Correo_Electronico)
VALUES						('0905-19XX-XXXXX', 'Hendrerit', 'Velit', 'Neque', 'Aliquam ', '9174-XXXX', 'vitae@gmail.com');
GO

INSERT INTO Personas.Cliente(Identidad_Cliente, Nombre_Cliente, Apellido_Cliente, Empresa, Ubicacion, Telefono, Correo_Electronico)
VALUES						('1012-19XX-XXXXX', 'Iaculis', 'Maecenas', 'Ornare', 'Risus ', '9012-XXXX', 'eleifend@gmail.com');
GO

INSERT INTO Personas.Cliente(Identidad_Cliente, Nombre_Cliente, Apellido_Cliente, Empresa, Ubicacion, Telefono, Correo_Electronico)
VALUES						('0315-19XX-XXXXX', 'Leo', 'Malesuada', '', 'Sagittis ', '9877-XXXX', 'morbi@gmail.com');
GO

INSERT INTO Personas.Cliente(Identidad_Cliente, Nombre_Cliente, Apellido_Cliente, Empresa, Ubicacion, Telefono, Correo_Electronico)
VALUES						('0310-19XX-XXXXX', 'Nisl', 'Volutpat', 'Iaculis', 'Amet ', '9827-XXXX', 'elementum@gmail.com');
GO


/* TABLA ARTICULO */
INSERT INTO Articulos.Articulo(Identidad_Cliente, No_Serie, Articulo, Marca, Modelo, Clave_Acceso)
VALUES						('0305-19XX-XXXXX', 'Pellentesque', 'Adipiscing', 'DELL', 'Est', 'Integer');
GO

INSERT INTO Articulos.Articulo(Identidad_Cliente, No_Serie, Articulo, Marca, Modelo, Clave_Acceso)
VALUES						('0305-19XX-XXXXX', 'Pharetra', 'Ultrices', 'HP', 'Nam', '');
GO

INSERT INTO Articulos.Articulo(Identidad_Cliente, No_Serie, Articulo, Marca, Modelo, Clave_Acceso)
VALUES						('0305-19XX-XXXXX', 'Amet', 'Aliquet', 'ASUS', 'Porta', 'Purus**');
GO

INSERT INTO Articulos.Articulo(Identidad_Cliente, No_Serie, Articulo, Marca, Modelo, Clave_Acceso)
VALUES						('0905-19XX-XXXXX', 'Arcu', 'Semper', 'SAMSUNG', 'Scelerisque', '');
GO

INSERT INTO Articulos.Articulo(Identidad_Cliente, No_Serie, Articulo, Marca, Modelo, Clave_Acceso)
VALUES						('0905-19XX-XXXXX', 'Nunc', 'Amet', 'EPSON', 'Nullam', '');
GO

INSERT INTO Articulos.Articulo(Identidad_Cliente, No_Serie, Articulo, Marca, Modelo, Clave_Acceso)
VALUES						('1012-19XX-XXXXX', 'Pulvinar', 'Commodo', 'TOSHIBA', 'Tincidunt', 'Dis');
GO

INSERT INTO Articulos.Articulo(Identidad_Cliente, No_Serie, Articulo, Marca, Modelo, Clave_Acceso)
VALUES						('0310-19XX-XXXXX', 'Ultrices', 'Aenean', 'LENOVO', 'Nunc', 'elementum');
GO

INSERT INTO Articulos.Articulo(Identidad_Cliente, No_Serie, Articulo, Marca, Modelo, Clave_Acceso)
VALUES						('0315-19XX-XXXXX', 'Viverra', 'Quis', 'ACER', 'Neque', 'Imperdiet');
GO

INSERT INTO Articulos.Articulo(Identidad_Cliente, No_Serie, Articulo, Marca, Modelo, Clave_Acceso)
VALUES						('1012-19XX-XXXXX', 'Nibh', 'Vel', 'CHROMEBOOK', 'Eget', '');
GO

INSERT INTO Articulos.Articulo(Identidad_Cliente, No_Serie, Articulo, Marca, Modelo, Clave_Acceso)
VALUES						('0315-19XX-XXXXX', 'Augue', 'Praesent', 'CANON', 'Orci', '');
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

INSERT INTO Registros.Ticket(Identidad_Cliente, No_Serie, Identidad_Tecnico_Asignado, Fecha_Ticket, IDEstado, Problema_Reportado, Observaciones)
VALUES						('0305-19XX-XXXXX', 'Pellentesque', '0801-19XX-XXXXX', '2019/11/2', 1, 'posuere', 'gravida');
GO

INSERT INTO Registros.Ticket(Identidad_Cliente, No_Serie, Identidad_Tecnico_Asignado,Fecha_Ticket, IDEstado, Problema_Reportado, Observaciones)
VALUES						('0905-19XX-XXXXX', 'Pharetra', '0801-19XX-XXXXX',  '2019/11/2', 1, 'tempus', 'quisque');
GO

INSERT INTO Registros.Ticket(Identidad_Cliente, No_Serie, Identidad_Tecnico_Asignado, Fecha_Ticket, IDEstado, Problema_Reportado, Observaciones)
VALUES						('1012-19XX-XXXXX', 'Amet', '0802-19XX-XXXXX',  '2019/11/2', 1, 'donec', 'tempor');
GO

INSERT INTO Registros.Ticket(Identidad_Cliente, No_Serie, Identidad_Tecnico_Asignado,  Fecha_Ticket, IDEstado, Problema_Reportado, Observaciones)
VALUES						('0315-19XX-XXXXX', 'Arcu', '0801-19XX-XXXXX',  '2019/11/2', 1, 'eget', 'quam');
GO

INSERT INTO Registros.Ticket(Identidad_Cliente, No_Serie, Identidad_Tecnico_Asignado,  Fecha_Ticket, IDEstado, Problema_Reportado, Observaciones)
VALUES						('0315-19XX-XXXXX', 'Nunc', '0802-19XX-XXXXX',  '2019/11/3', 2, 'congue', 'blandit');
GO

INSERT INTO Registros.Ticket(Identidad_Cliente, No_Serie, Identidad_Tecnico_Asignado,  Fecha_Ticket, IDEstado, Problema_Reportado, Observaciones)
VALUES						('0305-19XX-XXXXX', 'Pulvinar', '0802-19XX-XXXXX',  '2019/11/3', 2, 'vulputate', 'sed');
GO

INSERT INTO Registros.Ticket(Identidad_Cliente, No_Serie, Identidad_Tecnico_Asignado,  Fecha_Ticket, IDEstado, Problema_Reportado, Observaciones)
VALUES						('0905-19XX-XXXXX', 'Ultrices', '0801-19XX-XXXXX',  '2019/11/3', 2, 'integer', 'nunc');
GO

INSERT INTO Registros.Ticket(Identidad_Cliente, No_Serie, Identidad_Tecnico_Asignado, Fecha_Ticket, IDEstado, Problema_Reportado, Observaciones)
VALUES						('1012-19XX-XXXXX', 'Viverra', '0802-19XX-XXXXX', '2019/11/3', 3, 'iaculis', 'diam');
GO

INSERT INTO Registros.Ticket(Identidad_Cliente, No_Serie, Identidad_Tecnico_Asignado, Fecha_Ticket, IDEstado, Problema_Reportado, Observaciones)
VALUES						('0315-19XX-XXXXX', 'Nibh', '0801-19XX-XXXXX',  '2019/11/3', 3, 'urna', 'natoque');
GO

INSERT INTO Registros.Ticket(Identidad_Cliente, No_Serie, Identidad_Tecnico_Asignado,  Fecha_Ticket, IDEstado, Problema_Reportado, Observaciones)
VALUES						('0310-19XX-XXXXX', 'Augue', '0801-19XX-XXXXX', '2019/11/3', 3, 'varius', 'pulvinar');
GO



/* TABLA ENTREGA */

INSERT INTO Registros.Entrega(Ticket_Entrega, Identidad_Cliente, No_Serie, Identidad_Tecnico_Asignado,  IDEstado, Fecha_Entrega, Trabajo_Realizado, Repuesto, Garantia)
VALUES						(1, '0305-19XX-XXXXX', 'Nibh', '0801-19XX-XXXXX', 3, '2019/11/2', 'accumsan', 'cras', 'nunc');
GO

INSERT INTO Registros.Entrega(Ticket_Entrega, Identidad_Cliente, No_Serie, Identidad_Tecnico_Asignado, IDEstado, Fecha_Entrega, Trabajo_Realizado, Repuesto, Garantia)
VALUES						(2, '0310-19XX-XXXXX', 'Augue', '0802-19XX-XXXXX', 3, '2019/11/2', 'tortor', 'vitae', 'etiam');
GO

INSERT INTO Registros.Entrega(Ticket_Entrega, Identidad_Cliente, No_Serie, Identidad_Tecnico_Asignado, IDEstado, Fecha_Entrega, Trabajo_Realizado, Repuesto, Garantia)
VALUES						(3, '0315-19XX-XXXXX', 'Viverra', '0801-19XX-XXXXX', 3, '2019/11/2', 'suspendisse', 'quam', 'mollis');
GO
