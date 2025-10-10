create database Hotel
go

use Hotel
go

create table Rol (
idRol int primary key identity (1,1),
nombreRol varchar(20)
);
go

create table Usuario (
idUsuario int primary key identity (1,1),
nombreUsu varchar(50),
apellidoUsu varchar(50),
dui varchar(8),
fecha_nacimiento date,
telefono varchar (9),
contrasena varchar (255),
id_Rol int,
foreign key (id_Rol) references Rol (idRol)
);
go

create table EstadoHabitación (
idEstado int primary key identity (1,1),
nombreEstado varchar(30)
);
go

create table Habitacion (
idHabitaciones int primary key identity (1,1),
numeroHabitacion varchar(5),
precio decimal (10,2),
cantidad int,
estadoHabitacion int,
foreign key (estadoHabitacion) references EstadoHabitación (idEstado)
);
go

create table Cliente (
idCliente int primary key identity (1,1),
nombreCli varchar(50),
apellidoCli varchar(50),
duiCli varchar(8),
fechaNacimientoCli date,
telefono varchar (10),
Email varchar(50),
id_Usuario int,
foreign key (id_Usuario) references Usuario (idUsuario)
);
go

create table MetodoPago (
idPago int primary key identity (1,1),
nombreMetodo varchar(40)
);
go

create table EstadoReserva (
idEstadoRe int primary key identity (1,1),
nombreEstadoRe varchar (30)
);
go

create table Reserva (
idReserva int primary key identity (1,1),
cantidadReserva int,
fechaEntrada date,
fechaSalida date,
id_Estado int,
id_Pago int,
id_Habitacion int,
id_Cliente int,
foreign key (id_Estado) references EstadoReserva (idEstadoRe),
foreign key (id_Pago) references MetodoPago (idPago),
foreign key (id_Habitacion) references Habitacion (idHabitaciones),
foreign key (id_Cliente) references Cliente (idCliente)
);
go

create table Servicio (
idServicio int primary key identity (1,1),
nombreServicio varchar(30),
precio decimal (10,2),
descripcion varchar (100)
);
go

create table Consumo (
idConsumo int primary key identity (1,1),
fecha date,
id_Reserva int, 
id_Servicio int,
foreign key (id_Reserva) references Reserva (idReserva),
foreign key (id_Servicio) references Servicio (idServicio),
);
go

create table Ingreso (
idIngreso int primary key identity (1,1),
fecha date, 
habitación int,
servicio int, 
general int, 
id_Reserva int, 
foreign key (id_Reserva) references Reserva (idReserva)
);
go


select *from Ingreso
select *from Consumo
select *from Servicio
select *from Reserva
select *from EstadoReserva
select *from MetodoPago
select *from Cliente
select *from Habitacion
select *from EstadoHabitación
select *from Usuario
select *from Rol


INSERT INTO Habitacion VALUES ('101', 24, 5, 1),
('106', 21, 2, 1),
('100', 14, 1, 1)
go

insert into Rol values ('Administrador'),
('Recepcionista'),
('Gerente')
go

insert into MetodoPago values ('Efectivo'),
('Tarjeta'),
('Transferencia bancaria')
go

insert into EstadoReserva values ('En espera'),
('En estancia'),
('Completada')
go

insert into EstadoHabitación values ('Vacia'), 
('Ocupada')
go

INSERT INTO Usuario (nombreUsu, apellidoUsu, dui, fecha_nacimiento, telefono, contrasena, id_Rol)
VALUES ('María', 'González', '12345678', '1990-05-15', '77778888', '$2a$12$n06n0cFLssX.4iu4cUWNP.5a602lsj7/Hou8FwBsyyCWEi529m/Ee', 1),
--Contra: Administrador
('Carlos', 'Rodríguez', '87654321', '1985-08-22', '75556666', '$2a$12$SMnIt/JbOuZITsg19jwB.eHRnLz9FAG9ORxDG.BUJD6PVZ7b97pgW', 2),
--Contra: Recepcionista
('Ana', 'Martínez', '56781234', '1992-11-30', '72223333', '$2a$12$H4Od24jU5VlSop7qb0ctYuHsVHv5T14pctBiOzxoe3GiaMmZokGXq', 3);
--Contra: Gerente
go

create view Reservaciones as
select idReserva as Reserva, nombreEstadoRe as Estado, nombreCli as [Nombre del Cliente], duiCli as [DUI del cliente], numeroHabitacion as [Número de habitación], cantidadReserva as [Cantidad de personas], nombreMetodo as Pago, fechaEntrada as [Fecha de entrada], fechaSalida as [Fecha de salida]  from Reserva R
inner join
EstadoReserva ER on ER.idEstadoRe=R.id_Estado
INNER JOIN
MetodoPago MP ON MP.idPago=R.id_Pago
INNER JOIN
Habitacion H ON H.idHabitaciones=R.id_Habitacion
INNER JOIN
Cliente C ON C.idCliente=R.id_Cliente
go

create view ClientesReservas as
SELECT idCliente as Cliente, nombreCli as [Nombre del cliente], apellidoCli as [Apellido del cliente], duiCli as [DUI], nombreEstadoRe as [Estado] FROM Cliente C
inner join
Reserva R on R.id_Cliente= C.idCliente
INNER JOIN
EstadoReserva ER on ER.idEstadoRe = r.id_Estado
go

create view ReservaId as
SELECT idReserva, nombreCli + ' ' + apellidoCli AS Cliente,
numeroHabitacion AS Habitacion, duiCli as DUI, fechaEntrada as [Fecha de Entrada], fechaSalida as [Fecha de Salida], 
nombreEstadoRe
FROM Reserva R
INNER JOIN Cliente C ON R.id_Cliente = C.idCliente
INNER JOIN Habitacion H ON R.id_Habitacion = H.idHabitaciones
INNER JOIN EstadoReserva E ON R.id_Estado = E.idEstadoRe
go

create view Clientes as 
select idCliente as Cliente, nombreCli as Nombre, apellidoCli as Apellido, duiCli as DUI, 
fechaNacimientoCli as Fecha, telefono as Teléfono, Email from Cliente

create view Servicios as
select idServicio as Servicio, nombreServicio as Nombre, precio as Precio, descripcion as Descripción from Servicio