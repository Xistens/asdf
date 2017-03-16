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
            this.lblName = new System.Windows.Forms.Label();
            this.btnName = new System.Windows.Forms.Button();
            this.txbLvl = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblZeroDiff = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(279, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label1";
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(253, 174);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(90, 26);
            this.btnName.TabIndex = 1;
            this.btnName.Text = "button1";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // txbLvl
            // 
            this.txbLvl.Location = new System.Drawing.Point(205, 107);
            this.txbLvl.Name = "txbLvl";
            this.txbLvl.Size = new System.Drawing.Size(144, 20);
            this.txbLvl.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblZeroDiff
            // 
            this.lblZeroDiff.AutoSize = true;
            this.lblZeroDiff.Location = new System.Drawing.Point(279, 46);
            this.lblZeroDiff.Name = "lblZeroDiff";
            this.lblZeroDiff.Size = new System.Drawing.Size(45, 13);
            this.lblZeroDiff.TabIndex = 4;
            this.lblZeroDiff.Text = "ZeroDiff";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 494);
            this.Controls.Add(this.lblZeroDiff);
            this.Controls.Add(this.txbLvl);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.lblName);
            this.Name = "Game";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.TextBox txbLvl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblZeroDiff;
    }
}

