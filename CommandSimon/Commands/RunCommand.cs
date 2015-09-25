using System;

namespace CommandSimon.Commands
{
  public class RunCommand : ICommand
  {
    public void Execute()
    {
      Console.WriteLine("ran");
    }
  }
}
