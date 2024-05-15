
using poker.code.view;
using poker.code.model;
using poker.code.model.hand_ranks;
using poker.code.model.hand_ranks.ranks;

namespace poker.code.controller;
/*
Classe para testes
*/
public class Test
{
    //---------------------------------------------------------------------------------
    // Variável de instância / estados
    //---------------------------------------------------------------------------------
    private List<Card> loded_cards; // cards to evaluate (7)
    string rank_name; // name of the hand hank in evaluation
    string file_name; // file name of readed file
    private bool check_; // to control a miss or hit
    
    //---------------------------------------------------------------------------------
    //comportamentos
    //---------------------------------------------------------------------------------
    public Test(string n, List<Card> cs) // constructor / in object creation
    {
        this.check_ = false; 
        this.rank_name = "";
        this.file_name = n;
        this.loded_cards = new List<Card>(cs);
    }
    
    public void full_test()
    {
        //vocês devem implementar uma lógica que mostre a execução de testes
        //um para cada mão de poker possível (10 ao total)
    }

    /*
    Método para fazer e mostrar o test single (one file.csv)
    */
    public void single_test()
    {
        // Cria um objeto Histograma para analisar as cartas carregadas
        Histogram histogram = new Histogram(loded_cards);
        switch (file_name)
        {
            case "01.csv":
                // Cria um objeto HighCard para verificar a presença de uma carta alta
                HighCard high = new HighCard(histogram.get_histogram());
                // Executa a verificação e armazena o resultado
                check_ = high.check();
                Console.WriteLine("check_: " + check_);
                // Define o nome da classificação
                rank_name = "01.csv - HighCard";
                // Mostra os resultados
                draw_single(high);
                break;
            case "02.csv":
                // Cria um objeto OnePair para verificar a presença de um par
                OnePair one = new OnePair(histogram.get_histogram());
                check_ = one.check();
                Console.WriteLine("check_: " + check_);
                rank_name  = "02.csv - OnePair";
                draw_single(one);
                break;
            case "03.csv":
                // Cria um objeto TwoPair para verificar a presença de dois pares
                TwoPair two = new TwoPair(histogram.get_histogram());
                check_ = two.check();
                Console.WriteLine("check_: " + check_);
                rank_name  = "03.csv - TwoPair";
                draw_single(two);
                break;
            case "04.csv":
                // Cria um objeto ThreeofaKind para verificar a presença de uma trinca
                ThreeofaKind three = new ThreeofaKind(histogram.get_histogram());
                check_ = three.check();
                Console.WriteLine("check_: " + check_);
                rank_name = "04.csv - ThreeofaKind";
                draw_single(three);
                break;
            case "05.csv":
                // Cria um objeto Straight para verificar a presença de uma sequência
                Straight straightCards = new Straight(histogram.get_histogram());
                check_ = straightCards.check();
                Console.WriteLine("check_: " + check_);
                rank_name = "04.csv - Straight";
                draw_single(straightCards);
                break;
            case "06.csv":
                // Cria um objeto Flush para verificar a presença de um flush
                Flush flush = new Flush(histogram.get_histogram());
                check_ = flush.check();
                Console.WriteLine("check_: " + check_);
                rank_name = "04.csv - Flush";
                draw_single(flush);
                break;
            case "07.csv":
                // Cria um objeto FullHouse para verificar a presença de uma full house
                FullHouse full = new FullHouse(histogram.get_histogram());
                check_ = full.check();
                Console.WriteLine("check_: " + check_);
                rank_name = "07.csv - FullHouse";
                draw_single(full);
                break;
            case "08.csv":
                // Cria um objeto FourOfKind para verificar a presença de uma quadra
                FourOfKind four = new FourOfKind(histogram.get_histogram());
                check_ = four.check();
                Console.WriteLine("check_: " + check_);
                rank_name = "08.csv - FourOfKind";
                draw_single(four);
                break;
            case "09.csv":
                // Cria um objeto StraightFlush para verificar a presença de um straight flush
                StraightFlush straightFlush = new StraightFlush(histogram.get_histogram());
                check_ = straightFlush.check();
                Console.WriteLine("check_: " + check_);
                rank_name = "09.csv - StraightFlush";
                draw_single(straightFlush);
                break;
            case "10.csv":
                // Cria um objeto RoyalFlush para verificar a presença de um royal flush
                RoyalFlush royal = new RoyalFlush(histogram.get_histogram());
                check_ = royal.check();
                rank_name = "10.csv - RoyalFlush";
                draw_single(royal);
                break;
        }
    }

    // Método privado para exibir os resultados da análise
    private void draw_single(Ranks rank)    
    {
        // Constrói a mensagem a ser exibida com base na classificação e no resultado da verificação
        string msg = rank_name;
        if (this.check_)
            msg += " - FOUND!";
        else
            msg += " - NOT FOUND!";

        // Exibe a mensagem
        ShowText.show_single(msg);
        // Exibe as cartas carregadas
        DrawCards.display_cards(loded_cards, Semantic.LEFT, Semantic.CARD_TOP1);
        // Exibe as cartas relevantes para a classificação
        DrawCards.display_cards(rank.get_find(), Semantic.LEFT, Semantic.CARD_TOP2);
        // Define a posição do cursor para exibir o rodapé
        Console.SetCursorPosition(Semantic.LEFT, Semantic.FOOTER);
        // Exibe o rodapé com base na mensagem
        ShowText.show_footer(msg);
    }
}
