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
    public Semantic.Suit suit_ {get; private set;} // representa suit
    public Semantic.CardRank rank_ {get; private set;} // representa valor numérico
    public int owner {get; set;}
   
    //---------------------------------------------------------------------------------
    //Comportamentos
    //---------------------------------------------------------------------------------
    
    //Construtor
    public Card(Semantic.Suit s, Semantic.CardRank r)
    {// to deck build
        this.suit_ = s;
        this.rank_ = r;
        this.owner = 0; // deck | 1 hand player
    }
    
    public Card(Semantic.Suit s, Semantic.CardRank r, int o)
    {// armazena cartas
        this.suit_ = s;
        this.rank_ = r;
        this.owner = o;
    }
    
    public Card (Card c)
    { // copy constructor
        suit_ = c.suit_;
        rank_ = c.rank_;
        owner = c.owner;
    }

    // gets
    public int get_value()
    {
        return (int)this.rank_;
    }
    
    public int get_suit()
    {
        return (int)this.suit_;
    }
    
    public override string ToString()
    {//Take a text description of de object.
        return $"{rank_} of {suit_}";
    }
}
