-- CRIANDO O BANCO DE DADOS
CREATE DATABASE BDHamburgueria;

-- USANDO O BANCO DE DADOS
USE  BDHamburgueria;

-- CRIANDO AS TABELAS DO BANCO DE DADOS
CREATE TABLE tbPedidoo(
	codPedido int primary key auto_increment,
    tipoHambúrger varchar(50),
    valorHambúrger varchar(50),
    valorOpcao varchar(50),
    valorTotal varchar(50)
);

-- CONSULTANDO A TABELA DO BANCO DE DADOS

SELECT * FROM tbPedidoo;