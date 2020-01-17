
-- =============================================================================================================
--                        Proyecto de Análisis de Sistemas: Punto de Venta Beer Lab.
-- =============================================================================================================

use master
go
create database ProyectoFinalBeerLab
go 
use ProyectoFinalBeerLab
go 

-- =============================================================================================================
--                                        Creación de las Tablas
-- =============================================================================================================


create table TBL_BeerLab
(
Id_Empresa         int identity(1,1) not null,
Cedula_Juridica    varchar(11)       not null,
Nombre             varchar(60)       not null,
Telefono           int               not null,
Direccion_fisica   varchar(150)      not null,
Correo_electronico varchar(60)       not null

Constraint [pk_tbl_BeerLab] Primary Key
	(Id_Empresa ASC)
)
go
create  table TBL_Estado
(
Id_estado     int         identity(1,1) not null, 
Nombre_Estado varchar(20)               not null

Constraint [pk_tbl_Estado] Primary Key
	(Id_estado ASC)
)
go
create table TBL_Roles
(
Id_Rol     int identity(1,1) not null,
Nombre_Rol varchar(50)       not null

Constraint [pk_tbl_Roles] Primary Key
	(Id_Rol ASC)
)
go
create table TBL_Tiempos_Usuario
(
Id_Tiempo      int identity(1,1)            not null,
Tiempos_limite char(02)                     not null

  Constraint [pk_TBL_Tiempos_Usuario] Primary Key
	(
		[Id_Tiempo] ASC
	)
)
go
create table TBL_Usuarios
(
Id_usuario         int         identity(1,1)   not null,
Identificacion     varchar(20)                 not null,
Nombre             varchar(50)                 not null,
Apellido1          varchar(50)                 not null,
Apellido2          varchar(50)                 not null,
Correo             varchar(50)                 not null,
Contraseña         varchar(20)                 not null,
Fecha_creacion     datetime,
Fecha_modificacion datetime,
Id_Tiempo          int foreign key (Id_Tiempo)  references TBL_Tiempos_Usuario(Id_Tiempo),
Id_Rol             int foreign key (Id_Rol)     references TBL_Roles(Id_Rol),
Id_estado          int foreign key (Id_estado)  references TBL_Estado (Id_estado),
Id_Empresa         int foreign key (Id_Empresa) references TBL_BeerLab(Id_Empresa)

  Constraint [pk_tbl_Usuarios] Primary Key
	(
		[Id_usuario] ASC
	)
)
go
create table TBL_Modulos
(
Id_Modulo     int         identity(1,1) not null,
Nombre_Modulo varchar(50)               not null

  Constraint [pk_tbl_Modulos] Primary Key
	(
		[Id_Modulo] ASC
	)
)
go
create table TBL_Operaciones
(
Id_Operacion     int         identity(1,1)   not null,
Nombre_Operacion varchar(50)                 not null,
Id_Modulo        int foreign key (Id_Modulo) references TBL_Modulos(Id_Modulo)

  Constraint [pk_tbl_Operaciones] Primary Key
	(
		[Id_Operacion] ASC
	)
)
go
create table TBL_Perfil_Operacion
(
Id_PerfilO   int identity(1,1)              not null,
Id_Rol       int foreign key (Id_Rol)       references TBL_Roles(Id_Rol),
Id_Operacion int foreign key (Id_Operacion) references TBL_Operaciones(Id_Operacion)

  Constraint [pk_TBL_Perfil_Operacion] Primary Key
	(
		[Id_PerfilO] ASC
	)
)
go
create table TBL_Clientes
(
Id_cliente          int        identity(1,1) not null,
Tipo_identificacion varchar(20)              not null,
Identificacion      varchar(20)              not null,
Nombre              varchar(45)              not null,
Apellido1           varchar(45)              not null,
Apellido2           varchar(45)              not null,
Tipo_cliente        varchar(10)              not null,
Fecha_nacimiento    datetime                     null,
Fecha_creacion      datetime                 not null,
Fecha_modificacion  datetime                 not null,
Telefono            int                          null,
Correo              varchar (45)                 null,
Puntos_acumulados   int                          null,
Id_estado           int foreign key (Id_estado) references TBL_Estado(Id_estado)

  Constraint [pk_TBL_Clientes] Primary Key
	(
		Id_Cliente ASC
	)

)
go
create table TBL_Provincias
(
Id_provincia   char(01)    not null,
Desc_provincia varchar(60) not null

  Constraint [pk_TBL_Provincias] Primary Key
	(
		Id_provincia ASC
	)
)
go
create table TBL_Cantones
(
Id_canton    char(02)    not null,
Desc_canton  varchar(70) not null,
Id_provincia char(01)    foreign key (Id_provincia) references TBL_Provincias (Id_provincia)

  Constraint [pk_tbl_Cantones] Primary Key
	(
	  Id_canton    ASC,
	  Id_provincia ASC
	)
)
go
create table TBL_Distritos
(
Id_distrito   char(02)    not null,
Id_canton     char(02)    not null,
Id_provincia  char(01)    not null,
Desc_distrito varchar(70) not null

  Constraint [pk_tbl_Distritos] Primary Key
	(
	  Id_distrito  ASC,
	  Id_canton    ASC,
	  Id_provincia ASC
	)
)
go
Alter table [TBL_Distritos] With NoCheck
  Add constraint [fk_Distritos_Cantones_Id_canton] Foreign Key (Id_canton,Id_provincia)
  References [TBL_Cantones] (Id_canton,Id_provincia)
go
Alter table [TBL_Distritos]
  CHECK CONSTRAINT [fk_Distritos_Cantones_Id_canton]
go
Alter table [TBL_Distritos] With NoCheck
  Add constraint [fk_Distritos_Provincias_Id_provincia] Foreign Key (Id_provincia)
  References [TBL_Provincias] (Id_provincia)
go
Alter table [TBL_Distritos]
  CHECK CONSTRAINT [fk_Distritos_Provincias_Id_provincia]
go
create table TBL_Direcciones_cliente
(
Id_direccion  int identity(1,1)            not null,
Dsc_direccion nvarchar(200)                not null,
Id_provincia  char(01)                     not null,
Id_canton	  char(02)                     not null,
Id_distrito	  char(02)                     not null,
Id_cliente    int foreign key (Id_cliente) references TBL_Clientes(Id_cliente)
  
  Constraint [pk_TBL_Direcciones_cliente] Primary Key
	(
		Id_direccion ASC,
		Id_cliente   ASC
	)
)
go
Alter table [TBL_Direcciones_cliente] With NoCheck
  Add constraint [fk_Direcciones_Provincias_Id_provincia] Foreign Key (Id_provincia)
  References [TBL_Provincias] (Id_provincia)
go
Alter table [TBL_Direcciones_cliente]
  CHECK CONSTRAINT [fk_Direcciones_Provincias_Id_provincia]
go 
Alter table [TBL_Direcciones_cliente] With NoCheck
  Add constraint [fk_Direcciones_Cantones_Id_canton] Foreign Key (Id_canton,Id_provincia)
  References [TBL_Cantones] (Id_canton,Id_provincia)
go
Alter table [TBL_Direcciones_cliente]
  CHECK CONSTRAINT [fk_Direcciones_Cantones_Id_canton]
go
Alter table [TBL_Direcciones_cliente] With NoCheck
  Add constraint [fk_Direcciones_Distritos_Id_distrito] Foreign Key (Id_distrito,Id_canton,Id_provincia)
  References [TBL_Distritos] (Id_distrito,Id_canton,Id_provincia)
go
Alter table [TBL_Direcciones_cliente]
  CHECK CONSTRAINT [fk_Direcciones_Distritos_Id_distrito]
go
create table TBL_DescuentosVIP
(
Id_DescVIP         int      identity (1,1) not null,
Fecha_creacion     datetime                not null,
Fecha_modificacion datetime                    null,
Descuento          int                     not null,
Puntos             int                     not null,
Estado             varchar(10)                 null

  Constraint [pk_TBL_DescuentosVIP] Primary Key
	(
		Id_DescVIP ASC
	)
)
go
create table TBL_DescuentosEstandar
(
Id_DescEstandar    int      identity (1,1) not null,
Fecha_creacion     datetime                not null,
Fecha_modificacion datetime                    null,
Cantidad_Minima	   int					   not null,
Cantidad_Maxima	   int					   not null,
Descuento          int                     not null,
Dia                varchar(20)                 null,
Estado             varchar(10)             not null

  Constraint [pk_TBL_DescuentosEstandar] Primary Key
	(
		Id_DescEstandar ASC
	)
)
go
create table TBL_Factura
(
Id_factura        int identity(1,1)                 not null,
Tipo_Factura      varchar(10)                       not null, -- Debería ser una tabla con los valores respectivos []
Tipo_Pago         varchar(10)                       not null, -- Debería ser una tabla con los valores respectivos [] 
Subtotal          decimal(20,2)                     not null,
SubtotalDescuento decimal(20,2)                     not null,
Total_impuesto    decimal(20,2)                     not null,
Total             decimal(20,2)                     not null,
Fecha_venta       datetime                          not null,
Id_estado         int foreign key (Id_estado)       references TBL_Estado(Id_estado),
Id_cliente        int foreign key (Id_cliente)      references TBL_Clientes(Id_cliente),
Id_DescVIP        int foreign key (Id_DescVIP)      references TBL_DescuentosVIP(Id_DescVIP),
Id_DescEstandar   int foreign key (Id_DescEstandar) references TBL_DescuentosEstandar(Id_DescEstandar)

  Constraint [pk_TBL_Factura] Primary Key
	(
		Id_factura ASC
	)
)
go
create table TBL_Detalle_Factura
(
Id_detalle_factura   int identity(1,1)            not null,
Descripcion_Producto varchar(100)                 not null,
Codigo               varchar(30)                  not null,
Precio_unitario      decimal(20,2)                not null,
Cantidad             int                          not null,
Id_estado            int foreign key (Id_estado)  references TBL_Estado(Id_estado),
Id_factura           int foreign key (Id_factura) references TBL_Factura(Id_factura)

  Constraint [pk_TBL_Detalle_Factura] Primary Key
	(
		Id_detalle_factura ASC
	)
)
go
Create table TBL_Productos
(
Id_producto          int identity(1,1)                    not null,
Nombre_producto      varchar(100)                         not null,
Descripcion_producto varchar(100)                         not null,
Precio_producto      decimal(20,2)                        not null,
Tipo_envasado        varchar(50)                          not null,
Nivel_fragilidad     varchar(20)                          not null,
Cantidad_mililitros  int                                  not null,
Nivel_Alcohol        int                                  not null,
Fecha_emision        datetime                             not null,
Fecha_caducidad      datetime                             not null,
Codigo               varchar(50)                              null,
Fecha_ingreso        datetime                             not null,
Fecha_Modificacion   datetime                                 null,
Stock_Inicial        int                                  not null,
Stock_Actual         int                                  not null,
Punto_Reorden        int                                  not null,
Id_estado            int foreign key (Id_estado)          references TBL_Estado(Id_estado),
Id_detalle_factura   int foreign key (Id_detalle_factura) references TBL_Detalle_Factura(Id_detalle_factura)

  Constraint [pk_TBL_Productos] Primary Key
	(
		Id_producto ASC
	)
)
go
create table TBL_Devoluciones
(
 Id_Devolucion     int identity(1,1)            not null,
 Razon_Devolucion  varchar(100)                 not null, 
 Estado_Fisico     varchar(100)                 not null,
 MontoDevolucion   numeric(20,2)                not null,
 Estado_Inventario varchar (100)                not null, 
 Descripcion       varchar(200)                 not null,
 Id_factura        int foreign key (Id_factura) references TBL_Factura(Id_factura) Not Null,
 Id_cliente        int foreign key (Id_cliente) references TBL_Clientes(Id_cliente) Not Null,
 Id_Estado		   int foreign key (Id_Estado)  references TBL_Estado(Id_estado) Not null

  Constraint [pk_TBL_Devoluciones] Primary Key
	(
	  Id_Devolucion ASC
	)
 )
