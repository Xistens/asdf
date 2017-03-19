namespace CommandCenter
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnName = new System.Windows.Forms.Button();
            this.txbLvl = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblGain = new System.Windows.Forms.Label();
            this.txtEnemyLevel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblXPNeeded = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPl_Level = new System.Windows.Forms.Label();
            this.txtGiveXp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCurrentEXP = new System.Windows.Forms.Label();
            this.btnBaseXP = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(178, 354);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(90, 26);
            this.btnName.TabIndex = 1;
            this.btnName.Text = "button1";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // txbLvl
            // 
            this.txbLvl.Location = new System.Drawing.Point(180, 287);
            this.txbLvl.Name = "txbLvl";
            this.txbLvl.Size = new System.Drawing.Size(144, 20);
            this.txbLvl.TabIndex = 2;
            this.txbLvl.Text = "1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblGain
            // 
            this.lblGain.AutoSize = true;
            this.lblGain.Location = new System.Drawing.Point(279, 96);
            this.lblGain.Name = "lblGain";
            this.lblGain.Size = new System.Drawing.Size(43, 13);
            this.lblGain.TabIndex = 6;
            this.lblGain.Text = "XPGain";
            // 
            // txtEnemyLevel
            // 
            this.txtEnemyLevel.Location = new System.Drawing.Point(330, 287);
            this.txtEnemyLevel.Name = "txtEnemyLevel";
            this.txtEnemyLevel.Size = new System.Drawing.Size(144, 20);
            this.txtEnemyLevel.TabIndex = 7;
            this.txtEnemyLevel.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Player lvl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enemy lvl";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "XPGain";
            // 
            // lblXPNeeded
            // 
            this.lblXPNeeded.AutoSize = true;
            this.lblXPNeeded.Location = new System.Drawing.Point(281, 126);
            this.lblXPNeeded.Name = "lblXPNeeded";
            this.lblXPNeeded.Size = new System.Drawing.Size(29, 13);
            this.lblXPNeeded.TabIndex = 14;
            this.lblXPNeeded.Text = "XPN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "XP Needed";
            // 
            // lblPl_Level
            // 
            this.lblPl_Level.AutoSize = true;
            this.lblPl_Level.Location = new System.Drawing.Point(279, 153);
            this.lblPl_Level.Name = "lblPl_Level";
            this.lblPl_Level.Size = new System.Drawing.Size(26, 13);
            this.lblPl_Level.TabIndex = 16;
            this.lblPl_Level.Text = "LVL";
            // 
            // txtGiveXp
            // 
            this.txtGiveXp.Location = new System.Drawing.Point(180, 328);
            this.txtGiveXp.Name = "txtGiveXp";
            this.txtGiveXp.Size = new System.Drawing.Size(144, 20);
            this.txtGiveXp.TabIndex = 17;
            this.txtGiveXp.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Give xp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Current Level:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Current EXP:";
            // 
            // lblCurrentEXP
            // 
            this.lblCurrentEXP.AutoSize = true;
            this.lblCurrentEXP.Location = new System.Drawing.Point(279, 176);
            this.lblCurrentEXP.Name = "lblCurrentEXP";
            this.lblCurrentEXP.Size = new System.Drawing.Size(28, 13);
            this.lblCurrentEXP.TabIndex = 21;
            this.lblCurrentEXP.Text = "EXP";
            // 
            // btnBaseXP
            // 
            this.btnBaseXP.Location = new System.Drawing.Point(274, 354);
            this.btnBaseXP.Name = "btnBaseXP";
            this.btnBaseXP.Size = new System.Drawing.Size(90, 26);
            this.btnBaseXP.TabIndex = 22;
            this.btnBaseXP.Text = "Base exp";
            this.btnBaseXP.UseVisualStyleBackColor = true;
            this.btnBaseXP.Click += new System.EventHandler(this.btnBaseXP_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(56, 37);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(33, 13);
            this.lblTime.TabIndex = 23;
            this.lblTime.Text = "TIME";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 494);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnBaseXP);
            this.Controls.Add(this.lblCurrentEXP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGiveXp);
            this.Controls.Add(this.lblPl_Level);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblXPNeeded);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnemyLevel);
            this.Controls.Add(this.lblGain);
            this.Controls.Add(this.txbLvl);
            this.Controls.Add(this.btnName);
            this.Name = "Game";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.TextBox txbLvl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblGain;
        private System.Windows.Forms.TextBox txtEnemyLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblXPNeeded;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPl_Level;
        private System.Windows.Forms.TextBox txtGiveXp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCurrentEXP;
        private System.Windows.Forms.Button btnBaseXP;
        private System.Windows.Forms.Label lblTime;
    }
}

