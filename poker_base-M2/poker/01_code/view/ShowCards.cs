using poker.code.model;
namespace poker.code.view;

/*
 * Para exibir cartas formatadas como texto.
*/
public class ShowCards 
{
    public static void show_cards (Stack<Card> cards)
    {
        // Limpa a tela do console.
        Console.Clear();
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("A list of cards");                                        // Exibe texto
        Console.WriteLine("---------------------------------------------------");

        // Loop que itera sobre cada carta na pilha de cartas cards.
        foreach (var item in cards)
        {
            // Converte a carta para uma representação de string.
            string tmp = item.ToString();
            // Imprime a representação da carta.
            Console.WriteLine(tmp);                
        }
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Press any key to continue");                               //  // Exibe texto (instrução)
        Console.WriteLine("---------------------------------------------------");
        Console.ReadKey();
    }
    // Exibe um histograma das listas de cartas fornecidas como parâmetro
    public static void show_histogram(List<List<Card>> histo)
    {
        // Variável de controle para o índice das listas.
        int ctrl = 0;
        //Limpa tela
        Console.Clear();
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("A list of cards");                                        // Mostra texto
        Console.WriteLine("---------------------------------------------------");

        // Loop que itera sobre cada lista de cartas no histograma.
        foreach(var list in histo)
        {
            // Verifica se a lista atual está vazia.
        	if (list.Count == 0)
        		Console.WriteLine($"Cards in index: {ctrl} - 0"); // Se estiver vazia, exibe que não há cartas.
        	else
            {
                Console.WriteLine($"Cards in index: {ctrl}"); // Se não estiver vazia, exibe o índice da lista.
                 // Loop que itera sobre cada carta na lista atual.
        		for (int i = 0 ; i < list.Count ; i++)        			
        			Console.WriteLine("\t\t" + list[i].ToString());  // Exibe cada carta da lista.
        }
            }
            ctrl++;
        }
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Press any key to continue");                             // Mostra texto de instrução
        Console.WriteLine("---------------------------------------------------");
        Console.ReadKey();
    }
    // Método que recebe um objeto 'Card' como parâmetro e retorna uma representação em string dessa carta.
    public static string get_card_string(Card card)
    {
        string rankString;
        switch (card.rank_)
        {
            case Semantic.CardRank.Jack: // Caso o valor da carta seja um Jack.
                rankString = " J"; // Define a representação como "J".
                break;
            case Semantic.CardRank.Queen: // Caso o valor da carta seja uma Queen.
                rankString = " Q"; // Define a representação como "Q".
                break;
            case Semantic.CardRank.King: // Caso o valor da carta seja um King.
                rankString = " K"; // Define a representação como "K".
                break;
            case Semantic.CardRank.Ace: // Caso o valor da carta seja um King.
                rankString = " A"; // Define a representação como "K".
                break;
            default: // Se não for nenhum dos valores especiais (Jack, Queen, King, Ace).
                
                int value = card.get_value(); // Obtém o valor numérico da carta.
                rankString = value < 10 ? "0" : ""; // Se o valor for menor que 10, adiciona um zero à esquerda.
                rankString += (value).ToString(); // Converte o valor em string e o adiciona à representação.
                break;
        }

        char suitSymbol = ' ';
        switch (card.suit_) // Símbolos dos naipes
        {
            case Semantic.Suit.Hearts:
                suitSymbol = '\u2665'; // ♥
                break;
            case Semantic.Suit.Diamonds:
                suitSymbol = '\u2666'; // ♦
                break;
            case Semantic.Suit.Clubs:
                suitSymbol = '\u2663'; // ♣
                break;
            case Semantic.Suit.Spades:
                suitSymbol = '\u2660'; // ♠
                break;
        }
        return $"{rankString}:{suitSymbol}";
    }
}
