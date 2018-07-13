using System;

namespace FirstConsoleApp       //classes in C# are organised into nmaspaces to avoid class name collisions
{
    class Program
    {
        public static string title = "C# Tutorial";
        public static int part;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();         //this is a pause until u press enter

            part = 1;
            string output = string.Format("I am doing {0} part {1}", title, part);
            Console.WriteLine(output);

        }
    }
}