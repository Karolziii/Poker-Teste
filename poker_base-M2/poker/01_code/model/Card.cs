using System;
namespace poker.code.model;
/*
 *  Classe abstrata para representar carta (Card).
*/
public class Card
{

    //---------------------------------------------------------------------------------
    //Estados (propriedades)
    //---------------------------------------------------------------------------------
    public Semantic.Suit suit_ {get; private set;} // representa suit (naipe)
    public Semantic.CardRank rank_ {get; private set;} // representa valor numérico
    public int owner {get; set;} // Representa o dono da carta (deck: 0, jogador: 1)
   
    //---------------------------------------------------------------------------------
    //Comportamentos
    //---------------------------------------------------------------------------------
    
    // Construtor para construir cartas para o baralho
    public Card(Semantic.Suit s, Semantic.CardRank r)
    {// to deck build
        this.suit_ = s;
        this.rank_ = r;
        this.owner = 0; // deck | 1 hand player
    }
    
    // Construtor para armazenar cartas
    public Card(Semantic.Suit s, Semantic.CardRank r, int o)
    {// armazena cartas
        this.suit_ = s;
        this.rank_ = r;
        this.owner = o;
    }
    
     // Construtor de cópia
    public Card (Card c)
    { 
        suit_ = c.suit_;
        rank_ = c.rank_;
        owner = c.owner;
    }

    // Método para obter o valor numérico da carta
    public int get_value()
    {
        return (int)this.rank_;
    }
    
    // Método para obter o naipe da carta
    public int get_suit()
    {
        return (int)this.suit_;
    }
    
     // Sobrescrita do método ToString para obter uma descrição textual do objeto
    public override string ToString()
    {
        return $"{rank_} of {suit_}";
    }
}
