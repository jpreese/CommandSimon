using System;
using System.Runtime.InteropServices;

namespace CommandSimon
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandText = "jump";

            var commandFactory = new CommandFactory();
            var command = commandFactory.CreateCommand(commandText);
            var com = commandFactory.CreateCommand(commandText);
            command.Execute();
            com.Execute();

            var woo = new CommandFactory();
            woo.CreateCommand(commandText);

            Console.ReadKey();
        }
    }
}
