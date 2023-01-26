# App-Consola-Para-Empresatel
Aplicación por consola creada con C#. 
El objetivo de este trabajo práctico era simular lo siguiente:
Una empresa proveedora de telefonía móvil y cable ofrece 4 combos distintos, cada uno de ellos incluye provisión de cable HD básica de 121 canales pero varía la cantidad de minutos libres disponibles y el costo por minuto de comunicación. Como promoción aplica una bonificación mensual del 15% del costo del combo a aquellos clientes que hayan consumido menos del 85% de los minutos libres de su plan. Adicionalmente lanza una oferta por tiempo limitado (hasta una fecha dada) y con cupo restringido, de un combo PLUS que agrega el pack de fútbol y Disney Channel, a cada uno de los 4 combos, al mismo precio del combo original. De los clientes suscriptos al servicio que brinda conoce sus datos personales: nro. cliente, apellido y nombre, dni, fecha de alta (DateTime), plan vigente, minutos de comunicación consumidos y nombre del técnico asignado a su área. La empresa cuenta con un equipo de técnicos que trabajan por zonas o áreas (cada técnico cubre una sola área).
Se deberá desarrollar una aplicación, utilizando las clases que crea necesarias, que resuelva las funcionalidades que se muestra en el siguiente menú
a) Agregar cliente y asignarle un técnico según el área donde vive el cliente. Si se suscribe dentro del plazo de promoción del combo plus, hay que verificar si hay cupo suficiente para dárselo. En caso contrario se debe levantar una excepción por "Cupo Insuficiente" e informar lo sucedido, dando la posibilidad al cliente de suscribirse igual
al combo común sin el plus.
b) Modificar la cantidad de minutos consumidos por un cliente dado
c) Eliminar cliente de la empresa.
d) Dada un área determinada imprimir el nombre de los técnicos asignados a la misma
e) Listado de clientes
f) Agregar técnico
g) Imprimir la facturación de cada cliente en base a su plan, aplicando la bonificación cuando corresponda.
h) Listado de técnicos

Desarrollé las clase y el main con el editor SharpDevelop
