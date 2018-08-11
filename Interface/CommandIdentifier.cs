using System;
namespace Interface
{
    public class CommandIdentifier
    {
        internal void CommandReader(string userInput)
        {
            Commands commandsStorage = new Commands();
            InterfaceMain interfaceMain1 = new InterfaceMain();
            var inputFromUser = userInput;


            switch (inputFromUser.ToLower()){
                
                case "clear":
                    commandsStorage.Clear();
                    break;
                case "exit":
                    commandsStorage.Exit();
                    break;
                case "alias": //Will need to make a dictonary for this command.
                    break;
                default:
                case "mail":
                    commandsStorage.SendMail(/*Console.ReadLine(), Console.ReadLine(),Console.ReadLine()*/);
                    Console.WriteLine("An Error has Occured");
                    //Make it where it calls the main function again
                    break;
            }


        }
    }
}
