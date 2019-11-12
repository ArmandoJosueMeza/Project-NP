/*PRUEBAS PARA VERIFICAR QUE EL CRUD DE LAS TABLAS FUNCIONA BIEN */
USE BD_SERVICE_DESK
GO 

/* TABLA CLIENTE */
SELECT * FROM Personas.Cliente
GO

EXECUTE SP_AGREGAR_CLIENTE	@IDENTIDAD_CLIENTE=		'0318-XXXX-XXXXX',
							@NOMBRE_CLIENTE=		'JOSUE',
							@APELLIDO_CLIENTE=		'MEZA',
							@EMPRESA=				'AKIRA',
							@UBICACION=				'INFERNO',
							@TELEFONO=				'96523629',
							@CORREO=				'akira@gmail.com'

EXECUTE SP_ACTUALIZAR_CLIENTE	
								@IDENTIDAD_CLIENTE=		'0318-XXXX-XXXXX',
								@NOMBRE_CLIENTE=		'JOSUE',
								@APELLIDO_CLIENTE=		'MEZA',
								@EMPRESA=				'AKIRA',
								@UBICACION=				'TERABHITIA',
								@TELEFONO=				'96523629',
								@CORREO=				'akira@gmail.com'

EXECUTE SP_ELIMINAR_CLIENTE		@IDENTIDAD_CLIENTE=		'0318-XXXX-XXXXX',
								@NOMBRE_CLIENTE=		'JOSUE'

/* TABLA TECNICO */
SELECT * FROM Personas.Tecnico
GO

EXECUTE SP_AGREGAR_TECNICO	@IDENTIDAD_TECNICO=		'0313-19XX-XXXXX',
							@NOMBRE_TECNICO=		'JOSUE',
							@APELLIDO_TECNICO=		'MEZA',
							@TELEFONO=				'96523629'


EXECUTE SP_ACTUALIZAR_TECNICO	@IDENTIDAD_TECNICO=		'0313-19XX-XXXXX',
								@NOMBRE_TECNICO=		'JOSUE',
								@APELLIDO_TECNICO=		'MENA',
								@TELEFONO=				'96523629'

EXECUTE SP_ELIMINAR_TECNICO		@IDENTIDAD_TECNICO=		'0318-19XX-XXXXX',
								@NOMBRE_TECNICO=		'MEZA'


/* TABLA USUARIO */
SELECT * FROM Personas.Usuario
GO 

EXECUTE SP_AGREGAR_USUARIO @IDENTIDAD_USUARIO= '0318-XXXX-XXXXX',
							@NOMBRE_USUARIO= 'JOSUE',
							@APELLIDO_USUARIO= 'MEZA',
							@NOMBRE_ACCESO= 'JMEZA',
							@CLAVE_USUARIO= '1996'


EXECUTE SP_ACTUALIZAR_USUARIO @IDENTIDAD_USUARIO= '0318-XXXX-XXXXX',
							@NOMBRE_USUARIO= 'JONAS',
							@APELLIDO_USUARIO= 'MEZA',
							@NOMBRE_ACCESO= 'JMEZA',
							@CLAVE_USUARIO= '1996'

EXECUTE SP_ELIMINAR_USUARIO @IDENTIDAD_USUARIO= '0318-XXXX-XXXXX',
							@NOMBRE_ACCESO= 'JMEZA'


/* TABLA ARTICULO */
SELECT * FROM Articulos.Articulo
GO

EXECUTE SP_AGREGAR_ARTICULO	@ID_CLIENTE= '5',
							@NO_SERIE= '001',
							@ARTICULO= 'SERVIDOR',
							@MARCA= 'DELL',
							@MODELO= 'T-1000',
							@CLAVE_ACCESO= 'SERVIDOR2019**'

EXECUTE SP_ACTUALIZAR_ARTICULO	@ID_CLIENTE= '5',
								@NO_SERIE= '001',
								@ARTICULO= 'SERVIDOR',
								@MARCA= 'DELL',
								@MODELO= 'T-1000',
								@CLAVE_ACCESO= 'SERVIDOR2019//'

EXECUTE SP_ELIMINAR_ARTICULO	@NO_SERIE= 'CAMBIO',
								@ARTICULO= 'Praesent'

/* TABLA TICKET */
SELECT * FROM Registros.Ticket
GO

EXECUTE SP_AGREGAR_TICKET	@ID_CLIENTE= '5',
							@ID_ARTICULO= '10',
							@ID_TECNICO= '2',
							@NO_ORDEN= '012',
							@FECHA_TICKET= '8/11/2019',
							@ID_ESTADO='1',
							@PROBLEMA_REPORTADO='NO ENCIENDE',
							@OBSERVACIONES='NINGUNA'

EXECUTE SP_ACTUALIZAR_TICKET	@ID_CLIENTE= '5',
								@ID_ARTICULO= '10',
								@ID_TECNICO= '2',
								@NO_ORDEN= '012',
								@FECHA_TICKET= '8/11/2019',
								@ID_ESTADO='1',
								@PROBLEMA_REPORTADO='NO ENCIENDE',
								@OBSERVACIONES='NO TIENE TAPA'

EXECUTE SP_ELIMINAR_TICKET @NO_ORDEN = '011'

/* TABLA ENTREGA */
SELECT * FROM Registros.Entrega
GO 

EXECUTE SP_AGREGAR_ENTREGA	@ID_TICKET_ENTREGA= '12',
							@ID_CLIENTE= '5',
							@ID_ARTICULO= '10',
							@ID_TECNICO= '2',
							@ID_ESTADO= '2',
							@FECHA_ENTREGA= '8/11/2019',
							@TRABAJO_REALIZADO= 'CAMBIO DE BIOS',
							@REPUESTO= 'CHIPSET',
							@GARANTIA= '3 MESES'

EXECUTE SP_ACTUALIZAR_ENTREGA	@ID_TICKET_ENTREGA= '12',
								@ID_CLIENTE= '5',
								@ID_ARTICULO= '10',
								@ID_TECNICO= '2',
								@ID_ESTADO= '3',
								@FECHA_ENTREGA= '8/11/2019',
								@TRABAJO_REALIZADO= 'CAMBIO DE BIOS',
								@REPUESTO= 'CHIPSET',
								@GARANTIA= '3 MESES'

EXECUTE SP_ELIMINAR_ENTREGA	    @ID_TICKET_ENTREGA= '12'
								
								