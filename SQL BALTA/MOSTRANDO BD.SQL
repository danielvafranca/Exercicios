CREATE OR ALTER VIEW vwCourses AS --[4] Coloquei uma view para nao ficar reescrevendo o codigo
    SELECT 
        [Course].[Id], -- [2] tivemos que especificar de onde vem o id, tag title e etc. pois fizemos a junção das tabelas curso e categoria e os 2 tem esses campos
        [Course].[Tag],
        [Course].[Title],
        [Course].[Url],
        [Course].[Summary],
        [Category].[Title] AS [Category], --[1:1] Mudei o nome de titulo para categoria
        [Author].[Name] AS [Author] --[3:1]
    FROM
        [Course]
        INNER JOIN [Category] ON [Course].[CategoryId] = [Category].[Id] -- [1] ESTOU JUNTANDO O CURSO COM CATEGORIA ONDE O PONTO DE REFERENCIA CURSO. CATEGORIAID SEJA IGUAL A CATEGORIA ID
        INNER JOIN [Author] ON [Course].[AuthorId] = [Author].[Id] -- [3] Fiz mais uma junçao de tabela  declarei no select
    WHERE
        [Active] = 1 -- onde os cursos estao ativados
   -----------------------------------------------------Utilizando a VIEW NA NOVA QUERY----------------------------------------------------------------------------------

SELECT 
    * 
FROM 
    vwCourses
ORDER BY
    [CreateDate] DESC

