// m4rc3l0 - 28/04/2024
using System;
using poker.code.view;
namespace poker.code.controller;

/*
Class to handle inputs from user
*/
public class Input
{
    //---------------------------------------------------------------------------------
    //behaviors
    //---------------------------------------------------------------------------------
    /*
    Method to read a option from keyboard
    */
    public static int get_option()
    {
        int opt = 0;
        while (true)
        {
            Int32.TryParse(Console.ReadLine(), out opt);
            if(opt >= 1 && opt <= 2)
                break;
            else
                ShowText.print_text("Valid options: 1 or 2");
        }
        return opt;
    }

    /*
    Method to read a text from keyboard
    */
    public static string get_text()
    {
        return Console.ReadLine()!;
    }
}
