using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenPop;
using OpenPop.Mime;
namespace Interface
{
    public class MailSystem
    {
        static OpenPop.Pop3.Pop3Client client = new OpenPop.Pop3.Pop3Client();
        static StringBuilder builder = new StringBuilder();


        internal void get(){

            client.Connect("pop.gmail.com", 995, true);// Connects to the pop3 server for gmail
            client.Authenticate("systeminterface01@gmail.com", "Max1Oreo2");// Login Credentials



            var count = client.GetMessageCount();// gets the message count
            OpenPop.Mime.Message message = client.GetMessage(count);// Gets the message that correlates with the count variable- in this case 0
            OpenPop.Mime.MessagePart plainText = message.FindFirstPlainTextVersion();// Gets the first messsages body
            builder.Append(plainText.GetBodyAsText()); //Puts the email's text into a StringBuilder where it can be outputed
            Console.WriteLine(builder.ToString()); //Outputs the email to the console
            builder.Clear(); //Clears the String Builder
            client.Disconnect(); // Disconnects from the Pop3 Client
        
        }


    }
}

