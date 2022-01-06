=====================================================================================================
in = dentro
any = qualquer

SUBQUERIES = é uma querie secundaria dentro de outra querie ex:

***Utilizando uma subqueries
	select amount 
	from payment
	where amount >(
	select avg(amount) 
	from payment)
    
--seleciona a coluna amount apartir da tabela payment, aonde o amount é maior que
-- a media geral do precos do amount.
-- fiz uma subqueries aqui selecionanto a media do amount apartir da tabela payment
=====================================================================================================
***Trabalhando com o MAX
	select c.customer_id,
	  	c.first_name,
       		c.last_name,
       		p.payment_id,
       		p.amount,
       		p.payment_date,
       		p.last_update   
	from payment p
	join customer c using(customer_id)
	where amount = (
	select max(amount) 
	from payment)

-- selecionei as colunas e depois usei o join para interligar
-- depois fiz uma subquerie para mostrar o resultado amount tem que ser igual
-- selecionei todos os valores maximos da coluna amount da tabela payment

=====================================================================================================
***Verificar a quantidade de compras que cada cliente faz
	select customer_id, count(*) as Compras -- essa opcao serve para contar todos os registros
	from payment
	group by customer_id -- essa opcao mostra todos os clientes id existentes
	having count(*) > 35 -- colocando um filtro, só vai mostrar os maiores de 35 

***aqui ele mostra o nome de quem fez mais que 35 compras
	select * 
	from customer
	where customer_id in(
		select customer_id
		from payment
		group by customer_id -- essa opcao mostra todos os clientes id existentes
		having count(*) > 35 -- colocando um filtro, só vai mostrar os maiores de 35 
=====================================================================================================
***Utilizando IN
	select * 
	from customer
	where customer_id = any( -- igual a qualquer um la dentro da subquerie
		select customer_id
		from payment
		group by customer_id -- essa opcao mostra todos os clientes id existentes
		having count(*) > 35 -- colocando um filtro, só vai mostrar os maiores de 35

