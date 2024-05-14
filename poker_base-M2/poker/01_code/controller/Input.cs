using System;
using poker.code.view;
namespace poker.code.controller;

/*
Classe para lidar com entradas do usuário
*/
public class Input
{
    //---------------------------------------------------------------------------------
    //Comportamentos
    //---------------------------------------------------------------------------------
    /*
        Método para ler uma opção do teclado
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
      Método para ler um texto do teclado
    */
    public static string get_text()
    {
        return Console.ReadLine()!;
    }
}
