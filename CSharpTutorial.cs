namespace CSharpTutorial;

public class CSharpTutorial
{
    public CSharpTutorial()
    {
        //
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        foreach (var command in args)
        {
            if (command == "--help")
            {
                string help = Help();
                Console.WriteLine(help);
            }
        }

        bool isrunning = true;
        while (isrunning)
        {
            string? input = Console.ReadLine();
            if (input == "quit")
            {
                isrunning = false;
                Console.WriteLine("Goodbye!");
                Environment.Exit(0);
            }

            if (input == "help")
            {
                string help = Help();
                Console.WriteLine(help);
            }
        }
    }

    private static string Help()
    {
        string help = "HELP!";
        help += "\nhelp = shows this help";
        help += "\nquit = quits the program";
        return help;
    }
}