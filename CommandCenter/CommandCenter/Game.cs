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
            Formulas xp = new Formulas();
            Int32 lvl = Int32.Parse(txbLvl.Text);

            lblName.Text = xp.GetGrayLevel(lvl).ToString();
            lblZeroDiff.Text = xp.GetZeroDifference(lvl).ToString();
        }
    }
}
