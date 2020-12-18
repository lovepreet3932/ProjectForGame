namespace ProjectForGame
{
    partial class Form1
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
            this.ForGunShooting = new System.Windows.Forms.Label();
            this.Exitthegame = new System.Windows.Forms.Button();
            this.ForGunShootAway = new System.Windows.Forms.Label();
            this.SpinBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ShootIMZ = new System.Windows.Forms.PictureBox();
            this.GunReloadingIMZ = new System.Windows.Forms.PictureBox();
            this.GunSHootAway = new System.Windows.Forms.PictureBox();
            this.MainBackgroundIMZ = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ShootIMZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GunReloadingIMZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GunSHootAway)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBackgroundIMZ)).BeginInit();
            this.SuspendLayout();
            // 
            // ForGunShooting
            // 
            this.ForGunShooting.AutoSize = true;
            this.ForGunShooting.Location = new System.Drawing.Point(345, 237);
            this.ForGunShooting.Name = "ForGunShooting";
            this.ForGunShooting.Size = new System.Drawing.Size(58, 13);
            this.ForGunShooting.TabIndex = 22;
            this.ForGunShooting.Text = "Gun Shoot";
            this.ForGunShooting.Click += new System.EventHandler(this.ForGunShooting_Click);
            // 
            // Exitthegame
            // 
            this.Exitthegame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Exitthegame.ForeColor = System.Drawing.Color.White;
            this.Exitthegame.Location = new System.Drawing.Point(698, 301);
            this.Exitthegame.Margin = new System.Windows.Forms.Padding(2);
            this.Exitthegame.Name = "Exitthegame";
            this.Exitthegame.Size = new System.Drawing.Size(51, 30);
            this.Exitthegame.TabIndex = 17;
            this.Exitthegame.Text = "Exit";
            this.Exitthegame.UseVisualStyleBackColor = false;
            this.Exitthegame.Click += new System.EventHandler(this.Exitthegame_Click);
            // 
            // ForGunShootAway
            // 
            this.ForGunShootAway.AutoSize = true;
            this.ForGunShootAway.Location = new System.Drawing.Point(494, 237);
            this.ForGunShootAway.Name = "ForGunShootAway";
            this.ForGunShootAway.Size = new System.Drawing.Size(64, 13);
            this.ForGunShootAway.TabIndex = 23;
            this.ForGunShootAway.Text = "Shoot Away";
            this.ForGunShootAway.Click += new System.EventHandler(this.ForGunShootAway_Click);
            // 
            // SpinBTN
            // 
            this.SpinBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SpinBTN.ForeColor = System.Drawing.Color.White;
            this.SpinBTN.Location = new System.Drawing.Point(37, 301);
            this.SpinBTN.Margin = new System.Windows.Forms.Padding(2);
            this.SpinBTN.Name = "SpinBTN";
            this.SpinBTN.Size = new System.Drawing.Size(51, 30);
            this.SpinBTN.TabIndex = 24;
            this.SpinBTN.Text = "Spin";
            this.SpinBTN.UseVisualStyleBackColor = false;
            this.SpinBTN.Click += new System.EventHandler(this.SpinBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Gun Reload";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ShootIMZ
            // 
            this.ShootIMZ.Image = global::ProjectForGame.Properties.Resources.ForShoot;
            this.ShootIMZ.Location = new System.Drawing.Point(348, 266);
            this.ShootIMZ.Name = "ShootIMZ";
            this.ShootIMZ.Size = new System.Drawing.Size(55, 52);
            this.ShootIMZ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShootIMZ.TabIndex = 21;
            this.ShootIMZ.TabStop = false;
            this.ShootIMZ.Click += new System.EventHandler(this.ShootIMZ_Click);
            // 
            // GunReloadingIMZ
            // 
            this.GunReloadingIMZ.Image = global::ProjectForGame.Properties.Resources.GunReload;
            this.GunReloadingIMZ.Location = new System.Drawing.Point(201, 275);
            this.GunReloadingIMZ.Name = "GunReloadingIMZ";
            this.GunReloadingIMZ.Size = new System.Drawing.Size(42, 43);
            this.GunReloadingIMZ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GunReloadingIMZ.TabIndex = 19;
            this.GunReloadingIMZ.TabStop = false;
            this.GunReloadingIMZ.Click += new System.EventHandler(this.GunReloadingIMZ_Click);
            // 
            // GunSHootAway
            // 
            this.GunSHootAway.Image = global::ProjectForGame.Properties.Resources.FarShoot;
            this.GunSHootAway.Location = new System.Drawing.Point(497, 266);
            this.GunSHootAway.Name = "GunSHootAway";
            this.GunSHootAway.Size = new System.Drawing.Size(52, 52);
            this.GunSHootAway.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GunSHootAway.TabIndex = 18;
            this.GunSHootAway.TabStop = false;
            this.GunSHootAway.Click += new System.EventHandler(this.GunSHootAway_Click);
            // 
            // MainBackgroundIMZ
            // 
            this.MainBackgroundIMZ.Image = global::ProjectForGame.Properties.Resources.GameBackground;
            this.MainBackgroundIMZ.Location = new System.Drawing.Point(11, 11);
            this.MainBackgroundIMZ.Margin = new System.Windows.Forms.Padding(2);
            this.MainBackgroundIMZ.Name = "MainBackgroundIMZ";
            this.MainBackgroundIMZ.Size = new System.Drawing.Size(758, 326);
            this.MainBackgroundIMZ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainBackgroundIMZ.TabIndex = 16;
            this.MainBackgroundIMZ.TabStop = false;
            this.MainBackgroundIMZ.Click += new System.EventHandler(this.MainBackgroundIMZ_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 342);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SpinBTN);
            this.Controls.Add(this.ForGunShootAway);
            this.Controls.Add(this.ForGunShooting);
            this.Controls.Add(this.ShootIMZ);
            this.Controls.Add(this.GunReloadingIMZ);
            this.Controls.Add(this.GunSHootAway);
            this.Controls.Add(this.Exitthegame);
            this.Controls.Add(this.MainBackgroundIMZ);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ShootIMZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GunReloadingIMZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GunSHootAway)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBackgroundIMZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ForGunShooting;
        private System.Windows.Forms.PictureBox ShootIMZ;
        private System.Windows.Forms.PictureBox GunReloadingIMZ;
        private System.Windows.Forms.PictureBox GunSHootAway;
        private System.Windows.Forms.Button Exitthegame;
        private System.Windows.Forms.PictureBox MainBackgroundIMZ;
        private System.Windows.Forms.Label ForGunShootAway;
        private System.Windows.Forms.Button SpinBTN;
        private System.Windows.Forms.Label label1;
    }
}

