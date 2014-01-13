namespace TicTacToe
{
    partial class FormGame
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelNotice = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelGame = new System.Windows.Forms.Panel();
            this.labelTurn = new System.Windows.Forms.Label();
            this.labelPlayer2 = new System.Windows.Forms.Label();
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.buttonC01 = new System.Windows.Forms.Button();
            this.buttonC02 = new System.Windows.Forms.Button();
            this.buttonC00 = new System.Windows.Forms.Button();
            this.buttonC11 = new System.Windows.Forms.Button();
            this.buttonC10 = new System.Windows.Forms.Button();
            this.buttonC20 = new System.Windows.Forms.Button();
            this.buttonC22 = new System.Windows.Forms.Button();
            this.buttonC12 = new System.Windows.Forms.Button();
            this.buttonC21 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panelNotice.SuspendLayout();
            this.panelGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingStripMenuItem,
            this.newStripMenuItem,
            this.exitStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(304, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingStripMenuItem
            // 
            this.settingStripMenuItem.Name = "settingStripMenuItem";
            this.settingStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.settingStripMenuItem.Text = "Player Setting";
            this.settingStripMenuItem.Click += new System.EventHandler(this.settingStripMenuItem_Click);
            // 
            // newStripMenuItem
            // 
            this.newStripMenuItem.Name = "newStripMenuItem";
            this.newStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.newStripMenuItem.Text = "New Game";
            this.newStripMenuItem.Click += new System.EventHandler(this.newStripMenuItem_Click);
            // 
            // exitStripMenuItem
            // 
            this.exitStripMenuItem.Name = "exitStripMenuItem";
            this.exitStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitStripMenuItem.Text = "Exit";
            this.exitStripMenuItem.Click += new System.EventHandler(this.exitStripMenuItem_Click);
            // 
            // panelNotice
            // 
            this.panelNotice.Controls.Add(this.textBox1);
            this.panelNotice.Location = new System.Drawing.Point(10, 27);
            this.panelNotice.Name = "panelNotice";
            this.panelNotice.Size = new System.Drawing.Size(288, 47);
            this.panelNotice.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(17, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 40);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Please set player info first, using Player Setting on the menu.";
            // 
            // panelGame
            // 
            this.panelGame.Controls.Add(this.buttonC21);
            this.panelGame.Controls.Add(this.buttonC12);
            this.panelGame.Controls.Add(this.buttonC22);
            this.panelGame.Controls.Add(this.buttonC10);
            this.panelGame.Controls.Add(this.buttonC20);
            this.panelGame.Controls.Add(this.buttonC11);
            this.panelGame.Controls.Add(this.buttonC00);
            this.panelGame.Controls.Add(this.buttonC02);
            this.panelGame.Controls.Add(this.buttonC01);
            this.panelGame.Controls.Add(this.labelTurn);
            this.panelGame.Controls.Add(this.labelPlayer2);
            this.panelGame.Controls.Add(this.labelPlayer1);
            this.panelGame.Location = new System.Drawing.Point(10, 81);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(291, 321);
            this.panelGame.TabIndex = 2;
            // 
            // labelTurn
            // 
            this.labelTurn.AutoSize = true;
            this.labelTurn.Location = new System.Drawing.Point(17, 60);
            this.labelTurn.Name = "labelTurn";
            this.labelTurn.Size = new System.Drawing.Size(38, 13);
            this.labelTurn.TabIndex = 2;
            this.labelTurn.Text = "Turn:  ";
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.Location = new System.Drawing.Point(17, 35);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(45, 13);
            this.labelPlayer2.TabIndex = 1;
            this.labelPlayer2.Text = "Player 2";
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.Location = new System.Drawing.Point(17, 13);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(45, 13);
            this.labelPlayer1.TabIndex = 0;
            this.labelPlayer1.Text = "Player 1";
            // 
            // buttonC01
            // 
            this.buttonC01.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.buttonC01.Location = new System.Drawing.Point(100, 86);
            this.buttonC01.Name = "buttonC01";
            this.buttonC01.Size = new System.Drawing.Size(91, 75);
            this.buttonC01.TabIndex = 4;
            this.buttonC01.UseVisualStyleBackColor = true;
            this.buttonC01.Click += new System.EventHandler(this.buttonC01_Click);
            // 
            // buttonC02
            // 
            this.buttonC02.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.buttonC02.Location = new System.Drawing.Point(197, 86);
            this.buttonC02.Name = "buttonC02";
            this.buttonC02.Size = new System.Drawing.Size(91, 75);
            this.buttonC02.TabIndex = 5;
            this.buttonC02.UseVisualStyleBackColor = true;
            this.buttonC02.Click += new System.EventHandler(this.buttonC02_Click);
            // 
            // buttonC00
            // 
            this.buttonC00.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.buttonC00.Location = new System.Drawing.Point(2, 86);
            this.buttonC00.Name = "buttonC00";
            this.buttonC00.Size = new System.Drawing.Size(91, 75);
            this.buttonC00.TabIndex = 6;
            this.buttonC00.UseVisualStyleBackColor = true;
            this.buttonC00.Click += new System.EventHandler(this.buttonC00_Click);
            // 
            // buttonC11
            // 
            this.buttonC11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.buttonC11.Location = new System.Drawing.Point(100, 167);
            this.buttonC11.Name = "buttonC11";
            this.buttonC11.Size = new System.Drawing.Size(91, 75);
            this.buttonC11.TabIndex = 7;
            this.buttonC11.UseVisualStyleBackColor = true;
            this.buttonC11.Click += new System.EventHandler(this.buttonC11_Click);
            // 
            // buttonC10
            // 
            this.buttonC10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.buttonC10.Location = new System.Drawing.Point(4, 167);
            this.buttonC10.Name = "buttonC10";
            this.buttonC10.Size = new System.Drawing.Size(91, 75);
            this.buttonC10.TabIndex = 5;
            this.buttonC10.UseVisualStyleBackColor = true;
            this.buttonC10.Click += new System.EventHandler(this.buttonC10_Click);
            // 
            // buttonC20
            // 
            this.buttonC20.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.buttonC20.Location = new System.Drawing.Point(4, 246);
            this.buttonC20.Name = "buttonC20";
            this.buttonC20.Size = new System.Drawing.Size(91, 75);
            this.buttonC20.TabIndex = 8;
            this.buttonC20.UseVisualStyleBackColor = true;
            this.buttonC20.Click += new System.EventHandler(this.buttonC20_Click);
            // 
            // buttonC22
            // 
            this.buttonC22.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.buttonC22.Location = new System.Drawing.Point(197, 248);
            this.buttonC22.Name = "buttonC22";
            this.buttonC22.Size = new System.Drawing.Size(91, 75);
            this.buttonC22.TabIndex = 9;
            this.buttonC22.UseVisualStyleBackColor = true;
            this.buttonC22.Click += new System.EventHandler(this.buttonC22_Click);
            // 
            // buttonC12
            // 
            this.buttonC12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.buttonC12.Location = new System.Drawing.Point(197, 167);
            this.buttonC12.Name = "buttonC12";
            this.buttonC12.Size = new System.Drawing.Size(91, 75);
            this.buttonC12.TabIndex = 10;
            this.buttonC12.UseVisualStyleBackColor = true;
            this.buttonC12.Click += new System.EventHandler(this.buttonC12_Click);
            // 
            // buttonC21
            // 
            this.buttonC21.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.buttonC21.Location = new System.Drawing.Point(100, 246);
            this.buttonC21.Name = "buttonC21";
            this.buttonC21.Size = new System.Drawing.Size(91, 75);
            this.buttonC21.TabIndex = 11;
            this.buttonC21.UseVisualStyleBackColor = true;
            this.buttonC21.Click += new System.EventHandler(this.buttonC21_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 414);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.panelNotice);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGame";
            this.Text = "Tic Tac Toe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelNotice.ResumeLayout(false);
            this.panelNotice.PerformLayout();
            this.panelGame.ResumeLayout(false);
            this.panelGame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitStripMenuItem;
        private System.Windows.Forms.Panel panelNotice;
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelTurn;
        private System.Windows.Forms.Label labelPlayer2;
        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.Button buttonC21;
        private System.Windows.Forms.Button buttonC12;
        private System.Windows.Forms.Button buttonC22;
        private System.Windows.Forms.Button buttonC10;
        private System.Windows.Forms.Button buttonC20;
        private System.Windows.Forms.Button buttonC11;
        private System.Windows.Forms.Button buttonC00;
        private System.Windows.Forms.Button buttonC02;
        private System.Windows.Forms.Button buttonC01;
    }
}

