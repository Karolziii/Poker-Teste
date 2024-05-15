using System;
using poker.code.view;
namespace poker.code.controller;

/*
Método para ler uma opção do teclado
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
            // Tenta converter a entrada do usuário para um número inteiro
            Int32.TryParse(Console.ReadLine(), out opt);
            // Se o número estiver dentro do intervalo desejado, sai do loop
            if(opt >= 1 && opt <= 2)
                break;
            // Caso contrário, mostra uma mensagem de erro e continua pedindo uma entrada válida
            else
                ShowText.print_text("Valid options: 1 or 2");
        }
        // Retorna a opção válida
        return opt;
    }

    /*
      Método para ler um texto do teclado
    */
    public static string get_text()
    {
        // Lê e retorna o texto digitado pelo usuário
        return Console.ReadLine()!;
    }
}