go
create table TBL_Ubicaciones
(
 Id_Ubicacion        varchar(30)                   not null,
 Num_Almacen         char(01)                      not null,
 Num_Pasillo         int                           not null,
 Num_Estante         int                           not null,
 Tipo_Envasado       varchar(10)                   not null,
 Tipo_Cerveza        varchar(30)                   not null,
 Nivel_Fragilidad    char(02)                      not null,
 Ubicacion_Estante   varchar(05)                   not null,
 Ubicacion_receptora char(03)                      not null,
 Ubicacion_entrega   char (03)                     not null, 
 Peso_Lote           numeric(10,2)                 not null,
 Cantidad_Lote       int                           not null,
 Fecha_Produccion    datetime                      not null,
 Valor_Lote          numeric(20,2)                 not null,
 Id_producto         int foreign key (Id_producto) references TBL_Productos(Id_producto) not null
 
  Constraint [pk_TBL_Ubicaciones] Primary Key
	(
	  Id_Ubicacion ASC
	)
)
go
create table TBL_Orden_Fabricacion
(
 Id_Orden         int identity(1,1)            not null,
 FechaEmision     datetime                     not null,
 FechaFabricacion datetime							,
 Id_estado        int foreign key (Id_estado)  references TBL_Estado(Id_estado),
 Id_factura       int foreign key (Id_factura) references TBL_Factura(Id_factura)

  Constraint [pk_TBL_Orden_Fabricacion] Primary Key
	(
	  Id_Orden ASC
	)
)
go
create table TBL_Detalle_Orden_Fabricacion
(
Id_Detalle    int identity(1,1)             not null,
Desc_Producto varchar(30)                   not null,
Cantidad      int                           not null,
Id_Orden      int foreign key (Id_Orden)    references TBL_Orden_Fabricacion(Id_Orden),
Id_producto   int foreign key (Id_producto) references TBL_Productos(Id_Producto)

  Constraint [pk_TBL_Detalle_Orden_Fabricacion] Primary Key
	(
	  Id_Detalle ASC
	)
)
go
Create Table [TBL_CierreCajas]
(
  Id_CierreCajas int                          identity(1,1),
  Fecha_Cierre	 datetime                     Not null,
  Tipo_Factura	 varchar(10)                  Not null,
  Forma_Pago	 varchar(10)                  Not null,
  Entradas       numeric(20,2)                Not null,
  Salidas		 numeric(20,2)                Not null,
  Id_factura	 int foreign key (Id_factura) references TBL_Factura(Id_factura)
  
  Constraint [pk_TBL_CierreCajas] Primary Key
	(
	  Id_CierreCajas ASC
	)
)
go
Create Table [TBL_CuentasCobrar]
(
  Id_CuentaCobrar		 int                         identity(1,1),
  Fecha_Facturacion		 datetime                    not null,
  Fecha_Vencimiento		 datetime                    not null,
  Identificacion_Cliente varchar(10)                 Not null,
  Nombre_Cliente		 varchar(10)                 not null,
  Interes_Mora			 numeric(20,2)               not null,
  Total_Facturado		 numeric(20,2)               not null,
  Id_factura			 int foreign key (Id_factura) references TBL_Factura(Id_factura)
  
  Constraint [pk_TBL_CuentasCobrar] Primary Key
	(
	  Id_CuentaCobrar ASC
	)
)
go
Create Table [TBL_RprtCuentasxCobrar]
(
  Id_RprtCtasxCobrar   int                               identity(1,1),
  Fecha_reporte	       datetime                          not null,
  Total_Ventas_Credito numeric(20,2)                     not null,
  Total_Pagado         numeric(20,2)                     not null,
  Total_Intereses_Mora numeric(20,2)                     not null,
  Total_factura	       numeric(20,2)                     not null,
  Id_CuentaCobrar	   int foreign key (Id_CuentaCobrar) references TBL_CuentasCobrar(Id_CuentaCobrar)
  
  Constraint [pk_TBL_RprtCuentasxCobrar] Primary Key
	(
	  Id_RprtCtasxCobrar ASC
	)
)
go
Create Table TBL_Cuentas_por_pagar
(
  Id_CxP			 int                          identity(1,1),
  Id_Cliente		 int                          not null,
  Id_modulo		     int                          not null,
  Fecha_factura	     datetime                     not null,
  Tipo_devolucion	 varchar(60)                  not null,
  Monto_devolucion   numeric(20,2)                not null,
  Id_factura		 int foreign key (Id_factura) references TBL_Factura(Id_factura)
  
  Constraint [pk_TBL_Cuentas_por_pagar] Primary Key
	(
	  Id_CxP ASC
	)
)
go
Create Table [TBL_RprtCierreCajas]
(
  Id_RprtCierreCajas    int                          identity(1,1),
  Fecha_cierre	        datetime                     not null,
  Total_Ventas_Contado  numeric(20,2)                not null,
  Total_Ventas_Credito  numeric(20,2)                not null,
  Total_Devoluciones    numeric(20,2)                not null,
  Total_Efectivo	    numeric(20,2)                not null,
  Total_Tarjeta	        numeric(20,2)                not null,
  Total_Merma			numeric(20,2)                not Null,
  Total_General		    numeric(20,2)                not Null,
  Id_factura			int foreign key (Id_factura) references TBL_Factura(Id_factura)
  
  Constraint [pk_TBL_RprtCierreCajas] Primary Key
	(
	  Id_RprtCierreCajas ASC
	)
)
go
create table TBL_Merma
(
  Id_Merma  int identity(1,1)           not null,
  Fecha     datetime                    not null,
  Total     decimal(20,2)               not null,
  Id_estado int foreign key (Id_estado) references TBL_Estado(Id_estado)
  
  Constraint [pk_TBL_Merma] Primary Key
	(
	  Id_Merma ASC
	)
)
go
create table TBL_Detalle_Merma
(
  Id_merma_detalle int identity(1,1)             not null,
  Costo_unitario   decimal(20,2)                 not null,
  Cantidad         int                           not null,
  Id_Merma         int foreign key (Id_Merma)    references TBL_Merma(Id_Merma),
  Id_producto      int foreign key (Id_producto) references TBL_Productos(Id_Producto)
  
  Constraint [pk_TBL_Detalle_Merma] Primary Key
	(
	  Id_merma_detalle ASC
	)
)
go
create table TBL_Tipo_Reciclaje
(
  Id_Tipo_Reciclaje int identity(1,1) not null,
  Descripcion_Tipo  varchar(50)       not null
  
  Constraint [pk_TBL_Tipo_Reciclaje] Primary Key
	(
	  Id_Tipo_Reciclaje ASC
	)
)
go
create table TBL_Reciclaje
(
Id_Reciclaje         int identity(1,1)                   not null,
Fecha_reciclado      datetime                            not null,
Descripcion_producto varchar(100)                        not null,
Cantidad_unidades    int                                 not null,
Id_Tipo_Reciclaje    int foreign key (Id_Tipo_Reciclaje) references TBL_Tipo_Reciclaje(Id_Tipo_Reciclaje),
Id_producto          int foreign key (Id_producto)       references TBL_Productos(Id_Producto)
  
  Constraint [pk_TBL_Reciclaje] Primary Key
	(
	  Id_Reciclaje ASC
	)
)
go

-- =============================================================================================================
--										Fin de la Creación de Tablas
-- =============================================================================================================

-- =============================================================================================================
--                                Creación de los Procedimientos Almacenados
-- =============================================================================================================

-- -|---------------------------------------------------------------------------------------------------------|-
--                                 Procedimientos de Listado de Información
-- -|---------------------------------------------------------------------------------------------------------|-
create procedure  sp_Consulta_Factura_Detalle
@id int
as
begin
	Select Id_detalle_factura,Id_factura,Codigo,Descripcion_Producto,Cantidad,Precio_unitario 
	from [dbo].[TBL_Detalle_Factura]
end
go
create procedure  sp_Iniciar_Session
@identificacion varchar(20),
@contraseña varchar(20)
as
begin
	Select Identificacion,Contraseña 
	from [dbo].[TBL_Usuarios] 
	where @identificacion = Identificacion 
	  and @contraseña = Contraseña
end
go
create procedure sp_Tipo_Usuario  @identificacion varchar(20)
as
begin
	Select Id_Rol,Identificacion,Nombre,Apellido1,Apellido2 
	from [dbo].[TBL_Usuarios] 
	where identificacion = @Identificacion
end
go
create procedure sp_Mostrar_Usuarios
as
begin
	Select Id_usuario,Identificacion,Nombre,Apellido1,Apellido2,Correo,Id_estado 
	from [dbo].[TBL_Usuarios] 
end
go
create procedure sp_Mostrar_Clientes
as
begin
	select Tipo_identificacion,Identificacion,
	       Nombre,Apellido1,Apellido2,Fecha_nacimiento,
		   Fecha_creacion,Correo,Telefono 
	from [dbo].[TBL_Clientes]
end
go
create procedure sp_Mostrar_Productos
as
begin
   select Codigo,Nombre_producto,Tipo_envasado,Descripcion_producto,
          Nivel_fragilidad,Cantidad_mililitros,Nivel_Alcohol,Precio_producto,
          Fecha_emision,Fecha_caducidad,Stock_Inicial,Stock_Actual,Fecha_ingreso,Id_estado 
   from [dbo].[TBL_Productos]
end
go
create procedure sp_Mostrar_DescuentosVIP
as
begin
  select Id_DescVIP,Fecha_creacion,Fecha_modificacion,Descuento,Puntos,Estado 
  from [dbo].[TBL_DescuentosVIP]
end

go
create procedure sp_Modificar_Descuentos_Estandar
												@Id_DescEstandar int,
												@Fecha_modificacion datetime,
												@Cantidad_Minima int,
												@Cantidad_Maxima int,
												@Descuento int,
												@Dia varchar(50),
												@Estado int
as
begin
  UPDATE [dbo].[TBL_DescuentosEstandar] 
     set  Fecha_modificacion = @Fecha_modificacion,
	      Cantidad_Minima    = @Cantidad_Minima,
		  Cantidad_Maxima    = @Cantidad_Maxima,
	      Descuento          = @Descuento,
		  Dia                = @Dia,
		  Estado             = @Estado 
  where @Id_DescEstandar = @Id_DescEstandar
end


go
create procedure sp_Mostrar_Descuentos_Estandar
as
begin
  select Id_DescEstandar,Fecha_creacion,Fecha_modificacion,Cantidad_Minima,Cantidad_Maxima,Descuento,Dia,Estado 
  from [dbo].[TBL_DescuentosEstandar]
end

go
Create Procedure SP_Listar_Direcciones
As
Begin

Select	Id_direccion, Dsc_direccion, Id_provincia, Id_canton, Id_distrito, Id_cliente
From	[dbo].[TBL_Direcciones_cliente] 
	
End
go
create procedure sp_Mostrar_Ordenes_Fabricacion
as
begin
  select  Id_Orden,Id_factura,FechaEmision,FechaFabricacion,Id_estado
  from [dbo].[TBL_Orden_Fabricacion]
end
go
Create Procedure Sp_Listar_CierreCajas
	As
	Begin

	Select	Id_CierreCajas, Id_factura, Fecha_Cierre, Tipo_Factura, Forma_Pago, Entradas, Salidas	
	From	[dbo].[TBL_CierreCajas] where convert(char(08),fecha_cierre,112) = convert(char(08),getdate(),112) 
	
	End
Go
Create Procedure Sp_Listar_CuentasCobrar
	As
	Begin

	Select	Id_CuentaCobrar, Fecha_Facturacion, Fecha_Vencimiento, Identificacion_Cliente, Nombre_Cliente, Interes_Mora, Total_Facturado
	From	[dbo].[TBL_CuentasCobrar] 
	
	End
	
Go
Create Procedure Sp_Listar_CuentasPagar
	As
	Begin

	Select	Id_CxP, Id_Cliente, Id_modulo, Fecha_factura, Tipo_devolucion, Monto_devolucion
	From [dbo].[TBL_Cuentas_por_pagar] 
	
	End
Go
Create Procedure Sp_Listar_ReporteCierreCajas
As
Begin

Select	Id_RprtCierreCajas, Fecha_cierre, Total_Ventas_Contado, Total_Ventas_Credito, Total_Devoluciones, Total_Efectivo, Total_Tarjeta, Total_Merma, Total_General
From [dbo].[tbl_RprtCierreCajas] 
	
End
Go
Create Procedure Sp_Listar_ReporteCuentasXCobrar
As
Begin

Select	Id_CuentaCobrar, Fecha_Facturacion, Fecha_Vencimiento, Identificacion_Cliente, Nombre_Cliente, Interes_Mora, Total_Facturado
From [dbo].[TBL_CuentasCobrar] 
	
End
Go
create procedure SP_Mostrar_Detalle_Ordenes_Fabricacion
as
begin
  select  Id_Detalle,Desc_Producto,Cantidad,Id_Orden,Id_producto
  from [dbo].[TBL_Detalle_Orden_Fabricacion]
end
go
-- -|---------------------------------------------------------------------------------------------------------|-
--                                 Procedimientos de Filtrado de Información
-- -|---------------------------------------------------------------------------------------------------------|-
Create Procedure Sp_Filtrar_CierreCajas 
@Id_CierreCajas int
As
Begin

Select	Id_factura, Fecha_Cierre, Tipo_Factura, Forma_Pago, Entradas, Salidas	
From [dbo].[TBL_CierreCajas] 
Where Id_factura = @Id_CierreCajas
	
