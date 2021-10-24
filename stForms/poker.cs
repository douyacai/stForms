using Baseline.ImTools;
using ImTools;
using System;
using System.Collections.Generic;
using System.Text;

namespace stForms
{
    class poker : IDisposable
    {
        private string num;
        private string card;

        public poker()
        {

        }

        public poker(string Poker_card, string Poker_num)
        {
            this.num = Poker_num;
            this.card = Poker_card;
        }

        public poker Create_poker(string Poker_num, string Poker_card)
        {
            this.num = Poker_num;
            this.card = Poker_card;
            return this;
        }

        public string getPoker_card()
        {
            return this.card;
        }

        public string getPoker_num()
        {
            return this.num;
        }

        public string getCard_Internet()
        {
            string pokerInfo = this.num;
            if (int.Parse(this.num) > 10)
            {
                if (this.num == "11") pokerInfo += "J";
                else if (this.num == "12") pokerInfo += "Q";
                else pokerInfo += "K";
            }
            else pokerInfo += this.num;
            return pokerInfo;
        }

        public string getPokerImg()
        {
            string poker_Type = "";
            if (this.card == "S") poker_Type = "黑桃";
            else if (this.card == "H") poker_Type = "红桃";
            else if (this.card == "D") poker_Type = "梅花";
            else poker_Type = "方块";
            return poker_Type + this.num + ".jpg";
        }

        public bool Equal(poker another)
        {
            if (this.num == another.num &&
                this.card == another.card) return true;
            return false;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }

}
