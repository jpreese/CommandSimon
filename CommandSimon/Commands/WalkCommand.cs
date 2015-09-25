using System;

namespace CommandSimon.Commands
{
  public class WalkCommand : ICommand
  {
    public void Execute()
    {
      Console.WriteLine("walked");
    }
  }
}
