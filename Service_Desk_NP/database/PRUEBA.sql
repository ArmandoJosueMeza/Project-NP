/*PRUEBAS PARA VERIFICAR QUE EL CRUD DE LAS TABLAS FUNCIONA BIEN */
USE BD_SERVICE_DESK
GO 

/* TABLA CLIENTE */
EXECUTE SP_MOSTRAR_CLIENTE 'TODOS',''

EXECUTE SP_AGREGAR_CLIENTE 'Lucas',
							'Film',
							'Star Wars',
							'La galaxia',
							'95854210',
							'lucas@star.com'

EXECUTE SP_ACTUALIZAR_CLIENTE	'Josue',
								'Meza',
								'Akira',
								'Terabithia',
								'96523629',
								'akira@gmail.com',
								'006'


EXECUTE SP_ELIMINAR_CLIENTE	'006'

/* TABLA TECNICO */
EXECUTE SP_MOSTRAR_TECNICO 'TODOS',''

EXECUTE SP_AGREGAR_TECNICO	'Josue',
							'Meza',
							'96523629',
							'jmeza@network.com'


EXECUTE SP_ACTUALIZAR_TECNICO	'Josue',
								'Meza',
								'96523629',
								'jmeza@padawan.com',
								'003'

EXECUTE SP_ELIMINAR_TECNICO '003'
								
/* TABLA USUARIO */

/* TABLA ARTICULO */
EXECUTE SP_MOSTRAR_EQUIPO 'TODOS', ''

EXECUTE SP_AGREGAR_EQUIPO	'005',
							'SERVIDOR',
							'DELL',
							'T-1000',
							'CNV87914',
							'SERVIDOR2019**'

EXECUTE SP_ACTUALIZAR_EQUIPO '004',
							'Desktop',
							'Asus',
							'X550RCA',
							'004',
							'Lucas',
							'005'

EXECUTE SP_ELIMINAR_EQUIPO	'011'

/* TABLA TICKET */
EXECUTE SP_MOSTRAR_TICKET 'TODOS', ''

	
EXECUTE SP_AGREGAR_TICKET	'005',
							'GT-1000',
							'001',
							'12/2/2019',
							'1',
							'No enciende generador',
							'NINGUNA'

EXECUTE SP_ACTUALIZAR_TICKET	'004',
								'GT-1000',
								'002',
								'13/2/2019',
								'2',
								'NO ENCIENDE',
								'NINGUNA',
								'TIK-0004'	

EXECUTE SP_ELIMINAR_TICKET 'TIK-0006'		

EXECUTE SP_DATOS_TICKET 'TIK-0004'	

/* TABLA ENTREGA */
EXECUTE SP_MOSTRAR_ENTREGA 'TODOS', ''

EXECUTE SP_AGREGAR_ENTREGA	'TIK-0005',
							'004',
							'004',
							'001',
							'3',
							'12/2/2019',
							'No se realizo el trabajo el cliente retiro el equipo',
							'NINGUNO',
							'NINGUNO'

EXECUTE SP_ACTUALIZAR_ENTREGA	'TIK-0005',
								'004',
								'004',
								'001',
								'3',
								'12/2/2019',
								'No se realizo el trabajo el cliente retiro el equipo',
								'NINGUNO',
								'NINGUNO',
								'ETR-0003'
								

EXECUTE SP_ELIMINAR_ENTREGA	'ETR-0003'

EXECUTE SP_DATOS_ENTREGA 'ETR-0002'	
						