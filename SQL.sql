--Criar BANCO DE DADOS---------------------------------------------------------------------
CREATE DATABASE[Curso]-- and run

-- To Drop the database. because if i try write DROP DATABASE[Name]( i wont make it, because i'm using)

USE [master];

DECLARE @kill varchar(8000) = '';  
SELECT @kill = @kill + 'kill ' + CONVERT(varchar(5), session_id) + ';'  
FROM sys.dm_exec_sessions
WHERE database_id  = db_id('Curso')

EXEC(@kill);

DROP DATABASE [Curso]
---- Ao usar atentese nos nome USE [] ,  db_id('Curso') , DROP DATABASE [Curso], Para conseguir excluir
---- Creat table---------------------------------------------------------------------------
USE[Course] 
CREATE TABLE[Aluno]
(
    [Id] INT NOT NULL UNIQUE,--NÃO VAI SER NULO E VAI SER UNICO
    [Name] NVARCHAR(80) NOT NULL,
    [Email] NVARCHAR(180) NOT NULL UNIQUE,
    [Nascimetno] DATETIME NULL,
    [Active] BIT  DEFAULT(0),
)
GO
----Esqueceu de alterar ou adicionar algo --------------------------------------------
USE [Course]

ALTER TABLE [Aluno]  ---- ADICIONAR COLUNA
    ADD [Document] NVARCHAR(11)

ALTER TABLE[Aluno]---- REMOVER COLUNA
    DROP COLUMN [Dpciment]

    
ALTER TABLE [Aluno]----I changed NUL to NOT NULL (SE JA TIVER ALGUM DADO DENTRO E ESTIVER NULO, VAI FALHAR POIS NAO CONVERTE A LINHA)
    ALTER COLUMN [Active]BIT NOT NULL    
----------------------------------- LIGANDO TABELAS E USANDO REFERENCIA------------------------------------

USE [Course]

DROP TABLE[Aluno]

CREATE TABLE[Aluno]
(
    [Id] INT NOT NULL,
    [Name] NVARCHAR(80) NOT NULL,
    [Email] NVARCHAR(180) NOT NULL UNIQUE,
    [Nascimetno] DATETIME NULL,
    [Active] BIT  DEFAULT(0),

    CONSTRAINT [PK_Aluno] PRIMARY KEY([Id]),
    CONSTRAINT [UQ_Aluno_Email] UNIQUE([Email])
)
GO

DROP TABLE[Curso]
CREATE TABLE[Curso]
(
    ----[Id] INT NOT NULL IDENTITY(1, 1),---- fAZ UM INCREMENTO DE 1 EM 1 QUANDO ADICIONAR UM NOVO CURSO PARA NUMEROS INTEIROS.
    [Id] UNIQUEIDENTFIER NOT NULL ,---- fAZ UM INCREMENTO DE 1 EM 1 QUANDO ADICIONAR UM NOVO CURSO PARA NUMEROS REAIS
    [Name] NVARCHAR(80) NOT NULL,
    [CategoriaId] INT NOT NULL,
    
    CONSTRAINT [PK_Curso] PRIMARY KEY([Id]),
    CONSTRAINT [FK_Curso_Categoria] FOREIGN KEY([CategoriaId])
        REFERENCES [Categoria]([Id])
)
GO

CREATE TABLE[Categoria]
(
    [Id] INT NOT NULL,
    [Name] NVARCHAR(80) NOT NULL,
    
    CONSTRAINT [PK_Categoria] PRIMARY KEY([Id]),   
)
GO



CREATE TABLE[ProgressoCurso]
(
    [AlunoId] INT NOT NULL,
    [CursoId] INT NOT NULL,
    [Progresso] INT NOT NULL,
    [UltimaAtualizaçao]DATETIME NOT NULL DEFAULT(GETDATE()),
    
    CONSTRAINT PK_ProgressoCurso PRIMARY KEY([AlunoId],  [CursoId])
)
GO
---- Criar indices nas colunas que mais utilizo------------------------------------------------------------------
CREATE INDEX[IX_Aluno_Email] ON [Aluno]([Email])


DROP INDEX[IX_Aluno_Email] ON [Aluno]
----   INSERIR DADOS NA TABELA---------------------------------------------------------------------------
INSERT INTO [Categoria](Name) VALUES('Backend')-- Insira na tabela categoria 'Backend'
INSERT INTO [Categoria](Name) VALUES('Frontend')
INSERT INTO [Categoria](Name) VALUES('Mobile')

INSERT INTO[Curso]([Name], [CategoriaId]) VALUES('Fundamentos de c#', 1)
INSERT INTO[Curso]([Name], [CategoriaId]) VALUES('Fundamentos de OOP', 1)
INSERT INTO[Curso]([Name], [CategoriaId]) VALUES('Angular', 2)
INSERT INTO[Curso]([Name], [CategoriaId]) VALUES('Flutter', 3)

----SELECT-------------

----NAO USAR
SELECT *
FROM
    [Categoria]

----NAO USAR
SELECT 2 *
    [Id],[Name]
FROM
    [Categoria]

----USAR
SELECT TOP 100
    [Id],[Name]
FROM
    [Categoria]

----SE EU QUISER SÓ OS DIFERENTES(NAO MOSTRA OS IGUAIS)
SELECT DISTINCT TOP 100
    [Name]
FROM
    [Categoria]



SELECT TOP 100
    [Id], [Name], [CategoriaId]
FROM
    [Curso]
WHERE
    [Id] != 2 AND
    [CategoriaId] != 3 
------------------------------------
SELECT TOP 100
    [Id], [Name], [CategoriaId]
FROM
    [Curso]
WHERE
    [Id] != 2 OR
    [CategoriaId] IS NULL

---- Posso usar o IS E IS NOT

-- -- POR ORDEM USANDO ORDER BY ------------------
SELECT TOP 100
    [Id], [Name], [CategoriaId]
FROM
    [Curso]
-- WHERE
--     [CategoriaId] =1 
ORDER  BY
    [Name] ASC -- ASCENDENTE OU DESCENDENTE
----- update
SELECT * FROM [Categoria]

SELECT * FROM [Categoria]

BEGIN TRANSACTION
    UPDATE
        [Categoria]
    SET
        [Name] = 'Mobile'---- SE QUISER ALTERAR OUTRO CAMPO BASTA , EX[Id]
    WHERE
        [Id] = 3
ROLLBACK
--COMMIT
--Usar o COMMIT quando tiver certeza que alterou apenas o que queria


-- ---- DELETE INFORMACAO
SELECT * FROM [Categoria]

BEGIN TRANSACTION
    DELETE
        [Categoria] 
    WHERE
        [Id] = 3
ROLLBACK
---- Usar o COMMIT quando tiver certeza que alterou apenas o que queria

SELECT TOP 100
    MIN([Id])-- MAX, COUNT - CONTA QUANTOS ITENS TEM, AVG - TIRAR A MEDIA, - SUM - SOMA A COLUNA
FROM
    [Curso]

-- Colocar apelido com Alias


SELECT TOP 100
    [Id] AS [Identify],
    [Name]
FROM
    [Curso]
-- O Id ganha o apelido de Identify

----------- Joins
--INNER JOINS - junção de tabelas
SELECT TOP 100
    [Curso].[Id],
    [Curso].[Name],
    [Categoria].[Id] AS [Categoria],
    [Categoria].[Name]
FROM
    [Curso]
    INNER JOIN [Categoria]
        ON [Curso].[CategoriaId] = [Categoria].[Id]

    INNER JOIN [TabelaY]
        ON [Curso].[CategoriaId] = [Categoria].[Id]
---- Selecione tudo de curso juntando categoria onde o curso.categoria será igual a categoria.id e mude o nome de categoria id para categoria.( posso junta mais joiins)
SELECT TOP 100
    [Curso].[Id],
    [Curso].[Name],
    [Categoria].[Id] AS [Categoria],
    [Categoria].[Name]
FROM
    [Curso]
    LEFT JOIN [Categoria]
        ON [Curso].[CategoriaId] = [Categoria].[Id]
-- LEFT / RIGHT/ FULL OUTER 
SELECT TOP 100
    [Curso].[Id],
    [Curso].[Name],
    [Categoria].[Id] AS [Categoria],
    [Categoria].[Name]
FROM
    [Curso]
    LEFT JOIN [Categoria] -- TODOS ITENS DA PRIMEIRA TABELA
        ON [Curso].[CategoriaId] = [Categoria].[Id]
    -- --RIGHT JOIN - Pega todas as categorias e se o curso existir
    -- --FULL OUTER JOIN - pega todos itens de cursos e categorias

-- UNION/ UNION ALL
SELECT TOP 100                                                 
    [Id], [Name]
FROM
    [Curso]

UNION 

SELECT TOP 100
    [Id], [Name]
FROM
    [Categoria]

--O union une as tabelas, precisa ter o mesmo tipo de dado.

--GROUP BY --  View -------------------------------------------------
CREATE OR ALTER VIEW vwContagemCursosPorCategoria AS
SELECT TOP 100
    [Categoria].[Id],
    [Categoria].[Name],
    COUNT([Curso].[CategoriaId]) AS [Cursos]

FROM
    [Categoria]
    INNER JOIN [Curso] ON [Curso].[CategoriaId] = [Categoria]. [Id]

GROUP BY
    [Categoria].[Id],
    [Categoria].[Name],
    [Curso].[CategoriaId]
HAVING
    COUNT([Curso].[CategoriaId]) > 1
--    -- Não temos o where, utilizamos o havin. repetimos a sintaxe do count e colocamos a condição
--TODA VEZ que usar o COUNT, MIN, MAX E ETC  PRECISA USAR O GROUP BY OU OUTRO BY.  
---- Normalmente usado para contar itens no pedido ou saber quyantos cursos tem ans categorias.

-- Para vizualizar a view basta abrir uma nova query na pasta e colocar
SELECT * FROM vwContagemCursosPorCategoria
WHERE Name = 'Backend'
--Vantagem que posso usar o Where na viwe da nova query.

-- --- Variaveis CREATE OR ALTER PROCEDURE[SplitCourse] 
    @Category NVARCHAR(60),
    @PAR2 NVARCHAR(60)
AS

    DECLARE @CategoryId INT
    SET @CategoryId = (SELECT TOP 1 [Id] FROM [Categoria] WHERE [Name] = @Category)

    SELECT * FROM [Curso]
-- declarar variaveis  NA NOVA QUERY
    EXEC [SplitCourse] 'Bacend', ' '
---------------------------Contando os cursos 
--  [1] --

SELECT 
    [Id],
    [Title],
    [Url],
    (SELECT COUNT([CareerId])FROM[CareerItem] WHERE [CareerId] = [Id]) AS [Courses] --// menos recomendada
FROM
    [Career]

-- [2] --

SELECT 
    [Career].[Title] AS [Curso],
    COUNT([Id]) AS [QTD.]
    
FROM
    [Career]
    INNER JOIN [CareerItem] ON [CareerItem].[CareerId] = [Career].[Id]
GROUP BY
    [Career].[Title],
    [Id]
    

    
