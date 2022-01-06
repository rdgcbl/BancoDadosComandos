=====================================================================================================
***Inserir um idioma(Portugues) na tabela 'LANGUAGE'
	use SAKILA;
	insert into language
	values(default, "Portuguese", "2021/12/23 16:18:23")
	      (default, "Spanish", "2021/12/23 17:18:23")
=====================================================================================================
***adicionar um novo pais e uma cidade
	use sakila;
	insert into country
	values
		(default,'Brasil33', '2035-02-15 04:44:00');

	insert into city
	values
		(default,'Sao Paulo33', last_insert_id(), '2034-02-15 04:44:00')
		//last insert id quer dizer que ele vai pegar o ultimo FK da outra tabela,
		//e o default ele pega o ultimo PK
=====================================================================================================
***Copiar uma tabela completa ( Fazer Backup)
	create table payment_backup as
	select * from payment
=====================================================================================================
***Deletar uma tabela completa
	drop table payment_backup
***Deletar apenas os dados da tabela
	truncate table payment_backup
=====================================================================================================
***Atualizar um registro dentro de uma tabela
	update payment
	set
	amount = 15.99
	where payment_id = 1
=====================================================================================================
***Deletando um registro da tabela
	delete from language
	where language_id = 8
	
=====================================================================================================
***Deletando um banco de dados
	drop database sakila
=====================================================================================================
***Importando um banco de dados
	clica em open sql script....
	abra o shcema primeiro
	em seguida abra o data
=====================================================================================================
***Deletar apenas a coluna idade da tabela clientes
	alter table clientes drop idade
