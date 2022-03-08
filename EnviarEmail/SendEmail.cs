using System;
using System.Net;
using System.Net.Mail;

namespace EnviarEmail
{
    public static class SendEmail
    {
        /// <summary>
        /// Envia o email.
        /// </summary>
        /// <param name="addressEmail">Endereço onde será enviado o e-mail.</param>
        public static void Send(string addressEmail)
        {
            MailMessage emailMessage = new MailMessage();
            // Verificar eventuais erros na hora de enviar o e-mail.
            try
            {
                // Provedor que estará enviando os e-mails.
                var smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.Timeout = 60*60; //Timeout em segundos.
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("endereço de quem vai enviar", "senha de quem vai enviar");
                // Endereço de quem vai receber e o nome do quem está enviando.
                emailMessage.From = new MailAddress(addressEmail, "Sebastião Silva");
                // Conteúdo do e-mail.
                emailMessage.Body = "Parabéns mulheres pelo dia de vocês!";
                // Título do e-mail.
                emailMessage.Subject = "Enviando via Csharp as felicitações pelo Dia da Mulher!";
                // Quanto TRUE, o Dev consegue colocar tags HTML no corpo do e-mail, para um tipo personalizado.
                emailMessage.IsBodyHtml = true;
                emailMessage.Priority = MailPriority.Normal;
                emailMessage.To.Add(addressEmail);

                smtpClient.Send(emailMessage);

            }
            catch (Exception ex)
            {
                return;
            }       
        }
    }
}