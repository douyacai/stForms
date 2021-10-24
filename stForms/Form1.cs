using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            MessageBox.Show("登陆成功");
            Game_form Game_screen = new Game_form();
            Game_screen.StartPosition = FormStartPosition.Manual;
            Game_screen.Location = this.Location;
            this.Hide();
            Game_screen.ShowDialog();
            this.Dispose();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
