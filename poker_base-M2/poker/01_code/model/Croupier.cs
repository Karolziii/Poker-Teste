
using System;
using System.Collections.Generic;

namespace poker.code.model;
public class Croupier : Person 
{
    // Declaração de um campo privado chamado cards, que é uma pilha (Stack) de objetos do tipo Card
    private Stack<Card> cards;
    public Croupier (string n, int a) : base (n, a) 
    {
        cards = new Stack<Card> ();
        creat_deck();
    }

    private void creat_deck()
    {
        // Limpar o deck existente
        cards.Clear();

        // Laço duplo para percorrer cada naipe e cada valor
        foreach (Semantic.Suit suit in Enum.GetValues(typeof(Semantic.Suit)))
        {
            foreach (Semantic.CardRank rank in Enum.GetValues(typeof(Semantic.CardRank)))
            {
                // Adicionar nova carta ao deck
                cards.Push(new Card(suit, rank));
            }
        }
    }
    
    public void shuffle()
    {
        var random = new Random();
        var cardsArray = cards.ToArray();
        cards.Clear();

        // Embaralhar o array
        for (int i = cardsArray.Length - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            var temp = cardsArray[i];
            cardsArray[i] = cardsArray[j];
            cardsArray[j] = temp;
        }

        // Recolocar as cartas embaralhadas na pilha
        foreach (var card in cardsArray)
        {
            cards.Push(card);
        }
    }
    
    public Stack<Card> get_deck()
    {
        return cards;
    }
}
