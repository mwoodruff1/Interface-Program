using System;
namespace Interface
{
    public class CommandIdentifier
    {
        internal void CommandReader(string userInput)
        {
            Commands commandsStorage = new Commands();
            interfaceMain interfaceMain1 = new interfaceMain();
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
                    Console.WriteLine("An Error has Occured");
                    //Make it where it calls the main function again
                    break;
            }


        }
    }
}
