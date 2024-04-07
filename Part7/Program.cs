using Part7.CommandInterceptors;

namespace Part7
{
    public class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            while (string.Compare(command, "exit", StringComparison.OrdinalIgnoreCase) != 0)
            {
                Console.Write("-> "); command = Console.ReadLine();
                try
                {
                    var lcommands = CommandInterpreter.InterpretCommandTest(command);
                    foreach (var commandObject in lcommands) { CommandExecuterManager.Execute(commandObject); }
                }
                catch (Exception e) { Console.WriteLine(e.Message); }

            }
        }
    }
}
