using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Engine;

namespace CommandCenter
{
    public partial class Game : Form
    {
        private Player _Player;
        public Game()
        {
            InitializeComponent();
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            _Player = new Player("HEY");
            _Player.TEST.Add(new Hest("Hesasdt", 1));

            Hest one = _Player.TEST[0];

            lblName.Text = one._Name;
        }
    }
}
