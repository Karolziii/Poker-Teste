//m4rcelo - 2024-04-23
using poker.code.model;
namespace poker.code.view;

/*
 * To display formated cards as text.
*/
public class ShowCards // comentar o resto da classe
{
    public static void show_cards (Stack<Card> cards)
    {
        Console.Clear();
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("A list of cards");
        Console.WriteLine("---------------------------------------------------");
        foreach (var item in cards)
        {
            string tmp = item.ToString();
            Console.WriteLine(tmp);                
        }
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Press any key to continue");
        Console.WriteLine("---------------------------------------------------");
        Console.ReadKey();
    }
    public static void show_histogram(List<List<Card>> histo)
    {
        int ctrl = 0;
        Console.Clear();
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("A list of cards");
        Console.WriteLine("---------------------------------------------------");
        foreach(var list in histo)
        {
        	if (list.Count == 0)
        		Console.WriteLine($"Cards in index: {ctrl} - 0");
        	else
            {
                Console.WriteLine($"Cards in index: {ctrl}");		
        		for (int i = 0 ; i < list.Count ; i++)        			
        			Console.WriteLine("\t\t" + list[i].ToString());
            }
            ctrl++;
        }
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Press any key to continue");
        Console.WriteLine("---------------------------------------------------");
        Console.ReadKey();
    }
    public static string get_card_string(Card card)
    {
        string rankString;
        switch (card.rank_)
        {
            case Semantic.CardRank.Jack:
                rankString = " J";
                break;
            case Semantic.CardRank.Queen:
                rankString = " Q";
                break;
            case Semantic.CardRank.King:
                rankString = " K";
                break;
            case Semantic.CardRank.Ace:
                rankString = " A";
                break;
            default:
                int value = card.get_value();
                rankString = value < 10 ? "0" : "";
                rankString += (value).ToString();
                break;
        }

        char suitSymbol = ' ';
        switch (card.suit_)
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