using System;
using System.Collections.Generic;

namespace poker.code.model.hand_ranks.ranks
{
     /*
    *   Classe para avaliar a categoria One Pair.
    *   Classe Base: Ranks
    */
    public class OnePair : Ranks
    {
        //---------------------------------------------------------------------------------
        // Estados
        //---------------------------------------------------------------------------------
        // Construtor (classe / base)

        List<Card> player; // armazena as cartas da pessoa
        List<List<Card>> one; // temporária para a sequência específica

        // Construtor da classe OnePair
        public OnePair (List<List<Card>> h) : base (h)
        {   
            // Inicializa a lista de cartas do jogador
            player = new List<Card>();

            // Inicializa a lista temporária para armazenar sequências específicas
            one = new List<List<Card>>();
        }

        // Implementação específica da classe One Pair para o método abstrato da classe base
        public override bool check()
        {
            FindPairs(); // verifica se há pares de cartas na mão do jogador
            return player.Count > 0; // retorna true se tiver pelo menos um par na mão do jogador
        }

        // Verifica se há pares de cartas e armazena o par encontrado
        private void FindPairs()
        {
            //  Itera a partir do índice 2
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

            } // Fim do loop for
            
        }
    } // Fim da classe

} // Fim do namespace