End
Go
Create Procedure Sp_Filtrar_CuentasCobrar
@Id_CuentasCobrar int
As
Begin

Select Id_CuentaCobrar, Fecha_Facturacion, Fecha_Vencimiento, Identificacion_Cliente, Nombre_Cliente, Interes_Mora, Total_Facturado
From [dbo].[TBL_CuentasCobrar] 
Where Id_factura = @Id_CuentasCobrar
	
End
Go
Create Procedure Sp_Filtrar_Pagar
@Id_CuentasPagar int
As
Begin

Select	Id_CxP, Id_Cliente, Id_modulo, Fecha_factura, Tipo_devolucion, Monto_devolucion
From [dbo].[TBL_Cuentas_por_pagar] 
Where Id_factura = @Id_CuentasPagar
	
End
Go
-- -|---------------------------------------------------------------------------------------------------------|-
--                                 Procedimientos de Inserción de Información
-- -|---------------------------------------------------------------------------------------------------------|-
create procedure sp_Insertar_Usuarios 
									@Identificacion varchar(20),
									@Nombre varchar(50),
									@Apellido1 varchar(50),
									@Apellido2 varchar(50),
									@Correo varchar(50),
									@Fecha_creacion datetime,
									@Id_estado int 
as
begin
	insert into  [dbo].[TBL_Usuarios]
	(Identificacion,Nombre,Apellido1,Apellido2,Fecha_creacion,Correo,Id_estado) 
	values
	(@Identificacion,@Nombre ,@Apellido1 ,@Apellido2 ,@Fecha_creacion,@Correo ,@Id_estado)
end
go
create procedure sp_Insertar_Clientes
										@TipoId varchar(20),
										@Identificacion varchar(20),
										@Nombre varchar(45),
										@Apellido1 varchar(45),
										@Apellido2 varchar(45),
										@Fecha_nacimiento datetime,
										@Fecha_creacion datetime,
										@Correo varchar(45),
										@Telefono int
as
begin
	insert into [dbo].[TBL_Clientes]  
	(Tipo_identificacion,Identificacion,Nombre,Apellido1,Apellido2,Fecha_nacimiento,Fecha_creacion,Correo,Telefono) 
	values
	(@TipoId,@Identificacion,@Nombre,@Apellido1,@Apellido2,@Fecha_nacimiento,@Fecha_creacion,@Correo,@Telefono)
end

go
create procedure sp_Insertar_Productos
										@Codigo varchar(50),
										@Nombre_producto varchar(100),
										@Tipo_envasado varchar(50),
										@Nivel_fragilidad varchar(20),
										@Cantidad_mililitros int,
										@Nivel_Alcohol int,
										@Precio_producto decimal(20,2),
										@Fecha_emision datetime,
										@Fecha_caducidad datetime,
										@Stock_Inicial int,
										@Stock_Actual int,
										@Fecha_ingreso datetime,
										@Id_estado int,
										@Descripcion_producto varchar(100)
as
begin
  insert into [dbo].[TBL_Productos] 
	 (Codigo,Nombre_producto,Tipo_envasado,Descripcion_producto,Nivel_fragilidad,
	  Cantidad_mililitros,Nivel_Alcohol,Precio_producto,Fecha_emision,Fecha_caducidad,
	  Stock_Inicial,Stock_Actual,Fecha_ingreso,Id_estado) 
  values
	 (@Codigo,@Nombre_producto,@Tipo_envasado,@Descripcion_producto,@Nivel_fragilidad,
	  @Cantidad_mililitros,@Nivel_Alcohol,@Precio_producto,@Fecha_emision,@Fecha_caducidad,
	  @Stock_Inicial,@Stock_Actual,@Fecha_ingreso,@Id_estado)
end

go
create procedure sp_Insertar_DescuentosVIP
											@Fecha_creacion datetime,
											@Descuento int,
											@Puntos int,
											@Estado int
as
begin
  insert into [dbo].[TBL_DescuentosVIP] 
   (Fecha_creacion,Descuento,Puntos,Estado) 
  values 
   (@Fecha_creacion,@Descuento,@Puntos,@Estado) 
end

go
create procedure sp_Insertar_Descuentos_Estandar
												@Fecha_creacion datetime,
												@Cantidad_Minima int,
												@Cantidad_Maxima int,
												@Descuento int,
												@Dia varchar(50),
												@Estado int
as
begin
   insert into [dbo].[TBL_DescuentosEstandar] 
     (Fecha_creacion,Cantidad_Minima,Cantidad_Maxima,Descuento,Dia,Estado) 
   values (@Fecha_creacion,@Cantidad_Minima,@Cantidad_Maxima,@Descuento,@Dia,@Estado) 
end

go
create procedure sp_Insertar_Orden_Fabricacion
												
												@Id_Factura int,
												@Fecha_Emision datetime,
												@Fecha_Fabricacion datetime,
												@Estado int
as
begin
   insert into [dbo].[TBL_Orden_Fabricacion] 
     (Id_factura,FechaEmision,FechaFabricacion,Id_estado) 
   values (@Id_Factura,@Fecha_Emision,@Fecha_Fabricacion,@Estado) 
end

go
Create procedure Sp_Insertar_CierreFacturas 
                                @Id_factura   integer,
                                @Fecha_venta  datetime,
                                @Tipo_factura varchar(10),
                                @Tipo_pago    varchar(10),
                                @Total        numeric(20,2)
as
Begin

  Set nocount on
  If @tipo_factura in ('Contado','Credito')
     Begin
       If not exists(Select top 1 'x'
                     from Tbl_Devoluciones
		  		     Where Id_factura = @Id_factura)
		 Begin
           Insert into TBL_CierreCajas
             (Id_factura, 
		      Fecha_cierre,
		      Tipo_factura,
              Forma_pago, 
		      Entradas,
			  Salidas)
           values
             (@id_factura, 
		      @fecha_venta, 
		      @tipo_factura,
              @tipo_pago, 
			  @total,
			  0.0)
	     End
	End
End
go

Create procedure Sp_Insertar_CierreDevoluciones
                                    @Id_factura   integer,
 		                            @Descripcion  varchar(100),
                                    @Fecha_venta  datetime,
                                    @Tipo_pago    varchar(10),
                                    @Total        numeric(20,2)
as
Begin
  Set nocount on

  Insert into TBL_CierreCajas
   (Id_factura, 
	Fecha_cierre,
	Tipo_factura,
    Forma_pago,
	Entradas,
	Salidas)
  Values
   (@id_factura, 
	@fecha_venta, 
	'Devolución',
    @tipo_pago,
	0.00,
	@total)
End
go
Create procedure Sp_Insertar_CierreMerma
							 @Consecutivo_factura int,
                             @Fecha datetime,
                             @Total numeric(20,2)
as
Begin
  Set nocount on
  Insert into TBL_CierreCajas
      (Id_factura, 
	   Fecha_cierre,
	   Tipo_factura,
       Forma_pago,
	   Entradas,
	   Salidas)
    Values
      (@Consecutivo_factura, 
	   @fecha, 
	   'Merma',
       'Efectivo',
	    0.00,
	   @total)
End

go
Create procedure Sp_Insertar_CierreReciclaje
                                 @Fecha datetime,
                                 @Total numeric(20,2)
as
Begin
  Set nocount on
  Declare @Consecutivo_factura int

  Select top 1 @Consecutivo_factura = Id_factura
  from TBL_CierreCajas
  order by id_factura desc
  
  Insert into TBL_CierreCajas
      (Id_factura, 
	   Fecha_cierre,
	   Tipo_factura,
       Forma_pago,
	   Entradas,
	   Salidas)
  Values
      (@Consecutivo_factura,
	   @fecha,
	   'Reciclaje',
       'Efectivo',
	   0.00,
	   @total)
End
go
Create procedure Sp_Insertar_CuentaCobrar
As
Begin
Insert Into TBL_CuentasCobrar 
  	(Id_factura,
	Fecha_Facturacion,
	Fecha_Vencimiento,
	Identificacion_Cliente,
	Nombre_Cliente,
	Interes_Mora,
	Total_Facturado) 
Select Id_factura, 
	    Fecha_venta,
		dateadd(day,30,fecha_venta),
		t2.Identificacion,
		Substring((ltrim(rtrim(Apellido1))+' '+
		            ltrim(rtrim(Apellido2))+' '+
					ltrim(rtrim(Nombre))),1,45),
		(Total * (datediff(day,dateadd(day,30,fecha_venta),Getdate()) * 0.03)),
		Total
From TBL_Factura as t1
Inner join TBL_Clientes as t2
on t2.Id_cliente = t1.Id_cliente
Where Tipo_factura = 'Credito'
	and convert(char(08),Fecha_venta,112) = convert(char(08),Getdate(),112)
End
go
Create Procedure Sp_Insertar_CuentasPagar
                                       @Id_CxP int,
									   @Id_Cliente int,
									   @Fecha_factura datetime,
									   @Tipo_devolucion varchar(60),
									   @Monto_devolucion numeric(20,2),
									   @Id_factura int
As
Begin
	Insert Into  dbo.TBL_Cuentas_por_pagar 
	(Id_CxP, Id_Cliente,Fecha_factura,
	Tipo_devolucion,Monto_devolucion,Id_factura)
	values
	(@Id_CxP, @Id_Cliente, @Fecha_factura,
	 @Tipo_devolucion, @Monto_devolucion,@Id_factura)

End

go
Create Procedure Sp_Insertar_ReporteCuentasCobrar -- Reparar --

@Fecha_reporte			datetime,
@Total_Ventas_Credito	numeric(20,2), 
@Total_Pagado			numeric(20,2), 
@Total_Intereses_Mora	numeric(20,2), 
@Total_factura			numeric(20,2), 
@Id_CuentaCobrar		int

As
Begin
Insert Into  [dbo].[TBL_RprtCuentasxCobrar] 
(Fecha_reporte, Total_Ventas_Credito, Total_Pagado, Total_Intereses_Mora, Total_factura, Id_CuentaCobrar) 
values
(@Fecha_reporte, @Total_Ventas_Credito, @Total_Pagado, @Total_Intereses_Mora, @Total_factura, @Id_CuentaCobrar)
End
go
Create Procedure Sp_Insertar_ReporteCierreCajas

@Fecha_cierre			datetime,
@Total_Ventas_Contado	numeric(20,2), 
@Total_Ventas_Credito	numeric(20,2), 
@Total_Devoluciones		numeric(20,2), 
@Total_Efectivo			numeric(20,2), 
@Total_Tarjeta			numeric(20,2), 
@Total_Merma			numeric(20,2), 
@Total_General			numeric(20,2), 
@Id_factura				int

As
Begin
Insert Into  [dbo].[TBL_RprtCierreCajas] 
(Fecha_cierre, Total_Ventas_Contado, Total_Ventas_Credito, Total_Devoluciones, Total_Efectivo, Total_Tarjeta, Total_Merma, Total_General, Id_factura) 
values
(@Fecha_cierre,@Total_Ventas_Contado,@Total_Ventas_Credito,@Total_Devoluciones,@Total_Efectivo,@Total_Tarjeta,@Total_Merma,@Total_General,@Id_factura)
End
go
create procedure SP_Insertar_Detalle_Orden_Fabricacion
												
		@Desc_Producto VARCHAR(30),
		@Cantidad int, 
		@Id_Orden int,
		@Id_Producto int
as
begin
   insert into [dbo].[TBL_Detalle_Orden_Fabricacion] 
     (Desc_Producto,Cantidad,Id_Orden,Id_producto) 
   values (@Desc_Producto,@Cantidad,@Id_Orden,@Id_Producto) 
end
go
-- -|---------------------------------------------------------------------------------------------------------|-
--                                 Procedimientos de Modificación de Información
-- -|---------------------------------------------------------------------------------------------------------|-
create procedure sp_Modificar_Usuarios
										@Identificacion varchar(20),
										@Nombre varchar(50),
										@Apellido1 varchar(50),
										@Apellido2 varchar(50),
										@Correo varchar(50),
										@Fecha_modificacion datetime
as
begin
	UPDATE [dbo].[TBL_Usuarios] 
	   set Identificacion = @Identificacion,
		   Nombre = @Nombre,
		   Apellido1 = @Apellido1,
		   Apellido2 = @Apellido2,
		   Fecha_modificacion = @Fecha_modificacion,
		   Correo = @Correo
	   where Identificacion = @Identificacion
end
go
Create procedure sp_Modificar_Clientes
										@TipoId varchar(20),
										@Identificacion varchar(20),
										@Nombre varchar(45),
										@Apellido1 varchar(45),
										@Apellido2 varchar(45),
										@Fecha_nacimiento datetime,
										@Fecha_modificacion datetime,
										@Correo varchar(45),
										@Telefono int
