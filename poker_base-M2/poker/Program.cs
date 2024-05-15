
using System;
using poker.code.controller;
using poker.code.model;
//using poker.code.model.hand_ranks;
using poker.code.view;

namespace poker 
{
    class Program // Main class
    {
        // Entry point of execution.
        //two options: run full (tests or game) or run a single file test
        public static void Main(string[] args)
        {
            #region M2_LoadAndTest
            Console.Clear();
            if (args.Length == 0)
            {// wrong usage
                ShowText.show_help(); 
                Environment.Exit(0);
            }
            else if (args.Length == 1 && args[0] == "full")
            {// dotnet run full
                ShowText.show_menu();            
                switch (Input.get_option())
                {
                    case 1:
                        ShowText.print_text("Game - Not implemented yet.");
                        // only in M3
                        break;
                    case 2: 
                        // Criar um objeto de teste
                        Test test = new Test("dummy", new List<Card>()); // Dummy values for constructor
                        // Executar todos os testes em sequência
                        test.full_test();
                        break;
                }
            }
            else if (args.Length == 2 && args[0] == "single")
            {// dotnet run single <xx.csv>
                //creats an object of type Test / load_hand loads a file (cards list)
                Test test_single = new Test(args[1], Load.load_hand(args[1]));
                test_single.single_test(); // run test in a single file
            }
            else
            {// wrong usage
                ShowText.show_help(); // show help menu
                Environment.Exit(0); // close the program
            }
            #endregion
        }
    }
}
