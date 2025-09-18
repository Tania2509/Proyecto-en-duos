create database Hotel
go

use Hotel
go

create table Rol (
idRol int primary key identity (1,1),
nombreRol varchar(10)
);
go

create table Usuario (
idUsuario int primary key identity (1,1),
nombreUsu varchar(50),
apellidoUsu varchar(50),
dui varchar(8),
edad date,
id_Rol int,
foreign key (id_Rol) references Rol (idRol)
);
go

create table TipoHabitacion (
idTipo int primary key identity (1,1),
nombreTipo varchar(30)
);

create table Habitacion (
idHabitaciones int primary key identity (1,1),
precio decimal (10,2),
cantidad int,
id_Tipo int,
foreign key (id_Tipo) references TipoHabitacion (idTipo)
);
go

create table Cliente (
idCliente int primary key identity (1,1),
nombreCli varchar(50),
apellidoCli varchar(50),
duiCli varchar(8),
edadCli date,
telefono varchar (10),
Email varchar(50)
);
go

create table MetodoPago (
idPago int primary key identity (1,1),
nombreMetodo varchar(10)
);

create table Reserva (
idReserva int primary key identity (1,1),
fechaReservacion date,
id_Pago int,
id_Habitacion int,
id_Cliente int,
foreign key (id_Pago) references MetodoPago (idPago),
foreign key (id_Habitacion) references Habitacion (idHabitaciones),
foreign key (id_Cliente) references Cliente (idCliente)
);
go

create table Servicio (
idServicio int primary key identity (1,1),
nombreServicio varchar(30),
precio decimal (10,2)
);
go
