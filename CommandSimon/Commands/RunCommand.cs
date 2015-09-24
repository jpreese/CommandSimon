using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandSimon.Commands
{
    public class RunCommand : ICommand
    {
        public void Execute()
        {
            System.Console.WriteLine("run...");
        }
    }
}
