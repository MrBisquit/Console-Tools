using System.Text;

namespace Console_Tools
{
    public static class Main
    {
        /// <summary>
        /// Prints on one line a status message, (status) + (status message)
        /// </summary>
        /// <param name="message">The message that will be displayed after the status</param>
        /// <param name="type">The status, 0 = Failed, 1 = Progressing, 2 = Improving, 3 = Failed and retrying, 4 = Bad, 5 = Ok, 6 = Good, 7 = Info</param>
        public static void PrintStatus(string message, int type = 7)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[ ");

            // This is probably a terrible way of doing this but I couldn't figure out how a switch statement worked.
            // TODO: Make this look neater.

            if(type == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Failed");
            } else if(type == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Progressing");
            } else if(type == 2)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Improving");
            } else if(type == 3)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Failed and retrying");
            } else if(type == 4)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Bad");
            } else if(type == 5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Ok");
                
            } else if(type == 6)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Good");
            } else if(type == 7)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("Info");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" ] ");

            Console.ResetColor();
            Console.WriteLine(message);
        }

        /// <summary>
        /// Gets a "password" or some other string in an empty area, when the user types it will not show, but it will still be recorded.
        /// </summary>
        /// <param name="exitkey">The key that the user must press to escape. (Will return the value the user has entered)</param>
        public static string GetPassword(ConsoleKey exitkey = ConsoleKey.Enter)
        {
            ConsoleKey lastpressed = ConsoleKey.Backspace; // You can put any value here, just so it doesen't null out.
            StringBuilder stringBuilder = new StringBuilder();

            while(lastpressed != exitkey)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                lastpressed = key.Key;

                Console.Write("\b \b");

                if(key.Key == ConsoleKey.Backspace)
                {
                    stringBuilder.Remove(stringBuilder.Length - 1, 1);
                } else if(key.Key == exitkey)
                {

                } else
                {
                    if(key.KeyChar.ToString().Length == 1)
                    {
                        stringBuilder.Append(key.KeyChar);
                    }
                }
            }

            return stringBuilder.ToString();
        }
    }
}