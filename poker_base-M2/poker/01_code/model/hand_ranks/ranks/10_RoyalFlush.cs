using System;
using System.Collections.Generic;

namespace poker.code.model.hand_ranks.ranks
{
    /*
    *   Class to evaluate Straight rank.
    *   Base Class: Ranks
    */
    public class Straight : Ranks
    {
        //---------------------------------------------------------------------------------
        //states
        //---------------------------------------------------------------------------------
        // constructor (class / base)
        List<Card> player; // armazena as cartas da pessoa
        List<List<Card>> straightLists; // temporaria para a sequencia especifica
        
        //---------------------------------------------------------------------------------
        //behaviors
        //---------------------------------------------------------------------------------
        // constructor (class / base)        
        public Straight(List<List<Card>> h) : base(h) 
        {
            player = new List<Card>();
            straightLists = new List<List<Card>>();
        }
        
        //implementacao especifica da classe Straight
        //para o metodo abstrato da classe base
        public override bool Check()
        {
            if (CheckStraight() && FindWinner())
            {
                Semantic.Suit suit = FindSuit();
                foreach (var cardsList in straightLists)
                {
                    foreach (var card in cardsList)
                    {
                        if (card.Suit == suit)
                            Find.Add(card);
                    }
                }
                if (Find.Count == 5)
                {
                    foreach (Card c in Find)
                    {
                        if (c.Owner == 1)
                            return true;
                    }
                }
            }
            return false;
        }

        // verifica se existem cartas nas posicoes que satisfacam a sequencia 2, 3, ..., 10, J, Q, K, A 
        // e separa de <lists> as listas especificas da sequencia, colocando em <straightLists> 
        private bool CheckStraight()
        {
            int count = 0;
            for (int i = 2; i < 15; i++)
            {
                if (RanksHisto[i].Count > 0)                
                    count++;
            }       
            return count == 5 ? true : false;
        }
        
        // verifica se existe em <straightLists> uma ou duas cartas da pessoa e, caso exista, coloca em <player>
        private bool FindWinner()
        {
            for (int i = 2; i < 15; i++)
                straightLists.Add(ValueCopy(RanksHisto[i]));
            
            foreach(var list_ in straightLists)
            {
                foreach (var card in list_)
                {
                    if(card.Owner == 1)
                    {
                        player.Add(card);
                    }
                }
            }
            return player.Count > 0 ? true : false;
        }    

        // define o naipe para validar
        private Semantic.Suit FindSuit()
        {
            // neste ponto, obrigatoriamente terá uma lista com um card ...
            Semantic.Suit suit = new Semantic.Suit();
            foreach (var cards in straightLists)
            {
                if (cards.Count == 1)
                    suit = cards[0].Suit;
            }
            return suit;
        }
    }
}
