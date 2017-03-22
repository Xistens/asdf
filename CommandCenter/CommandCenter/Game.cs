using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


using src;
using src.Events;
using src.Items;
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

            _Player.OnMessage += DisplayMessage;

            // DataGrid Weapons
            dgvWeapons.RowHeadersVisible = false;
            dgvWeapons.AutoGenerateColumns = false;
            dgvWeapons.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Name",
                DataPropertyName = "Name"
            });
            dgvWeapons.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Damage",
                DataPropertyName = "GetBaseDamage"
            });
            dgvWeapons.ScrollBars = ScrollBars.Vertical;
            dgvWeapons.DataSource = World.weapons;

            // DataGrid Inventory
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.AutoGenerateColumns = false;
            dgvInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Name",
                DataPropertyName = "Description"
            });

            dgvInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Quantity",
                DataPropertyName = "Quantity"
            });
            dgvInventory.ScrollBars = ScrollBars.Vertical;
            dgvInventory.DataSource = _Player.PlayerInventory.UnitInventory;


            // ComboBox players weapon from inventory
            cboWeapon.DataSource = _Player.PlayerInventory.Weapons;
            cboWeapon.DisplayMember = "Name";
            cboWeapon.ValueMember = "Id";

            if (_Player.CurrentWeapon != null)
            {
                cboWeapon.SelectedItem = _Player.CurrentWeapon;
            }

            cboWeapon.SelectedIndexChanged += cboWeapons_SelectedIndexChanged;

        }

        private void DisplayMessage(object sender, MessageEventArgs messageEventArgs)
        {
            rtbEvents.Text += messageEventArgs.Message + Environment.NewLine;

            if(messageEventArgs.AddExtraNewLine)
            {
                rtbEvents.Text += Environment.NewLine;
            }

            rtbEvents.SelectionStart = rtbEvents.Text.Length;
            rtbEvents.ScrollToCaret();
        }


        private void PlayerOnPropertyChange(Object sender, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            if (propertyChangedEventArgs.PropertyName == "Weapons")
            {
                cboWeapon.DataSource = _Player.PlayerInventory.Weapons;
            }
        }

        // Event - Set weapon to players current weapon
        private void cboWeapons_SelectedIndexChanged(object sender, EventArgs e)
        {
            int weaponId = Convert.ToInt32(cboWeapon.SelectedValue);
            _Player.EquipWeapon(weaponId);
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            uint lvl = _Player.UnitLevel;
            uint plPlayerLevel = _Player.UnitLevel;
            Weapon CurrWeapon = _Player.CurrentWeapon;

            if (CurrWeapon == null)
            {
                lblCurrentWeapon.Text = "";
            }
            else
            {
                lblCurrentWeapon.Text = CurrWeapon.Name.ToString();
            }

            lblGain.Text = Experience.BaseGain(plPlayerLevel, plPlayerLevel).ToString();
            lblXPNeeded.Text = Experience.XPRequired(_Player.UnitLevel).ToString();
            lblPl_Level.Text = lvl.ToString();
            lblCurrentEXP.Text = _Player.experiencePoints.ToString();
            lblTime.Text = _Player.IsDead.ToString();
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
            uint giveExp = Experience.BaseGain(plPlayerLevel, plPlayerLevel);
            _Player.SetExperience(giveExp);
            UpdateDisplay();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            lblDamage.Text = _Player.CalculateDamage().ToString();
        }

        private void btnAddWeapon_Click(object sender, EventArgs e)
        {
            int last = cboWeapon.SelectedIndex;
            _Player.PlayerInventory.AddItemToInventory(World.weapons[3], _Player, 1);
            cboWeapon.DataSource = _Player.PlayerInventory.Weapons;

            cboWeapon.SelectedIndex = last;
        }
    }
}
