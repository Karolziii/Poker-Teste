using System;
using System.Collections.Generic;

namespace poker.code.model.hand_ranks.ranks
{
    public class ThreeofaKind : Ranks
    {
        List<Card> player; // armazena as cartas do jogador
        List<List<Card>> threeOfAKind; // armazena os conjuntos de três cartas

        public ThreeofaKind(List<List<Card>> h) : base(h)
        {
            player = new List<Card>();
            threeOfAKind = new List<List<Card>>();
        }

        // Implementação específica da classe Three Of A Kind para o método abstrato da classe base

        public override bool check()
        {
            FindThreeOfAKind();
            return player.Count > 0; // retorna true se houver pelo menos um Three of a Kind na mão do jogador
        }

        // Verifica se há conjuntos de três cartas com o mesmo valor e armazena o conjunto encontrado
        private void FindThreeOfAKind()
        {
            for (int i = 2; i < ranks_histo.Count; i++)
            {
                if (ranks_histo[i].Count == 3) // verifica se há um conjunto de três cartas com o mesmo valor
                {
                    threeOfAKind.Add(value_copy(ranks_histo[i])); // adiciona o conjunto de três cartas à lista de conjuntos
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