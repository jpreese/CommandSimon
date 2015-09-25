namespace CommandSimon
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandText = args[0];

            var commandFactory = new CommandFactory();
            var command = commandFactory.CreateCommand(commandText);

            command.Execute();
        }
    }
}
