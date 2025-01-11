DECLARE @StudentId UNIQUEIDENTIFIER = 'ff94bd04-368a-408a-8f9a-edc56d330113'

--[1] "Não posso deletar Student sem excluir o studentCourse antes. sempre excluir na ordem."
BEGIN TRANSACTION
    DELETE
        [StudentCourse]
    WHERE
        [StudentId] = @StudentId



    DELETE
        [Student]
    WHERE
        [Id] = @StudentId
COMMIT