as
begin
	UPDATE [dbo].[TBL_Clientes] 
	   SET Tipo_identificacion = @TipoId, 
	       Identificacion      = @Identificacion, 
		   Nombre              = @Nombre, 
		   Apellido1           = @Apellido1,
		   Apellido2           = @Apellido2, 
		   Fecha_nacimiento    = @Fecha_nacimiento,
		   Fecha_modificacion  = @Fecha_modificacion, 
		   Correo              = @Correo, 
		   Telefono            = @Telefono 
    where Identificacion = @Identificacion
end

go
create procedure sp_Modificar_Productos
										@Codigo varchar(50),
										@Nombre_producto varchar(100),
										@Tipo_envasado varchar(50),
										@Nivel_fragilidad varchar(20),
										@Cantidad_mililitros int,
										@Nivel_Alcohol int,
										@Precio_producto decimal(20,2),
										@Fecha_emision datetime,
										@Fecha_caducidad datetime,
										@Stock_Inicial int,
										@Stock_Actual int,
										@Descripcion_producto varchar(100),
										@Fecha_Modificacion datetime
as
begin
   UPDATE [dbo].[TBL_Productos] 
     SET Codigo = @Codigo,
	     Nombre_producto      = @Nombre_producto,
	     Tipo_envasado        = @Tipo_envasado,
	     Nivel_fragilidad     = @Nivel_fragilidad,
	     Cantidad_mililitros  = @Cantidad_mililitros,
	     Nivel_Alcohol        = @Nivel_Alcohol,
	     Precio_producto      = @Precio_producto,
	     Fecha_emision        = @Fecha_emision,
	     Fecha_caducidad      = @Fecha_caducidad,
	     Stock_Inicial        = @Stock_Inicial,
	     Stock_Actual         = @Stock_Actual,
	     Descripcion_producto = @Descripcion_producto,
	     Fecha_Modificacion   = @Fecha_Modificacion
   where Codigo = @Codigo
end

go
create procedure sp_Modificar_DescuentosVIP
											@Id_DescVIP int,
											@Fecha_modificacion datetime,
											@Descuento int,
											@Puntos int,
											@Estado int
as
begin
  UPDATE [dbo].[TBL_DescuentosVIP] 
     set Fecha_modificacion = @Fecha_modificacion,
	     Descuento = @Descuento,
	     Puntos =@Puntos,
	     Estado = @Estado 
  where Id_DescVIP = @Id_DescVIP
end

go
create procedure SP_Modificar_Detalle_Factura

@ID_Factura int

as
begin
	UPDATE [dbo].[TBL_Detalle_Factura] 

	   set Id_factura = @ID_Factura

	   where Id_estado = 1 AND Id_factura Is Null;
end
go
create procedure sp_Modificar_Ordenes_Fabricacion
												@Id_Orden int,
												@Id_Factura int,
												@Fecha_Emision datetime,
												@Fecha_Fabricacion datetime,
												@Estado int
as
begin
  UPDATE [dbo].[TBL_Orden_Fabricacion] 
     set  
	      Id_factura = @Id_Factura,
	      FechaFabricacion = @Fecha_Fabricacion,
		  FechaEmision = @Fecha_Emision,
		  Id_estado = @Estado

  where @Id_Orden = @Id_Orden
end
go
create procedure SP_Modificar_Detalle_Orden_Fabricacion
		@Id_Detalle int,
		@Desc_Producto VARCHAR(30),
		@Cantidad int,
		@IdOrden int,
		@Id_Producto int
as
begin
	UPDATE [dbo].[TBL_Detalle_Orden_Fabricacion] 

	   set  Desc_Producto = @Desc_Producto,
			Cantidad = @Cantidad,
			Id_Orden = @IdOrden,
			Id_producto = @Id_Producto
 
	   where @Id_Detalle = @Id_Detalle;
end
go

-- =============================================================================================================
--                                 Fin de los Procedimientos Almacenados
-- =============================================================================================================

