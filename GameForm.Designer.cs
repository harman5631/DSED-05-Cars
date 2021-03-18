namespace DSED_05_Cars
{
    partial class GameForm
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
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBet = new System.Windows.Forms.Button();
            this.rbFera = new System.Windows.Forms.RadioButton();
            this.rbLambo = new System.Windows.Forms.RadioButton();
            this.rbTes = new System.Windows.Forms.RadioButton();
            this.txtFera = new System.Windows.Forms.TextBox();
            this.txtLambo = new System.Windows.Forms.TextBox();
            this.txtTes = new System.Windows.Forms.TextBox();
            this.numUDbet = new System.Windows.Forms.NumericUpDown();
            this.numUDCarNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.pnlGameOver = new System.Windows.Forms.Panel();
            this.lblLastPunter = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUDbet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCarNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlGameOver.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWinner
            // 
            this.lblWinner.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblWinner.Location = new System.Drawing.Point(825, 434);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(284, 88);
            this.lblWinner.TabIndex = 4;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(717, 434);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(96, 42);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(717, 480);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 42);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(616, 434);
            this.btnBet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(96, 42);
            this.btnBet.TabIndex = 7;
            this.btnBet.Text = "Bet";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // rbFera
            // 
            this.rbFera.AutoSize = true;
            this.rbFera.Location = new System.Drawing.Point(517, 434);
            this.rbFera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFera.Name = "rbFera";
            this.rbFera.Size = new System.Drawing.Size(58, 21);
            this.rbFera.TabIndex = 8;
            this.rbFera.TabStop = true;
            this.rbFera.Text = "Fera";
            this.rbFera.UseVisualStyleBackColor = true;
            this.rbFera.CheckedChanged += new System.EventHandler(this.rbFera_CheckedChanged);
            // 
            // rbLambo
            // 
            this.rbLambo.AutoSize = true;
            this.rbLambo.Location = new System.Drawing.Point(517, 466);
            this.rbLambo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbLambo.Name = "rbLambo";
            this.rbLambo.Size = new System.Drawing.Size(72, 21);
            this.rbLambo.TabIndex = 9;
            this.rbLambo.TabStop = true;
            this.rbLambo.Text = "Lambo";
            this.rbLambo.UseVisualStyleBackColor = true;
            this.rbLambo.CheckedChanged += new System.EventHandler(this.rbLambo_CheckedChanged);
            // 
            // rbTes
            // 
            this.rbTes.AutoSize = true;
            this.rbTes.Location = new System.Drawing.Point(517, 502);
            this.rbTes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbTes.Name = "rbTes";
            this.rbTes.Size = new System.Drawing.Size(53, 21);
            this.rbTes.TabIndex = 10;
            this.rbTes.TabStop = true;
            this.rbTes.Text = "Tes";
            this.rbTes.UseVisualStyleBackColor = true;
            this.rbTes.CheckedChanged += new System.EventHandler(this.rbTes_CheckedChanged);
            // 
            // txtFera
            // 
            this.txtFera.Location = new System.Drawing.Point(16, 433);
            this.txtFera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFera.Name = "txtFera";
            this.txtFera.ReadOnly = true;
            this.txtFera.Size = new System.Drawing.Size(362, 22);
            this.txtFera.TabIndex = 11;
            // 
            // txtLambo
            // 
            this.txtLambo.Location = new System.Drawing.Point(16, 465);
            this.txtLambo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLambo.Name = "txtLambo";
            this.txtLambo.ReadOnly = true;
            this.txtLambo.Size = new System.Drawing.Size(362, 22);
            this.txtLambo.TabIndex = 12;
            // 
            // txtTes
            // 
            this.txtTes.Location = new System.Drawing.Point(16, 501);
            this.txtTes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTes.Name = "txtTes";
            this.txtTes.ReadOnly = true;
            this.txtTes.Size = new System.Drawing.Size(362, 22);
            this.txtTes.TabIndex = 13;
            // 
            // numUDbet
            // 
            this.numUDbet.Location = new System.Drawing.Point(387, 454);
            this.numUDbet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numUDbet.Name = "numUDbet";
            this.numUDbet.Size = new System.Drawing.Size(107, 22);
            this.numUDbet.TabIndex = 14;
            this.numUDbet.ValueChanged += new System.EventHandler(this.numUDbet_ValueChanged);
            // 
            // numUDCarNumber
            // 
            this.numUDCarNumber.Location = new System.Drawing.Point(387, 496);
            this.numUDCarNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numUDCarNumber.Name = "numUDCarNumber";
            this.numUDCarNumber.Size = new System.Drawing.Size(107, 22);
            this.numUDCarNumber.TabIndex = 15;
            this.numUDCarNumber.ValueChanged += new System.EventHandler(this.numUDCarNumber_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Money";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Car Number";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(16, 319);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(178, 97);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(16, 218);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(178, 96);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(16, 117);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(178, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(157, 238);
            this.btnPlayAgain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(144, 34);
            this.btnPlayAgain.TabIndex = 18;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(157, 277);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(144, 34);
            this.btnQuit.TabIndex = 19;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // pnlGameOver
            // 
            this.pnlGameOver.Controls.Add(this.lblLastPunter);
            this.pnlGameOver.Controls.Add(this.btnQuit);
            this.pnlGameOver.Controls.Add(this.lblGameOver);
            this.pnlGameOver.Controls.Add(this.btnPlayAgain);
            this.pnlGameOver.Location = new System.Drawing.Point(347, 22);
            this.pnlGameOver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlGameOver.Name = "pnlGameOver";
            this.pnlGameOver.Size = new System.Drawing.Size(453, 343);
            this.pnlGameOver.TabIndex = 20;
            this.pnlGameOver.Visible = false;
            // 
            // lblLastPunter
            // 
            this.lblLastPunter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLastPunter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastPunter.Location = new System.Drawing.Point(115, 152);
            this.lblLastPunter.Name = "lblLastPunter";
            this.lblLastPunter.Size = new System.Drawing.Size(226, 56);
            this.lblLastPunter.TabIndex = 22;
            this.lblLastPunter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGameOver
            // 
            this.lblGameOver.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(32, 18);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(388, 85);
            this.lblGameOver.TabIndex = 21;
            this.lblGameOver.Text = "GAME OVER";
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1155, 551);
            this.Controls.Add(this.pnlGameOver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUDCarNumber);
            this.Controls.Add(this.numUDbet);
            this.Controls.Add(this.txtTes);
            this.Controls.Add(this.txtLambo);
            this.Controls.Add(this.txtFera);
            this.Controls.Add(this.rbTes);
            this.Controls.Add(this.rbLambo);
            this.Controls.Add(this.rbFera);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GameForm";
            this.Text = "Game Area ";
            ((System.ComponentModel.ISupportInitialize)(this.numUDbet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCarNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlGameOver.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.RadioButton rbFera;
        private System.Windows.Forms.RadioButton rbLambo;
        private System.Windows.Forms.RadioButton rbTes;
        private System.Windows.Forms.TextBox txtFera;
        private System.Windows.Forms.TextBox txtLambo;
        private System.Windows.Forms.TextBox txtTes;
        private System.Windows.Forms.NumericUpDown numUDbet;
        private System.Windows.Forms.NumericUpDown numUDCarNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Panel pnlGameOver;
        private System.Windows.Forms.Label lblLastPunter;
        private System.Windows.Forms.Label lblGameOver;
    }
}

