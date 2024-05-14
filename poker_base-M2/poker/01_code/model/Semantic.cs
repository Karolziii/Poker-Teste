namespace poker.code.model;

/*
 * Classe que define enums e constants
 */
public class Semantic
{
    //constantes para posicionar o cursor e pintar na tela
    public const int LEFT = 0, CARD_TOP1 = 03, CARD_TOP2 = 13, FOOTER = 22;
    public enum Suit
    {
        Hearts = 1, // Copas
        Diamonds,   // Ouros
        Clubs,      // Paus
        Spades      // Espadas
    }
    // Enumeração para os valores das cartas
    public enum CardRank
    { //valor numérico para cada carta
        Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
        Jack, Queen, King, Ace
    }
    public enum HandRank
    {
        HighCard = 1,   // Carta Alta: A mão de menor valor.
        OnePair,        // Um Par: Duas cartas do mesmo valor.
        TwoPair,        // Dois Pares: Dois pares diferentes de cartas do mesmo valor.
        ThreeOfAKind,   // Trinca: Três cartas do mesmo valor.
        Straight,       // Sequência: Cinco cartas em sequência numérica.
        Flush,          // Flush (Cor): Cinco cartas do mesmo naipe, não em sequência.
        FullHouse,      // Full House: Três cartas de um valor e duas cartas de outro valor.
        FourOfAKind,    // Quadra: Quatro cartas do mesmo valor.
        StraightFlush,  // Straight Flush: Cinco cartas em sequência numérica, todas do mesmo naipe.
        RoyalFlush      // Royal Flush: A, K, Q, J, 10, todos do mesmo naipe.
    }
}
