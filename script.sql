create database BDFloricultura;

use BDFloricultura;

create table tbPedido(
codPedido int primary key auto_increment,
tipoBuque varchar(50),
valorBuque varchar(50),
valorOpcao varchar(50),
valorTotal varchar(50)
);

select * from tbPedido;