use master;
go
drop database if exists knjiznica;
go
create database knjiznica;
go
use knjiznica;

create table vlasnici(
sifra int not null primary key identity(1,1),
knjiga int
);

create table clanovi(
sifra int not null primary key identity(1,1),
cl_broj int
);

create table knjige(
sifra int not null primary key identity(1,1), 
naslov varchar(50) not null,
pisac varchar(50) not null, 
vlasnik int not null references vlasnici(sifra),
clan int not null references clanovi(sifra), 
datum_pos datetime,
datum_vrac datetime
);

create table osobe(
sifra int not null primary key identity(1,1), 
ime varchar(50) not null,
prezime varchar(50) not null,
adresa varchar(50),
email varchar(50)
);