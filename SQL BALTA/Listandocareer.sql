CREATE OR ALTER VIEW vwCareers AS
    SELECT 
        [Career].[Title] AS [Curso],
        [Career].[Id],
        [Career].[Url],
        COUNT([Id]) AS [QTD.] -- [1] PARA CONTAR QUANTOS OS ITENS TEM EM CADA CARREIRA
        
    FROM
        [Career]
        INNER JOIN [CareerItem] ON [CareerItem].[CareerId] = [Career].[Id] --[2] junçao de tabelas carreira com o carreiraitem
    GROUP BY 
        [Career].[Title],-- [3] Sempre que usamos um cont, min, max utilizamos o GROUP BY E REPETIMOS AS INFORMAÇÕES DO SELECT
        [Career].[Id],
        [Career].[Url]
        
-- CHAMADNO A VIEW NA NOVA QUERY
SELECT * FROM vwCareers