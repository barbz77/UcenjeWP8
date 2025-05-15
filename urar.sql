use master;
go
drop database if exists urar;
go
create database urar;
go
use urar;

create table korisnici(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(100) not null,
);

create table popravci(
sifra int not null primary key identity(1,1),
naziv varchar(100),
cijena decimal(18,2) not null,
opis_kvara varchar(200)
);

create table segrti(
sifra int not null primary key identity(1,1),
ime varchar(50),
prezime varchar(100),
);

create table satovi(
sifra int not null primary key identity(1,1),
vrsta varchar(50),
model varchar(50),
ser_broj varchar(50),
korisnik int not null references korisnici(sifra)
);

create table popravci_satova(
sat int not null references satovi(sifra),
popravak int not null references popravci(sifra)
);