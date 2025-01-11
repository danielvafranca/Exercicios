namespace BaltaDataAccess.Models
{
    public class Category
    {
        public Guid Id { get; set; } // Posso colocar como titulo, des de que na querry eu utilize o [Title] AS [Titulo].
        public string Title { get; set; } 
    }
}
// O nome original no banco de dados é Id  e Title, mas como utilisei o Alias, consegui mudar na query tambem para codigo e titulo:
//var categories = connection.Query<Category>("SELECT [Id] AS [Codigo], [Title] AS [Titulo] FROM [Category]"); // Posso usar o alias e trocar para o nome que eu quise, se eu mudar na classe category, tambem
 
           