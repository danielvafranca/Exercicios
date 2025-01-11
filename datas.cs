using System.Globalization;

Console.Clear();
Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=");
Console.WriteLine("DATAS");
var dataAtual = DateTime.Now;// data atual
var criarData = new DateTime(2020, 10, 12, 13, 23, 14);//(2020 ano, 10 mes, 12 dia, 13 hora, 23 minuto , 14 segundo)

Console.WriteLine(dataAtual.Year);
Console.WriteLine(dataAtual.Month);
Console.WriteLine(dataAtual.Day);
Console.WriteLine(dataAtual.Hour);
Console.WriteLine(dataAtual.Minute);
Console.WriteLine(dataAtual.Second);

Console.WriteLine(dataAtual.DayOfWeek);
Console.WriteLine((int)dataAtual.DayOfWeek);//podemos fazer uma conversao de enumerado. em vez de mostrar o dia da semana, mostra o numero ex:
Console.WriteLine((int)dataAtual.DayOfYear);

//formatar data
Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=");
Console.WriteLine("//formatar data");
var formatada = $"{dataAtual.Year}/{dataAtual.Month}/{dataAtual.Day}"; 

var formatada1 = String.Format("{0:yyyy-MM-dd  hh:mm:ss }",criarData);

//Adicionar algo na data ex: 
Console.WriteLine(formatada1);
Console.WriteLine(dataAtual.AddYears(1));
Console.WriteLine(dataAtual.AddMonths(1));
Console.WriteLine(dataAtual.AddDays(1));

//COMPARADO DATAS---------------------
Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=");
Console.WriteLine("COMPARADO DATAS");

if(dataAtual.Date == DateTime.Now.Date)
{
    Console.WriteLine("é igual");
};

//GLOBALIZAÇÃO DE DATAS ( CultureInfo)
Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=");
Console.WriteLine("//GLOBALIZAÇÃO DE DATAS ( CultureInfo)");
var ptBr = new CultureInfo("pt-BR");
var ptPt = new CultureInfo("pt-PT");
var enUs = new CultureInfo("en-US");
var atual = CultureInfo.CurrentCulture;// Cultura arual da maquina

Console.WriteLine(DateTime.Now.ToString("D", enUs));

//TimeZone
Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=");
Console.WriteLine("//TimeZone");

var utcDate = DateTime.UtcNow;//salvar sempre as datas no formato utc para clientes internacionais
Console.WriteLine(utcDate);
Console.WriteLine(DateTime.Now);
Console.WriteLine(utcDate.ToLocalTime());//voltou para data da maquina

// maquina nos eua mas usuario esta na australia

Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=");
Console.WriteLine("// maquina nos eua mas usuario esta na australia");

var timeZoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland"); //   [1] Criamos um timezone da australia
Console.WriteLine(timeZoneAustralia);

var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timeZoneAustralia);//   [2] Criamos uma variavel de data e convertemos
Console.WriteLine(horaAustralia);

//TimeSpan   trabalhar com hora
Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=");
Console.WriteLine("//TimeSpan   trabalhar com hora");

var timeSpan = new TimeSpan();
Console.WriteLine(timeSpan);

var timeSpanHoraMinutoSegundo = new TimeSpan(4, 12, 8); // Criar hora   hora, minuto, segundo
var timeSpandiaHoraMinutoSegundo = new TimeSpan(3, 4, 12, 8); // Criar dia, hora   hora, minuto, segundo
var timeSpanHoraMinutoSegundoMiliSegundo = new TimeSpan(3, 4, 12, 8,100); // Criar dia, hora   hora, minuto, segundo
Console.WriteLine(timeSpanHoraMinutoSegundo);
Console.WriteLine(timeSpandiaHoraMinutoSegundo);
Console.WriteLine(timeSpanHoraMinutoSegundoMiliSegundo);
// usamos para fazer calculos sobre datas
Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpandiaHoraMinutoSegundo);
Console.WriteLine(timeSpanHoraMinutoSegundo.Days);
Console.WriteLine(timeSpanHoraMinutoSegundo. Add(new TimeSpan(12,0,0)));


//OBS MUITO USADO NA ENTRADA E SAIDA DE FUNCIONARIO