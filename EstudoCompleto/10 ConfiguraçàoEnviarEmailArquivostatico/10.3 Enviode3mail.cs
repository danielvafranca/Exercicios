//SendGrid, SendBlue, Zoho mail
// Criando uma ApiKey Pelo SendGrid e copiando a Senha: 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

//Criando um Serviço de envio de e-mail:

//Ir Na pasta services e criar Uma classe EmailService
namespace Blog.Services
{
    public class EmailService
    {
    }
}
//Ir no program e colocar o emailServices no program.cs e colocar o e-mailServices

void ConfigureServices(WebApplicationBuilder builder)
{
    // builder.Services.AddDbContext<BlogDataContext>();
    // builder.Services.AddTransient<TokenService>();
    builder.Services.AddTransient<EmailService>();
}

//Como fica o e-mai Service+

using System.Net;
using System.Net.Mail;

namespace Blog.Services;
public class EmailService
{
    public bool Send(
        string toName,
        string toEmail,
        string subject,
        string body,
        string fromName = "Equipe balta.io",
        string fromEmail = "email@balta.io")
    {
        var smtpClient = new SmtpClient(Configuration.Smtp.Host, Configuration.Smtp.Port);
        smtpClient.Credentials = new NetworkCredential(Configuration.Smtp.UserName, Configuration.Smtp.Password);
        smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
        smtpClient.EnableSsl = true;// porta 587

        //Menssagem De E-MAIL
        var mail = new MailMessage();

        mail.From = new MailAddress(fromEmail, fromName);
        mail.To.Add(new MailAddress(toEmail, toName));//Posso mandar par mais dfe uma pessoa
        mail.Subject = subject;
        mail.Body = body;
        mail.IsBodyHtml = true;
        try
        {
            smtpClient.Send(mail); // Enviando no try para nao quebrar a aplicação
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }


}

//Com o serviço de e-mail Criado e registrado, Já podemos usar na nossa conta
