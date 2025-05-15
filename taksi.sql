use master;
go
drop database if exists taksi;
go
create database taksi;
go
use taksi;

create table vozaci(
sifra int not null primary key identity(1,1),
ime varchar(50),
prezime varchar(100),
broj_tel varchar(50)
);

create table vozila(
sifra int not null primary key identity(1,1),
broj_reg varchar(10),
vozac int not null references vozaci(sifra)
);

create table putnici(
sifra int not null primary key identity(1,1),
ime varchar(50),
prezime varchar(100),
broj_tel varchar(50)
);

create table voznje(
sifra int not null primary key identity(1,1),
vrij_pocetka datetime,
vrij_zavrsetka datetime,
cijena decimal(18,2)
);

create table putnici_voznje(
putnik int not null references putnici(sifra),
voznja int not null references voznje(sifra)
);