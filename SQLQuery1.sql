create table USUARIO(
usuario_id    int identity PRIMARY KEY NOT NULL,
usuario_nombre  varchar(40) NOT NULL,
usuario_correo  varchar(40) NOT NULL,
usuario_pass  varchar(40) NOT NULL)


create table PRODUCTO(
producto_id    int identity PRIMARY KEY NOT NULL,
producto_nombre  varchar(40) NOT NULL
)

create table DESPENSA(
despensa_id int identity PRIMARY KEY NOT NULL,
producto_id int,
desp_cant_prod int,
usuario_id int,
CONSTRAINT FK1 FOREIGN KEY (producto_id) references PRODUCTO(producto_id),
CONSTRAINT FK2 FOREIGN KEY (usuario_id) references USUARIO(usuario_id))


insert into USUARIO values('Pedro','pedro@despman.cl','1234');
insert into USUARIO values('Ismael','ismael@despman.cl','1234');
insert into USUARIO values('Ricardo','ricardo@despman.cl','1234');
insert into USUARIO values('Fabian','fabian@despman.cl','1234');
insert into USUARIO values('Marta','marta@despman.cl','1234');

insert into PRODUCTO values('ARROZ');
insert into PRODUCTO values('FIDEOS');
insert into PRODUCTO values('POROTOS');
insert into PRODUCTO values('HARINA');
insert into PRODUCTO values('ATUN');
insert into PRODUCTO values('SAL');

insert into DESPENSA values(1,5,1);
insert into DESPENSA values(2,10,1);
insert into DESPENSA values(3,3,1);
insert into DESPENSA values(4,7,1);
insert into DESPENSA values(5,4,1);
insert into DESPENSA values(6,2,1);


insert into DESPENSA values(6,7,2);
insert into DESPENSA values(5,9,2);
insert into DESPENSA values(4,4,2);
insert into DESPENSA values(3,6,2);
insert into DESPENSA values(2,3,2);
insert into DESPENSA values(1,5,2);