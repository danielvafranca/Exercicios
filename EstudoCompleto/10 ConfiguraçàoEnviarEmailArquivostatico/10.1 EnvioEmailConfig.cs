namespace Blog;

public static class Configuration
{
    public static string JwtKey = "ZmVkYWY3ZDg4NjNiNDhlMTk3YjkyODdkNDkyYjcwOGU=";
    public static string ApiKeyName = "api_key";
    public static string ApiKey = "curso_api_IlTevUM/z0ey3NwCV/unWg==";
    public static SmtpConfiguration Smtp = new();// 1.1 Instanciando

    public class Smtp // 1.0 Envio de e-mail
    {
        public string Host { get; set; }
        public int Port { get; set; } = 25;
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}

//Colocando as informaçoens no settings=>

{
  "JwtKey": "8443783fa8f54c3fa6f6a7c19e1448ea",
  "ApiKeyName": "api_key",
  "ApiKey": "curso_api_IlTevUM/z0ey3NwCV/unWg==",
  "Smtp": {
    "Host": "smtp.sendgrid.net",
    "Port": "587",
    "UserName": "apikey",
    "Password": "suasenha"
  },
//   "Logging": {
//     "LogLevel": {
//       "Default": "Information",
//       "Microsoft.AspNetCore": "Warning"
//     }
//   },
//   "AllowedHosts": "*"
// }

//No arquivo program, colocamos as infgoraçoens para leitura dos valores e da seção

// using System.Text;
// using Blog;
// using Blog.Data;
// using Blog.Services;
// using Microsoft.AspNetCore.Authentication.JwtBearer;
// using Microsoft.IdentityModel.Tokens;

// var builder = WebApplication.CreateBuilder(args);

// var key = Encoding.ASCII.GetBytes(Configuration.JwtKey);
// builder.Services.AddAuthentication(x =>
// {
//     x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//     x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
// }).AddJwtBearer(x =>
// {
//     x.TokenValidationParameters = new TokenValidationParameters
//     {
//         ValidateIssuerSigningKey = true,
//         IssuerSigningKey = new SymmetricSecurityKey(key),
//         ValidateIssuer = false,
//         ValidateAudience = false
//     };
// });

// builder
//     .Services
//     .AddControllers()
//     .ConfigureApiBehaviorOptions(options =>
//     {
//         options.SuppressModelStateInvalidFilter = true;
//     });
// builder.Services.AddDbContext<BlogDataContext>();
// builder.Services.AddTransient<TokenService>();

var app = builder.Build();
Configuration.JwtKey = app.Configuration.GetValue<string>("JwtKey");
Configuration.ApiKeyName = app.Configuration.GetValue<string>("ApiKeyName");
Configuration.ApiKey = app.Configuration.GetValue<string>("ApiKey");

var smtp = new Configuration.SmtpConfiguration();
app.Configuration.GetSection("Smtp").Bind(smtp);
Configuration.Smtp = smtp;  


// app.UseAuthentication();
// app.UseAuthorization();

// app.MapControllers();

// app.Run();
