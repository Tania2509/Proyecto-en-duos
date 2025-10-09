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
Email varchar(50)
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



/* INSERT INTO Cliente VALUES ('Juan Carlos', 'García López', '12345678', '1990-05-15', '77778888', 'juan.garcia@email.com'),
('María Elena', 'Rodríguez Sánchez', '87654321', '1985-08-22', '76665555', 'maria.rodriguez@email.com'),
('Carlos Antonio', 'Hernández Castro', '11223344', '1992-12-03', '74443333', 'carlos.hernandez@email.com');
go

INSERT INTO Servicio (nombreServicio, precio, descripcion) VALUES
('Lavandería', 15.50, 'Servicio de lavado y planchado de ropa'),
('Desayuno Buffet', 25.00, 'Buffet de desayuno continental e internacional'),
('Spa y Masajes', 75.00, 'Servicio de spa con masajes relajantes y terapéuticos');
*/

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

create view Clientes as
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