-- =============================================================================================================
--                                  Inserts de Datos para Prueba y Funcionalidad
-- =============================================================================================================


	--|--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**
	-- || Inserción datos tabla tbl_BEERLAB                           ||
	--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**

	Insert into TBL_BeerLab(cedula_juridica,nombre,telefono,direccion_fisica,correo_electronico) values ('3500042147','BEER LAB',8581-3589,'Avenida 4, Roosevelt, San Pedro San José','Ventas@beerlab.com')

	--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**
	-- || Inserción datos tabla tbl_estados                           ||
	--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**

	insert into TBL_Estado (Nombre_Estado) values ('Activo');
	insert into TBL_Estado (Nombre_Estado) values ('Inactivo');
	insert into TBL_Estado (Nombre_Estado) values ('Anulado');
	insert into TBL_Estado (Nombre_Estado) values ('Disponible');
	insert into TBL_Estado (Nombre_Estado) values ('Agotado');
	insert into TBL_Estado (Nombre_Estado) values ('Aprobado Inventarios');
	insert into TBL_Estado (Nombre_Estado) values ('Aprobado Admin');
	insert into TBL_Estado (Nombre_Estado) values ('Denegado');

	--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**
	-- || Inserción datos tabla tbl_Roles                             ||
	--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**

	insert into [dbo].[TBL_Roles] (Nombre_Rol) values ('Administrador');
	insert into [dbo].[TBL_Roles] (Nombre_Rol) values ('Contabilidad');
	insert into [dbo].[TBL_Roles] (Nombre_Rol) values ('Inventario');
	insert into [dbo].[TBL_Roles] (Nombre_Rol) values ('Vendedor');
	insert into [dbo].[TBL_Roles] (Nombre_Rol) values ('Sin Privilegios');

	--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**
	-- || Inserción datos tabla tbl_Modulos                           ||
	--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**

	insert into [dbo].[TBL_Modulos] (Nombre_Modulo) values('Mantenimientos');
	insert into [dbo].[TBL_Modulos] (Nombre_Modulo) values('Seguridad');
	insert into [dbo].[TBL_Modulos] (Nombre_Modulo) values('Contabilidad');
	insert into [dbo].[TBL_Modulos] (Nombre_Modulo) values('Inventario');
	insert into [dbo].[TBL_Modulos] (Nombre_Modulo) values('Ventas');


	--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**
	-- || Inserción datos tabla tbl_Operaciones                       ||
	--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**

	insert into [dbo].[TBL_Operaciones] (Id_Modulo,Nombre_Operacion) values(1,'Agregar');
	insert into [dbo].[TBL_Operaciones] (Id_Modulo,Nombre_Operacion) values(1,'Editar');
	insert into [dbo].[TBL_Operaciones] (Id_Modulo,Nombre_Operacion) values(1,'Eliminar');
	insert into [dbo].[TBL_Operaciones] (Id_Modulo,Nombre_Operacion) values(1,'Mostrar');
	insert into [dbo].[TBL_Operaciones] (Id_Modulo,Nombre_Operacion) values(2,'Agregar');
	insert into [dbo].[TBL_Operaciones] (Id_Modulo,Nombre_Operacion) values(2,'Editar');
	insert into [dbo].[TBL_Operaciones] (Id_Modulo,Nombre_Operacion) values(2,'Mostrar');
	insert into [dbo].[TBL_Operaciones] (Id_Modulo,Nombre_Operacion) values(3,'Agregar');
	insert into [dbo].[TBL_Operaciones] (Id_Modulo,Nombre_Operacion) values(3,'Editar');
	insert into [dbo].[TBL_Operaciones] (Id_Modulo,Nombre_Operacion) values(3,'Mostrar');
	insert into [dbo].[TBL_Operaciones] (Id_Modulo,Nombre_Operacion) values(4,'Agregar');
	insert into [dbo].[TBL_Operaciones] (Id_Modulo,Nombre_Operacion) values(4,'Editar');
	insert into [dbo].[TBL_Operaciones] (Id_Modulo,Nombre_Operacion) values(4,'Mostrar');

	--Select * from tbl_operaciones

	--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**
	-- || Inserción datos tabla tbl_Usuarios                          ||
	--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**

	insert into TBL_Usuarios (Id_Rol,Identificacion,Nombre,Apellido1,Apellido2,Correo,Contraseña,Fecha_creacion,Id_estado)
	values (1,402080365,'Carmen','Gonzéales','Araya','cgaraya@gmail.com','Administrador',GETDATE(),'1');
	insert into TBL_Usuarios (Id_Rol,Identificacion,Nombre,Apellido1,Apellido2,Correo,Contraseña,Fecha_creacion,Id_estado) 
	values (2,302560985,'Marcos','Mora','Solís','mcsolís@gmail.com','Vendedor',GETDATE(),'1');
	insert into TBL_Usuarios (Id_Rol,Identificacion,Nombre,Apellido1,Apellido2,Correo,Contraseña,Fecha_creacion,Id_estado) 
	values (4,302560985,'Andrés','Carmona','Gutierrez','acgutu@gmail.com','Inventario',GETDATE(),'1');


	--select * from tbl_usuarios


	--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**
	-- || Inserción datos tabla tbl_Modulos                           ||
	--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**

	insert into [dbo].[TBL_Modulos] (Nombre_Modulo) values('Mantenimientos');
	insert into [dbo].[TBL_Modulos] (Nombre_Modulo) values('Seguridad');
	insert into [dbo].[TBL_Modulos] (Nombre_Modulo) values('Contabilidad');
	insert into [dbo].[TBL_Modulos] (Nombre_Modulo) values('Inventario');
	insert into [dbo].[TBL_Modulos] (Nombre_Modulo) values('Ventas');

	--Select * from tbl_modulos

	--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**
	-- || Inserción datos tabla TBL_Perfil_Operación                  ||
	--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**

	insert into [dbo].[TBL_Perfil_Operacion] (Id_Rol,Id_Operacion) values(1,1);
	insert into [dbo].[TBL_Perfil_Operacion] (Id_Rol,Id_Operacion) values(1,2);
	insert into [dbo].[TBL_Perfil_Operacion] (Id_Rol,Id_Operacion) values(1,3);
	insert into [dbo].[TBL_Perfil_Operacion] (Id_Rol,Id_Operacion) values(1,4);
	insert into [dbo].[TBL_Perfil_Operacion] (Id_Rol,Id_Operacion) values(2,5);
	insert into [dbo].[TBL_Perfil_Operacion] (Id_Rol,Id_Operacion) values(2,6);
	insert into [dbo].[TBL_Perfil_Operacion] (Id_Rol,Id_Operacion) values(2,7);
	insert into [dbo].[TBL_Perfil_Operacion] (Id_Rol,Id_Operacion) values(3,8);
	insert into [dbo].[TBL_Perfil_Operacion] (Id_Rol,Id_Operacion) values(3,9);
	insert into [dbo].[TBL_Perfil_Operacion] (Id_Rol,Id_Operacion) values(3,10);
	insert into [dbo].[TBL_Perfil_Operacion] (Id_Rol,Id_Operacion) values(4,11);
	insert into [dbo].[TBL_Perfil_Operacion] (Id_Rol,Id_Operacion) values(4,12);
	insert into [dbo].[TBL_Perfil_Operacion] (Id_Rol,Id_Operacion) values(4,13);

	--Select * from TBL_Perfil_Operacion

	--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**
	-- || Inserción datos tabla tbl_clientes                          ||
	--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**

	insert into TBL_Clientes values ('Cédula',402080365,'Armando','Puertas','Robles','VIP',GETDATE(),GETDATE(),GETDATE(),'80455263','puertaroblearmado@gmail.com',100,1);
	insert into TBL_Clientes values ('DIMEX',402450365,'Arnoldo','Amador','Robles','VIP',GETDATE(),GETDATE(),GETDATE(),'88040066','puertaroblearmado@gmail.com',100,1);
	insert into TBL_Clientes values ('Cédula',402770365,'Alba','Solano','Víquez','Estandar',GETDATE(),GETDATE(),GETDATE(),'88500664','puertaroblearmado@gmail.com',100,1);
	insert into TBL_Clientes values ('Cédula',402080089,'Carla','Ulate','Caballero','VIP',GETDATE(),GETDATE(),GETDATE(),'83255878','puertaroblearmado@gmail.com',100,1);
	insert into TBL_Clientes values ('Cédula',302000465,'Julio','Madriz','Marín','Estandar',GETDATE(),GETDATE(),GETDATE(),'84505662','puertaroblearmado@gmail.com',100,1);
	insert into TBL_Clientes values ('Cédula',403180365,'Juan','Badilla','Dumaní','Estandar',GETDATE(),GETDATE(),GETDATE(),'84505662','puertaroblearmado@gmail.com',100,1);
	insert into TBL_Clientes values ('Pasaporte',208480365,'Mario','Araya','Mora','Estandar',GETDATE(),GETDATE(),GETDATE(),'84505662','puertaroblearmado@gmail.com',100,1);

	--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**
	-- || Inserción datos tabla tbl_descuentosvip                     ||
	--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**

	insert into [dbo].[TBL_DescuentosVIP] (Fecha_Creacion,Descuento,Puntos,Estado) values(GETDATE(),1000,1,1);


	--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**
	-- || Inserción datos tabla tbl_descuentosestandar                ||
	--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**

	insert into [dbo].[TBL_DescuentosEstandar] (Fecha_Creacion,Fecha_modificacion,Cantidad_Minima,Cantidad_Maxima,Descuento,Dia,Estado) values (GETDATE(),'',1,5,1000,'Lunes',1);
	insert into [dbo].[TBL_DescuentosEstandar] (Fecha_Creacion,Fecha_modificacion,Cantidad_Minima,Cantidad_Maxima,Descuento,Dia,Estado) values (GETDATE(),'',6,10,1000,'Lunes',1);
	insert into [dbo].[TBL_DescuentosEstandar] (Fecha_Creacion,Fecha_modificacion,Cantidad_Minima,Cantidad_Maxima,Descuento,Dia,Estado) values (GETDATE(),'',1,5,1000,'Miércoles',1);
	insert into [dbo].[TBL_DescuentosEstandar] (Fecha_Creacion,Fecha_modificacion,Cantidad_Minima,Cantidad_Maxima,Descuento,Dia,Estado) values (GETDATE(),'',6,10,1000,'Miércoles',1);
	insert into [dbo].[TBL_DescuentosEstandar] (Fecha_Creacion,Fecha_modificacion,Cantidad_Minima,Cantidad_Maxima,Descuento,Dia,Estado) values (GETDATE(),'',1,5,1000,'Viernes',1);
	insert into [dbo].[TBL_DescuentosEstandar] (Fecha_Creacion,Fecha_modificacion,Cantidad_Minima,Cantidad_Maxima,Descuento,Dia,Estado) values (GETDATE(),'',6,10,1000,'Viernes',1);
	insert into [dbo].[TBL_DescuentosEstandar] (Fecha_Creacion,Fecha_modificacion,Cantidad_Minima,Cantidad_Maxima,Descuento,Dia,Estado) values (GETDATE(),'',1,5,1000,'Domingo',1);
	insert into [dbo].[TBL_DescuentosEstandar] (Fecha_Creacion,Fecha_modificacion,Cantidad_Minima,Cantidad_Maxima,Descuento,Dia,Estado) values (GETDATE(),'',6,10,1000,'Domingo',1);
	insert into [dbo].[TBL_DescuentosEstandar] (Fecha_Creacion,Fecha_modificacion,Cantidad_Minima,Cantidad_Maxima,Descuento,Dia,Estado) values (GETDATE(),'',1,5,1000,'Martes',1);
	insert into [dbo].[TBL_DescuentosEstandar] (Fecha_Creacion,Fecha_modificacion,Cantidad_Minima,Cantidad_Maxima,Descuento,Dia,Estado) values (GETDATE(),'',6,10,1000,'Martes',1);
	insert into [dbo].[TBL_DescuentosEstandar] (Fecha_Creacion,Fecha_modificacion,Cantidad_Minima,Cantidad_Maxima,Descuento,Dia,Estado) values (GETDATE(),'',1,5,1000,'Jueves',1);
	insert into [dbo].[TBL_DescuentosEstandar] (Fecha_Creacion,Fecha_modificacion,Cantidad_Minima,Cantidad_Maxima,Descuento,Dia,Estado) values (GETDATE(),'',6,10,1000,'Jueves',1);
	insert into [dbo].[TBL_DescuentosEstandar] (Fecha_Creacion,Fecha_modificacion,Cantidad_Minima,Cantidad_Maxima,Descuento,Dia,Estado) values (GETDATE(),'',1,5,1000,'Sábados',1);
	insert into [dbo].[TBL_DescuentosEstandar] (Fecha_Creacion,Fecha_modificacion,Cantidad_Minima,Cantidad_Maxima,Descuento,Dia,Estado) values (GETDATE(),'',6,10,1000,'Sábados',1);

	--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**
	-- || Inserción datos tabla tbl_Productos                         ||
	--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**

	insert into [dbo].[TBL_Productos] (Codigo,Nombre_producto,Descripcion_producto,Precio_producto,Tipo_envasado,
	Nivel_fragilidad,Cantidad_mililitros,Nivel_Alcohol,Fecha_emision,Fecha_caducidad,Fecha_ingreso,Stock_Inicial,Stock_Actual,Punto_Reorden,Id_estado)
	values ('CB0001','Slothie','Birra',2200,'Botella de vidrio','Muy frágil',355,10,GETDATE(),GETDATE(),GETDATE(),300,300,150,1);

	insert into [dbo].[TBL_Productos] (Codigo,Nombre_producto,Descripcion_producto,Precio_producto,Tipo_envasado,
	Nivel_fragilidad,Cantidad_mililitros,Nivel_Alcohol,Fecha_emision,Fecha_caducidad,Fecha_ingreso,Stock_Inicial,Stock_Actual,Punto_Reorden,Id_estado)
	values ('CL0002','Slothie','Birra',2000,'Lata de aluminio','Frágil',355,10,GETDATE(),GETDATE(),GETDATE(),300,300,150,1);

	insert into [dbo].[TBL_Productos] (Codigo,Nombre_producto,Descripcion_producto,Precio_producto,Tipo_envasado,
	Nivel_fragilidad,Cantidad_mililitros,Nivel_Alcohol,Fecha_emision,Fecha_caducidad,Fecha_ingreso,Stock_Inicial,Stock_Actual,Punto_Reorden,Id_estado)
	values ('CB0003','Monkie Moon','Birra',1900,'Botella de vidrio','Muy frágil',355,10,GETDATE(),GETDATE(),GETDATE(),300,300,150,1);

	insert into [dbo].[TBL_Productos] (Codigo,Nombre_producto,Descripcion_producto,Precio_producto,Tipo_envasado,
	Nivel_fragilidad,Cantidad_mililitros,Nivel_Alcohol,Fecha_emision,Fecha_caducidad,Fecha_ingreso,Stock_Inicial,Stock_Actual,Punto_Reorden,Id_estado)
	values ('CL0004','Monkie Moon','Birra',1700,'Lata de aluminio','Frágil',355,10,GETDATE(),GETDATE(),GETDATE(),300,300,150,1);

	insert into [dbo].[TBL_Productos] (Codigo,Nombre_producto,Descripcion_producto,Precio_producto,Tipo_envasado,
	Nivel_fragilidad,Cantidad_mililitros,Nivel_Alcohol,Fecha_emision,Fecha_caducidad,Fecha_ingreso,Stock_Inicial,Stock_Actual,Punto_Reorden,Id_estado)
	values ('CB0005','Lapa Love','Birra',2700,'Botella de vidrio','Muy frágil',355,10,GETDATE(),GETDATE(),GETDATE(),300,300,150,1);

	insert into [dbo].[TBL_Productos] (Codigo,Nombre_producto,Descripcion_producto,Precio_producto,Tipo_envasado,
	Nivel_fragilidad,Cantidad_mililitros,Nivel_Alcohol,Fecha_emision,Fecha_caducidad,Fecha_ingreso,Stock_Inicial,Stock_Actual,Punto_Reorden,Id_estado)
	values ('CL0006','Lapa Love','Birra',2500,'Lata de aluminio','Frágil',355,10,GETDATE(),GETDATE(),GETDATE(),300,300,150,1);

	insert into [dbo].[TBL_Productos] (Codigo,Nombre_producto,Descripcion_producto,Precio_producto,Tipo_envasado,
	Nivel_fragilidad,Cantidad_mililitros,Nivel_Alcohol,Fecha_emision,Fecha_caducidad,Fecha_ingreso,Stock_Inicial,Stock_Actual,Punto_Reorden,Id_estado)
	values ('CB0006','Dhir Orosi','Birra',2400,'Botella de vidrio','Muy frágil',355,10,GETDATE(),GETDATE(),GETDATE(),300,300,150,1);

	insert into [dbo].[TBL_Productos] (Codigo,Nombre_producto,Descripcion_producto,Precio_producto,Tipo_envasado,
	Nivel_fragilidad,Cantidad_mililitros,Nivel_Alcohol,Fecha_emision,Fecha_caducidad,Fecha_ingreso,Stock_Inicial,Stock_Actual,Punto_Reorden,Id_estado)
	values ('CL0007','Dhir Orosi','Birra',2200,'Lata de aluminio','Frágil',355,10,GETDATE(),GETDATE(),GETDATE(),300,300,150,1);

	insert into [dbo].[TBL_Productos] (Codigo,Nombre_producto,Descripcion_producto,Precio_producto,Tipo_envasado,
	Nivel_fragilidad,Cantidad_mililitros,Nivel_Alcohol,Fecha_emision,Fecha_caducidad,Fecha_ingreso,Stock_Inicial,Stock_Actual,Punto_Reorden,Id_estado)
	values ('CB0008','Magnus Moin','Birra',3100,'Botella de vidrio','Muy frágil',355,10,GETDATE(),GETDATE(),GETDATE(),300,300,150,1);

	insert into [dbo].[TBL_Productos] (Codigo,Nombre_producto,Descripcion_producto,Precio_producto,Tipo_envasado,
	Nivel_fragilidad,Cantidad_mililitros,Nivel_Alcohol,Fecha_emision,Fecha_caducidad,Fecha_ingreso,Stock_Inicial,Stock_Actual,Punto_Reorden,Id_estado)
	values ('CL0009','Magnus Moin','Birra',2900,'Lata de aluminio','Frágil',355,10,GETDATE(),GETDATE(),GETDATE(),300,300,150,1);

	--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**
	-- || Inserción datos tabla TBL_facturas                          ||
	--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**

	-- Truncate table Tbl_Factura

	Insert into Tbl_Factura Values ('Contado','Efectivo',100,2000,100,9000,GETDATE(),1,3,1,1)
	Insert into Tbl_Factura Values ('Crédito','Efectivo',100,2000,100,9000,GETDATE(),1,3,1,1)

	--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**
	-- || Inserción datos tabla TBL_Reciclaje                         ||
	--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**

	insert into [dbo].[TBL_Tipo_Reciclaje] values ('Reciclaje Botellas');
	insert into [dbo].[TBL_Tipo_Reciclaje] values ('Reciclaje Latas');

	--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**
	-- || Inserción datos tabla TBL_Orden_Fabriación                         ||
	--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**

	Insert into TBL_Orden_Fabricacion (FechaEmision,FechaFabricacion,Id_estado,[Id_factura]) values (GETDATE(),GETDATE(),6,1)

	--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**
-- || Inserción datos tabla tbl_Provincias                        ||
--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**

	Insert into TBL_Provincias values ('1','San José')
	Insert into TBL_Provincias values ('2','Alajuela')
	Insert into TBL_Provincias values ('3','Cartago')
	Insert into TBL_Provincias values ('4','Heredia')
	Insert into TBL_Provincias values ('5','Guanacaste')
	Insert into TBL_Provincias values ('6','Puntarenas')
	Insert into TBL_Provincias values ('7','Limón')

--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**
-- || Inserción datos tabla tbl_Cantones                          ||
--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**

--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**
-- || Cantones de San José               ||
--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**

	Insert into TBL_Cantones values ('01','San José','1')
	Insert into TBL_Cantones values ('02','Escazu','1')
	Insert into TBL_Cantones values ('03','Desamparados','1')
	Insert into TBL_Cantones values ('04','Puriscal','1')
	Insert into TBL_Cantones values ('05','Tarrazu','1')
	Insert into TBL_Cantones values ('06','Aserri','1')
	Insert into TBL_Cantones values ('07','Mora','1') 
	Insert into TBL_Cantones values ('08','Goicoechea','1')
	Insert into TBL_Cantones values ('09','Santa Ana','1')
	Insert into TBL_Cantones values ('10','Alajuelita','1')
	Insert into TBL_Cantones values ('11','Vásquez de Coronado','1')
	Insert into TBL_Cantones values ('12','Acosta','1')
	Insert into TBL_Cantones values ('13','Tibás','1')
	Insert into TBL_Cantones values ('14','Moravia','1')
	Insert into TBL_Cantones values ('15','Montes de Oca','1')
	Insert into TBL_Cantones values ('16','Turrubares','1')
	Insert into TBL_Cantones values ('17','Dota','1')
	Insert into TBL_Cantones values ('18','Curridabat','1')
	Insert into TBL_Cantones values ('19','Pérez Zeledón','1')
	Insert into TBL_Cantones values ('20','León Córtes Castro','1')

