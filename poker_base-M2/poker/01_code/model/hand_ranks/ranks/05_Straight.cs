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
        List<Card> player; // armazena as cartas da pessoa
        List<Card> straightCards; // armazena as cartas que formam o straight
        
        //---------------------------------------------------------------------------------
        //behaviors
        //---------------------------------------------------------------------------------
        // constructor (class / base)        
        public Straight(List<List<Card>> h) : base(h) 
        {
            player = new List<Card>();
            straightCards = new List<Card>();
        }
        
        //implementação específica da classe Straight
        //para o método abstrato da classe base
        public override bool check()
        {
            if (chekStraight() && FindOwner())
            {
                foreach (var card in straightCards)
                {
                    if (card.owner == 1)
                        return true;
                }
            }
            return false;
        }

        // verifica se há um straight presente nas cartas
        // se existir, armazena as cartas do straight em straightCards
        private bool chekStraight()
        {
            for (int i = 2; i <= 10; i++)
            {
                if (ranks_histo[i].Count > 0 &&
                    ranks_histo[i + 1].Count > 0 &&
                    ranks_histo[i + 2].Count > 0 &&
                    ranks_histo[i + 3].Count > 0 &&
                    ranks_histo[i + 4].Count > 0)
                {
                    straightCards.Add(ranks_histo[i][0]);
                    straightCards.Add(ranks_histo[i + 1][0]);
                    straightCards.Add(ranks_histo[i + 2][0]);
                    straightCards.Add(ranks_histo[i + 3][0]);
                    straightCards.Add(ranks_histo[i + 4][0]);
                    return true;
                }
            }
            return false;
        }
        
        // verifica se as cartas do straight contêm uma carta do jogador
        private bool FindOwner()
        {
            foreach (var card in straightCards)
            {
                if (card.owner == 1)
                {
                    player.Add(card);
                }
            }
            return player.Count > 0;
        }
    }
}
