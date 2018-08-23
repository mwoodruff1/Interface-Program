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

            client.Connect("pop.gmail.com", 995, true);
            client.Authenticate("systeminterface01@gmail.com", "Max1Oreo2");



            var count = client.GetMessageCount();
            OpenPop.Mime.Message message = client.GetMessage(count);
            OpenPop.Mime.MessagePart plainText = message.FindFirstPlainTextVersion();
            builder.Append(plainText.GetBodyAsText());
            Console.WriteLine(builder.ToString());
            builder.Clear();
            client.Disconnect();
        
        }


    }
}

