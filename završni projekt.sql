use master;
go
drop database if exists preporucitelj;
go
create database preporucitelj;
go
use preporucitelj;

create table igrice(
sifra int not null primary key identity(1,1),
naziv varchar(100) not null,
ocjena decimal(3,1) not null,
godina_izdanja datetime not null
);

create table zanrovi(
sifra int not null primary key identity(1,1),
naziv varchar(100) not null
);

create table platforme(
sifra int not null primary key identity(1,1),
naziv varchar(100) not null
);

create table igrice_zanrovi(
igrica int not null references igrice(sifra),
zanr int not null references zanrovi(sifra)
);

create table igrice_platforme(
igrica int not null references igrice(sifra),
platforma int not null references platforme(sifra)
);