=====================================================================================================
***Listar todos os cliente e quanto que eles gastaram na tabela payment
	Create or replace view vendas_por_cliente as 
	select 
		c.customer_id,
    		c.first_name,
    		c.last_name,
    	p.amount
	from customer c 
	join payment p
	on c.customer_id = p.payment_id
=====================================================================================================
***'Create or replace view' = aqui eu crio uma view e posso altera-la sem precisar deletar, ao contrario
   de
   'Create view' = crio uma ves e para alterar tenho que deletar e refaze-la
