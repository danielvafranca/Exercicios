static void MeuMetodo()
{
    Console.WriteLine("Meu Metodo"); 
}

MeuMetodo(); 

//----------------------------------
static string RetornaNome(
    string nome, //Obrigatório
    string sobrenome,//Obrigatório
    int idade = 34,// Opicional
    double novo = 33.22,//opcional
    bool teste = false//Opcional
    )
{
    return nome + " " + sobrenome + " " +idade.ToString();
}

string pessoa = RetornaNome("Daniel", "Vitor", 48);

Console.WriteLine(pessoa);
