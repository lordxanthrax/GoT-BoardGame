namespace GameOfThronesBG
{
    partial class PlayerSetupForm
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
            this.rbnFourPlayer = new System.Windows.Forms.RadioButton();
            this.rbnFivePlayer = new System.Windows.Forms.RadioButton();
            this.rbnSixPlayer = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpPlayers = new System.Windows.Forms.GroupBox();
            this.grpPlayers.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbnFourPlayer
            // 
            this.rbnFourPlayer.AutoSize = true;
            this.rbnFourPlayer.Location = new System.Drawing.Point(49, 19);
            this.rbnFourPlayer.Name = "rbnFourPlayer";
            this.rbnFourPlayer.Size = new System.Drawing.Size(109, 17);
            this.rbnFourPlayer.TabIndex = 0;
            this.rbnFourPlayer.Text = "Four Player Game";
            this.rbnFourPlayer.UseVisualStyleBackColor = true;
            // 
            // rbnFivePlayer
            // 
            this.rbnFivePlayer.AutoSize = true;
            this.rbnFivePlayer.Location = new System.Drawing.Point(50, 42);
            this.rbnFivePlayer.Name = "rbnFivePlayer";
            this.rbnFivePlayer.Size = new System.Drawing.Size(108, 17);
            this.rbnFivePlayer.TabIndex = 1;
            this.rbnFivePlayer.Text = "Five Player Game";
            this.rbnFivePlayer.UseVisualStyleBackColor = true;
            // 
            // rbnSixPlayer
            // 
            this.rbnSixPlayer.AutoSize = true;
            this.rbnSixPlayer.Checked = true;
            this.rbnSixPlayer.Location = new System.Drawing.Point(49, 65);
            this.rbnSixPlayer.Name = "rbnSixPlayer";
            this.rbnSixPlayer.Size = new System.Drawing.Size(102, 17);
            this.rbnSixPlayer.TabIndex = 2;
            this.rbnSixPlayer.TabStop = true;
            this.rbnSixPlayer.Text = "Six Player Game";
            this.rbnSixPlayer.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Begin Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "What type of game will this be?";
            // 
            // grpPlayers
            // 
            this.grpPlayers.Controls.Add(this.rbnFourPlayer);
            this.grpPlayers.Controls.Add(this.rbnFivePlayer);
            this.grpPlayers.Controls.Add(this.rbnSixPlayer);
            this.grpPlayers.Location = new System.Drawing.Point(12, 65);
            this.grpPlayers.Name = "grpPlayers";
            this.grpPlayers.Size = new System.Drawing.Size(200, 100);
            this.grpPlayers.TabIndex = 5;
            this.grpPlayers.TabStop = false;
            // 
            // PlayerSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 225);
            this.Controls.Add(this.grpPlayers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "PlayerSetupForm";
            this.Text = "Game of Thrones";
            this.Load += new System.EventHandler(this.PlayerSetupForm_Load);
            this.grpPlayers.ResumeLayout(false);
            this.grpPlayers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbnFourPlayer;
        private System.Windows.Forms.RadioButton rbnFivePlayer;
        private System.Windows.Forms.RadioButton rbnSixPlayer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpPlayers;
    }
}