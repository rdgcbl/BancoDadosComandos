=====================================================================================================
***	AVG () - Retorna o valor médio
	COUNT () - Retorna o número de linhas
	FIRST () - Retorna o primeiro valor
	LAST () - Retorna o último valor
	MAX () - Retorna o maior valor
	MIN () - Retorna o menor valor
	SUM () - Retorna a soma
=====================================================================================================
***Listar o MAX(), MIN(), AVG(), SUM(), COUNT(), e ver qual dos vendedores vendeu mais.
	select 
		max(amount) as Maior,
    		min(amount) as Menor,
    		avg(amount) as Media,
    		sum(amount) as 'Total de Vendas',
    		count(amount) as 'Numero de Vendas'
	from payment
	where staff_id = 1
=====================================================================================================
***Mostrar em um simples relatorio, quanto o cliente 1 gastou, cliente 2 etc.......
e depois eu ordenei de forma decrescente os valores
	select 
		customer_id.
    		sum(amount) as total,
	from payment
	group by customer_id
	order by total desc
	
	
=====================================================================================================
***GROUP BY customer_id;
	
	O 'group by' Serve para mostrar todos os cliente da coluna customer_id
	
=====================================================================================================
***Estou selecionando a coluna customer id, firstname, lastname e estou usando uma função soma
para trazer os resultados da coluna amount que seria os valores gastos pelos clientes, tudo isso 
de duas tabelas, payment e customer. usando o join para interligar as duas tabelas e um ELIAS
para dimunuir o tamanho. depois um group na customerID para mostrar todos os id e nao só um.
e finalando com um order by desc, para mostrar valores amount decrescente.

	use sakila;

	select 
		cus.customer_id as ID,
    		cus.first_name as Nome,
    		cus.last_name as Sobrenome,
    		sum(amount) as Total
	from payment pay
	join customer cus using(customer_id) 	-- interliga duas tabelas 'join'

	group by customer_id	 -- informa todos os id que tem nessa coluna
	order by Total desc; 	-- coluna amount fica em ordem decrescente
=====================================================================================================
***Filtrando os valores, quem gastou mais de 150,00 fornecer uma lista com ID, nome,Sobrenome, total
tem que ser maior ou = a 150,00 e o total de compras por cliente que gastaram mais de 150,00
	select 
		cus.customer_id as ID,
    		cus.first_name as Nome,
    		cus.last_name as Sobrenome,
    		sum(amount) as Total,
   	 count(amount) as Compras
    
	from payment pay
	join customer cus using(customer_id) -- interliga duas tabelas 'join'

	group by customer_id -- informa todos os id que tem nessa coluna
	having Total >= 150 and Compras >=35 	-- having no lugar de where por causa da sequencia
	order by Total desc; -- coluna amount fica em ordem decrescente
