//m4rc3lo - 26/04/202
using poker.code.view;
using poker.code.model;
using poker.code.model.hand_ranks;
using poker.code.model.hand_ranks.ranks;

namespace poker.code.controller;
/*
Class to handle tests
*/
public class Test
{
    //---------------------------------------------------------------------------------
    // instance variables / states
    //---------------------------------------------------------------------------------
    private List<Card> loded_cards; // cards to evaluate (7)
    string rank_name; // name of the hand hank in evaluation
    string file_name; // file name of readed file
    private bool check_; // to control a miss or hit
    
    //---------------------------------------------------------------------------------
    //behaviors
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
    Method to run and show a single test (one file.csv)
    */
    public void single_test()
    {
        // A histogram a object of type Histogram.
        Histogram histogram = new Histogram(loded_cards);
        switch (file_name)
        {
            case "01.csv":
                HighCard high = new HighCard(histogram.get_histogram());
                check_ = high.check();
                Console.WriteLine("check_: " + check_);
                rank_name = "01.csv - HighCard";
                draw_single(high);
                break;
            case "02.csv":
                OnePair one = new OnePair(histogram.get_histogram());
                check_ = one.check();
                Console.WriteLine("check_: " + check_);
                rank_name  = "02.csv - OnePair";
                draw_single(one);
                break;
            case "03.csv":
                TwoPair two = new TwoPair(histogram.get_histogram());
                check_ = two.check();
                Console.WriteLine("check_: " + check_);
                rank_name  = "03.csv - TwoPair";
                draw_single(two);
                break;
            case "04.csv":
                ThreeofaKind three = new ThreeofaKind(histogram.get_histogram());
                check_ = three.check();
                Console.WriteLine("check_: " + check_);
                rank_name = "04.csv - ThreeofaKind";
                draw_single(three);
                break;
            case "05.csv":
                Straight straightCards = new Straight(histogram.get_histogram());
                check_ = straightCards.check();
                Console.WriteLine("check_: " + check_);
                rank_name = "04.csv - Straight";
                draw_single(straightCards);
                break;
            case "06.csv":
                Flush flush = new Flush(histogram.get_histogram());
                check_ = flush.check();
                Console.WriteLine("check_: " + check_);
                rank_name = "04.csv - Flush";
                draw_single(flush);
                break;
            case "07.csv":
                FullHouse full = new FullHouse(histogram.get_histogram());
                check_ = full.check();
                Console.WriteLine("check_: " + check_);
                rank_name = "07.csv - FullHouse";
                draw_single(full);
                break;
            case "08.csv":
                FourOfKind four = new FourOfKind(histogram.get_histogram());
                check_ = four.check();
                Console.WriteLine("check_: " + check_);
                rank_name = "08.csv - FourOfKind";
                draw_single(four);
                break;
            case "09.csv":
                StraightFlush straightFlush = new StraightFlush(histogram.get_histogram());
                check_ = straightFlush.check();
                Console.WriteLine("check_: " + check_);
                rank_name = "09.csv - StraightFlush";
                draw_single(straightFlush);
                break;
            case "10.csv":
                RoyalFlush royal = new RoyalFlush(histogram.get_histogram());
                check_ = royal.check();
                rank_name = "10.csv - RoyalFlush";
                draw_single(royal);
                break;
        }
    }

    private void draw_single(Ranks rank)    
    {
        string msg = rank_name;
        if (this.check_)
            msg += " - FOUND!";
        else
            msg += " - NOT FOUND!";

        ShowText.show_single(msg);
        DrawCards.display_cards(loded_cards, Semantic.LEFT, Semantic.CARD_TOP1);
        DrawCards.display_cards(rank.get_find(), Semantic.LEFT, Semantic.CARD_TOP2);
        Console.SetCursorPosition(Semantic.LEFT, Semantic.FOOTER);
        ShowText.show_footer(msg);
    }
}
