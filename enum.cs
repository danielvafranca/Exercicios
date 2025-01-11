
enum EEstadoCivil
{
    Solteiro = 1,
    Casado = 2,
    Divorciado = 3
}
struct Cliente
{
    public string Nome;
    public EEstadoCivil EstadoCivil;
}
// Sem enumeradores
// var cliente = new Cliente("João Silva", 1);
// Com enumerador
//var cliente = new Cliente("João Silva", EEstadoCivil.Casado);
Console.WriteLine(cliente.Nome);
Console.WriteLine(cliente.EstadoCivil); // Escreve Casado
Console.WriteLine((int)cliente.EstadoCivil); // Escreve 2
