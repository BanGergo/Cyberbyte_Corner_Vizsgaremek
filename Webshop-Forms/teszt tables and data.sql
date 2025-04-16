create table termek(
cikkszam int primary key not null,
img_id int not null,
nev varchar(255) not null unique,
keszlet int not null default 0,
netto int not null,
kedv tinyint not null default 0,
kat_id int not null,
gyarto_id int not null,
leiras_id int not null
);

select * from termek order by termek.nev asc;

insert into termek(cikkszam,img_id,nev,keszlet,netto,kedv,kat_id,gyarto_id,leiras_id) value
(66666666,1,"Alaplap 8",50,19500,0,1,1,1),
(77777777,2,"termék 6",10,1500,0,2,2,1),
(88888888,3,"SSD 5",25,13490,0,3,3,3),
(99999999,4,"termék 7",2,19999,0,4,4,1),
(10101010,5,"Videokártya 6",1,500,0,5,5,5);

create table kategoria(
kat_id int primary key auto_increment,
nev varchar(255) not null
);

insert into kategoria(nev) values
('Processzor'),
('Videokártya'),
('Alaplap'),
('Memória (RAM)'),
('SSD'),
('Tápegység'),
('Számítógép ház'),
('Számítógép hűtő'),
('Processzorhűtő'),
('Periféria'),
("Merevlemez (HDD)"),
("Egyéb");

create table gyarto(
gyarto_id int auto_increment primary key,
nev varchar(255) not null
);

insert into gyarto(nev) values
('Intel'),
('AMD'),
('ASUS'),
('MSI'),
('Gigabyte'),
('ZOTAC'),
('EVGA'),
('ASRock'),
('Kingston'),
('Corsair'),
('G.Skill'),
('Crucial'),
('Samsung'),
('Western Digital'),
('Seagate'),
('Seasonic'),
('Cooler Master'),
('Be Quiet!'),
('Lian Li'),
('NZXT'),
('Fractal Design'),
('Phanteks'),
('Thermaltake'),
('SilverStone'),
('Noctua'),
('be quiet!'),
('Logitech'),
('Razer'),
('SteelSeries'),
('HyperX'),
('Arctic');
