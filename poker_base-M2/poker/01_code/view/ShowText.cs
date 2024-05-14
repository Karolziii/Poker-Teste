using System;
using System.Collections.Generic;
using poker.code.model;

namespace poker.code.view
{
    public class ShowText
    {
        public static void print_text(string text)
        {
            Console.WriteLine(text);
        }
        public static void show_menu()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1 - Game");                                             // Mostra texto para instrução
            Console.WriteLine("2 - Test");
            Console.WriteLine("--------------------------------------------------------------------------------------");
        }
        public static void show_restart()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("Choose a option: ");                                    // Mostra texto para instrução
            Console.WriteLine("1 - Restart\n2 - Exit\n");
            Console.WriteLine("--------------------------------------------------------------------------------------");
        }
        public static void show_single(string text)
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("Testing: \t" + text);                                    // Mostra texto
            Console.WriteLine("--------------------------------------------------------------------------------------");
        }

        public static void show_footer(string text)
        {
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("Test: \t" + text);
            Console.WriteLine("--------------------------------------------------------------------------------------");
        }

        public static void show_help()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Invalid Usage. Try this:");
            Console.WriteLine("donte run <option>");
            Console.WriteLine("options:");
            Console.WriteLine("\t full");
            Console.WriteLine("\t single <file_name.csv>");                  // Mostra texto de instrução 
            Console.Write("ex: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\tdotnet run full");
            Console.WriteLine("\tdotnet run single 01.csv");
            //Console.ForegroundColor = //ConsoleColor.White;
            Console.ResetColor();
            Console.WriteLine("---------------------------------------------------------------------------------");
        }
    }
}
