//Gera um novo Guid
var id = Guid.NewGuid();

 // transformando em string
id.ToString(); 

//passagem de guid para uma variavel
id = new Guid("2af0ee7b-a8b6-4b42-b8de-3e99b96c6835");

//Pegar apenas os 8 numeros da strin

Console.WriteLine(id.ToString().Substring(0,8));
