using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stForms
{
    class Local_War : Form
    {
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private PictureBox pictureBox3;
        #region 数据定义
        private Stack<poker> poker_Lib; // 牌堆
        private Stack<poker> poker_tmp; // 出牌摸牌区
        private poker[] Card_Lib = new poker[60];
        private poker Card_tmp;
        private Random randint = new Random();
        private Player P1;
        private TextBox P1_text_S;
        private TextBox P1_text_H;
        private TextBox P1_text_C;
        private TextBox P1_text_D;
        private TextBox textBox7;
        private Player AI;
        #endregion

        public Local_War()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.P1_text_S = new System.Windows.Forms.TextBox();
            this.P1_text_H = new System.Windows.Forms.TextBox();
            this.P1_text_C = new System.Windows.Forms.TextBox();
            this.P1_text_D = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::stForms.Properties.Resources.beimain2;
            this.pictureBox1.Location = new System.Drawing.Point(249, 223);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 213);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::stForms.Properties.Resources.beimain2;
            this.pictureBox2.Location = new System.Drawing.Point(460, 223);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 213);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::stForms.Properties.Resources.beimain2;
            this.pictureBox3.Location = new System.Drawing.Point(663, 223);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(146, 212);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(273, 190);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 27);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "数量";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(691, 190);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(85, 27);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "数量";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 81);
            this.button1.TabIndex = 5;
            this.button1.Text = "黑桃";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.P1_Push_S);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 81);
            this.button2.TabIndex = 6;
            this.button2.Text = "红桃";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.P1_Push_H);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 355);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 81);
            this.button3.TabIndex = 7;
            this.button3.Text = "方块";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.P1_Push_C);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(29, 466);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 81);
            this.button4.TabIndex = 8;
            this.button4.Text = "梅花";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.P1_Push_D);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(932, 476);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 81);
            this.button5.TabIndex = 9;
            this.button5.Text = "梅花";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(932, 354);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(133, 81);
            this.button6.TabIndex = 10;
            this.button6.Text = "方块";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(932, 239);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(133, 81);
            this.button7.TabIndex = 11;
            this.button7.Text = "红桃";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(932, 136);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(133, 81);
            this.button8.TabIndex = 12;
            this.button8.Text = "黑桃";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // P1_text_S
            // 
            this.P1_text_S.Location = new System.Drawing.Point(165, 149);
            this.P1_text_S.Name = "P1_text_S";
            this.P1_text_S.Size = new System.Drawing.Size(33, 27);
            this.P1_text_S.TabIndex = 13;
            // 
            // P1_text_H
            // 
            this.P1_text_H.Location = new System.Drawing.Point(165, 264);
            this.P1_text_H.Name = "P1_text_H";
            this.P1_text_H.Size = new System.Drawing.Size(32, 27);
            this.P1_text_H.TabIndex = 14;
            // 
            // P1_text_C
            // 
            this.P1_text_C.Location = new System.Drawing.Point(165, 382);
            this.P1_text_C.Name = "P1_text_C";
            this.P1_text_C.Size = new System.Drawing.Size(32, 27);
            this.P1_text_C.TabIndex = 15;
            // 
            // P1_text_D
            // 
            this.P1_text_D.Location = new System.Drawing.Point(165, 496);
            this.P1_text_D.Name = "P1_text_D";
            this.P1_text_D.Size = new System.Drawing.Size(32, 27);
            this.P1_text_D.TabIndex = 16;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(978, 89);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(40, 27);
            this.textBox7.TabIndex = 17;
            // 
            // Local_War
            // 
            this.BackgroundImage = global::stForms.Properties.Resources.R_C;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.P1_text_D);
            this.Controls.Add(this.P1_text_C);
            this.Controls.Add(this.P1_text_H);
            this.Controls.Add(this.P1_text_S);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Local_War";
            this.Text = "单人模式";
            this.Load += new System.EventHandler(this.Lwar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (poker_Lib.Count != 0)
            {
                this.Card_tmp = new poker();
                Card_tmp = poker_Lib.Pop();
                this.pictureBox2.Image = Image.FromFile(@"..\..\..\Resources\" + Card_tmp.getPokerImg());
                this.pictureBox2.Refresh();
                this.textBox1.Text = Convert.ToString(poker_Lib.Count());
                this.textBox1.Refresh();
                Thread.Sleep(1000);
                if (this.poker_judge() == 2)
                {
                    poker_tmp.Push(Card_tmp);
                    this.pictureBox2.Image = Image.FromFile(@"..\..\..\Resources\beimain2.jpg");
                    this.pictureBox2.Refresh();
                    this.pictureBox3.Image = Image.FromFile(@"..\..\..\Resources\" + Card_tmp.getPokerImg());
                    this.pictureBox3.Refresh();
                    this.textBox2.Text = Convert.ToString(poker_tmp.Count());
                    this.textBox2.Refresh();
                    Thread.Sleep(500);
                }
                else if (this.poker_judge() == 1)
                {
                    poker_tmp.Push(Card_tmp);
                    Licensing_poker(P1);
                    this.pictureBox2.Image = Image.FromFile(@"..\..\..\Resources\beimain2.jpg");
                    this.pictureBox2.Refresh();
                    this.pictureBox3.Image = Image.FromFile(@"..\..\..\Resources\beimain2.jpg");
                    this.pictureBox3.Refresh();
                    this.textBox2.Text = Convert.ToString(poker_tmp.Count());
                    this.textBox2.Refresh();
                    this.P1_text_S.Text = Convert.ToString(this.P1.S_num());
                    this.P1_text_S.Refresh();
                    this.P1_text_H.Text = Convert.ToString(this.P1.H_num());
                    this.P1_text_H.Refresh();
                    this.P1_text_D.Text = Convert.ToString(this.P1.D_num());
                    this.P1_text_D.Refresh();
                    this.P1_text_C.Text = Convert.ToString(this.P1.C_num());
                    this.P1_text_C.Refresh();
                    Thread.Sleep(500);
                }
            }
            if (this.poker_Lib.Count() == 0)
            {
                int Py1_sum = 0;
                int Py2_sum = 0;
                Py1_sum = this.P1.Poker_Sum();
                Py2_sum = this.AI.Poker_Sum();
                if (Py1_sum > Py2_sum)
                {
                    MessageBox.Show("右方胜！！！");
                }
                else if (Py1_sum < Py2_sum)
                {
                    MessageBox.Show("左方胜！！！");
                }
                else
                {
                    MessageBox.Show("这么有缘在一起吧！");
                }
                Game_form Game_screen = new Game_form();
                Game_screen.StartPosition = FormStartPosition.Manual;
                Game_screen.Location = this.Location;
                this.Hide();
                Game_screen.ShowDialog();
                this.Dispose();
            }
            this.AI_operate();
        }
        #region 笨笨AI设计
        private void AI_operate()
        {
            if (this.AI.Poker_Sum() > this.P1.Poker_Sum())
            {
                int i = randint.Next(4);
                if (i == 0)
                {
                    if (this.AI.S_num() != 0)
                        this.AI_Get_cards(this.AI.get_Spade());
                    else
                        this.AI_Touch_cards();
                }
                else if (i == 1)
                {
                    if (this.AI.H_num() != 0)
                        this.AI_Get_cards(this.AI.get_Heart());
                    else
                        this.AI_Touch_cards();
                }
                else if (i == 2)
                {
                    if (this.AI.C_num() != 0)
                        this.AI_Get_cards(this.AI.get_Club());
                    else
                        this.AI_Touch_cards();
                }
                else if (i == 4)
                {
                    if (this.AI.D_num() != 0)
                        this.AI_Get_cards(this.AI.get_Diamond());
                    else
                        this.AI_Touch_cards();
                }
            }
            else if (this.AI.Poker_Sum() <= this.P1.Poker_Sum())
            {
                this.AI_Touch_cards();
            }
        }
        public void AI_Get_cards(poker temp) // 人机出牌处理
        {
            this.Card_tmp = new poker();
            this.Card_tmp = temp;
            this.pictureBox2.Image = Image.FromFile(@"..\..\..\Resources\" + this.Card_tmp.getPokerImg());
            this.pictureBox2.Refresh();
            this.textBox7.Text = Convert.ToString(AI.Poker_Sum());
            this.textBox7.Refresh();
            Thread.Sleep(1000);
            if (this.poker_judge() == 2)
            {
                poker_tmp.Push(Card_tmp);
                this.pictureBox2.Image = Image.FromFile(@"..\..\..\Resources\beimain2.jpg");
                this.pictureBox2.Refresh();
                this.pictureBox3.Image = Image.FromFile(@"..\..\..\Resources\" + this.Card_tmp.getPokerImg());
                this.pictureBox3.Refresh();
                this.textBox2.Text = Convert.ToString(poker_tmp.Count());
                this.textBox2.Refresh();
                Thread.Sleep(500);
            }
            else if (this.poker_judge() == 1)
            {
                poker_tmp.Push(Card_tmp);
                Licensing_poker(AI);
                this.pictureBox2.Image = Image.FromFile(@"..\..\..\Resources\beimain2.jpg");
                this.pictureBox2.Refresh();
                this.pictureBox3.Image = Image.FromFile(@"..\..\..\Resources\beimain2.jpg");
                this.pictureBox3.Refresh();
                this.textBox2.Text = Convert.ToString(poker_tmp.Count());
                this.textBox2.Refresh();
                this.textBox2.Text = Convert.ToString(poker_tmp.Count());
                this.textBox2.Refresh();
                this.textBox7.Text = Convert.ToString(this.AI.Poker_Sum());
                this.textBox7.Refresh();
                Thread.Sleep(500);
            }
        }
        public void AI_Touch_cards() // 人机摸牌处理
        {
            if (poker_Lib.Count != 0)
            {
                this.Card_tmp = new poker();
                Card_tmp = poker_Lib.Pop();
                this.pictureBox2.Image = Image.FromFile(@"..\..\..\Resources\" + Card_tmp.getPokerImg());
                this.pictureBox2.Refresh();
                this.textBox1.Text = Convert.ToString(poker_Lib.Count());
                this.textBox1.Refresh();
                Thread.Sleep(1000);
                if (this.poker_judge() == 2)
                {
                    poker_tmp.Push(Card_tmp);
                    this.pictureBox2.Image = Image.FromFile(@"..\..\..\Resources\beimain2.jpg");
                    this.pictureBox2.Refresh();
                    this.pictureBox3.Image = Image.FromFile(@"..\..\..\Resources\" + Card_tmp.getPokerImg());
                    this.pictureBox3.Refresh();
                    this.textBox2.Text = Convert.ToString(poker_tmp.Count());
                    this.textBox2.Refresh();
                    Thread.Sleep(500);
                }
                else if (this.poker_judge() == 1)
                {
                    poker_tmp.Push(Card_tmp);
                    Licensing_poker(AI);
                    this.pictureBox2.Image = Image.FromFile(@"..\..\..\Resources\beimain2.jpg");
                    this.pictureBox2.Refresh();
                    this.pictureBox3.Image = Image.FromFile(@"..\..\..\Resources\beimain2.jpg");
                    this.pictureBox3.Refresh();
                    this.textBox2.Text = Convert.ToString(poker_tmp.Count());
                    this.textBox2.Refresh();
                    this.textBox7.Text = Convert.ToString(this.AI.Poker_Sum());
                    this.textBox7.Refresh();
                    Thread.Sleep(500);
                }
            }
            if (this.poker_Lib.Count() == 0)
            {
                int Py1_sum = 0;
                int Py2_sum = 0;
                Py1_sum = this.P1.Poker_Sum();
                Py2_sum = this.AI.Poker_Sum();
                if (Py1_sum > Py2_sum)
                {
                    MessageBox.Show("右方胜！！！");
                }
                else if (Py1_sum < Py2_sum)
                {
                    MessageBox.Show("左方胜！！！");
                }
                else
                {
                    MessageBox.Show("奈何人机殊途，你走吧！");
                }
                Game_form Game_screen = new Game_form();
                Game_screen.StartPosition = FormStartPosition.Manual;
                Game_screen.Location = this.Location;
                this.Hide();
                Game_screen.ShowDialog();
                this.Dispose();
            }
        }
        #endregion

        private void Lwar_Load(object sender, EventArgs e)
        {
            this.P1 = new Player();
            this.AI = new Player();
            this.Card_tmp = new poker();
            this.randint = new Random();
            this.poker_Lib = new Stack<poker>();
            this.poker_tmp = new Stack<poker>();
            this.create_card();
            this.poker_shuffle();
            this.push_poker();
            this.textBox1.Text = Convert.ToString(this.poker_Lib.Count());
            this.textBox1.Refresh();
        }
        #region 卡牌处理
        public void create_card() // 生成卡牌
        {
            int Card_count = 0;
            for (int i = 1; i <= 13; i++, Card_count++)
            {
                Card_Lib[Card_count] = new poker("S", Convert.ToString(i));
            }
            for (int i = 1; i <= 13; i++, Card_count++)
            {
                Card_Lib[Card_count] = new poker("H", Convert.ToString(i));
            }
            for (int i = 1; i <= 13; i++, Card_count++)
            {
                Card_Lib[Card_count] = new poker("C", Convert.ToString(i));
            }
            for (int i = 1; i <= 13; i++, Card_count++)
            {
                Card_Lib[Card_count] = new poker("D", Convert.ToString(i));
            }

        }
        public void poker_shuffle()  // 洗牌操作
        {
            for (int i = 0; i < 52; i++)
            {
                this.Card_tmp = new poker();
                int index = randint.Next(52);
                Card_tmp = Card_Lib[i];
                Card_Lib[i] = Card_Lib[index];
                Card_Lib[index] = Card_tmp;
            }
        }
        public void push_poker() // 将洗好的牌放入牌堆栈中
        {

            for (int i = 0; i < 52; i++)
            {
                poker_Lib.Push(Card_Lib[i]);
            }
        }
        public int poker_judge()
        {
            if (poker_tmp.Count() == 0)
            {
                return 2;
            }
            else if (this.Card_tmp.getPoker_card() == poker_tmp.Peek().getPoker_card())
                return 1;
            else
                return 2;
        }
        #endregion
        #region 玩家操作
        public void Licensing_poker(Player py)
        {
            int num = poker_tmp.Count();
            for (int i = 0; i < num; i++)
            {
                this.Card_tmp = new poker();
                this.Card_tmp = poker_tmp.Pop();
                if (this.Card_tmp.getPoker_card() == "S")
                {
                    py.push_Spade(this.Card_tmp);
                }
                else if (this.Card_tmp.getPoker_card() == "H")
                {
                    py.push_Heart(this.Card_tmp);
                }
                else if (this.Card_tmp.getPoker_card() == "C")
                {
                    py.push_Club(this.Card_tmp);
                }
                else if (this.Card_tmp.getPoker_card() == "D")
                {
                    py.push_Diamond(this.Card_tmp);
                }
            }
        }
        #endregion

        private void P1_Push_S(object sender, EventArgs e)
        {
            if (this.P1.S_num() == 0)
            {
                MessageBox.Show("别动没牌了，程序崩了怪你！");
            }
            else
            {
                this.Card_tmp = new poker();
                this.Card_tmp = this.P1.get_Spade();
                this.pictureBox2.Image = Image.FromFile(@"..\..\..\Resources\" + this.Card_tmp.getPokerImg());
                this.pictureBox2.Refresh();
                this.P1_text_S.Text = Convert.ToString(P1.S_num());
                this.P1_text_S.Refresh();
                Thread.Sleep(1000);
                if (this.poker_judge() == 2)
                {
                    poker_tmp.Push(Card_tmp);
                    this.pictureBox2.Image = Image.FromFile(@"..\..\..\Resources\beimain2.jpg");
                    this.pictureBox2.Refresh();
                    this.pictureBox3.Image = Image.FromFile(@"..\..\..\Resources\" + this.Card_tmp.getPokerImg());
                    this.pictureBox3.Refresh();
                    this.textBox2.Text = Convert.ToString(poker_tmp.Count());
                    this.textBox2.Refresh();
                    Thread.Sleep(500);
                }
                else if (this.poker_judge() == 1)
                {
                    poker_tmp.Push(Card_tmp);
                    Licensing_poker(P1);
                    this.P1_text_S.Text = Convert.ToString(this.P1.S_num());
                    this.P1_text_S.Refresh();
                    this.P1_text_H.Text = Convert.ToString(this.P1.H_num());
                    this.P1_text_H.Refresh();
                    this.P1_text_D.Text = Convert.ToString(this.P1.D_num());
                    this.P1_text_D.Refresh();
                    this.P1_text_C.Text = Convert.ToString(this.P1.C_num());
                    this.P1_text_C.Refresh();
                    this.pictureBox2.Image = Image.FromFile(@"..\..\..\Resources\beimain2.jpg");
                    this.pictureBox2.Refresh();
                    this.pictureBox3.Image = Image.FromFile(@"..\..\..\Resources\beimain2.jpg");
                    this.pictureBox3.Refresh();
                    this.textBox2.Text = Convert.ToString(poker_tmp.Count());
                    this.textBox2.Refresh();
                    Thread.Sleep(500);
                }
            }
            this.AI_operate();
        }

        private void P1_Push_H(object sender, EventArgs e)
        {
            if (this.P1.H_num() == 0)
            {
                MessageBox.Show("别动没牌了，程序崩了怪你！");
            }
            else
            {
                this.Card_tmp = new poker();
                this.Card_tmp = this.P1.get_Heart();
                this.pictureBox2.Image = Image.FromFile(@"..\..\..\Resources\" + this.Card_tmp.getPokerImg());
                this.pictureBox2.Refresh();
                this.P1_text_H.Text = Convert.ToString(P1.H_num());
                this.P1_text_H.Refresh();
                Thread.Sleep(1000);
                if (this.poker_judge() == 2)
                {
                    poker_tmp.Push(Card_tmp);
                    this.pictureBox2.Image = Image.FromFile(@"..\..\..\Resources\beimain2.jpg");
                    this.pictureBox2.Refresh();
                    this.pictureBox3.Image = Image.FromFile(@"..\..\..\Resources\" + this.Card_tmp.getPokerImg());
                    this.pictureBox3.Refresh();
                    this.textBox2.Text = Convert.ToString(poker_tmp.Count());
                    this.textBox2.Refresh();
                    Thread.Sleep(500);
                }
                else if (this.poker_judge() == 1)
                {
                    poker_tmp.Push(Card_tmp);
                    Licensing_poker(P1);
                    this.P1_text_S.Text = Convert.ToString(this.P1.S_num());
                    this.P1_text_S.Refresh();
                    this.P1_text_H.Text = Convert.ToString(this.P1.H_num());
                    this.P1_text_H.Refresh();
                    this.P1_text_D.Text = Convert.ToString(this.P1.D_num());
                    this.P1_text_D.Refresh();
                    this.P1_text_C.Text = Convert.ToString(this.P1.C_num());
                    this.P1_text_C.Refresh();
                    this.pictureBox2.Image = Image.FromFile(@"..\..\..\Resources\beimain2.jpg");
                    this.pictureBox2.Refresh();
                    this.pictureBox3.Image = Image.FromFile(@"..\..\..\Resources\beimain2.jpg");
                    this.pictureBox3.Refresh();
                    this.textBox2.Text = Convert.ToString(poker_tmp.Count());
                    this.textBox2.Refresh();
                    Thread.Sleep(500);
                }
            }
            this.AI_operate();
        }

        private void P1_Push_C(object sender, EventArgs e)
        {
            if (this.P1.C_num() == 0)
            {
                MessageBox.Show("别动没牌了，程序崩了怪你！");
            }
            else
            {
                this.Card_tmp = new poker();
                this.Card_tmp = this.P1.get_Club();
                this.pictureBox2.Image = Image.FromFile(@"..\..\..\Resources\" + this.Card_tmp.getPokerImg());
                this.pictureBox2.Refresh();
                this.P1_text_C.Text = Convert.ToString(P1.C_num());
                this.P1_text_C.Refresh();
                Thread.Sleep(1000);
                if (this.poker_judge() == 2)
                {
                    poker_tmp.Push(Card_tmp);
                    this.pictureBox2.Image = Image.FromFile(@"..\..\..\Resources\beimain2.jpg");
                    this.pictureBox2.Refresh();
                    this.pictureBox3.Image = Image.FromFile(@"..\..\..\Resources\" + this.Card_tmp.getPokerImg());
                    this.pictureBox3.Refresh();
                    this.textBox2.Text = Convert.ToString(poker_tmp.Count());
                    this.textBox2.Refresh();
                    Thread.Sleep(500);
                }
                else if (this.poker_judge() == 1)
                {
                    poker_tmp.Push(Card_tmp);
                    Licensing_poker(P1);
                    this.P1_text_S.Text = Convert.ToString(this.P1.S_num());
                    this.P1_text_S.Refresh();
                    this.P1_text_H.Text = Convert.ToString(this.P1.H_num());
                    this.P1_text_H.Refresh();
                    this.P1_text_D.Text = Convert.ToString(this.P1.D_num());
                    this.P1_text_D.Refresh();
                    this.P1_text_C.Text = Convert.ToString(this.P1.C_num());
                    this.P1_text_C.Refresh();
                    this.pictureBox2.Image = Image.FromFile(@"..\..\..\Resources\beimain2.jpg");
                    this.pictureBox2.Refresh();
                    this.pictureBox3.Image = Image.FromFile(@"..\..\..\Resources\beimain2.jpg");
                    this.pictureBox3.Refresh();
                    this.textBox2.Text = Convert.ToString(poker_tmp.Count());
                    this.textBox2.Refresh();
                    Thread.Sleep(500);
                }
            }
            this.AI_operate();
        }

        private void P1_Push_D(object sender, EventArgs e)
        {
            if (this.P1.D_num() == 0)
            {
                MessageBox.Show("别动没牌了，程序崩了怪你！");
            }
            else
            {
                this.Card_tmp = new poker();
                this.Card_tmp = this.P1.get_Diamond();
                this.pictureBox2.Image = Image.FromFile(@"..\..\..\Resources\" + this.Card_tmp.getPokerImg());
                this.pictureBox2.Refresh();
                this.P1_text_D.Text = Convert.ToString(P1.D_num());
                this.P1_text_D.Refresh();
                Thread.Sleep(1000);
                if (this.poker_judge() == 2)
                {
                    poker_tmp.Push(Card_tmp);
                    this.pictureBox2.Image = Image.FromFile(@"..\..\..\Resources\beimain2.jpg");
                    this.pictureBox2.Refresh();
                    this.pictureBox3.Image = Image.FromFile(@"..\..\..\Resources\" + this.Card_tmp.getPokerImg());
                    this.pictureBox3.Refresh();
                    this.textBox2.Text = Convert.ToString(poker_tmp.Count());
                    this.textBox2.Refresh();
                    Thread.Sleep(500);
                }
                else if (this.poker_judge() == 1)
                {
                    poker_tmp.Push(Card_tmp);
                    Licensing_poker(P1);
                    this.P1_text_S.Text = Convert.ToString(this.P1.S_num());
                    this.P1_text_S.Refresh();
                    this.P1_text_H.Text = Convert.ToString(this.P1.H_num());
                    this.P1_text_H.Refresh();
                    this.P1_text_D.Text = Convert.ToString(this.P1.D_num());
                    this.P1_text_D.Refresh();
                    this.P1_text_C.Text = Convert.ToString(this.P1.C_num());
                    this.P1_text_C.Refresh();
                    this.pictureBox2.Image = Image.FromFile(@"..\..\..\Resources\beimain2.jpg");
                    this.pictureBox2.Refresh();
                    this.pictureBox3.Image = Image.FromFile(@"..\..\..\Resources\beimain2.jpg");
                    this.pictureBox3.Refresh();
                    this.textBox2.Text = Convert.ToString(poker_tmp.Count());
                    this.textBox2.Refresh();
                    Thread.Sleep(500);
                }
            }
            this.AI_operate();
        }
    }
}
