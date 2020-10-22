# Introducción
TODO: Dé una breve introducción a su proyecto. Deje que esta sección explique los objetivos o la motivación detrás de este proyecto.

# Empezando
TODO: Guíe a los usuarios a preparar y ejecutar su código en su propio sistema. En esta sección puedes hablar sobre:
1. Proceso de instalación
2. Dependencias de software
3. Últimos lanzamientos
4. Referencias de API

# Construir y probar
TODO: Describe y muestra cómo crear tu código y ejecutar las pruebas.

# Contribuir
TODO: Explique cómo otros usuarios y desarrolladores pueden contribuir a mejorar su código.

If you want to learn more about creating good readme files then refer the following [guidelines](https://docs.microsoft.com/en-us/azure/devops/repos/git/create-a-readme?view=azure-devops).También puede buscar inspiración en los archivos Léame a continuación:
Si desea obtener más información sobre cómo crear buenos archivos Léame, consulte las siguientes [guidelines] (https://docs.microsoft.com/en-us/azure/devops/ 
- [ASP.NET Core](https://github.com/aspnet/Home)
- [Visual Studio Code](https://github.com/Microsoft/vscode)
- [Chakra Core](https://github.com/Microsoft/ChakraCore)


# Sobre el Proyecto
# Sistema de Restaurante
Todo: Este proyecto se trata de Crear un Sistema para un Restaurante Ficticio que tenga los siguientes requerimientos 

Proyecto

Se solicita que cree una aplicación en C# que permita realizar las ventas en un punto de venta de un Restaurante.
Requerimiento de la Base de Datos

Se debe tener como mínimo las siguientes tablas:

•	tbl_usuario: Se almacenan los usuarios de la aplicación. Los campos mínimos son los siguientes:
o	id_usuario: llave primaria
o	usuario: Usuario de acceso
o	contrasenna: es la contraseña del usuario.
o	nombre: es el nombre y apellido del usuario
o	cargo: es el cargo que ocupa en el restaurante
o	activo: indica si esta activo en la base de datos

•	tbl_mesa: almacena la información referente a la mesa:
o	numero: es el número de la mesa. Llave primaria
o	descripcion: cualquier descripción de la mesa
o	estado: indica si la mesa está ocupada o está libre. Se almacenan los valores “O” para ocupada y“L” para Libre. El valor predeterminado es “L”
o	activo: indica si esta activo en la base de datos

•	tbl_categoria: Almacena las categorías de productos que dispondrá el menú del restaurante
o	id_categoria: Es el id único de cada categoría. Llave primaria.
o	nombre: es el nombre de la categoría
o	Imagen: indica la ruta de la imagen de la categoría.
o	activo: indica si esta activo en la base de datos

•	tbl_producto: Almacena todos los productos o ítems de venta en el restaurante. Cada producto pertenece a una categoría.
o	id_producto: es el id único de cada producto.
o	descripcion: es una descripción breve del producto.
o	precio: es el precio del producto.
o	Cantidad: es la cantidad en existencia del producto
o	id_categoria: indica la categoría al cual está asignado el producto.
o	activo: indica si esta activo en la base de datos

•	tbl_orden_encabezado: Almacena el encabezado de la orden.
o	id_orden: id único de la orden, debe ser autoincremental
o	fecha_hora: es la fecha actual de la orden.
o	total: es el total de la orden.
o	id_usuario: es el usuario que crea el pedido.
o	numero_mesa: Es el número de la mesa en la que se realizó el pedido.
o	id_cliente: Es el id de cliente, si lo tiene, en tal caso de no tenerlo sería cero.
o	estado: indica el estado de la orden: “P” = Pendiente, “C” = Culminada, “A” = Anulada, “E”= Elaborada.

•	tbl_orden_detalle: almacena el detalle de los productos en la orden.
o	id_orden: es el id de la orden a la que pertenece.
o	id_producto: es el id de los productos en el pedido.
o	cantidad: es la cantidad en la orden.
o	precio: es el precio unitario del producto.
o	total: es la multiplicación del precio x cantidad

•	tbl_cliente: Almacena los datos del cliente
o	Id_cliente: Número de cliente. Autoincremental
o	Nombre: Nombre de Cliente.
o	Apellido: apellido de cliente.
o	Ultima_compra: Es la fecha de la última compra. (no la introduce el usuario)
o	Puntos: Es el total de puntos del cliente. (no la introduce el usuario)


*Cualquier otro campo o tabla que usted considere necesario.


Requerimientos funcionales de la Aplicación

1.	Pantalla de Login, se debe validar el usuario y contraseña contra la tabla tbl_usuario.

2.	Una vez logueado el usuario, debe acceder a una pantalla con las siguientes opciones: 
•	Administración 
•	Creación de Ordenes
•	Pedidos Pendientes
•	Listado

3.	Pantallas de Administración: en esta sección se da mantenimiento a las tablas:
•	tbl_usuario: aquí se debe pedir al usuario que introduzca nuevos usuarios, modificarlos y eliminarlos.
•	tbl_mesa: aquí se debe pedir al usuario que introduzca nuevas mesas, modificarlas y eliminarlas.
•	tbl_categoria: aquí se debe pedir al usuario que introduzca nuevas categorías, modificarlas y eliminarlas.
•	tbl_producto: aquí se debe pedir al usuario que introduzca nuevos productos, modificarlos y eliminarlos.
•	tbl_cliente: aquí se debe pedir al usuario que introduzca nuevas categorías, modificarlas y eliminarlas.
•	Cada pantalla de mantenimiento debe permitir Adicionar, modificar, eliminar los datos de cada tabla.

4.	Pantalla de Creación de Ordenes: En esta pantalla se gestiona la creación de Órdenes. Al acceder a esta pantalla se deben mostrar todas las mesas (accediendo al listado de mesas en la tabla tbl_mesa), en color verde las mesas que tengan el estado =“L” y en Rojo las mesas que tengan el estado “O”. Las mesas se deben crear de manera dinámica a partir de botones. 
