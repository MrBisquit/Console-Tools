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
            Console_Tools.Main.ProgressBar pb = Console_Tools.Main.NewProgressBar(); // Not needed, you can directly create one but I thought it might be easier.
            for (int i = 0; i < 100; i++)
            {
                pb.UpdateProgress(i);
            }
            Console.WriteLine(); // Make sure to do this after because otherwise it'll write on the same line as the finished progress bar!
            Console_Tools.Main.PrintStatus("It works!", 7);
        }
    }
}