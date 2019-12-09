create database Tia
use Tia
--tabla de Cargos
create table Cargos(i_IdCargo int primary key identity (1,1) not null, NombreCargo varchar(20) not null)

--ingreso de cargos
insert into Cargos values('Administrador')
insert into Cargos values('Cajero')

--tabla de Administadores
create table Cuentas(i_IdAdmin int primary key identity(1,1) not null, NombresAdmin varchar(25), ApellidosAdmin varchar(25), i_IdCargos int foreign key(i_IdCargos) references Cargos(i_IdCargo), ApadoAdmin varchar(20) not null, PassAdmin varchar(15))

--ingreso de Usuarios
insert into Cuentas values('STEVYN','POVEDA',1,'spovedav','admin')
insert into Cuentas values('CESAR','ERASO',2,'eraso','123')
insert into Cuentas values('ISAAK','ORRALA',1,'isaak','admin')
insert into Cuentas values('CRISTIAN','LOPEZ',2,'lopez','123')

--tabla de Marcas
create table Marcas(i_IdMarca int primary key identity(1,1) not null,NombresMarcas varchar(20) not null)

--tabla de glosario
create table Glosario(Id int , Apodo varchar(25) primary key not null, fecha date)--en PROCESO 



--ingreso de Marcass
insert into Marcas values('Happy Toys')--niños
insert into Marcas values('HomeClub')--niños
insert into Marcas values('Hometech')--electro
insert into Marcas values('Oster')--electro

--tabla de Productos
create table Productos(i_IdProducto int primary key identity (1,1) not null, NombresProductos varchar(50) not null, Genero varchar(20), Precio float, CantStok int,i_IdMarca int foreign key(i_IdMarca) references Marcas(i_IdMarca),ImagenProducto binary(300), Descricion varchar(50))
insert into Productos values('Licuadora','electrodo',1000,20,4,null,'potenete licuadora para licuar')
insert into Productos values('Licuadora Basic','electrodo',500,10,4,null,'barata licuadora para licuar')
select * from Productos
--
insert into Productos(Precio,NombresProductos,Genero,CantStok,i_IdMarca,Descricion)
values('Patines Happy Toys con accesorios','INFANTIL',29,90,20,1,'Son patines para que los niños se diviertan mucho tanto dentro de la casa')



------------------------------------------
truncate table Cuentas 
truncate table Productos
select * from Cuentas
go
------------------------------------------

--PROCEDIMINETO ALMACENADO DE INSERTAR CUENTA
create procedure sp_insertar_cuenta (@nombre nvarchar(20),@apellido nvarchar(20),@id_cargo int ,@user nvarchar(15) ,@pass nvarchar(15))
as
begin
insert into Cuentas(NombresAdmin,ApellidosAdmin,i_IdCargos,ApadoAdmin,PassAdmin) values (@nombre,@apellido,@id_cargo,@user,@pass)
end

--PROCEDIMIENTO ALMACENADO DE BUSCAR PRODUCTO -- From Primcipal
create procedure sp_buscar_producto (@id int)
as
begin
SELECT        dbo.Productos.NombresProductos, dbo.Productos.i_IdProducto, dbo.Marcas.NombresMarcas, dbo.Productos.Genero, dbo.Productos.Precio, dbo.Productos.CantStok, dbo.Productos.Descricion, 
                         dbo.Productos.ImagenProducto
FROM            dbo.Marcas INNER JOIN
                         dbo.Productos ON dbo.Marcas.i_IdMarca = dbo.Productos.i_IdMarca where i_IdProducto = @id
end
exec sp_buscar_producto 1

--PREOCEDIMIENTO ALMACENADO DE ISNERTAR PRODUCTO -- from 
create procedure sp_insertar_producto(@nombre varchar(50),@genero varchar(50),@precio float,@cantStok int, @marca int, @descricion varchar(50))
as
begin
insert into Productos(NombresProductos,Genero,Precio,CantStok,i_IdMarca,Descricion) values (@nombre,@genero,@precio,@cantStok,@marca,@descricion)
end 

--procedimiento de eliminar por ID cuenta  -- Cargos
create procedure sp_eliminar_cargo(@id int)
as
begin
delete from Cuentas where i_IdAdmin = @id
end

exec sp_eliminar_cargo 6
select * from Cuentas

--procedimiento de eliminar por Nombre -- Cargos
create procedure sp_eliminar_cargo_nom(@nombre varchar(25))
as
begin
delete from Cuentas where NombresAdmin = @nombre
end

exec sp_eliminar_cargo_nom 'CESAR'
select * from Cuentas 





--id del`producto que sigue en el from PRODUCTOS
select top(1) i_IdProducto + 1 as id from Productos order by i_IdProducto desc

--vista de las cuentas -- from BaseDeDatos
create view view_cuentas as
select cu.i_IdAdmin,cu.NombresAdmin,cu.ApellidosAdmin,ca.NombreCargo,cu.ApadoAdmin,cu.PassAdmin from Cuentas cu inner join Cargos ca on cu.i_IdCargos = ca.i_IdCargo

select * from view_cuentas


--vista de los productos -- from BaseDeDatos
create view view_productos as
select pr.i_IdProducto,pr.NombresProductos,pr.Genero,pr.CantStok,ma.NombresMarcas,pr.ImagenProducto,pr.Descricion from Productos pr inner join Marcas ma on pr.i_IdMarca = ma.i_IdMarca

select * from view_productos


















