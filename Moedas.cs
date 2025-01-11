using System.Globalization;

decimal valor = 10545.25m; // normalmente utilizamos o decimal para trabalhar com valores de moedas
Console.WriteLine
    (
    valor.ToString("C"),valor.ToString(CultureInfo.CreateSpecificCulture("pt-BR"))//coloca o formato da moeda
    );

//Arrendondar o valor\
Console.WriteLine("-=-=-=-=-=-=-=-=-=");// Arredonda

Console.WriteLine(Math.Round(valor));// Arredonda
Console.WriteLine(Math.Ceiling(valor));// Arredonda para cima
Console.WriteLine(Math.Floor(valor));// Arredonda para Bixo
