=====================================================================================================
***Criando a tabela marcas
	create table  marcas (
	id int not null auto_increment,
    	nome_marca varchar(255) not null,
    	primary key (id)
    	);
=====================================================================================================
***Alterar uma tabela, ou Inserir uma coluna na tabela
	create table  marcas (
	id int not null auto_increment,
    	nome_marca varchar(255) not null,
    	primary key (id)
    	); 
	alter table marcas add origem varchar(255) not null;	 <<<<<<<-----------
=====================================================================================================
***Adicionar uma nova tabela com foreign key (chave estrangeira)
	create table inventario (
	id int not null auto_increment,
    	modelo varchar(255) not null,
    	transmissao varchar(255) not null,
	motor varchar(255) not null,
    	combustivel varchar(255) not null,
   	cor varchar(255) not null,
	marcas_id int not null,
    	primary key (id),
    	foreign key (marcas_id) references  marcas(id)
	);
=====================================================================================================
***Criando uma tabela clientes
	create table clientes (
	id int not null auto_increment,
    	nome varchar(255) not null,
    	sobrenome varchar(255) not null,
	endereço varchar(255) not null,
    	primary key (id)
