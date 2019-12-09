create database Tia2
use Tia2
--tabla de Cargos
create table Cargos(i_IdCargo int primary key not null, NombreCargo varchar(20) not null)

--ingreso de cargos
insert into Cargos values(1,'Administrador')
insert into Cargos values(2,'Cajero')

--tabla de Administadores
create table Cuentas(i_IdAdmin int primary key identity(1,1) not null, NombresAdmin varchar(25), ApellidosAdmin varchar(25), i_IdCargos int foreign key(i_IdCargos) references Cargos(i_IdCargo), ApadoAdmin varchar(20) not null, PassAdmin varchar(15))

--ingreso de Usuarios
insert into Cuentas values('STEVYN','POVEDA',1,'spovedav','admin')
insert into Cuentas values('CESAR','ERASO',2,'eraso','123')
insert into Cuentas values('ISAAK','ORRALA',1,'isaak','admin')
insert into Cuentas values('CRISTIAN','LOPEZ',2,'lopez','123')

--tabla de glosario
create table Glosario(id int , apodo varchar(25) primary key not null, fecha date)--en PROCESO 


--tabla de Productos
create table Productos(cod_producto int primary key not null, nomproducto varchar(50) not null, precio float, cantstok int, totalinver float,imgproducto varchar(10), descri varchar(100))
go

insert into Productos values (1,'LAPTOP ASUS',780.25,20,15600,null,'Ram 6gb, Disco duro 1tb, 8 nucleos, 4.5hgz, 15 pulgadas')
insert into Productos values (2,'PANTALONES',12,20,240,null,'Pantalones de camuflaje Militar con cinturon de oro Grtis')
insert into Productos values (3,'PARLANTES',11.50,50,575,null,'Parlanes con puerto usb, micro sd, bluetooth')
insert into Productos values (4,'CORTINAS',25,10,250,null,'Cortinas con estampado de Frutas y Vegetales')


select * from Productos

update Productos set cantstok = cantstok - 2 where cod_producto = 1

select precio,cantstok from Productos where nomproducto = 'SAMSUNG TV'
------------------------------------------
truncate table Cuentas 
truncate table Productos
select * from Cuentas
go
------------------------------------------
--PROCEDIMIENTO ALMACENADO DE AGREGARPRODUCTO
create procedure agregarproducto(@cod int, @nom varchar(25),@precio float,@cantidad int,@total float,@img varchar(10),@descri varchar(100)) as
begin 
insert into Productos(cod_producto,nomproducto,precio,cantstok,totalinver,imgproducto,descri) values (@cod,@nom,@precio,@cantidad,@total,@img,@descri)
end
exec agregarproducto 1,'SAMSUNG TV',1005.99,10,10059.9,null,'es un televisor de 35 pulgadas'
go
select * from Productos

--PROCEDIMINETO ALMACENADO DE ELIMINACIONPRODUCTO
go
create procedure eliminarproducto(@cod int) as
begin
delete from Productos where cod_producto = @cod
end
exec eliminarproducto 3
select * from Productos
--PROCEDIMINETO ALMACENADO DE LLERPRODUCTO
create proc leerproducto as
begin
select * from Productos
end

exec leerproducto

--PROCEDIMINETO ALMACENADO DE VEREFICAR
create proc verificar(@usuario varchar(25),@clave varchar(25)) as
begin
select * from Cuentas where apodo = @usuario and pass = @clave
end
exec verificar 'spovedav','admin'

--PROCEDIMIENTO ALMACENADO DE BUSQUEDA
create proc busqueda(@cod int) as
begin
select * from Productos where cod_producto = @cod
end
exec busqueda 1
select * from Productos

--PROCEDIMINETO ALMACENADO DE INSERTAR CUENTA

--PROCEDIMIENTO ALMACENADO DE BUSCAR PRODUCTO -- From Primcipal

--PREOCEDIMIENTO ALMACENADO DE ISNERTAR PRODUCTO -- from 

--id del`producto que sigue en el from PRODUCTOS


