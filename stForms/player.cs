using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stForms
{
    class Player : IDisposable
    {
        private Stack<poker> spade; //♠
        private Stack<poker> heart; //♥
        private Stack<poker> club; //♣️
        private Stack<poker> diamond; //♦
        public Player()
        {
            this.spade = new Stack<poker>();
            this.heart = new Stack<poker>();
            this.club = new Stack<poker>();
            this.diamond = new Stack<poker>();
        }
        #region 出牌操作
        public poker get_Spade()
        {
            return this.spade.Pop();
        }
        public poker get_Heart()
        {
            return this.heart.Pop();
        }
        public poker get_Club()
        {
            return this.club.Pop();
        }
        public poker get_Diamond()
        {
            return this.diamond.Pop();
        }
        #endregion

        #region 收牌操作
        public void push_Diamond(poker temp)
        {
            this.diamond.Push(temp);
        }
        public void push_Spade(poker temp)
        {
            this.spade.Push(temp);
        }
        public void push_Heart(poker temp)
        {
            this.heart.Push(temp);
        }
        public void push_Club(poker temp)
        {
            this.club.Push(temp);
        }
        #endregion

        #region 获取手牌术
        public int H_num()
        {
            return this.heart.Count();
        }
        public int C_num()
        {
            return this.club.Count();
        }
        public int D_num()
        {
            return this.diamond.Count();
        }
        public int S_num()
        {
            return this.spade.Count();
        }
        public int Poker_Sum()
        {
            return this.S_num() + this.H_num() + this.D_num() + this.C_num();
        }
        #endregion

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
