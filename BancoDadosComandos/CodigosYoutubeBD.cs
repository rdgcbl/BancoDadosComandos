
/*
--esses dois tracos é comentario no banco, // eh no MVE code

***Criar e Remover Banco de dados
	create database meubanco;
drop database meubanco;

***Usar um banco especifico, se eu tiver varios quero selecionar um banco para usar
	use meubanco;

***Criar e Remover tabela
	drop table minha tabela;
create table minha tabela(
	nome varchar(100)
);

***Tipos de dados
	texto = varchar(50)
	numeros = int(x)
	datas = date

create table pessoas(
	nome varchar(100),
	salario int,
	data_nascimento date
);

***Alterar tabela(alterar coluna) adicionar coluna profissao
		alter table pessoas add column profissao varchar(255);

***Para ver a tabela criada, colunas
	select * from pessoas;
se eu quero só o nome fica
	select nome from pessoas;

***Crud
 	C = create = Insert
	R = Read = Select(Where)
	U = Update = atualizar Sempre usar where
	D = Delete = deletar   Sempre usar where
	
	--Insira na tabela
	Insert into pessoas(nome, salario, data_nascimento, profissao)
	Values("Kipper", 12000, "1990-09-05", "programador");

***Pesquisar quem ganha mais que 5mil
	SELECT * FROM pessoas WHERE salario > 5000;

***Criar Constraints
	create table pessoas (
		id int primary key auto_increment not null,
		nome varchar(100),
		salario int,
		data_nascimento date,
		profissao varchar(100)
);

***Criar Constraints - relacao - foreign key - chave estrangeira
	create table enderecos (
		id int primary key auto_increment not null,
		rua varchar(255),
		numero varchar(10),
		pessoa_id int not null,
		foreign key (pessoa_id) references pessoas(id)
);

insert into enderecos (rua, numero, pessoa_id)
	values("rua tal", "12b", 1);

***JOIN - consulta
	--Inner join
	--Left join
	--Right join

	SELECT pessoas.nome, enderecos.* FROM pessoas INNER JOIN enderecos ON pessoas.id = enderecos.pessoa_id;

***Aggregation functions - unir resultados em um, ex: soma de todos salarios
	select sum(salario) from pessoas;


***Alias, serve para dar nome  ex:
	select sum(salario) from pessoas; (geito normal sem alias)
	select sum(salario) AS soma_dos_salarios from pessoas; (usando alias(AS) para ficar melhor o resultado)

***Count - quero contar qtas pessoas registradas tem
	select count(*) from pessoas; (modo normal)

	select count(*) AS qtde_pessoas from pessoas;

select count(*) AS qtde_programadores from pessoas 
     Where profissao = "programadores"; (ver quantos programadores que tem)

	select count(*) AS qtde_por_profissao from pessoas group by profissao; (ele mostra todas as profissoes e qtde quem tem)

***Concatenar funcao de texto e data
	SELECT CONCAT("O nome da pessoas pe: ", nome ", e ele ganha: R$", salario) AS descricao FROM pessoas;
SELECT YEAR(data_nascimento) AS mes_de_nascimento, DAY(data_nascimento) AS dia_de_nascimento FROM pessoas;






