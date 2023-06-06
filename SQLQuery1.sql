--************************************************Store Procedures
create procedure sp_ListarProductos
as
Select Id_Producto as  'Identificador', Descripcion as 'Descripcion', Precio as 'Precio', Cantidad as 'Cantidad', Habilitado as 'Habilitado'
from dbo.Producto

execute sp_ListarProductos

create procedure sp_CrearProducto(
	@pDescripcion varchar (30),
	@pPrecio float,
	@pCantidad int,
	@pHabilitado varchar (2)
)
as 
insert into dbo.Producto (Descripcion,Precio,Cantidad,Habilitado)
values (@pDescripcion,@pPrecio,@pCantidad,@pHabilitado)

execute sp_CrearProducto 'Harina Molinos 1 kg',270,130,'SI'

create procedure sp_BuscarProducto(
	@pDescripcion varchar (30)
)
as
Select Id_Producto as  'Identificador', Descripcion as 'Descripcion', Precio as 'Precio', Cantidad as 'Cantidad', Habilitado as 'Habilitado' 
from dbo.Producto
where Descripcion like '%'+ @pDescripcion+'%'

--Select * from dbo.Producto

execute sp_BuscarProducto 'leche'

create procedure sp_ProductosAlerta
as 
Select Id_Producto as  'Identificador', Descripcion as 'Descripcion', Precio as 'Precio', Cantidad as 'Cantidad', Habilitado as 'Habilitado' from dbo.Producto
where Cantidad<50

execute sp_ProductosAlerta
create procedure sp_ModificarProducto(
	@pIdProducto int,
	@pDescripcion varchar (30),
	@pPrecio float,
	@pHabilitado varchar (2)
)
as
update dbo.Producto
set Descripcion= @pDescripcion, Precio=@pPrecio, Habilitado= @pHabilitado
where Id_Producto=@pIdProducto

create procedure sp_cargarStock(
	@pIdProducto int,
	@pCantidad int
)
as
update dbo.Producto
set Cantidad = (Cantidad+@pCantidad)
where Id_Producto=@pIdProducto

create procedure sp_ListarEmpleados
as
Select empleado.Legajo, dp.DNI, dp.Nombre, dp.Apellido
from dbo.Empleado empleado
inner join Datos_Personales dp on empleado.Empleado_DNI = dp.DNI

execute sp_ListarEmpleados

create procedure sp_ListarRoles
as
Select Nombre
from dbo.Rol

execute sp_ListarRoles
