using System;

namespace Richard_Pizzaria_UML2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Store store = new Store();
            Console.Write("Hit any key to continue with user dialog");
            Console.ReadKey();
            //store.Run();
        }
    }
}
