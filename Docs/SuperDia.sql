

/*Script BBDD SuperDia****************************************************************/


create database SuperDia;

go

use SuperDia;

go

/*CREACION DE TABLAS******************************************************************/

create table Acceso(
	Id_nivel_de_acceso int identity (1, 1),
	Descripcion varchar(100) not null,
	primary key(Id_nivel_de_acceso)
	);
go

create table Datos_personales(
	Dni bigint not null,
	Apellidos varchar(50) not null,
	Nombres varchar(50) not null,
	Fecha_nac date not null,
	Telefono varchar(12) not null,
	Telefono_movil varchar(12),
	Direccion varchar(100) not null,
	primary key(Dni)
);

go

create table Cliente(
	id_cliente bigint not null,
	DNI bigint not null
	primary key(id_cliente)
	constraint fk_cliente_Datos_personales foreign key(DNI) references Datos_personales(Dni)
	);
go



create table Empleado(
	Legajo int identity(100,10),
	Fecha_ingreso date,
	Cuit_cuil bigint not null,
	Id_datos_pers bigint not null,
	primary key(Legajo),
	constraint fk_Id_datos_pers foreign key(Id_datos_pers) references Datos_personales(Dni)
	);

go

create table Cajero(
	Id_cajero int identity (10, 40) not null,
	Sueldo_cajero float not null,
	Legajo_cajero int not null,
	Id_ref_acceso int not null,
	primary key(Id_cajero),
	constraint fk_legajo_cajero foreign key(Legajo_cajero) references Empleado(Legajo),
	constraint fk_id_ref_acceso_C foreign key(Id_ref_acceso) references Acceso(Id_nivel_de_acceso)
	);

go

create table Gerente(
    Id_gerente int identity (5,5),
	Sueldo_gerente float not null,
	Legajo_gerente int not null,
	Id_ref_acceso int not null,
	primary key(Id_gerente),
	constraint fk_Legajo_gerente foreign key(Legajo_gerente) references Empleado(Legajo),
	constraint fk_Id_ref_acceso_G foreign key(Id_ref_acceso) references Acceso(Id_nivel_de_acceso)
	);

go

create table Encargado(
	Id_encargado int identity(20, 5),
	Sueldo_encargado float not null,
	Legajo_encargado int not null,
	Id_ref_acceso int not null,
	primary key(Id_encargado),
	constraint fk_Legajo_empleado foreign key(Legajo_encargado) references Empleado(Legajo),
	constraint fk_id_ref_acceso_E foreign key(Id_ref_acceso) references Acceso(Id_nivel_de_acceso)
	);

go

create table Administrador(
	Id_administrador int identity(100, 50),
	Sueldo_administrador float not null,
	Legajo_administrador int not null,
	Id_ref_acceso int not null, 
	primary key(Id_administrador),
	constraint fk_Legajo_administrador foreign key(Legajo_administrador) references Empleado(Legajo),
	constraint fk_id_ref_acceso_A foreign key(Id_ref_acceso) references Acceso(Id_nivel_de_acceso)
	);

go

create table Caja(
	Id_caja int identity(1,1),
	Fecha date not null,
	Horario_inicio time not null,
	Horario_cierre time not null,
	Id_operador int not null,
	primary key(Id_caja),
	constraint fk_Id_operador foreign key(Id_operador) references Cajero(Id_cajero)
	);

go

create table Sector(
	Id_sector int identity(1,1),
	Descripcion_sec varchar(100) not null,
	primary key(Id_sector)
	);

go

create table Producto(
	Id_producto int not null,
	Descripcion_prod varchar(200) not null,
	Valor_unitario float not null,
	Id_tipo int not null,
	primary key(Id_producto),
	constraint fk_Id_tipo foreign key(Id_tipo) references Sector(Id_sector)
	);

go

create table Arqueo(
	Id_arqueo int identity(15,10),
	Fecha_arqueo date not null,
	Hora time not null,
	Id_caja_asociada int not null,
	primary key(Id_arqueo),
	constraint fk_Id_caja_asociada foreign key(Id_caja_asociada) references Caja(Id_caja)
	);

go

