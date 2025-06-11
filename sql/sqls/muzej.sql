use master;
go
drop database if exists muzej;
go
create database muzej
go
use muzej

create table izlozbe(
sifra int not null primary key identity(1,1),
naziv varchar(100) not null,
trajanje datetime,
);

create table djela(
sifra int not null primary key identity(1,1),
naziv varchar(100) not null,
autor varchar(100) not null,
izlozba int not null references izlozbe(sifra)
);

create table kustosi(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(100) not null
);

create table sponzori(
sifra int not null primary key identity(1,1),
naziv varchar(100) not null,
);