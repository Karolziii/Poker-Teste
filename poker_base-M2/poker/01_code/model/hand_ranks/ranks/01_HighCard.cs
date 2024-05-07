//m4rc3lo - 2024-04-28
using System;
using System.Collections.Generic;
namespace poker.code.model.hand_ranks.ranks
{
    /*
    *   Class to evaluate High Card rank.
    *   Base Class: Ranks
    */
    public class HighCard : Ranks 
    {
        //---------------------------------------------------------------------------------
        //behaviors
        //---------------------------------------------------------------------------------
        // constructor (class / base)
        public HighCard (List<List<Card>> h) : base (h) {}

        // Dynamic polymorphism 
        public override bool check()
        {
            bool find = true; // to control if found
            List<Card> temp_list = new List<Card>(); // temporary (local list)
            temp_list = this.copy_woner(); 

            Card c1_tmp = temp_list[0];
            Card c2_tmp = temp_list[1];

            if (c1_tmp.get_value() >= c2_tmp.get_value())
                this.find.Add(new Card(c1_tmp));
            else
                this.find.Add(new Card(c2_tmp));
            
            return find;
        }
    }// end class
}// end namespace