--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**
-- || Cantones de Alajuela               ||
--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**

	Insert into TBL_Cantones values ('01','Alajuela','2')
	Insert into TBL_Cantones values ('02','San Ramón','2')
	Insert into TBL_Cantones values ('03','Grecia','2')
	Insert into TBL_Cantones values ('04','San Mateo','2')
	Insert into TBL_Cantones values ('05','Atenas','2')
	Insert into TBL_Cantones values ('06','Naranjo','2')
	Insert into TBL_Cantones values ('07','Palmares','2')
	Insert into TBL_Cantones values ('08','Poás','2')
	Insert into TBL_Cantones values ('09','Orotina','2')
	Insert into TBL_Cantones values ('10','San Carlos','2')
	Insert into TBL_Cantones values ('11','Alfaro Ruiz','2')
	Insert into TBL_Cantones values ('12','Valverde Vega','2')
	Insert into TBL_Cantones values ('13','Upala','2')
	Insert into TBL_Cantones values ('14','Los Chiles','2')
	Insert into TBL_Cantones values ('15','Guatuso','2')

--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**
-- || Cantones de Cartago                ||
--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**

	Insert into TBL_Cantones values ('01','Cartago','3')
	Insert into TBL_Cantones values ('02','Paraíso','3')
	Insert into TBL_Cantones values ('03','La Unión','3')
	Insert into TBL_Cantones values ('04','Jiménez','3')
	Insert into TBL_Cantones values ('05','Turrialba','3')
	Insert into TBL_Cantones values ('06','Alvarado','3')
	Insert into TBL_Cantones values ('07','Oreamuno','3')
	Insert into TBL_Cantones values ('08','El Guarco','3')

--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**
-- || Cantones de Heredia                ||
--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**

	Insert into TBL_Cantones values ('01','Heredia','4')
	Insert into TBL_Cantones values ('02','Barva','4')
	Insert into TBL_Cantones values ('03','Santo Domingo','4')
	Insert into TBL_Cantones values ('04','Santa Bárbara','4')
	Insert into TBL_Cantones values ('05','San Rafael','4')
	Insert into TBL_Cantones values ('06','San Isidro','4')
	Insert into TBL_Cantones values ('07','Belén','4')
	Insert into TBL_Cantones values ('08','Flores','4')
	Insert into TBL_Cantones values ('09','San Pablo','4')
	Insert into TBL_Cantones values ('10','Sarapiquí','4')

--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**
-- || Cantones de Guanacaste             ||
--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**

	Insert into TBL_Cantones values ('01','Liberia','5')
	Insert into TBL_Cantones values ('02','Nicoya','5')
	Insert into TBL_Cantones values ('03','Santa Cruz','5')
	Insert into TBL_Cantones values ('04','Bagaces','5')
	Insert into TBL_Cantones values ('05','Carrillo','5')
	Insert into TBL_Cantones values ('06','Cañas','5')
	Insert into TBL_Cantones values ('07','Abangares','5')
	Insert into TBL_Cantones values ('08','Tilarán','5')
	Insert into TBL_Cantones values ('09','Nandayure','5')
	Insert into TBL_Cantones values ('10','La Cruz','5')
	Insert into TBL_Cantones values ('11','Hojancha','5')


--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**
-- || Cantones de Puntarenas             ||
--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**

	Insert into TBL_Cantones values ('01','Puntarenas','6')
	Insert into TBL_Cantones values ('02','Esparza','6') 
	Insert into TBL_Cantones values ('03','Buenos Aires','6') 
	Insert into TBL_Cantones values ('04','Montes de Oro','6') 
	Insert into TBL_Cantones values ('05','Osa','6') 
	Insert into TBL_Cantones values ('06','Aguirre','6') 
	Insert into TBL_Cantones values ('07','Golfito','6') 
	Insert into TBL_Cantones values ('08','Coto Brus','6') 
	Insert into TBL_Cantones values ('09','Parrita','6') 
	Insert into TBL_Cantones values ('10','Corredores','6') 
	Insert into TBL_Cantones values ('11','Garabito','6')


--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**
-- || Cantones de Limón                  ||
--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**

	Insert into TBL_Cantones values ('01','Limón','7') 
	Insert into TBL_Cantones values ('02','Pococí','7') 
	Insert into TBL_Cantones values ('03','Siquirres','7')
	Insert into TBL_Cantones values ('04','Talamanca','7') 
	Insert into TBL_Cantones values ('05','Matina','7') 
	Insert into TBL_Cantones values ('06','Guacimo','7')

--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**
-- || Inserción datos tabla tbl_Distritos                         ||
--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**

--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**
-- || Distritos de San José              ||
--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**

	Insert into TBL_Distritos values ('01','01','1','El Carmen')
	Insert into TBL_Distritos values ('02','01','1','Merced')
	Insert into TBL_Distritos values ('03','01','1','Hospital')
	Insert into TBL_Distritos values ('04','01','1','Catedral')
	Insert into TBL_Distritos values ('05','01','1','Zapote')
	Insert into TBL_Distritos values ('06','01','1','San Fco.de Dos Ríos')
	Insert into TBL_Distritos values ('07','01','1','Uruca')
	Insert into TBL_Distritos values ('08','01','1','Mata Redonda')
	Insert into TBL_Distritos values ('09','01','1','Pavas')
	Insert into TBL_Distritos values ('10','01','1','Hatillo')
	Insert into TBL_Distritos values ('11','01','1','San Sebastián')

	Insert into TBL_Distritos values ('01','02','1','Escazú')
	Insert into TBL_Distritos values ('02','02','1','San Antonio')
	Insert into TBL_Distritos values ('03','02','1','San Rafael')

	Insert into TBL_Distritos values ('01','03','1','Desamparados')
	Insert into TBL_Distritos values ('02','03','1','San Miguel')
	Insert into TBL_Distritos values ('03','03','1','San Juan de Dios')
	Insert into TBL_Distritos values ('04','03','1','San Rafael Arriba')
	Insert into TBL_Distritos values ('05','03','1','San Antonio')
	Insert into TBL_Distritos values ('06','03','1','Frailes')
	Insert into TBL_Distritos values ('07','03','1','Patarrá')
	Insert into TBL_Distritos values ('08','03','1','San Cristóbal')
	Insert into TBL_Distritos values ('09','03','1','Rosario')
	Insert into TBL_Distritos values ('10','03','1','Damas')
	Insert into TBL_Distritos values ('11','03','1','San Rafael Abajo')
	Insert into TBL_Distritos values ('12','03','1','Gravilias')

	Insert into TBL_Distritos values ('01','04','1','Santiago')
	Insert into TBL_Distritos values ('02','04','1','Mercedes Sur')
	Insert into TBL_Distritos values ('03','04','1','Barbacoas')
	Insert into TBL_Distritos values ('04','04','1','Grifo Alto')
	Insert into TBL_Distritos values ('05','04','1','San Rafael')
	Insert into TBL_Distritos values ('06','04','1','Candelarita')
	Insert into TBL_Distritos values ('07','04','1','Desamparaditos')
	Insert into TBL_Distritos values ('08','04','1','San Antonio')
	Insert into TBL_Distritos values ('09','04','1','Chires')

	Insert into TBL_Distritos values ('01','05','1','San Marcos')
	Insert into TBL_Distritos values ('02','05','1','San Lorenzo')
	Insert into TBL_Distritos values ('03','05','1','San Carlos')

	Insert into TBL_Distritos values ('01','06','1','Aserrí')
	Insert into TBL_Distritos values ('02','06','1','Tarbaca')
	Insert into TBL_Distritos values ('03','06','1','Vuelta de Jorco')
	Insert into TBL_Distritos values ('04','06','1','San Gabriel')
	Insert into TBL_Distritos values ('05','06','1','Legua')
	Insert into TBL_Distritos values ('06','06','1','Monterrey')
	Insert into TBL_Distritos values ('07','06','1','Salitrillos')

	Insert into TBL_Distritos values ('01','07','1','Colón')
	Insert into TBL_Distritos values ('02','07','1','Guayabo')
	Insert into TBL_Distritos values ('03','07','1','Tabarcia')
	Insert into TBL_Distritos values ('04','07','1','Piedras Negras')
	Insert into TBL_Distritos values ('05','07','1','Picagres')

	Insert into TBL_Distritos values ('01','08','1','Guadalupe')
	Insert into TBL_Distritos values ('02','08','1','San Francisco')
	Insert into TBL_Distritos values ('03','08','1','Calle Blancos')
	Insert into TBL_Distritos values ('04','08','1','Mata de Plátano')
	Insert into TBL_Distritos values ('05','08','1','Ipís')
	Insert into TBL_Distritos values ('06','08','1','Rancho Redondo')
	Insert into TBL_Distritos values ('07','08','1','Purral')

	Insert into TBL_Distritos values ('01','09','1','Santa Ana')
	Insert into TBL_Distritos values ('02','09','1','Salitral')
	Insert into TBL_Distritos values ('03','09','1','Pozos')
	Insert into TBL_Distritos values ('04','09','1','Uruca')
	Insert into TBL_Distritos values ('05','09','1','Piedades')
	Insert into TBL_Distritos values ('06','09','1','Brasil')

	Insert into TBL_Distritos values ('01','10','1','Alajuelita')
	Insert into TBL_Distritos values ('02','10','1','San Josecito')
	Insert into TBL_Distritos values ('03','10','1','San Antonio')
	Insert into TBL_Distritos values ('04','10','1','Concepción')
	Insert into TBL_Distritos values ('05','10','1','San Felipe')

	Insert into TBL_Distritos values ('01','11','1','San Isidro')
	Insert into TBL_Distritos values ('02','11','1','San Rafael')
	Insert into TBL_Distritos values ('03','11','1','Dulce Nombre de Jesús')
	Insert into TBL_Distritos values ('04','11','1','Patalillo')
	Insert into TBL_Distritos values ('05','11','1','Cascajal')

	Insert into TBL_Distritos values ('01','12','1','San Ignacio')
	Insert into TBL_Distritos values ('02','12','1','Guaitíl')
	Insert into TBL_Distritos values ('03','12','1','Palmichal')
	Insert into TBL_Distritos values ('04','12','1','Cangrejal')
	Insert into TBL_Distritos values ('05','12','1','Sabanillas')

	Insert into TBL_Distritos values ('01','13','1','San Juan')
	Insert into TBL_Distritos values ('02','13','1','Cinco Esquinas')
	Insert into TBL_Distritos values ('03','13','1','Anselmo Llorente')
	Insert into TBL_Distritos values ('04','13','1','León XIII')
	Insert into TBL_Distritos values ('05','13','1','Colima')

	Insert into TBL_Distritos values ('01','14','1','San Vicente')
	Insert into TBL_Distritos values ('02','14','1','San Jerónimo')
	Insert into TBL_Distritos values ('03','14','1','Trinidad')

	Insert into TBL_Distritos values ('01','15','1','San Pedro')
	Insert into TBL_Distritos values ('02','15','1','Sabanilla')
	Insert into TBL_Distritos values ('03','15','1','Mercedes')
	Insert into TBL_Distritos values ('04','15','1','San Rafael')

	Insert into TBL_Distritos values ('01','16','1','San Pablo')
	Insert into TBL_Distritos values ('02','16','1','San Pedro')
	Insert into TBL_Distritos values ('03','16','1','San Juan de Mata')
	Insert into TBL_Distritos values ('04','16','1','San Luis')

	Insert into TBL_Distritos values ('01','17','1','Santa María')
	Insert into TBL_Distritos values ('02','17','1','Jardín')
	Insert into TBL_Distritos values ('03','17','1','Copey')

	Insert into TBL_Distritos values ('01','18','1','Curridabat')
	Insert into TBL_Distritos values ('02','18','1','Granadilla')
	Insert into TBL_Distritos values ('03','18','1','Sánchez')
	Insert into TBL_Distritos values ('04','18','1','Tirrases')

	Insert into TBL_Distritos values ('01','19','1','San Isidro de El General')
	Insert into TBL_Distritos values ('02','19','1','General')
	Insert into TBL_Distritos values ('03','19','1','Daniel Flores')
	Insert into TBL_Distritos values ('04','19','1','Rivas')
	Insert into TBL_Distritos values ('05','19','1','San Pedro')
	Insert into TBL_Distritos values ('06','19','1','Platanares')
	Insert into TBL_Distritos values ('07','19','1','Pejibaye')
	Insert into TBL_Distritos values ('08','19','1','Cajón')
	Insert into TBL_Distritos values ('09','19','1','Barú')
	Insert into TBL_Distritos values ('10','19','1','Río Nuevo')
	Insert into TBL_Distritos values ('11','19','1','Páramo')

	Insert into TBL_Distritos values ('01','20','1','San Pablo')
	Insert into TBL_Distritos values ('02','20','1','San Andrés')
	Insert into TBL_Distritos values ('03','20','1','Llano Bonito')
	Insert into TBL_Distritos values ('04','20','1','San Isidro')
	Insert into TBL_Distritos values ('05','20','1','Santa Cruz')
	Insert into TBL_Distritos values ('06','20','1','San Antonio')

