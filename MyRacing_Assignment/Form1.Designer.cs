namespace MyRacing_Assignment
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
            this.imgMonkey = new System.Windows.Forms.PictureBox();
            this.imgMicky = new System.Windows.Forms.PictureBox();
            this.imgKoala = new System.Windows.Forms.PictureBox();
            this.imgJerry = new System.Windows.Forms.PictureBox();
            this.pbxRaceTrack = new System.Windows.Forms.PictureBox();
            this.Betting = new System.Windows.Forms.GroupBox();
            this.betAmount = new System.Windows.Forms.NumericUpDown();
            this.btnBet = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblDavid = new System.Windows.Forms.Label();
            this.lblPeter = new System.Windows.Forms.Label();
            this.lblSonia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPlayer = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.rbDavid = new System.Windows.Forms.RadioButton();
            this.rbPeter = new System.Windows.Forms.RadioButton();
            this.rbSonia = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.imgMonkey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMicky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgKoala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgJerry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRaceTrack)).BeginInit();
            this.Betting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // imgMonkey
            // 
            this.imgMonkey.Image = global::MyRacing_Assignment.Properties.Resources.monkey;
            this.imgMonkey.Location = new System.Drawing.Point(56, 468);
            this.imgMonkey.Name = "imgMonkey";
            this.imgMonkey.Size = new System.Drawing.Size(51, 67);
            this.imgMonkey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMonkey.TabIndex = 4;
            this.imgMonkey.TabStop = false;
            // 
            // imgMicky
            // 
            this.imgMicky.Image = global::MyRacing_Assignment.Properties.Resources.micky;
            this.imgMicky.Location = new System.Drawing.Point(55, 401);
            this.imgMicky.Name = "imgMicky";
            this.imgMicky.Size = new System.Drawing.Size(52, 61);
            this.imgMicky.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMicky.TabIndex = 3;
            this.imgMicky.TabStop = false;
            // 
            // imgKoala
            // 
            this.imgKoala.Image = global::MyRacing_Assignment.Properties.Resources.koala;
            this.imgKoala.Location = new System.Drawing.Point(56, 321);
            this.imgKoala.Name = "imgKoala";
            this.imgKoala.Size = new System.Drawing.Size(51, 63);
            this.imgKoala.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgKoala.TabIndex = 2;
            this.imgKoala.TabStop = false;
            // 
            // imgJerry
            // 
            this.imgJerry.Image = global::MyRacing_Assignment.Properties.Resources.jerry;
            this.imgJerry.Location = new System.Drawing.Point(56, 245);
            this.imgJerry.Name = "imgJerry";
            this.imgJerry.Size = new System.Drawing.Size(51, 57);
            this.imgJerry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgJerry.TabIndex = 1;
            this.imgJerry.TabStop = false;
            // 
            // pbxRaceTrack
            // 
            this.pbxRaceTrack.BackColor = System.Drawing.Color.Transparent;
            this.pbxRaceTrack.Image = global::MyRacing_Assignment.Properties.Resources.race_border;
            this.pbxRaceTrack.Location = new System.Drawing.Point(23, 207);
            this.pbxRaceTrack.Name = "pbxRaceTrack";
            this.pbxRaceTrack.Size = new System.Drawing.Size(978, 368);
            this.pbxRaceTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRaceTrack.TabIndex = 0;
            this.pbxRaceTrack.TabStop = false;
            // 
            // Betting
            // 
            this.Betting.Controls.Add(this.betAmount);
            this.Betting.Controls.Add(this.btnBet);
            this.Betting.Controls.Add(this.btnReset);
            this.Betting.Controls.Add(this.lblDavid);
            this.Betting.Controls.Add(this.lblPeter);
            this.Betting.Controls.Add(this.lblSonia);
            this.Betting.Controls.Add(this.label2);
            this.Betting.Controls.Add(this.label1);
            this.Betting.Controls.Add(this.cbxPlayer);
            this.Betting.Controls.Add(this.btnStart);
            this.Betting.Controls.Add(this.rbDavid);
            this.Betting.Controls.Add(this.rbPeter);
            this.Betting.Controls.Add(this.rbSonia);
            this.Betting.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Betting.ForeColor = System.Drawing.Color.Red;
            this.Betting.Location = new System.Drawing.Point(42, 12);
            this.Betting.Name = "Betting";
            this.Betting.Size = new System.Drawing.Size(943, 189);
            this.Betting.TabIndex = 5;
            this.Betting.TabStop = false;
            this.Betting.Text = "Betting";
            //this.Betting.Enter += new System.EventHandler(this.Betting_Enter);
            // 
            // betAmount
            // 
            this.betAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betAmount.ForeColor = System.Drawing.Color.Blue;
            this.betAmount.Location = new System.Drawing.Point(797, 38);
            this.betAmount.Name = "betAmount";
            this.betAmount.Size = new System.Drawing.Size(120, 26);
            this.betAmount.TabIndex = 13;
            // 
            // btnBet
            // 
            this.btnBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnBet.Location = new System.Drawing.Point(487, 151);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(140, 32);
            this.btnBet.TabIndex = 12;
            this.btnBet.Text = "Place Bet";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.Location = new System.Drawing.Point(645, 151);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(140, 32);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblDavid
            // 
            this.lblDavid.AutoSize = true;
            this.lblDavid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDavid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblDavid.Location = new System.Drawing.Point(275, 141);
            this.lblDavid.Name = "lblDavid";
            this.lblDavid.Size = new System.Drawing.Size(0, 20);
            this.lblDavid.TabIndex = 10;
            // 
            // lblPeter
            // 
            this.lblPeter.AutoSize = true;
            this.lblPeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPeter.Location = new System.Drawing.Point(275, 97);
            this.lblPeter.Name = "lblPeter";
            this.lblPeter.Size = new System.Drawing.Size(0, 20);
            this.lblPeter.TabIndex = 9;
            // 
            // lblSonia
            // 
            this.lblSonia.AutoSize = true;
            this.lblSonia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSonia.Location = new System.Drawing.Point(275, 48);
            this.lblSonia.Name = "lblSonia";
            this.lblSonia.Size = new System.Drawing.Size(0, 20);
            this.lblSonia.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(793, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(641, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Player";
            // 
            // cbxPlayer
            // 
            this.cbxPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPlayer.ForeColor = System.Drawing.Color.Blue;
            this.cbxPlayer.FormattingEnabled = true;
            this.cbxPlayer.Location = new System.Drawing.Point(645, 38);
            this.cbxPlayer.Name = "cbxPlayer";
            this.cbxPlayer.Size = new System.Drawing.Size(121, 28);
            this.cbxPlayer.TabIndex = 4;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnStart.Location = new System.Drawing.Point(797, 151);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(140, 32);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rbDavid
            // 
            this.rbDavid.AutoSize = true;
            this.rbDavid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbDavid.Location = new System.Drawing.Point(14, 134);
            this.rbDavid.Name = "rbDavid";
            this.rbDavid.Size = new System.Drawing.Size(91, 30);
            this.rbDavid.TabIndex = 2;
            this.rbDavid.TabStop = true;
            this.rbDavid.Text = "David";
            this.rbDavid.UseVisualStyleBackColor = true;
            this.rbDavid.CheckedChanged += new System.EventHandler(this.rbDavid_CheckedChanged);
            // 
            // rbPeter
            // 
            this.rbPeter.AutoSize = true;
            this.rbPeter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbPeter.Location = new System.Drawing.Point(14, 90);
            this.rbPeter.Name = "rbPeter";
            this.rbPeter.Size = new System.Drawing.Size(87, 30);
            this.rbPeter.TabIndex = 1;
            this.rbPeter.TabStop = true;
            this.rbPeter.Text = "Peter";
            this.rbPeter.UseVisualStyleBackColor = true;
            this.rbPeter.CheckedChanged += new System.EventHandler(this.rbPeter_CheckedChanged);
            // 
            // rbSonia
            // 
            this.rbSonia.AutoSize = true;
            this.rbSonia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbSonia.Location = new System.Drawing.Point(14, 48);
            this.rbSonia.Name = "rbSonia";
            this.rbSonia.Size = new System.Drawing.Size(91, 30);
            this.rbSonia.TabIndex = 0;
            this.rbSonia.TabStop = true;
            this.rbSonia.Text = "Sonia";
            this.rbSonia.UseVisualStyleBackColor = true;
            this.rbSonia.CheckedChanged += new System.EventHandler(this.rbSonia_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 626);
            this.Controls.Add(this.Betting);
            this.Controls.Add(this.imgMonkey);
            this.Controls.Add(this.imgMicky);
            this.Controls.Add(this.imgKoala);
            this.Controls.Add(this.imgJerry);
            this.Controls.Add(this.pbxRaceTrack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgMonkey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMicky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgKoala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgJerry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRaceTrack)).EndInit();
            this.Betting.ResumeLayout(false);
            this.Betting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxRaceTrack;
        private System.Windows.Forms.PictureBox imgJerry;
        private System.Windows.Forms.PictureBox imgKoala;
        private System.Windows.Forms.PictureBox imgMicky;
        private System.Windows.Forms.PictureBox imgMonkey;
        private System.Windows.Forms.GroupBox Betting;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblDavid;
        private System.Windows.Forms.Label lblPeter;
        private System.Windows.Forms.Label lblSonia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPlayer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RadioButton rbDavid;
        private System.Windows.Forms.RadioButton rbPeter;
        private System.Windows.Forms.RadioButton rbSonia;
        private System.Windows.Forms.NumericUpDown betAmount;
    }
}

