=====================================================================================================
***OPERADORES E SIGNIFICADOS
	AND = E 	OR = OU		NOT = NÃO 	'|' = 'e' 	'<>' = 'diferente' ou '!='
	IN = posso usar varias coisas na mesma linha, ex: em baixo
	BETWEEN = entre um valor e o outro
		  utilizado para puxar uma range que esta dentro de inicio e fim
 	LIKE = "A%" seleciona as letras que comecam com 'A', % continua o nome
	IS NULL = mostra o que é null
	LIMIT = consulta linha
	REGEXP = mix de varias expressoes, resultados simples, consulta letras iniciais
	^a = inicia em 'a'
	order by = consulta em ordem crescente where informar(para decrescente = desc)
	AS = serve para dar nomes
=====================================================================================================
***Consultar a tabela payment, aonde o staff_id é igual a 1 e o amount tem que ser 0.99
   e o cliente tem que ter o id menor que 10.
	SELECT * FROM payment
	WHERE staff_id = 1 AND amount = 0.99 AND customer_id < 10
=====================================================================================================
***Consultar 3 cidade no mesmo comando IN
	select * from address
	where district in ("Texas","Alberta", "California")
=====================================================================================================
***Consultar todos os clientes inativos da loja 1
	select * from customer
	where store_id = 1 and active = 0
=====================================================================================================
***Consultar o valor entre 1.99 e 3.99, pode ser feito por 'Between' ou 'AND'
	select * from payment	
	where amount BETWEEN 1.99 and 3.99     OU
	
	where amount >=1.99 and amount <=3.99 (FORMA COMPLICADA)
=====================================================================================================
***Selecionar a coluna ID da tabela Actor
	SELECT actor_id FROM actor;		//seleciona o id da coluna actor
	SELECT actor_id, first name FROM actor; //seleciona id e name da tabela 'actor
	SELECT * FROM actor; 			//seleciona todas as colunas da tabela 'actor'
=====================================================================================================
***Selecionar por ordem alfabetica
	SELECT actor_id, first name, last_name FROM actor ORDER BY first_name
	//selecionou o id, primeiro nome, ultimo nome apartir da tabela actor, deu o ordem by
	//para por ordem alfabetica na coluna first_name.
=====================================================================================================
***Selecionar os 10 primeiros ID
	select actor_id,first_name,last_name
	from actor
	where actor_id < 10
	-- order by last_name (linha comentada)
=====================================================================================================
***Modificar uma coluna
	select customer_id, 
	amount,
	amount - (amount * 0.10) as "10% discount"
	from payment
	where customer_id = 1
	//selecionou o id, e o montante, apartir da tabela pagamento, aonde o id é 1
	// depois mostrei o id, o montante, e o montante com desconto de 10%
	// 'as' serve para inserir um nome em alguma coluna, trocar nome
=====================================================================================================
***Consultar quem gasta mais
	select * from payment
	order by amount desc
	//seleciono tudo da tabela pagamento e dou um order by para ver quem tem o montante mais
	caro com o codigo (desc)
=====================================================================================================
***Consultar a cidade de california por ordem do ID
	select * from address
	where district = "california"
	order by address_id
=====================================================================================================
********payment		pagamento
	customer	cliente
	staff		funcionario
	rental		aluguel
	amount		montante
	last update	ultima atualizacao
=====================================================================================================
***Selecionar todos os atores que iniciam com a letra 'A' e que finalizam com 'O'.
	select * from actor
	where first_name like "A%"
	where first_name like "%O"
	//porcentagem quer dizer que o nome continua apos o 'A'.
=====================================================================================================
***Consulta a coluna address2 e mostra somente os campos null
	select * from address
	where address2 is null
=====================================================================================================
***COnsultar registro do 5 ao 15 usando LIMIT
	select * from actor
	limit 5,10
=====================================================================================================
	--REGEXP--
***Consultar primeiro nome que iniciam com a letra A,R,D
	select * from actor
	where first_name
	regexp "^a|^d|r"           '|' = 'e'
*Filtras com letra A
	select * from actor
	where first_name
	regexp "a"