--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**
-- || Distritos de Alajuela              ||
--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**

	Insert into TBL_Distritos values ('01','01','2','Alajuela')
	Insert into TBL_Distritos values ('02','01','2','San José')
	Insert into TBL_Distritos values ('03','01','2','Carrizal')
	Insert into TBL_Distritos values ('04','01','2','San Antonio')
	Insert into TBL_Distritos values ('05','01','2','Guácima')
	Insert into TBL_Distritos values ('06','01','2','San Isidro')
	Insert into TBL_Distritos values ('07','01','2','Sabanilla')
	Insert into TBL_Distritos values ('08','01','2','San Rafael')
	Insert into TBL_Distritos values ('09','01','2','Río Segundo')
	Insert into TBL_Distritos values ('10','01','2','Desamparados')
	Insert into TBL_Distritos values ('11','01','2','Turrúcares')
	Insert into TBL_Distritos values ('12','01','2','Tambor')
	Insert into TBL_Distritos values ('13','01','2','La Garita')
	Insert into TBL_Distritos values ('14','01','2','Sarapiquí')

	Insert into TBL_Distritos values ('01','02','2','San Ramón')
	Insert into TBL_Distritos values ('02','02','2','Santiago')
	Insert into TBL_Distritos values ('03','02','2','San Juan')
	Insert into TBL_Distritos values ('04','02','2','Piedades Norte')
	Insert into TBL_Distritos values ('05','02','2','Piedades Sur')
	Insert into TBL_Distritos values ('06','02','2','San Rafael')
	Insert into TBL_Distritos values ('07','02','2','San Isidro')
	Insert into TBL_Distritos values ('08','02','2','Angeles')
	Insert into TBL_Distritos values ('09','02','2','Alfaro')
	Insert into TBL_Distritos values ('10','02','2','Volio')
	Insert into TBL_Distritos values ('11','02','2','Concepción')
	Insert into TBL_Distritos values ('12','02','2','Zapotal')
	Insert into TBL_Distritos values ('13','02','2','Peñas Blancas')

	Insert into TBL_Distritos values ('01','03','2','Grecia')
	Insert into TBL_Distritos values ('02','03','2','San Isidro')
	Insert into TBL_Distritos values ('03','03','2','San José')
	Insert into TBL_Distritos values ('04','03','2','San Roque')
	Insert into TBL_Distritos values ('05','03','2','Tacares')
	Insert into TBL_Distritos values ('06','03','2','Río Cuarto')
	Insert into TBL_Distritos values ('07','03','2','Puente de Piedra')
	Insert into TBL_Distritos values ('08','03','2','Bolívar')

	Insert into TBL_Distritos values ('01','04','2','San Mateo')
	Insert into TBL_Distritos values ('02','04','2','Desmonte')
	Insert into TBL_Distritos values ('03','04','2','Jesús María')

	Insert into TBL_Distritos values ('01','05','2','Atenas')
	Insert into TBL_Distritos values ('02','05','2','Jesús')
	Insert into TBL_Distritos values ('03','05','2','Mercedes')
	Insert into TBL_Distritos values ('04','05','2','San Isidro')
	Insert into TBL_Distritos values ('05','05','2','Concepción')
	Insert into TBL_Distritos values ('06','05','2','San José')
	Insert into TBL_Distritos values ('07','05','2','Santa Eulalia')

	Insert into TBL_Distritos values ('01','06','2','Naranjo')
	Insert into TBL_Distritos values ('02','06','2','San Miguel')
	Insert into TBL_Distritos values ('03','06','2','San José')
	Insert into TBL_Distritos values ('04','06','2','Cirrí Sur')
	Insert into TBL_Distritos values ('05','06','2','San Jerónimo')
	Insert into TBL_Distritos values ('06','06','2','San Juan')
	Insert into TBL_Distritos values ('07','06','2','Rosario')

	Insert into TBL_Distritos values ('01','07','2','Palmares')
	Insert into TBL_Distritos values ('02','07','2','Zaragoza')
	Insert into TBL_Distritos values ('03','07','2','Buenos Aires')
	Insert into TBL_Distritos values ('04','07','2','Santiago')
	Insert into TBL_Distritos values ('05','07','2','Candelaria')
	Insert into TBL_Distritos values ('06','07','2','Esquipulas')
	Insert into TBL_Distritos values ('07','07','2','Granja')

	Insert into TBL_Distritos values ('01','08','2','San Pedro')
	Insert into TBL_Distritos values ('02','08','2','San Juan')
	Insert into TBL_Distritos values ('03','08','2','San Rafael')
	Insert into TBL_Distritos values ('04','08','2','Carrillos')
	Insert into TBL_Distritos values ('05','08','2','Sabana Redonda')

	Insert into TBL_Distritos values ('01','09','2','Orotina')
	Insert into TBL_Distritos values ('02','09','2','Mastate')
	Insert into TBL_Distritos values ('03','09','2','Hacienda Vieja')
	Insert into TBL_Distritos values ('04','09','2','Coyolar')
	Insert into TBL_Distritos values ('05','09','2','Ceiba')

	Insert into TBL_Distritos values ('01','10','2','Quesada')
	Insert into TBL_Distritos values ('02','10','2','Florencia')
	Insert into TBL_Distritos values ('03','10','2','Buenavista')
	Insert into TBL_Distritos values ('04','10','2','Aguas Zarcas')
	Insert into TBL_Distritos values ('05','10','2','Venecia')
	Insert into TBL_Distritos values ('06','10','2','Pital')
	Insert into TBL_Distritos values ('07','10','2','Fortuna')
	Insert into TBL_Distritos values ('08','10','2','Tigra')
	Insert into TBL_Distritos values ('09','10','2','Palmera')
	Insert into TBL_Distritos values ('10','10','2','Venado')
	Insert into TBL_Distritos values ('11','10','2','Cutris')
	Insert into TBL_Distritos values ('12','10','2','Monterrey')
	Insert into TBL_Distritos values ('13','10','2','Pocosol')

	Insert into TBL_Distritos values ('01','11','2','Zarcero')
	Insert into TBL_Distritos values ('02','11','2','Laguna')
	Insert into TBL_Distritos values ('03','11','2','Tapezco')
	Insert into TBL_Distritos values ('04','11','2','Guadalupe')
	Insert into TBL_Distritos values ('05','11','2','Palmira')
	Insert into TBL_Distritos values ('06','11','2','Zapote')
	Insert into TBL_Distritos values ('07','11','2','Brisas')

	Insert into TBL_Distritos values ('01','12','2','Sarchí Norte')
	Insert into TBL_Distritos values ('02','12','2','Sarchí Sur')
	Insert into TBL_Distritos values ('03','12','2','Toro Amarillo')
	Insert into TBL_Distritos values ('04','12','2','San Pedro')
	Insert into TBL_Distritos values ('05','12','2','Rodríguez')

	Insert into TBL_Distritos values ('01','13','2','Upala')
	Insert into TBL_Distritos values ('02','13','2','Aguas Claras')
	Insert into TBL_Distritos values ('03','13','2','San José o Pizote')
	Insert into TBL_Distritos values ('04','13','2','Bijagua')
	Insert into TBL_Distritos values ('05','13','2','Delicias')
	Insert into TBL_Distritos values ('06','13','2','Dos Ríos')
	Insert into TBL_Distritos values ('07','13','2','Yolillal')

	Insert into TBL_Distritos values ('01','14','2','Los Chiles')
	Insert into TBL_Distritos values ('02','14','2','Caño Negro')
	Insert into TBL_Distritos values ('03','14','2','El Amparo')
	Insert into TBL_Distritos values ('04','14','2','San Jorge')

	Insert into TBL_Distritos values ('01','15','2','San Rafael')
	Insert into TBL_Distritos values ('02','15','2','Buenavista')
	Insert into TBL_Distritos values ('03','15','2','Cote')

--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**
-- || Distritos de Cartago               ||
--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**

	Insert into TBL_Distritos values ('01','01','3','Oriental')
	Insert into TBL_Distritos values ('02','01','3','Occidental')
	Insert into TBL_Distritos values ('03','01','3','Carmen')
	Insert into TBL_Distritos values ('04','01','3','San Nicolás')
	Insert into TBL_Distritos values ('05','01','3','Aguacaliente  o  San Fco.')
	Insert into TBL_Distritos values ('06','01','3','Guadalupe o Arenilla')
	Insert into TBL_Distritos values ('07','01','3','Corralillo')
	Insert into TBL_Distritos values ('08','01','3','Tierra Blanca')
	Insert into TBL_Distritos values ('09','01','3','Dulce Nombre')
	Insert into TBL_Distritos values ('10','01','3','Llano Grande')
	Insert into TBL_Distritos values ('11','01','3','Quebradilla')

	Insert into TBL_Distritos values ('01','02','3','Paraíso')
	Insert into TBL_Distritos values ('02','02','3','Santiago')
	Insert into TBL_Distritos values ('03','02','3','Orosi')
	Insert into TBL_Distritos values ('04','02','3','Cachí')

	Insert into TBL_Distritos values ('01','03','3','Tres Ríos')
	Insert into TBL_Distritos values ('02','03','3','San Diego')
	Insert into TBL_Distritos values ('03','03','3','San Juan')
	Insert into TBL_Distritos values ('04','03','3','San Rafael')
	Insert into TBL_Distritos values ('05','03','3','Concepción')
	Insert into TBL_Distritos values ('06','03','3','Dulce Nombre')
	Insert into TBL_Distritos values ('07','03','3','San Ramón')
	Insert into TBL_Distritos values ('08','03','3','Río Azul')

	Insert into TBL_Distritos values ('01','04','3','Juan Viñas')
	Insert into TBL_Distritos values ('02','04','3','Tucurrique')
	Insert into TBL_Distritos values ('03','04','3','Pejibaye')

	Insert into TBL_Distritos values ('01','05','3','Turrialba')
	Insert into TBL_Distritos values ('02','05','3','La Suiza')
	Insert into TBL_Distritos values ('03','05','3','Peralta')
	Insert into TBL_Distritos values ('04','05','3','Santa Cruz')
	Insert into TBL_Distritos values ('05','05','3','Santa Teresita')
	Insert into TBL_Distritos values ('06','05','3','Pavones')
	Insert into TBL_Distritos values ('07','05','3','Tuis')
	Insert into TBL_Distritos values ('08','05','3','Tayutic')
	Insert into TBL_Distritos values ('09','05','3','Santa Rosa')
	Insert into TBL_Distritos values ('10','05','3','Tres Equis')

	Insert into TBL_Distritos values ('01','06','3','Pacayas')
	Insert into TBL_Distritos values ('02','06','3','Cervantes')
	Insert into TBL_Distritos values ('03','06','3','Capellades')

	Insert into TBL_Distritos values ('01','07','3','San Rafael')
	Insert into TBL_Distritos values ('02','07','3','Cot')
	Insert into TBL_Distritos values ('03','07','3','Potrero Cerrado')
	Insert into TBL_Distritos values ('04','07','3','Cipreses')
	Insert into TBL_Distritos values ('05','07','3','Santa Rosa')

	Insert into TBL_Distritos values ('01','08','3','El Tejar')
	Insert into TBL_Distritos values ('02','08','3','San Isidro')
	Insert into TBL_Distritos values ('03','08','3','Tobosi')
	Insert into TBL_Distritos values ('04','08','3','Patio de Agua')

