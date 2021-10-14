using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO
{
    public partial class Start : Form
    {
        private bool bt_easy = false;
        private bool bt_med = false;
        private bool bt_hard = false;
        private bool complexity = false;

        private bool bt_x = false;
        private bool bt_o = false;
        private bool pers = false;

        private bool next_stage = false;

        private playerOption player = new playerOption();

        public Start()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bt_easy = true;
            complexity = true;
            button1.BackColor = Color.Green;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            player.Complexity = 1;
            to_next_stage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bt_med = true;
            complexity = true;
            button2.BackColor = Color.Green;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            player.Complexity = 2;
            to_next_stage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bt_hard = true;
            complexity = true;
            button3.BackColor = Color.Green;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            player.Complexity = 3;
            to_next_stage();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bt_x = true;
            pers = true;
            button4.BackColor = Color.Green;
            button4.Enabled = false;
            button5.Enabled = false;
            player.Pers = 1;
            to_next_stage();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bt_o = true;
            pers = true;
            button5.BackColor = Color.Green;
            button4.Enabled = false;
            button5.Enabled = false;
            player.Pers = 0;
            to_next_stage();
        }
        private void to_next_stage()
        {
            if(complexity&&pers)
            {
                Game game = new Game(player);
                this.Hide();
                game.ShowDialog();
            }
        }
    }
}
