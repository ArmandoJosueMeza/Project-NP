/*PRUEBAS PARA VERIFICAR QUE EL CRUD DE LAS TABLAS FUNCIONA BIEN */
USE BD_SERVICE_DESK
GO 

/* TABLA CLIENTE */
EXECUTE SP_MOSTRAR_CLIENTE 'Apellido','Lorem'

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
EXECUTE SP_MOSTRAR_TECNICO

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
EXECUTE SP_MOSTRAR_USUARIO

EXECUTE SP_AGREGAR_USUARIO	'Josue',
							'Meza',
							'jmeza@network.com',
							'JMeza',
							'1996'


EXECUTE SP_ACTUALIZAR_USUARIO	'Josue',
								'Meza',
								'jmeza@padawan.com',
								'JMeza',
								'1996',
								3

EXECUTE SP_ELIMINAR_USUARIO 	3


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
	


EXECUTE SP_AGREGAR_TICKET	'004',
							'004',
							'001',
							'12/2/2019',
							'1',
							'No funciona tarjeta de red',
							'Carcasa rallada'

EXECUTE SP_ACTUALIZAR_TICKET	'005',
								'NBA',
								'001',
								'11/26/2019',
								'2',
								'NO ENCIENDE',
								'NINGUNA',
								'TIK-0011'	

EXECUTE SP_ELIMINAR_TICKET 'TIK-0011'		

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
								