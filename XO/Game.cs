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
    public partial class Game : Form
    {
        private playerOption player;
        public Game(playerOption _player)
        {
            player = _player;
            InitializeComponent();
        }
        
        private void Game_Load(object sender, EventArgs e)
        {

        }
    }
}
