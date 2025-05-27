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


insert into igrice (naziv, ocjena, godina_izdanja) values
('The Witcher 3: Wild Hunt', 9.7, '2015-05-19'),
('Red Dead Redemption 2', 9.7, '2018-10-26'),
('Grand Theft Auto V', 9.5, '2013-09-17'),
('Cyberpunk 2077', 8.5, '2020-12-10'),
('Elden Ring', 9.5, '2022-02-25'),
('The Legend of Zelda: Breath of the Wild', 9.7, '2017-03-03'),
('God of War (2018)', 9.4, '2018-04-20'),
('Spider-Man: Miles Morales', 8.7, '2020-11-12'),
('Horizon Zero Dawn', 9.0, '2017-02-28'),
('Minecraft', 9.3, '2011-11-18');

insert into zanrovi (naziv) values
('RPG'),
('Action'),
('Adventure'),
('Open World'),
('FPS'),
('Fantasy'),
('Sci-Fi'),
('Horror'),
('Building'),
('Survival');

insert into platforme (naziv) values
('PC'),
('PlayStation 4'),
('PlayStation 5'),
('Xbox One'),
('Xbox Series X/S'),
('Nintendo Switch');

