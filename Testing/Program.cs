using static Console_Tools.Main;

namespace Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console_Tools.Main.PrintStatus("Hello", 0);
            Console_Tools.Main.PrintStatus("Hello", 1);
            Console_Tools.Main.PrintStatus("Hello", 2);
            Console_Tools.Main.PrintStatus("Hello", 3);
            Console_Tools.Main.PrintStatus("Hello", 4);
            Console_Tools.Main.PrintStatus("Hello", 5);
            Console_Tools.Main.PrintStatus("Hello", 6);
            Console_Tools.Main.PrintStatus("Hello", 7);
            Console.Write("Password: ");
            string pass = Console_Tools.Main.GetPassword();
            Console.WriteLine("You typed: " + pass);
            Console.WriteLine("Correct?");
        }
    }
}