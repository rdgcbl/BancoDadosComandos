=====================================================================================================
***EXERCISE * **********************
   1 - Criar um usuario que possa acessar de qualquer lugar.
   2- mostrar quais sao as permissoes desse user
   3- inserir  as permissoes select, insert e update
   4- remover a permissao update
   5- mostrar o resultado total de todos os usuarios

	create user priscila identified by '1234';

show grants for priscila;

grant select, insert, update
	on sakila.*
	to priscila;

revoke update
	on sakila.*
	from priscila;

select* from mysql.user;
=====================================================================================================
***Criar os usuariose seleciona-los
	create user ana identified by '1234'; -- acesso de qualquer lugar total
	create user joao@localhost identified by '1234'; -- acessa atraves do localhost, empresa
	create user priscila@andreiacono.com identified by '1234'; -- acessa atraves do dominio site
	select * from mysql.user -- verificar quais sao os usuarios
=====================================================================================================
***Removendo os usuarios
	drop user priscila@andreiacono.com;
=====================================================================================================
***Recuperar uma senha do usuario ou alterar senha
	set password;   --assim eu troco a minha senha de acesso
	set password for joao@localhost = '4444'; --troco a senha do joao
	select * from mysql.user -- verifica quais sao os usuarios
	--workbench/administration
=====================================================================================================
***Como adicionar os privilegios
	grant select, insert, update, delete
	on sakila.*             -- para todas as tabelas sakila
	to ana;                 -- para usuario ana

	show grants for ana;    --serve para mostrar as permissoes da ana
				-- select * from mysql.user;
=====================================================================================================
***Adicionando um ADMIN da database sakila
	grant all               -- para adc admin somenta na sakila
	on sakila.*             -- para todas as tabelas sakila
	to ana;                 -- para usuario ana

	show grants for ana;    --serve para mostrar as permissoes da ana
				--select * from mysql.user;
=====================================================================================================
***Adicionando um ADMIN em todo MYSQL
	grant all               -- para adc admin em todo o MYSQL
	on *.*                  -- para todas as tabelas e database do MYSQL
	to joao@localhost;      -- para usuario joao

	show grants for joao@localhost;    --serve para mostrar as permissoes do joao
				-- select * from mysql.user;
=====================================================================================================
***Removendo os Privilegios
	revoke update
	on sakila.*
	from priscila;

