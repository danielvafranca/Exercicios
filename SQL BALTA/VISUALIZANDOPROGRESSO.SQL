DECLARE @StudentId UNIQUEIDENTIFIER = 'ff94bd04-368a-408a-8f9a-edc56d330113' -- declarei UMA VARIAVEL PARA  O ID ALUNO

SELECT -- sELECIONANDO TUDO DE CURSSO 
    [Student].[Name] AS [Student],
    [Course].[Title] AS [Course],
    [StudentCourse].[Progress]
FROM  
    [StudentCourse] -- JUNTANDO ELE COM STUDENTCOURSE
    INNER JOIN [Student] ON [StudentCourse].[StudentId] = [Student].[Id]
    INNER JOIN [Course] ON [StudentCourse].[CourseId] = [Course].[Id]
WHERE
    [StudentCourse].[StudentId] = @StudentId --  traga todos os cursos que o aluno está fazendo

--------------------------------------------------------------------------------------------

CREATE OR ALTER PROCEDURE spStudentProgress ( --[1] DECLARAR O @StudentId pelo procedure
    @StudentId UNIQUEIDENTIFIER
)
AS
    SELECT -- sELECIONANDO TUDO DE CURSSO 
        [Student].[Name] AS [Student],
        [Course].[Title] AS [Course],
        [StudentCourse].[Progress]
    FROM  
        [StudentCourse] -- JUNTANDO ELE COM STUDENTCOURSE
        INNER JOIN [Student] ON [StudentCourse].[StudentId] = [Student].[Id]
        INNER JOIN [Course] ON [StudentCourse].[CourseId] = [Course].[Id]
    WHERE
        [StudentCourse].[StudentId] = @StudentId --  traga todos os cursos que o aluno está fazendo

-- NA NOVA QUERY [2]
EXEC spStudentProgress