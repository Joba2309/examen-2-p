create database DBTeam
go
use DBTeam


create database DBTeam
go
use DBTeam

create table Clientes
( 
codigo varchar (5),
Equipos varchar(50),
Reparaciones varchar(5),
Usuarios varchar(50),
Tecnicos varchar(50),
Asignaciones varchar (50),
DetallesReparacion varchar(50),
);
go

create proc sp_listar_clientes
as
select* from clientes order by codigo
go

create proc sp_buscar_clientes
@nombre varchar(50)
as
select Equipos,Reparaciones,Usuarios,Tecnicos,Asignaciones,DetallesReparacion from clientes where nombre like @nombre+'%'
go
create proc sp_mantenimiento_clientes
@Codigo varchar (5),
@Equipos varchar(20),
@Reparaciones varchar (50),
@Usuarios varchar(20),
@Tecnicos varchar (20),
@Asignaciones varchar (30),
@DetallesReparacion varchar (50),
@accion varchar(50) output
as
if (@accion='1')
begin
 declare @codnuevo varchar(5), @codmax varchar (5)
set @codmax = (select max(codigo) from clientes)
set @codmax =isnull(@codmax,'A0000')
set @codnuevo = 'A' +RIGHT(RIGHT(@codmax,4)+10001,4)
insert into clientes (Equipos,Reparaciones,Usuarios,Tecnicos,Asignaciones,DetallesReparacion)
values(@codnuevo,@Equipos,@Reparaciones,@Usuarios,@Tecnicos,@Asignaciones,@DetallesReparacion)
set @accion='Se genero el codigo: '+@codnuevo 
end
else if (@accion='2')
begin
   update clientes set Equipos=@Equipos,Reparaciones=@Reparaciones,Usuarios=@Usuarios,Tecnicos=@Tecnicos,Asignaciones=@Asignaciones where DetallesReparacion=@DetallesReparacion,
set @accion='Se modifico el codigo:'+@codigo
end
else if (@accion='3')
begin
delete from clientes where codigo=@codigo
set @accion='se borro el codigo:' +@codigo
end
go