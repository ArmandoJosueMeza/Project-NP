/*PRUEBAS PARA VERIFICAR QUE EL CRUD DE LAS TABLAS FUNCIONA BIEN */
USE BD_SERVICE_DESK
GO 

/* TABLA CLIENTE */
EXECUTE SP_MOSTRAR_CLIENTE

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
EXECUTE SP_MOSTRAR_EQUIPO


EXECUTE SP_AGREGAR_EQUIPO	'005',
							'SERVIDOR',
							'DELL',
							'T-1000',
							'CNV87914',
							'SERVIDOR2019**'

EXECUTE SP_ACTUALIZAR_EQUIPO '005',
							'SERVIDOR',
							'DELL',
							'T-1000',
							'CNV87914',
							'SERVIDOR2019//'

EXECUTE SP_ELIMINAR_EQUIPO	'CNV87914'

/* TABLA TICKET */
EXECUTE SP_MOSTRAR_TICKET


EXECUTE SP_AGREGAR_TICKET	'005',
							'NBA',
							'001',
							'11/26/2019',
							'1',
							'NO ENCIENDE',
							'NINGUNA'

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
EXECUTE SP_MOSTRAR_ENTREGA

EXECUTE SP_AGREGAR_ENTREGA	'TIK-0012',
							'002',
							'Nibh',
							'001',
							'3',
							'11/24/2019',
							'NADA',
							'NADA',
							'NADA'

EXECUTE SP_ACTUALIZAR_ENTREGA	'TIK-0012',
								'002',
								'Nibh',
								'001',
								'3',
								'11/24/2019',
								'TODO',
								'TODO',
								'TODO',
								'ETR-0004'
								

EXECUTE SP_ELIMINAR_ENTREGA	'ETR-0007'
								
								