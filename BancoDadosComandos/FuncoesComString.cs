=====================================================================================================
***TRIM
	select trim ('carros')
	-- retira os espacos
=====================================================================================================
***LOCATE
	select locate('C', 'Carros')
	-- localiza a letra que setei
=====================================================================================================
***CASE
	select lcase('Carros') -- transforma tudo em minusculo
	select ucase('Carros') -- transforma tudo em maiusculo	
=====================================================================================================
***Length
	select length('Carros') -- conta quantos caracteres tem
=====================================================================================================
***REPEAT	
	select repeat('Carros', 4) -- repete 4 vezes a palavra carro
=====================================================================================================
***RIGHT OU LEFT
	select left ('Carros', 4) -- mostra as 4 primeiras letras
	select right ('Carros', 4) -- mostras as 4 ultimas letras
