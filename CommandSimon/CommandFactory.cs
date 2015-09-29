using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CommandSimon
{
  public class CommandFactory
  {
    private static readonly Lazy<IList<ICommand>> _commandDictionary = new Lazy<IList<ICommand>>(LoadCommands);

    public ICommand CreateCommand(string command)
    {
      var commands = _commandDictionary.Value;
      return commands[0];
    }
 
    private static IList<ICommand> LoadCommands()
    {
      return Assembly.GetExecutingAssembly()
        .GetTypes()
        .Where(t => t.GetInterfaces()
        .Contains(typeof (ICommand)))
        .Select(a => Activator.CreateInstance(a) as ICommand)
        .ToList();
    }
  }
}
