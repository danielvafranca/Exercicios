using System.Reflection;


Console.Clear();
int valor = 0;
while(valor != 9)
{
    Console.WriteLine("OPERAÇÄO\n[1] SOMA\n[2] SUBTRAÇAO\n[3] MULTIPLICAÇAO\n[4] DIVISAO\n[9] FECHAR");
    int resposta = int.Parse(Console.ReadLine());
    valor = resposta;
    Console.Clear();


    Console.WriteLine("Primeiro valor: ");
    float n1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float n2 = float.Parse(Console.ReadLine());

    switch(resposta)
    {
        case 1: 
            Console.Clear();
            Console.WriteLine("SOMA");
            var soma = n1 + n2;
            Console.WriteLine(soma);
            break;
        case 2: 
            Console.Clear();
            Console.WriteLine("SUBTRACAO");
            var subtracao = n1 - n2;
            Console.WriteLine(subtracao);
            break;
        case 3:
            Console.Clear();
            Console.WriteLine("Multiplicacao");
            var multiplicacao = n1 * n2;
            Console.WriteLine(multiplicacao);
            break;
        case 4: 
            Console.Clear();
            Console.WriteLine("DIVISAO");
            var divisao = n1 / n2;
            Console.WriteLine(divisao);
            break;
        default:
            Console.WriteLine("Opçao invalida. tente novamente");
            break;

    }
    if (valor != 9)
    {
        Console.WriteLine("Pressione qualquer tecla para continuar");
        Console.ReadKey();
        Console.Clear();
    };
};


    



