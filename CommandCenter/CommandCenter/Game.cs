using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using src;

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
            Formulas xp = new Formulas();
            uint pl_level = uint.Parse(txbLvl.Text);
            uint victim_level = uint.Parse(txtEnemyLevel.Text);

            lblGain.Text = xp.BaseGain(pl_level, victim_level).ToString();
            lblXPNeeded.Text = xp.XPRequired(pl_level).ToString();
        }
    }
}
