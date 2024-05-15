
using poker.code.model;
using poker.code.view;
namespace poker.code.controller;
using System.Runtime.InteropServices;

/*
Class for loading files in test mode
a static class don't necessarily create object
*/
public class Load
{
    //---------------------------------------------------------------------------------
    //behaviors
    //---------------------------------------------------------------------------------
    
    /*this one revceive by parameter (file path)1
    return a list of cards build by file read
    */
    public static List<Card> load_hand(string name)
    {
        List<Card> cards = new List<Card>();
        string[] readText;        
        string path_file = Directory.GetCurrentDirectory();
            
        //testa em qual sistema operacional o código está executando
        //linux e windows tem diferença na escrita do caminho
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            path_file += "/02_data/"; // linux way
        else
            path_file += "\\02_data\\"; // windows way
                
        //ShowText.print_text("\nDigite o nome do arquivo");
        //path_file += Input.get_text();        
        path_file += name;
        try // try to read a file in path_file
        {
            readText = File.ReadAllLines(path_file)!;
        }
        catch ( System.IO.FileNotFoundException ex)
        { // if it fails 
            ShowText.print_text(ex.Message);
            ShowText.print_text("\n\nSystem.IO.FileNotFoundException - CLOSING!\n\n");
            throw; // close the program.
        }

        foreach(var line in readText)
        { // for each line, creats one card
            string[] fields = line.Split(';'); //each field is an argument to the card object creation 
            Card card = new Card
            (
                Enum.Parse<Semantic.Suit>(fields[0]),
                Enum.Parse<Semantic.CardRank>(fields[1]),
                int.Parse(fields[2])
            );
            cards.Add(card); // add to cards
        }
        return cards; // return cards
    }
}