Sweet Easy Project. 

Company specialized in the commercialization of confectionery products, operating in both the wholesale and retail segments. It has multiple physical points of sale and a distribution network that covers various geographical areas.

Database for project

```sql
if not exists (select name from sys.databases where name = N'db_dulce_facil')
begin
	create database db_dulce_facil;
end;
go

use db_dulce_facil;
go

create table tipo_cliente (
	id_tipo_cliente int identity(1,1) constraint PK_Tipo_cliente primary key clustered,
	tipo_cliente varchar (20)
);
go

create table cliente(
	id_cliente int identity(1,1) constraint PK_Cliente primary key clustered,
	id_tipo_cliente int constraint FK_Tipo_cliente foreign key (id_tipo_cliente) references tipo_cliente (id_tipo_cliente) on update cascade on delete cascade,
	nombres varchar(45) not null,
	apellidos varchar(45) not null,
	telefono varchar(10) not null,
	correo varchar(45) not null
);
go

create table provincias(
	id_provincia int identity(1,1) constraint PK_Provincias primary key clustered,
	provincia varchar(25) not null
);
go

create table ciudades(
	id_ciudad int identity(1,1) constraint PK_Ciudades primary key clustered,
	ciudad varchar(25) not null
);
go

create table direciones (
	id_direccion int identity(1,1) constraint PK_Direciones primary key clustered,
	calle_principal varchar(45) not null,
	calle_secundaria varchar(45) not null,
	numero varchar(10) not null,
	referencias varchar(45),
	id_cliente int constraint FK_Cliente_direciones foreign key (id_cliente) references cliente(id_cliente) on update cascade on delete cascade,
	id_provincia int constraint FK_Provincias_direciones foreign key (id_provincia) references provincias(id_provincia) on update cascade on delete cascade,
	id_ciudad int constraint FK_Ciudades_direciones foreign key (id_ciudad) references ciudades(id_ciudad) on update cascade on delete cascade
);
go

create table permisos (
	id_permiso int identity(1,1) constraint PK_Permisos primary key clustered,
	permiso varchar (20)
);
GO

create table roles (
	id_rol int identity(1,1) constraint PK_Rol primary key clustered,
	rol varchar (20)
);
GO

create table roles_permisos (
	id_rol int,
	id_permiso int,
	primary key (id_rol, id_permiso),
	constraint Fk_Rol foreign key (id_rol) references roles(id_rol) on update cascade on delete cascade,
	constraint Fk_Permiso foreign key (id_permiso) references permisos(id_permiso) on update cascade on delete cascade,
);
go

create table usuario(
	id_usuario int identity(1,1) constraint PK_Usuario primary key clustered,
	id_rol int constraint Fk_Roles_usuario foreign key (id_rol) references roles(id_rol) on update cascade on delete cascade,
	nombres_usuario varchar(45) not null,
	apellidos_usuario varchar(45) not null,
	correo varchar(45) not null,
	contrasena varchar(45) not null
);
go

create table estado_ruta (
	id_estado_ruta int identity(1,1) constraint PK_Estado_ruta primary key clustered,
	estado_ruta varchar(25)
);
go

create table ruta (
	id_ruta int identity(1,1) constraint PK_Ruta primary key clustered,
	id_estado_ruta int constraint Fk_Estado_ruta foreign key (id_estado_ruta) references estado_ruta(id_estado_ruta) on update cascade on delete cascade,
	id_rol int constraint Fk_Roles_ruta foreign key (id_rol) references roles(id_rol) on update cascade on delete cascade,
	fecha_inicio date not null,
	fecha_fin date
);
go

create table producto (
	id_producto int identity(1,1) constraint PK_Producto primary key clustered,
	nombre_producto varchar (25) not null,
	descripcion varchar (45),
	stock int not null
);
go

create table precio_producto (
	id_precio_producto int identity(1,1) constraint id_precio_producto primary key clustered,
	precio decimal(10,2),
	id_producto int constraint FK_Prdocuto_id_producto foreign key (id_producto) references producto(id_producto) on update cascade on delete cascade,
);
go

create table precio_producto_historico (
	id_precio_producto_historico int identity(1,1) constraint PK_precio_producto_historico primary key clustered,
	id_precio_producto int constraint Fk_Precio_producto foreign key (id_precio_producto) references precio_producto (id_precio_producto) on update cascade on delete cascade,
	fecha_inicio date constraint df_pph_fecha_inicio default getdate(),
	fecha_fin date constraint df_pph_fecha_fin default NULL,
	usuaio_actualiza varchar(45) not null
);
go

create table estado_pedido (
	id_estado_pedido int identity(1,1) constraint Pk_Estado_pedido primary key clustered,
	estado_pedido varchar(20) not null
);
go

create table pedido (
	id_pedido int identity(1,1) constraint Pk_pedido primary key clustered,
	id_estado_pedido int constraint Fk_Estado_pedido foreign key (id_estado_pedido) references estado_pedido (id_estado_pedido) on update cascade on delete cascade,
	id_cliente int constraint Fk_pedido_cliente foreign key (id_cliente) references cliente(id_cliente) on update cascade on delete cascade,
	fecha_pedido date constraint Df_pedido_fp default getdate(),
	fecha_entrega date,
	id_ruta int,
	constraint Fk_pedido_ruta foreign key (id_ruta) references ruta(id_ruta) on update cascade on delete cascade,
);
go

create table detalle_pedido (
	id_detalle_pedido int identity(1,1) constraint PK_DetallePedido primary key clustered, 
	id_pedido int not null constraint FK_DetallePedido_Pedido foreign key (id_pedido) references pedido(id_pedido) on update cascade on delete cascade, 
	id_producto int not null constraint FK_DetallePedido_Producto foreign key (id_producto) references producto(id_producto) on update cascade on delete NO ACTION,
	cantidad int not null constraint CK_DetallePedido_Cantidad_Valida check (cantidad > 0),
	precio_unitario DECIMAL(10, 2) NOT NULL CONSTRAINT CK_DetallePedido_PrecioUnitario_Valido CHECK (precio_unitario >= 0),
	subtotal DECIMAL(10, 2) NOT NULL CONSTRAINT CK_DetallePedido_Subtotal_Valido CHECK (subtotal >= 0)
);
go

CREATE TRIGGER trg_ins_precioProeductoHistorico
on precio_producto
after update 
as
	begin
		SET NOCOUNT ON;
		-- Actualizar endDate del registro anterior (solo si el precio cambió)
		UPDATE pph
		SET pph.fecha_fin = GETDATE()
		FROM precio_producto_historico pph
		INNER JOIN inserted i ON pph.id_precio_producto = i.id_precio_producto
		INNER JOIN deleted d ON i.id_precio_producto = d.id_precio_producto
		WHERE i.precio <> d.precio
		AND pph.fecha_fin IS NULL; 
    
		-- Insertar nuevo registro en el histórico (solo si el precio cambió)
		INSERT INTO precio_producto_historico (id_precio_producto, fecha_inicio, usuaio_actualiza)
		SELECT i.id_precio_producto, GETDATE(), SYSTEM_USER
		FROM inserted i
		INNER JOIN deleted d ON i.id_precio_producto = d.id_precio_producto
		WHERE i.precio <> d.precio;
	end
go
