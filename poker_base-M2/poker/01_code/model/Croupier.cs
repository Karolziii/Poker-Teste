
using System;
using System.Collections.Generic;

namespace poker.code.model;
public class Croupier : Person 
{
    // Atributo privado para armazenar as cartas do croupier
    private Stack<Card> cards;
    public Croupier (string n, int a) : base (n, a) 
    {
        cards = new Stack<Card> (); // Inicializa o deck como uma pilha vazia
        creat_deck(); // Cria o deck de cartas
    }

    // Método privado para criar um novo deck de cartas
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
    
    // Método público para embaralhar o deck de cartas
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
    
    // Método público para obter o deck de cartas
    public Stack<Card> get_deck()
    {
        return cards;
    }
}
