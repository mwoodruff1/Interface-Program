using System;
using System.Net.Mail;
using ActiveUp.Net.Mail;
namespace Interface
{
    public class Commands
    {


        internal void Clear()
        {
            Console.Clear();
        }

        internal void Exit(){
            System.Environment.Exit(0);
        }


        //Start Mail Commands
        internal void SendMail(/*string toUser, string messageSubject, string messageBody*/){
            
            MailMessage message = new MailMessage();
            Console.WriteLine("Please enter the destination user");
            message.To.Add(Console.ReadLine());
            Console.WriteLine("Pleas enter Subject");
            message.Subject = Console.ReadLine();
            message.From = new MailAddress("systeminterface01@gmail.com");
            Console.WriteLine("Pleas enter message body");
            message.Body = Console.ReadLine();
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com");
            smtp.UseDefaultCredentials = false;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("systeminterface01@gmail.com", "Max1Oreo2");
            smtp.Send(message);
        }

        internal void GetMail(){
            var mailRepository = new MailSystem("imap.gmail.com", 993, true, "systeminterface01@gmail.com", "Max1Oreo2");
                            

            var emailList = mailRepository.GetAllMails("inbox");

            foreach (Message email in emailList)
            {
                Console.WriteLine("<p>{0}: {1}</p><p>{2}</p>", email.From, email.Subject, email.BodyHtml.Text);
                if (email.Attachments.Count > 0)
                {
                    foreach (MimePart attachment in email.Attachments)
                    {
                        Console.WriteLine("<p>Attachment: {0} {1}</p>", attachment.ContentName, attachment.ContentType.MimeType);
                    }
                }
            }

        }



    }
}
