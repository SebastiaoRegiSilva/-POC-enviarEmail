using EnviarEmail;
using System;

namespace POC_enviarEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://10minutemail.net/?lang=pt-br
            Console.WriteLine("Enviando email...");
            SendEmail.Send("endereço de email para envio");
            Console.WriteLine("Email enviado...");
        }
    }
}
