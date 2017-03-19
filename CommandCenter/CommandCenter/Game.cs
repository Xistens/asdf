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
using Helpers;

namespace CommandCenter
{
    public partial class Game : Form
    {
        // Just testing... everything will be removed
        private Player _Player;

        public Game()
        {
            InitializeComponent();

            _Player = Player.CreateDefaultPlayer();
            UpdateDisplay();
            
        }

        private void UpdateDisplay()
        {
            uint lvl = _Player.UnitLevel;
            Experience xp = new Experience();
            uint plPlayerLevel = _Player.UnitLevel;

            lblGain.Text = xp.BaseGain(plPlayerLevel, plPlayerLevel).ToString();
            lblXPNeeded.Text = xp.XPRequired(_Player.UnitLevel).ToString();
            lblPl_Level.Text = lvl.ToString();
            lblCurrentEXP.Text = _Player.ExperiencePoints.ToString();

            AppTimer time = new AppTimer();
            lblTime.Text = time.Test().ToString();
        }

        private void btnName_Click(object sender, EventArgs e)
        {

            uint giveExp = uint.Parse(txtGiveXp.Text);

            _Player.SetExperience(giveExp);
            UpdateDisplay();

        }

        private void btnBaseXP_Click(object sender, EventArgs e)
        {
            uint plPlayerLevel = _Player.UnitLevel;
            Experience EXP = new Experience();
            uint giveExp = EXP.BaseGain(plPlayerLevel, plPlayerLevel);
            _Player.SetExperience(giveExp);
            UpdateDisplay();
        }
    }
}
