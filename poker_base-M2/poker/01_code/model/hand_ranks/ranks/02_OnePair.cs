// Karoline Dutra - 07/05/24
// Mão One Pair do poker

using System;
using System.Collections.Generic;
namespace poker.code.model.hand_ranks.ranks
{
    public class OnePair : Ranks
    {
        List<Card> player; // armazena as cartas da pessoa
        List<List<Card>> one; // temporária para a sequência específica

        public OnePair (List<List<Card>> h) : base (h)
        {
            player = new List<Card>();
            one = new List<List<Card>>();
        }

        // implementação específica da classe One Pair para o método abstrato da classe base

        public override bool check()
        {
            FindPairs();
            return player.Count > 0; // retorna true se tiver pelo menos um par na mão do jogador
        }

        // verifica se há pares de cartas e armazena o par encontrado
        private void FindPairs()
        {
            for (int i = 2; i < ranks_histo.Count; i++)
            {
                if (ranks_histo[i].Count == 2) // verifica se há um par de cartas
                {
                    one.Add(value_copy(ranks_histo[i])); // adiciona o par encontrado a lista de pares
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