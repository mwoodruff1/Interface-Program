using System;
using System.Net.Mail;

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
            Console.WriteLine("Please enter Subject");
            message.Subject = Console.ReadLine();
            message.From = new MailAddress("systeminterface01@gmail.com");
            Console.WriteLine("Please enter message body");
            message.Body = Console.ReadLine();
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com");
            smtp.UseDefaultCredentials = false;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("systeminterface01@gmail.com", "Max1Oreo2");
            smtp.Send(message);
        }

        internal void GetMail(){
            MailSystem mail = new MailSystem();

            mail.get();
        }
        internal void hostname(){

            Console.WriteLine(System.Net.Dns.GetHostName().ToString());//Added the .ToString() call incase of future failures.

        }
        internal void jobs(){
            
            System.Diagnostics.Process[] systemProccesses = System.Diagnostics.Process.GetProcesses();
            foreach(System.Diagnostics.Process processes in systemProccesses){
                Console.WriteLine("Process: {0} ID: {1}", processes.ProcessName, processes.Id);
            }
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadKey();
        }




    }
}
