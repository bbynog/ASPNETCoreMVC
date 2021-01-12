using Site01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Site01.Library.Mail
{
    public class EnviarEmail
    {
        public static void EnviarMensagemContato(Contact contact)
        {
            string conteudo = String.Format("Nome: {0}<br /> Email: {1}<br /> Assunto: {2}<br /> Mensagem: {3}<br /> ", contact.Nome, contact.Email, contact.Assunto, contact.Mensagem);
            //Configurar servidor SMTP
            SmtpClient smtp = new SmtpClient(Constants.ServidorSMTP, Constants.PortaSMTP);
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(Constants.Usuario, Constants.Senha);

             
            //Mail
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("do.not.reply.this.x@gmail.com");
            mensagem.To.Add("gabrielccat@gmail.com");
            mensagem.Subject = "Formulário de contato";

            mensagem.IsBodyHtml = true;
            mensagem.Body = "<h1>Formulário de contato</h1> " + conteudo;

            smtp.Send(mensagem);
        }
    }
}
