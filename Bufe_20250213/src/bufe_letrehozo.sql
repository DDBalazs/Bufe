create table forgalom(
sorszam varchar(4) not null primary key,
termek varchar(20) not null,
vevo varchar(20) not null,
menny int not null default 1,
brutto int not null,
datum date not null
);
insert into forgalom(sorszam,termek,vevo,menny,brutto,datum)
values
("246","hot-dog","Lajos",4,850,"2017-10-18"),
("268","virsli","Béla",8,600,"2022-01-14"),
("275","limonádé","Lajos",6,200,"1999-02-08"),
("321","gyros","Béla",6,1400,"2016-03-05"),
("468","ízes palacsinta","Éva",10,250,"2020-01-15");