create table Factura_Cabecera(
	Nro_factura int identity(100,25),
	Fecha date not null,
	Id_ref_caja int not null,
	id_cliente bigint not null,
	constraint Fk_Factura_Cabecera_Cliente foreign key (id_cliente) references Cliente(id_cliente),
	constraint Pk_Nro_factura primary key(Nro_factura),
	constraint Fk_Id_ref_caja foreign key(Id_ref_caja) references Caja(Id_caja)
	);

create table Factura_Detalle(
	Id_detalle int identity(50,10),
	Id_fact_cabecera int not null,
	primary key(Id_detalle),
	constraint fk_Id_fact_cabecera foreign key(Id_fact_cabecera) references Factura_Cabecera(Nro_factura)
	);
go

create table Factura_Detalle_Producto(
	Id_ref_detalle int not null,
	Id_ref_producto int not null,
	Cantidad int not null,
	constraint Fk_Id_ref_detalle foreign key(Id_ref_detalle) references Factura_Detalle(Id_detalle),
	constraint  Fk_Id_ref_producto foreign key(Id_ref_producto) references Producto(Id_producto),
	constraint Pk_clave_compuesta_DP primary key clustered (Id_ref_detalle, Id_ref_producto)
	);

go

create table Stock_Cabecera(
	Id_stock int identity(45,5),
	Fecha_stock date not null,
	Id_ref_sector int not null,
	Id_ref_encargado int not null,
	constraint Pk_Id_stock primary key(Id_stock),
	constraint Fk_Id_ref_sector foreign key(Id_ref_sector) references Sector(Id_sector),
	constraint  Fk_Id_ref_encargado foreign key(Id_ref_encargado) references Encargado(Id_encargado)
	);

go

create table Stock_Detalle(
	Id_detalle int identity(20,5),
	Id_ref_stock_cabecera int not null,
	constraint Pk_Id_detalle primary Key(Id_detalle),
	constraint Fk_Id_ref_stock_cabecera foreign key(Id_ref_stock_cabecera) references Stock_Cabecera(Id_stock)
	);

go

create table Stock_Detalle_Producto(
	Id_ref_detalle int not null,
	Id_ref_producto int not null,
	Cantidad_total int not null,
	constraint Fk_id_ref_detalle_SDP foreign key(Id_ref_detalle) references Stock_Detalle(Id_detalle),
	constraint Fk_id_ref_producto_SDP foreign key(Id_ref_producto) references Producto(Id_producto),
	constraint Pk_clave_compuesta_SDP primary key clustered (Id_ref_detalle, Id_ref_producto) 
	);


go

create table Reporte_Tipo(
	Id_tipo_rep int identity(1,1),
	Descripcion varchar(200) not null,
	constraint Pk_id_tipo_rep_RT primary key(Id_tipo_rep) 
	);

go

create table Reporte_Cabecera(
	Id_reporte int identity(5,5),
	Fecha date not null,
	Id_tipo int not null,
	constraint Pk_Id_reporte_RC primary key(Id_reporte),
	constraint Fk_Id_tipo_RC foreign key(Id_tipo) references Reporte_Tipo(Id_tipo_rep) 
	);

go

create table Reporte_Detalle(
	Id_rep_detalle int identity(3,3),
	Id_ref_tipo int not null,
	constraint Pk_Id_rep_detalle_RD primary key(Id_rep_detalle),
	constraint Fk_Id_ref_tipo_RD foreign key(Id_ref_tipo) references Reporte_Tipo(Id_tipo_rep)
	);

go

create table Reporte_Detalle_Producto(
	Id_ref_detalle int not null,
	Id_ref_producto int not null,
	Unidades_vendidas int not null,
	Total_en_pesos float not null,
	constraint Fk_Id_ref_detalle_RDP foreign key(Id_ref_detalle) references Reporte_Detalle(Id_rep_detalle),
	constraint Fk_Id_ref_producto_RDP foreign key(Id_ref_producto) references Producto(Id_producto),
	constraint Pk_clave_compuesta_RDP primary key clustered(Id_ref_detalle, Id_ref_producto)
	);


go


/*ALTAS INICIALES***************************************************************************/

