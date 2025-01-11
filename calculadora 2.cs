using System.Data;


Menu();

static void Menu()
{
    Console.Clear();

    Console.WriteLine("-=-=CALCULADORA-=-=\n");
    Console.WriteLine("SELECIONE A OPERAÇÄO: \n[1] SOMA\n[2] SUBTRAÇAO\n[3] DIVISAO\n[4] MULTIPLICAÇAO\n[5] FECHAR");
    short resp = short.Parse(Console.ReadLine());

    switch(resp)
    {
        case 1: Soma(); break;  
        case 2: Subtracao(); break;
        case 3: Multiplicacao(); break;
        case 4: Divisao(); break;
        case 5: System.Environment.Exit(0); break;
        default: Menu(); break;
    };

    
};

static void Soma()
{
    Console.Clear();
    Console.WriteLine("-=-=-=SOMA-=-=-=");

    Console.WriteLine("Primeiro valor");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = v1 + v2; 
    Console.WriteLine($"RESULTADO:\n{resultado}"); 
    Console.ReadKey();
    Menu(); 
}

static void Subtracao()

{
    Console.Clear();
    Console.WriteLine("-=-=SUBTRACAO-=-= ");

    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor");
    float v2 = float.Parse(Console.ReadLine());

    float resultado = v1 -v2; 
    Console.WriteLine($"RESULTADO\n{resultado}");
    Console.ReadKey(); 
    Menu(); 
};

static void Divisao()
{
    Console.Clear();
    Console.WriteLine("-=-= DIVISAO -=-=");

    Console.WriteLine("Primeiro valor");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo Valor");
    float v2 = float.Parse(Console.ReadLine());

    float resultado = v1 / v2;
    Console.WriteLine($"RESULTADO\n{resultado}");
    Console.ReadKey(); 
    Menu(); 
}

static void Multiplicacao()
{
    Console.Clear();
    Console.WriteLine("-=-= MULTIPLICACAO -=-=");

    Console.WriteLine("Primeiro valor");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo Valor");
    float v2 = float.Parse(Console.ReadLine());

    float resultado = v1 * v2;
    Console.WriteLine($"RESULTADO\n{resultado}");
    Console.ReadKey(); 
    Menu(); 
};