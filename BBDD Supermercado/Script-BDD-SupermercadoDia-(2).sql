create database SupermercadoDia;
Go
use SupermercadoDia;
Go
create table [Rol](
	Id_Rol int identity (1,1),
	Nombre varchar (30) not null,
	primary key (Id_Rol)
);
Go
create table [Empleado](
	Legajo int identity (10000,1), 
	Fecha_Ingreso datetime not null,
	primary key (Legajo),
);
Go
create table [Usuario](
	Id_Usuario int identity (1,1),
	Nombre varchar (15) not null,
	Passw varchar (11) not null,
	Legajo int not null, 
	Id_Rol int not null,		
	primary key (Id_Usuario),
	foreign key (Legajo) references Empleado (Legajo),
	foreign key (Id_Rol) references Rol (Id_Rol)
);
Go
create table [Cliente](
	DNI int not null,
	Fecha_Registro datetime not null,
	primary key (DNI)
);
Go
create table [Datos_Personales](
	Id_Datos int identity (1,1),
	DNI int,
	Legajo int, 
	Nombre varchar (30) not null,
	Apellido varchar (30) not null,
	Telefono int not null,
	Cuil int not null, 
	Direccion varchar (30) not null,
	primary key (Id_Datos),
	foreign key (Legajo) references Empleado (Legajo),
	foreign key (DNI) references Cliente (DNI),
);
Go
create table [Producto](
	Id_Producto int identity (1,1),
	Descripcion varchar (50) not null,
	Precio  float not null,
	Cantidad int not null,
	Habilitado varchar (2) not null,
	primary key (Id_Producto),	
);
Go
create table [Carga_Stock](
	Id_Stock int identity (1,1),
	Id_Producto int not null, 
	Cantidad int not null,
	Fecha_Carga datetime not null,
	primary key (Id_Stock),
	foreign key (Id_Producto) references Producto (Id_Producto)
);
Go
create table [Factura](
	Id_Factura int identity (1,1),
	DNI int not null,
	Id_Usuario int not null,
	Fecha datetime not null, 
	primary key (Id_Factura),
	foreign key (DNI) references Cliente (DNI),
	foreign key (Id_Usuario) references Usuario (Id_Usuario)
);
Go
create table [Factura_Detalle](
	Id_Detalle int identity (1,1),
	Id_Factura int not null,
	Id_Producto int not null,
	Precio  float not null,
	Cantidad int not null, 
	primary key (Id_Detalle),
	foreign key (Id_Factura) references Factura (Id_Factura),
	foreign key (Id_Producto) references Producto (Id_Producto)
);