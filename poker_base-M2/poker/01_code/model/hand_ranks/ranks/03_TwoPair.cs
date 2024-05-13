using System;
using System.Collections.Generic;

namespace poker.code.model.hand_ranks.ranks
{
    public class TwoPair : Ranks
    {
        List<Card> player; // armazena as cartas do jogador
        List<List<Card>> two; // armazena os pares encontrados

        public TwoPair(List<List<Card>> h) : base(h)
        {
            player = new List<Card>();
            two = new List<List<Card>>();
        }

        // implementação específica da classe Two Pair para o método abstrato da classe base
        public override bool check()
        {
            FindPairs();
            return two.Count >= 2; // retorna true se pelo menos dois pares forem encontrados
        }

        // verifica se há pares de cartas e armazena os pares encontrados
        private void FindPairs()
        {
            for (int i = 2; i < ranks_histo.Count; i++)
            {
                if (ranks_histo[i].Count == 2) // verifica se há um par de cartas
                {
                    two.Add(value_copy(ranks_histo[i])); // adiciona o par encontrado à lista de pares
                    foreach (var card in ranks_histo[i])
                    {
                        if (card.owner == 1) // verifica se a carta pertence ao jogador
                        {
                            player.Add(card); // adiciona a carta ao jogador se ele for o proprietário
                        }
                    }
                }
            }
        }
    }
}