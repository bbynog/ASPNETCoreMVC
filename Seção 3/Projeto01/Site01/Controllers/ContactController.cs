using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Site01.Models;
using Site01.Library.Mail;

namespace Site01.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ReceberContato([FromForm]Contact contact)
        {
            if (ModelState.IsValid)
            {
                //string conteudo = String.Format("Nome: {0},\nEmail: {1},\nAssunto: {2},\nMensagem: {3}\n", contact.Nome, contact.Email, contact.Assunto, contact.Mensagem);
                //return new ContentResult() { Content = conteudo };

                EnviarEmail.EnviarMensagemContato(contact);
                ViewBag.Mensagem = "Mensagem enviada co sucesso.";

                return View("Index");
            }
            else
            {
                return View("Index");
            }
            
        }

        /* Obter dados manualmente
         * 
        public IActionResult ReceberContato()
        {
            Contact contact = new Contact();

            contact.Nome = Request.Form["nome"];
            contact.Email = Request.Form["email"];
            contact.Assunto = Request.Form["assunto"];
            contact.Mensagem = Request.Form["mensagem"];

            string conteudo = String.Format("Nome: {0},\nEmail: {1},\nAssunto: {2},\nMensagem: {3}\n", contact.Nome, contact.Email, contact.Assunto, contact.Mensagem);

            return new ContentResult() { Content = conteudo };
        }
        */
    }
}
