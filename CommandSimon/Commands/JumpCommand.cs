using System;

namespace CommandSimon.Commands
{
  public class JumpCommand : ICommand
  {
    public void Execute()
    {
      Console.WriteLine("jumped");
    }
  }
}
