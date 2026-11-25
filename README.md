# Postres-Pro
Aplicación de escritorio para gestionar clientes y pedidos de postres
# Postres Pro

## 1. Nombre del proyecto e integrantes

**Nombre:** Postres Pro

**Integrantes y roles:**
- **Jaider Diosa:** Líder técnico y encargado del módulo de Clientes.
- **Julian Gómez:** Encargado del módulo de Pedidos.

Ambos participaremos en la integración del proyecto, la base de datos, las pruebas y la documentación.

## 2. Funcionalidades del proyecto

Postres Pro será una aplicación de escritorio para administrar clientes y pedidos de un negocio de postres.

Permitirá registrar, consultar, editar y eliminar clientes, además de gestionar pedidos seleccionando al cliente, indicando el postre, la cantidad, el precio y la fecha. También permitirá calcular automáticamente el total y actualizar el estado del pedido.

**Reportes:**
- **Pedidos por estado:** permitirá consultar cuántos pedidos están pendientes, en preparación o entregados.
- **Reporte de ventas:** mostrará el total de ventas y permitirá consultar los pedidos registrados.

**Formularios de la aplicación:**
- `FormInicio`: menú principal para navegar por la aplicación.
- `FormClientes`: administración de clientes.
- `FormPedidos`: registro y administración de pedidos.
- `FormReportes`: visualización de los reportes.

## 3. Reparto de archivos y responsabilidades

**Jaider Diosa:**
- `Cliente.cs`: clase que representa a los clientes.
- `ClienteServicio.cs`: lógica para gestionar los clientes.
- `FormClientes.cs`: formulario para registrar, consultar, editar y eliminar clientes.

**Julian Gómez:**
- `Pedido.cs`: clase que representa los pedidos.
- `PedidoServicio.cs`: lógica para gestionar los pedidos.
- `FormPedidos.cs`: formulario para registrar y administrar los pedidos.

**Trabajo compartido:**
- `AppDbContext.cs`: configuración y conexión con la base de datos.
- `FormInicio.cs`: menú principal.
- `FormReportes.cs`: consultas y reportes mediante LINQ.
- Integración de los módulos, pruebas y documentación.

## 4. Tablas y relación de la base de datos

El proyecto contará con dos tablas relacionadas:

**Tabla Clientes:**
- Id
- Nombre
- Telefono
- Correo

**Tabla Pedidos:**
- Id
- ClienteId
- NombrePostre
- Cantidad
- PrecioUnitario
- Fecha
- Estado
- Total

**Relación entre las tablas:**

La relación será de uno a muchos (1:N). Esto significa que un cliente puede tener varios pedidos, pero cada pedido pertenece a un solo cliente.

Para establecer esta relación, la tabla `Pedidos` tendrá el campo `ClienteId`, que será una clave foránea relacionada con el campo `Id` de la tabla `Clientes`.
