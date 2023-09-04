namespace MineSweeper
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.easy = new System.Windows.Forms.RadioButton();
            this.medium = new System.Windows.Forms.RadioButton();
            this.expert = new System.Windows.Forms.RadioButton();
            this.custom = new System.Windows.Forms.RadioButton();
            this.playerName = new System.Windows.Forms.TextBox();
            this.openGames = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playNewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "NewGame";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Play);
            // 
            // easy
            // 
            this.easy.AutoSize = true;
            this.easy.Location = new System.Drawing.Point(138, 54);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(48, 17);
            this.easy.TabIndex = 1;
            this.easy.TabStop = true;
            this.easy.Text = "Easy";
            this.easy.UseVisualStyleBackColor = true;
            this.easy.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // medium
            // 
            this.medium.AutoSize = true;
            this.medium.Checked = true;
            this.medium.Location = new System.Drawing.Point(212, 54);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(62, 17);
            this.medium.TabIndex = 2;
            this.medium.TabStop = true;
            this.medium.Text = "Medium";
            this.medium.UseVisualStyleBackColor = true;
            this.medium.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // expert
            // 
            this.expert.AutoSize = true;
            this.expert.Location = new System.Drawing.Point(293, 54);
            this.expert.Name = "expert";
            this.expert.Size = new System.Drawing.Size(55, 17);
            this.expert.TabIndex = 3;
            this.expert.TabStop = true;
            this.expert.Text = "Expert";
            this.expert.UseVisualStyleBackColor = true;
            this.expert.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // custom
            // 
            this.custom.AutoSize = true;
            this.custom.Location = new System.Drawing.Point(177, 92);
            this.custom.Name = "custom";
            this.custom.Size = new System.Drawing.Size(60, 17);
            this.custom.TabIndex = 4;
            this.custom.TabStop = true;
            this.custom.Text = "Custom";
            this.custom.UseVisualStyleBackColor = true;
            this.custom.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // playerName
            // 
            this.playerName.Location = new System.Drawing.Point(125, 27);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(100, 20);
            this.playerName.TabIndex = 7;
            this.playerName.Text = "EnterName:";
            this.playerName.TextChanged += new System.EventHandler(this.playerName_TextChanged);
            // 
            // openGames
            // 
            this.openGames.Location = new System.Drawing.Point(261, 27);
            this.openGames.Name = "openGames";
            this.openGames.Size = new System.Drawing.Size(100, 20);
            this.openGames.TabIndex = 8;
            this.openGames.Text = "GamesRunning:";
            this.openGames.TextChanged += new System.EventHandler(this.openGames_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(261, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "CloseAll";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(497, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playNewGameToolStripMenuItem,
            this.closeAllGamesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.userToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // playNewGameToolStripMenuItem
            // 
            this.playNewGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.expertToolStripMenuItem});
            this.playNewGameToolStripMenuItem.Name = "playNewGameToolStripMenuItem";
            this.playNewGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.playNewGameToolStripMenuItem.Text = "Play New Game";
            this.playNewGameToolStripMenuItem.Click += new System.EventHandler(this.playNewGameToolStripMenuItem_Click);
            // 
            // closeAllGamesToolStripMenuItem
            // 
            this.closeAllGamesToolStripMenuItem.Name = "closeAllGamesToolStripMenuItem";
            this.closeAllGamesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeAllGamesToolStripMenuItem.Text = "Close All Games";
            this.closeAllGamesToolStripMenuItem.Click += new System.EventHandler(this.closeAllGamesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.easyToolStripMenuItem.Text = "Easy";
            this.easyToolStripMenuItem.Click += new System.EventHandler(this.easyToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mediumToolStripMenuItem.Text = "Medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click);
            // 
            // expertToolStripMenuItem
            // 
            this.expertToolStripMenuItem.Name = "expertToolStripMenuItem";
            this.expertToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.expertToolStripMenuItem.Text = "Expert";
            this.expertToolStripMenuItem.Click += new System.EventHandler(this.expertToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(261, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "5";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 179);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.openGames);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.custom);
            this.Controls.Add(this.expert);
            this.Controls.Add(this.medium);
            this.Controls.Add(this.easy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "MineSweeper";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton easy;
        private System.Windows.Forms.RadioButton medium;
        private System.Windows.Forms.RadioButton expert;
        private System.Windows.Forms.RadioButton custom;
        private System.Windows.Forms.TextBox playerName;
        private System.Windows.Forms.TextBox openGames;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playNewGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
    }
}

