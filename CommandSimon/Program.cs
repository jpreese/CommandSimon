using System;

namespace CommandSimon
{
  class Program
  {
    static void Main(string[] args)
    {
      var commandFactory = new CommandFactory();
      var command = commandFactory.CreateCommand(args[0]);

      Console.ReadKey();
    }
  }
}