--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**
--|| Distritos de Heredia                ||
--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**

	Insert into TBL_Distritos values ('01','01','4','Heredia')
	Insert into TBL_Distritos values ('02','01','4','Mercedes')
	Insert into TBL_Distritos values ('03','01','4','San Francisco')
	Insert into TBL_Distritos values ('04','01','4','Ulloa')
	Insert into TBL_Distritos values ('05','01','4','Vara Blanca')

	Insert into TBL_Distritos values ('01','02','4','Barva')
	Insert into TBL_Distritos values ('02','02','4','San Pedro')
	Insert into TBL_Distritos values ('03','02','4','San Pablo')
	Insert into TBL_Distritos values ('04','02','4','San Roque')
	Insert into TBL_Distritos values ('05','02','4','Santa Lucía')
	Insert into TBL_Distritos values ('06','02','4','San José de La Montaña')

	Insert into TBL_Distritos values ('01','03','4','Santo Domingo')
	Insert into TBL_Distritos values ('02','03','4','San Vicente')
	Insert into TBL_Distritos values ('03','03','4','San Miguel')
	Insert into TBL_Distritos values ('04','03','4','Paracito')
	Insert into TBL_Distritos values ('05','03','4','Santo Tomás')
	Insert into TBL_Distritos values ('06','03','4','Santa Rosa')
	Insert into TBL_Distritos values ('07','03','4','Tures')
	Insert into TBL_Distritos values ('08','03','4','Pará')

	Insert into TBL_Distritos values ('01','04','4','Santa Bárbara')
	Insert into TBL_Distritos values ('02','04','4','San Pedro')
	Insert into TBL_Distritos values ('03','04','4','San Juan')
	Insert into TBL_Distritos values ('04','04','4','Jesús')
	Insert into TBL_Distritos values ('05','04','4','Santo Domingo')
	Insert into TBL_Distritos values ('06','04','4','Purabá')

	Insert into TBL_Distritos values ('01','05','4','San Rafael')
	Insert into TBL_Distritos values ('02','05','4','San Josecito')
	Insert into TBL_Distritos values ('03','05','4','Santiago')
	Insert into TBL_Distritos values ('04','05','4','Angeles')
	Insert into TBL_Distritos values ('05','05','4','Concepción')

	Insert into TBL_Distritos values ('01','06','4','San Isidro')
	Insert into TBL_Distritos values ('02','06','4','San José')
	Insert into TBL_Distritos values ('03','06','4','Concepción')
	Insert into TBL_Distritos values ('04','06','4','San Francisco')

	Insert into TBL_Distritos values ('01','07','4','San Antonio')
	Insert into TBL_Distritos values ('02','07','4','Rivera')
	Insert into TBL_Distritos values ('03','07','4','Asunción')

	Insert into TBL_Distritos values ('01','08','4','San Joaquín')
	Insert into TBL_Distritos values ('02','08','4','Barrantes')
	Insert into TBL_Distritos values ('03','08','4','Llorente')

	Insert into TBL_Distritos values ('01','09','4','San Pablo')

	Insert into TBL_Distritos values ('01','10','4','Puerto Viejo')
	Insert into TBL_Distritos values ('02','10','4','La Vírgen')
	Insert into TBL_Distritos values ('03','10','4','Horquetas')
	Insert into TBL_Distritos values ('04','10','4','Llanuras del Gaspar')
	Insert into TBL_Distritos values ('05','10','4','Cureña')

--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**
-- || Distritos de Guanacaste            ||
--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**

	Insert into TBL_Distritos values ('01','01','5','Liberia')
	Insert into TBL_Distritos values ('02','01','5','Cañas Dulces')
	Insert into TBL_Distritos values ('03','01','5','Mayorga')
	Insert into TBL_Distritos values ('04','01','5','Nacascolo')
	Insert into TBL_Distritos values ('05','01','5','Curubandé')

	Insert into TBL_Distritos values ('01','02','5','Nicoya')
	Insert into TBL_Distritos values ('02','02','5','Mansión')
	Insert into TBL_Distritos values ('03','02','5','San Antonio')
	Insert into TBL_Distritos values ('04','02','5','Quebrada Honda')
	Insert into TBL_Distritos values ('05','02','5','Sámara')
	Insert into TBL_Distritos values ('06','02','5','Nosara')
	Insert into TBL_Distritos values ('07','02','5','Belén de Nosarita')

	Insert into TBL_Distritos values ('01','03','5','Santa Cruz')
	Insert into TBL_Distritos values ('02','03','5','Bolsón')
	Insert into TBL_Distritos values ('03','03','5','27 de Abril')
	Insert into TBL_Distritos values ('04','03','5','Tempate')
	Insert into TBL_Distritos values ('05','03','5','Cartagena')
	Insert into TBL_Distritos values ('06','03','5','Cuajiniquil')
	Insert into TBL_Distritos values ('07','03','5','Diriá')
	Insert into TBL_Distritos values ('08','03','5','Cabo Velas')
	Insert into TBL_Distritos values ('09','03','5','Tamarindo')

	Insert into TBL_Distritos values ('01','04','5','Bagaces')
	Insert into TBL_Distritos values ('02','04','5','Fortuna')
	Insert into TBL_Distritos values ('03','04','5','Mogote')
	Insert into TBL_Distritos values ('04','04','5','Río Naranjo')

	Insert into TBL_Distritos values ('01','05','5','Filadelfia')
	Insert into TBL_Distritos values ('02','05','5','Palmira')
	Insert into TBL_Distritos values ('03','05','5','Sardinal')
	Insert into TBL_Distritos values ('04','05','5','Belén')

	Insert into TBL_Distritos values ('01','06','5','Cañas')
	Insert into TBL_Distritos values ('02','06','5','Palmira')
	Insert into TBL_Distritos values ('03','06','5','San Miguel')
	Insert into TBL_Distritos values ('04','06','5','Bebedero')
	Insert into TBL_Distritos values ('05','06','5','Porozal')

	Insert into TBL_Distritos values ('01','07','5','Juntas')
	Insert into TBL_Distritos values ('02','07','5','Sierra')
	Insert into TBL_Distritos values ('03','07','5','San Juan')
	Insert into TBL_Distritos values ('04','07','5','Colorado')

	Insert into TBL_Distritos values ('01','08','5','Tilarán')
	Insert into TBL_Distritos values ('02','08','5','Quebrada Grande')
	Insert into TBL_Distritos values ('03','08','5','Tronadora')
	Insert into TBL_Distritos values ('04','08','5','Santa Rosa')
	Insert into TBL_Distritos values ('05','08','5','Líbano')
	Insert into TBL_Distritos values ('06','08','5','Tierras Morenas')
	Insert into TBL_Distritos values ('07','08','5','Arenal')

	Insert into TBL_Distritos values ('01','09','5','Carmona')
	Insert into TBL_Distritos values ('02','09','5','Santa Rita')
	Insert into TBL_Distritos values ('03','09','5','Zapotal')
	Insert into TBL_Distritos values ('04','09','5','San Pablo')
	Insert into TBL_Distritos values ('05','09','5','Porvenir')
	Insert into TBL_Distritos values ('06','09','5','Bejuco')

	Insert into TBL_Distritos values ('01','10','5','La Cruz')
	Insert into TBL_Distritos values ('02','10','5','Santa Cecilia')
	Insert into TBL_Distritos values ('03','10','5','Garita')
	Insert into TBL_Distritos values ('04','10','5','Santa Elena')

	Insert into TBL_Distritos values ('01','11','5','Hojancha')
	Insert into TBL_Distritos values ('02','11','5','Monte Romo')
	Insert into TBL_Distritos values ('03','11','5','Puerto Carrillo')
	Insert into TBL_Distritos values ('04','11','5','Huacas')


--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**
-- || Cantones de Puntarenas             ||
--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**

	Insert into TBL_Distritos values ('01','01','6','Puntarenas')
	Insert into TBL_Distritos values ('02','01','6','Pitahaya')
	Insert into TBL_Distritos values ('03','01','6','Chomes')
	Insert into TBL_Distritos values ('04','01','6','Lepanto')
	Insert into TBL_Distritos values ('05','01','6','Paquera')
	Insert into TBL_Distritos values ('06','01','6','Manzanillo')
	Insert into TBL_Distritos values ('07','01','6','Guacimal')
	Insert into TBL_Distritos values ('08','01','6','Barranca')
	Insert into TBL_Distritos values ('09','01','6','Monteverde')
	Insert into TBL_Distritos values ('10','01','6','Cóbano')
	Insert into TBL_Distritos values ('11','01','6','Chacarita')
	Insert into TBL_Distritos values ('12','01','6','Chira')
	Insert into TBL_Distritos values ('13','01','6','Acapulco')

	Insert into TBL_Distritos values ('01','02','6','Espíritu Santo')
	Insert into TBL_Distritos values ('02','02','6','San Juan Grande')
	Insert into TBL_Distritos values ('03','02','6','Macacona')
	Insert into TBL_Distritos values ('04','02','6','San Rafael')
	Insert into TBL_Distritos values ('05','02','6','San Jerónimo')

	Insert into TBL_Distritos values ('01','03','6','Buenos Aires')
	Insert into TBL_Distritos values ('02','03','6','Volcán')
	Insert into TBL_Distritos values ('03','03','6','Potrero Grande')
	Insert into TBL_Distritos values ('04','03','6','Boruca')
	Insert into TBL_Distritos values ('05','03','6','Pilas')
	Insert into TBL_Distritos values ('06','03','6','Colinas')
	Insert into TBL_Distritos values ('07','03','6','Chánguena')
	Insert into TBL_Distritos values ('08','03','6','Biolley')

	Insert into TBL_Distritos values ('01','04','6','Miramar')
	Insert into TBL_Distritos values ('02','04','6','Unión')
	Insert into TBL_Distritos values ('03','04','6','San Isidro')

	Insert into TBL_Distritos values ('01','05','6','Puerto Cortés')
	Insert into TBL_Distritos values ('02','05','6','Palmar')
	Insert into TBL_Distritos values ('03','05','6','Sierpe')
	Insert into TBL_Distritos values ('04','05','6','Bahía Ballena')
	Insert into TBL_Distritos values ('05','05','6','Piedras Blancas')

	Insert into TBL_Distritos values ('01','06','6','Quepos')
	Insert into TBL_Distritos values ('02','06','6','Savegre')
	Insert into TBL_Distritos values ('03','06','6','Naranjito')

	Insert into TBL_Distritos values ('01','07','6','Golfito')
	Insert into TBL_Distritos values ('02','07','6','Puerto Jiménez')
	Insert into TBL_Distritos values ('03','07','6','Guaycará')
	Insert into TBL_Distritos values ('04','07','6','Pavón')

	Insert into TBL_Distritos values ('01','08','6','San Vito')
	Insert into TBL_Distritos values ('02','08','6','Sabalito')
	Insert into TBL_Distritos values ('03','08','6','Agua Buena')
	Insert into TBL_Distritos values ('04','08','6','Limoncito')
	Insert into TBL_Distritos values ('05','08','6','Pittier')

	Insert into TBL_Distritos values ('01','09','6','Parrita')

	Insert into TBL_Distritos values ('01','10','6','Corredor')
	Insert into TBL_Distritos values ('02','10','6','La Cuesta')
	Insert into TBL_Distritos values ('03','10','6','Canoas')
	Insert into TBL_Distritos values ('04','10','6','Laurel')

	Insert into TBL_Distritos values ('01','11','6','Jacó')
	Insert into TBL_Distritos values ('02','11','6','Tárcoles')

--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**
-- || Cantones de Limón                  ||
--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**

	Insert into TBL_Distritos values ('01','01','7','Limón')
	Insert into TBL_Distritos values ('02','01','7','Valle La Estrella')
	Insert into TBL_Distritos values ('03','01','7','Río Blanco')
	Insert into TBL_Distritos values ('04','01','7','Matama')

	Insert into TBL_Distritos values ('01','02','7','Guápiles')
	Insert into TBL_Distritos values ('02','02','7','Jiménez')
	Insert into TBL_Distritos values ('03','02','7','Rita')
	Insert into TBL_Distritos values ('04','02','7','Roxana')
	Insert into TBL_Distritos values ('05','02','7','Cariari')
	Insert into TBL_Distritos values ('06','02','7','Colorado')

	Insert into TBL_Distritos values ('01','03','7','Siquirres')
	Insert into TBL_Distritos values ('02','03','7','Pacuarito')
	Insert into TBL_Distritos values ('03','03','7','Florida')
	Insert into TBL_Distritos values ('04','03','7','Germania')
	Insert into TBL_Distritos values ('05','03','7','Cairo')
	Insert into TBL_Distritos values ('06','03','7','Alegría')

	Insert into TBL_Distritos values ('01','04','7','Bratsi')
	Insert into TBL_Distritos values ('02','04','7','Sixaola')
	Insert into TBL_Distritos values ('03','04','7','Cahuita')

	Insert into TBL_Distritos values ('01','05','7','Matina')
	Insert into TBL_Distritos values ('02','05','7','Batán')
	Insert into TBL_Distritos values ('03','05','7','Carrandí')

	Insert into TBL_Distritos values ('01','06','7','Guácimo')
	Insert into TBL_Distritos values ('02','06','7','Mercedes')
	Insert into TBL_Distritos values ('03','06','7','Pocora')
	Insert into TBL_Distritos values ('04','06','7','Río Jiménez')
	Insert into TBL_Distritos values ('05','06','7','Duacarí')

--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**
-- || Inserción datos tabla tbl_Direcciones_cliente               ||
--*=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**=-=**

	Insert into TBL_Direcciones_cliente values ('Barrio Gonzalez Lamahan, San José','1','01','01',1)
	Insert into TBL_Direcciones_cliente values ('Condominios del Sur','6','03','05',2)
	Insert into TBL_Direcciones_cliente values ('Barrio Don Bosco,San José','1','01','03',2)
	Insert into TBL_Direcciones_cliente values ('Guácimo,Limón','7','06','04',3)
--- ===================================================================================================================
---                                      -*- ÚLTIMA LÍNEA -*-
-- -===================================================================================================================