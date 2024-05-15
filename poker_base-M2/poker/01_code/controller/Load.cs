
using poker.code.model;
using poker.code.view;
namespace poker.code.controller;
using System.Runtime.InteropServices;

/*
// Classe para carregar arquivos em modo de teste
// Uma classe estática não necessariamente cria objetos
*/
public class Load
{
    //---------------------------------------------------------------------------------
    //Comportamentos
    //---------------------------------------------------------------------------------
    
    /*Este método recebe como parâmetro o nome do arquivo.
       Retorna uma lista de cartas construídas pela leitura do arquivo.
    */
    public static List<Card> load_hand(string name)
    {
        List<Card> cards = new List<Card>(); // Lista para armazenar as cartas
        string[] readText; // Array para armazenar as linhas lidas do arquivo        
        string path_file = Directory.GetCurrentDirectory(); // Obtém o diretório atual
            
        // Verifica em qual sistema operacional o código está sendo executado
        // Linux e Windows têm diferenças na escrita do caminho
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