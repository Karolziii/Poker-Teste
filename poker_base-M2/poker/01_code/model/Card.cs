//m4rc3lo - 2024-04-28
using System;
namespace poker.code.model;
/*
 *  Class to abstract(represent) a card.
*/
public class Card
{

    //---------------------------------------------------------------------------------
    //states (properties)
    //---------------------------------------------------------------------------------
    public Semantic.Suit suit_ {get; private set;} // represents the suit
    public Semantic.CardRank rank_ {get; private set;} // represents the numerical value
    public int owner {get; set;}
   
    //---------------------------------------------------------------------------------
    //behaviors
    //---------------------------------------------------------------------------------
    
    //constructors
    public Card(Semantic.Suit s, Semantic.CardRank r)
    {// to deck build
        this.suit_ = s;
        this.rank_ = r;
        this.owner = 0; // deck | 1 hand player
    }
    
    public Card(Semantic.Suit s, Semantic.CardRank r, int o)
    {// to file cards
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