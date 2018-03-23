using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace ProjetoCEEM.Services
{
    public class EmailService
    {
        public static string Msg { get; set; }
        public static string MsgError { get; set; }

        public static bool EnviarEmail(string emailDestinatario, string assunto, string
            corpomsg)
        {

            try
            {
                //Cria o endereço de email do remetente
                var de = new MailAddress("fatecgtaads@gmail.com");
                //Cria o endereço de email do destinatário -->
                var para = new MailAddress(emailDestinatario);
                var mensagem = new MailMessage(de, para)
                {
                    IsBodyHtml = true,
                    //Assunto do email
                    Subject = assunto,
                    //Conteúdo do email
                    Body = corpomsg,
                    //Prioridade E-mail
                    Priority = MailPriority.Normal
                };
                //Cria o objeto que envia o e-mail
                var cliente = new SmtpClient();
                //Envia o email
                cliente.Send(mensagem);
                Msg = "E-mail enviado com sucesso";
                return true;
            }
            catch(Exception e)
            {
                Msg = "Erro ao enviar e-mail";
                MsgError = e.Message; 
                return false;
            }
        }
    }
}