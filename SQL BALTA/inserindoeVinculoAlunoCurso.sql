
SELECT NEWID()
SELECT * FROM [Course]
SELECT * FROM [Student]
SELECT * FROM [StudentCourse]


INSERT INTO 
    [Student]([Id],[Name],[Email],[Document],[Phone],[Birthdate],[CreateDate])
VALUES
(
    'ff94bd04-368a-408a-8f9a-edc56d330113', 
    'Daniel', 
    'daniel@gmail.com',
    '12345678901',
    '123456789',
    GETDATE(),
    GETDATE()
)
-- Vinculo de curso com aluno
INSERT INTO
    [StudentCourse]([CourseId],[StudentId],[Progress],[Favorite],[StartDate],[LastUpdateDate])
VALUES
(
    '5d8cf396-e717-9a02-2443-021b00000000',
    'ff94bd04-368a-408a-8f9a-edc56d330113',
    50,
    0,
    '2021-04-17 12:35:53',
    GETDATE()
)


   