using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        var texto = "Este texto é um teste";
        //Meu texto contem isso ?
        Console.WriteLine(texto.Contains("teste"));
        Console.WriteLine(texto.Contains("Teste"));
        //Vai ignorar o case sensitive
        Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));

        //Meu texto comeca com isso ?  retorna booleano tambem
        Console.WriteLine(texto.StartsWith("Teste"));
        Console.WriteLine(texto.StartsWith("teste"));


        //meu texto termina com isso?
        Console.WriteLine(texto.EndsWith("teste"));
        Console.WriteLine(texto.EndsWith("teste"));


        // estre texto é exatamente igual igual ?
        Console.WriteLine(texto.Equals("teste"));


        //Pega a posição da string (IndexOf sempre pede o mesmo tipo da variavel)
        Console.WriteLine(texto.IndexOf("é"));// primeira posição
        Console.WriteLine(texto.LastIndexOf("é")); // ultima posição


        // (ToLower and ToUpper)Converter para minusculo e maiusculo e inserir
        Console.WriteLine(texto.ToLower());//Minusculo
        Console.WriteLine(texto.ToUpper());//Maiusculo


        // (Insert AND Remove) Adicionar e Remover
        Console.WriteLine(texto.Insert(5, "Aqui"));//Adicionar na Posição 5 a palavra aqui!
        Console.WriteLine(texto.Remove(5, 5));//Remova iniciando na posicao 5 e os 5 caracteres



        // (Length) Conte
        Console.WriteLine(texto.Length);//Conte os caracteres


        // (Replace) Trocar
        Console.WriteLine(texto.Replace("Estes", "Isto"));// trocar todos os estes do texto por Isto

        // Split 
        var divisao = texto.Split(" "); //Vamos separar os caracteres do var texto e cada po espaco palavra será um texto diferente.
        Console.WriteLine(divisao[0]); //Para mostrar o os itens  da lista utilize []
        Console.WriteLine(divisao[1]); //Para mostrar o os itens  da lista utilize []
        Console.WriteLine(divisao[2]); //Para mostrar o os itens  da lista utilize []
        Console.WriteLine(divisao[3]); //Para mostrar o os itens  da lista utilize []

        //Substring
        //var resultado = texto.Substring(5, 5);// comece no 5 e pegue 5 caracteres
        var resultado = texto.Substring(5, texto.LastIndexOf("o"));// vai pegar do caracter 5 até o ultim indice do "o"  exemplo texto
        Console.WriteLine(resultado);

        // Remover espaços do inicio e do fim com o Trim
        Console.WriteLine(texto.Trim());

        //StringBuilder
        var texto1 = new StringBuilder();
        texto1.Append("Este texto é um teste"); 
        texto1.Append("é um teste"); 
        texto1.Append("Este texto"); 

        Console.WriteLine(texto1); 
        
    }
}