internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("----------------Try/catch-------------\n");

        var array = new int[3];
        try
        {
            // for (var i = 1; i < 11; i ++)
            // {
            //     Console.WriteLine(array[i]);
            // }
            Cadastrar("");
        }
        // Posso ter mais de um tratamento com o catch. sempre tratar do mais específico para o genérico
        catch (IndexOutOfRangeException ex) // específico
        {
            Console.WriteLine("Não encontrei o índice");
            Console.WriteLine(ex.InnerException);
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentNullException ex) // saber o que aconteceu, utilizar apenas se necessário // genérico
        {
            Console.WriteLine("Falha ao cadastrar Texto");
            Console.WriteLine(ex.InnerException);
            Console.WriteLine(ex.Message); // mostrar o erro
        }
        catch (Exception ex) // saber o que aconteceu, utilizar apenas se necessário // genérico
        {
            Console.WriteLine("Algo deu errado");
            Console.WriteLine(ex.InnerException);
            Console.WriteLine(ex.Message); // mostrar o erro
        }
        finally
        {
            Console.WriteLine("Fim do erro1");
        }

        //------------------------------------
        Console.WriteLine("--------------CUSTOM EXCEPTION---------------\n");


    }

    private static void Cadastrar(string texto)//disparo
    {
        if (string.IsNullOrEmpty(texto)) // se o texto for vazio ou nulo
        {
            throw new ArgumentNullException("O texto não pode ser nulo ou vazio");// pode ser exibido.
            throw new Exception("O texto não pode ser nulo ou vazio");// pode ser exibido.
        }
    }
}
