using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace BusProjekt
{
    public class Mail
    {


       public void Send(string email,string subjectMessage,string headerMessage,string bodyMessage)
        {
            SmtpClient client = new SmtpClient("smtp-mail.outlook.com");
            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            System.Net.NetworkCredential credential = new System.Net.NetworkCredential("syncc.me@outlook.com", "$ync.me2022");
            client.EnableSsl = true;
            client.Credentials = credential;
            MailMessage message = new MailMessage("syncc.me@outlook.com", email);
            message.Subject = subjectMessage;
            message.Body = "<h3>"+headerMessage+"</h3>";
            message.Body += "<p>"+ bodyMessage + "</p>";
            message.IsBodyHtml = true;
            client.Send(message);

        }


    }
}