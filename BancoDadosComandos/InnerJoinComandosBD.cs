====================================================================================================
***Join coloca informação de duas tabelas em um resultado
	select * from customer
	join payment 
	on customer.customer_id = payment.payment_id 	
=====================================================================================================
***Usando Join, quero consultar duas tabelas na mesma linha de codigo e com as colunas especificas
   vou escolher algumas colunas de cada tabela
	
	select 
        	customer.customer_id,
        	customer.first_name, 
        	customer.last_name,
        	payment.rental_id, 
        	payment.amount
	from customer
	join payment on customer.customer_id = payment.payment_id
	
	//select,selecionou as tabelas customer...e payment... from,apartir da tabela customer
	//join,junte com a tabela payment on,se custumerid tem que ser igual paymenteid

***Adicionando 'ALIAS' seria uma abreviação
	
	select 
        	cus.customer_id,
        	cus.first_name, 
        	cus.last_name,
        	pay.rental_id, 
        	pay.amount
	from customer cus  ***
	join payment pay on cus.customer_id = pay.payment_id

***Adicionado mais uma tabela, usando JOIN

	select 
       	 	cus.customer_id,
        	cus.first_name, 
        	cus.last_name,
        	adr.address,				***
        	pay.rental_id, 
        	pay.amount
	from customer cus
	join payment pay 
    		on cus.customer_id = pay.payment_id
	join address adr 				***
    		on cus.customer_id = adr.address_id	***

***Adicionando Left and Right no JOIN
	//se eu colocar o left, ele mostra todos que tem do lado esquerdo, mesmo se for null
	//no lado direito, 
	//e seu colocar o right ele mostra todos os resultados no lado direito mesmo se
	//o lado esquerdo for null
	ex:
	left join address adr 				
    		on cus.customer_id = adr.address_id
	//ele vai mostrar tudo que tem no custumer, mesmo se for null o adress	
=====================================================================================================
***Adicionando UNION, imprimir na tela os dois select, com a mesma linha de comando
mostrando os valores 10.99 vip, e menor para os non vip
	
=====================================================================================================
EXERCICIO:
1- Consultar as tabelas customer, coluna id,first name e last name. Payment, coluna id e amount.
usando o 'Alias' para rename as table. depois usar o Union para pesquisar vip e non vip
vip quem paga mais de 10,00 e non vip abaixo de 10reais

	select  
        	cus.customer_id,
        	cus.first_name,
        	cus.last_name,
        	pay.payment_id,
        	pay.amount,
        	"VIP" as status //AQUI EU CRIEI UMA VISUALIZAÇÃO DA COLUNA STATUS COM O RESULTADO VIP
	from customer cus
	join payment pay on cus.customer_id = pay.payment_id 
	where pay.amount >= 10


	UNION

	select  
        	cus.customer_id,
        	cus.first_name,
        	cus.last_name,
        	pay.payment_id,
        	pay.amount,
        	"NON VIP" as status  //AQUI EU CRIEI UMA VISUALIZAÇÃO DA COLUNA STATUS COM O RESULTADO NON VIP
	from customer cus
	join payment pay 
	on cus.customer_id = pay.payment_id 
	where pay.amount < 10
=====================================================================================================
******Estou selecionando a coluna customer id, firstname, lastname e estou usando uma função soma
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