insert into Datos_personales(Dni, Apellidos, Nombres,Fecha_nac,Telefono, Telefono_movil, Direccion) 
	values(20222123, 'Carmack', 'John', '1979-08-12', '0114555666', '011555444', 'Av Doom 64, Santiago Del Estero'),
		  (30222555, 'Napier', 'Jack', '1936-05-02', '0114545658', '011456879', 'Av del Crimen 1936, Ciudad Gotica'),
		  (40333564, 'Van Houten', 'Milhouse', '1990-06-01', '011564879', '0115557', 'Av El Chiflon 555, Springfield'),
		  (50222111, 'Bitat', 'Rabah', '1925-12-19', '02544566', '02299663', 'Av FLN 1962, Argelia'),
		  (50505050, 'Wazowski', 'Micke', '2001-12-01', '01010101', '02020202', 'Hiciste tu papeleo y Boo(S/N), Puertas');

go



insert into Acceso(Descripcion) values 
		('Nivel de acceso Administrador'),
		('Nivel de acceso Gerente'),
		('Nivel de acceso Encargado'),
		('Nivel de acceso Cajero');

go

insert into Empleado(Fecha_ingreso, Cuit_cuil, Id_datos_pers)
	values('2015-05-12', 501234567, 20222123),
		  ('2017-08-08', 212121212, 30222555),
		  ('2018-05-05', 696969696, 40333564),
		  ('2020-02-01', 878787878, 50222111),
		  ('2020-05-05', 191919191, 50505050); 

go

insert into Gerente(Sueldo_gerente, Legajo_gerente, Id_ref_acceso)
	values(25000, 100, 2);
go

insert into Administrador(Sueldo_administrador, Legajo_administrador, Id_ref_acceso)
	values(150000, 110, 1);

go

insert into Encargado(Sueldo_encargado, Legajo_encargado, Id_ref_acceso)
	values(35000, 120, 3);

go

insert into Cajero(Sueldo_cajero, Legajo_cajero, Id_ref_acceso)
	values(350000, 130, 4),
		  (350000, 140, 4);

go

insert into Sector(Descripcion_sec)
	values('ALMACEN'),
		  ('LIMPIEZA'),
		  ('VERDULERÍA');

go

insert into Producto(Id_producto, Descripcion_prod, Valor_unitario, Id_tipo)
	values (20001, 'Puré de tomate x 500cm3', 150.25, 1),
		   (20002, 'Fideos tallarines x 500grs', 200, 1),
		   (20003, 'Lentejas x 500grs', 190.50, 1),
		   (20004, 'Aceite de girasol x 980ml', 890.80, 1),
		   (20005, 'Arroz x 1kg', 150, 1),
		   (20006, 'Gaseosa  x 2.25ml', 500.25, 1),
		   (20007, 'Galletitas Pack x 3', 400.69, 1),
		   (20008, 'Vino tinto Skaviador x 5lts', 50.5, 1),
		   (20009, 'Jardinera x 250cm3', 190.25, 1),
		   (20010, 'Leche larga vida', 270.25, 1),
		   (30001, 'Rollo de cocina x 3', 250.25, 2),
		   (30002, 'Mata moscas y políticos x 360cm3', 600, 2),
		   (30003, 'Jabón en polvo x 1kg', 600.25, 2),
		   (30004, 'Papel higiénico x 4', 450.25, 2),
		   (30005, 'Detergente x 500cm3', 500.25, 2),
		   (30006, 'Lavandina x 1000cm3', 600.25, 2),
		   (30007, 'Trapo rejilla', 100.50, 2),
		   (30008, 'Trapo de piso', 250, 2),
		   (30009, 'Balde plástico x 5lts', 1000, 2),
		   (30010, 'Escoba Gavilia', 1500.25, 2),
		   (40001, 'Manzana roja x kg', 450.25, 3),
		   (40002, 'Peras x kg', 420, 3),
		   (40003, 'Acelga x 3', 250, 3),
		   (40004, 'Calabaza como tu cabeza x kg', 500, 3),
		   (40005, 'Papa Francisco x 5kg', 500, 3),
		   (40006, 'Uva blanca x kg', 480.60, 3),
		   (40007, 'Cebolla x 5kg', 1000.50 , 3),
		   (40008, 'Choclo x 2u', 180.90, 3),
		   (40009, 'Nirbanana x 1kg', 500, 3),
		   (40010, 'Naranja de jugo x kg', 150.5, 3);

	