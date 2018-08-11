using System;
using System.Configuration;

namespace Interface
{
    class interfaceMain
    {
        public string rootUsername = "admin";
        public string rootPassword = "password";
        
        static void Startup(){ //Standard Startup Stuffs
            var systemName = "Interface01";
            var systemDateTime = System.DateTime.Now;
            var systemVersion = "0.01";


            Console.WriteLine(systemName + " has started");
            Console.WriteLine("Current Date and Time is " + systemDateTime);
            Console.WriteLine("Current System version is: " + systemVersion);

        }




        static void CommandSender(){ 
            //Sets the Command Reader, and then calls for the user to input the required command then sends the input
            //the commandIdentifier Class.
            CommandIdentifier commandReader = new CommandIdentifier();
            var userInpt = Console.ReadLine();
            commandReader.CommandReader(userInpt); 
        }


        //WARNING Main class is below
        public static void Main()
        {
        Link:
            Console.Clear();
            Startup();
            CommandSender();
            goto Link;
        }
    }
}
