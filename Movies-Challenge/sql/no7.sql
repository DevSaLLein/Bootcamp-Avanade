SELECT 
	Ano, COUNT(Id) Quantidade
FROM Filmes
GROUP BY Ano
ORDER BY Quantidade DESC