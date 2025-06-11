use master;
go
drop database if exists ordinacija;
go
create database ordinacija;
go
use ordinacija;

create table doktori(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
specijalizacija varchar(50) not null
);

create table pacijenti(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
dat_rodjenja datetime,
kontakt varchar(50)
);

create table posjeti(
sifra int not null primary key identity(1,1),
datum datetime not null,
dijagnoza varchar(100) not null,
terapija varchar(100) not null,
doktor int not null references doktori(sifra),
pacijent int not null references pacijenti(sifra)
);

create table med_sestre(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null
);