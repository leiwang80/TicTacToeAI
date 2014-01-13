namespace TicTacToe
{
    partial class FormSetting
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupStart1 = new System.Windows.Forms.GroupBox();
            this.radioNo1 = new System.Windows.Forms.RadioButton();
            this.radioYes1 = new System.Windows.Forms.RadioButton();
            this.groupSym1 = new System.Windows.Forms.GroupBox();
            this.radioO1 = new System.Windows.Forms.RadioButton();
            this.radioX1 = new System.Windows.Forms.RadioButton();
            this.groupName1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupStart2 = new System.Windows.Forms.GroupBox();
            this.radioNo2 = new System.Windows.Forms.RadioButton();
            this.radioYes2 = new System.Windows.Forms.RadioButton();
            this.groupSym2 = new System.Windows.Forms.GroupBox();
            this.radioO2 = new System.Windows.Forms.RadioButton();
            this.radioX2 = new System.Windows.Forms.RadioButton();
            this.groupName2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupPlayers = new System.Windows.Forms.GroupBox();
            this.radio0 = new System.Windows.Forms.RadioButton();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.radio4 = new System.Windows.Forms.RadioButton();
            this.radio5 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupStart1.SuspendLayout();
            this.groupSym1.SuspendLayout();
            this.groupName1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupStart2.SuspendLayout();
            this.groupSym2.SuspendLayout();
            this.groupName2.SuspendLayout();
            this.groupPlayers.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupStart1);
            this.panel1.Controls.Add(this.groupSym1);
            this.panel1.Controls.Add(this.groupName1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 191);
            this.panel1.TabIndex = 0;
            // 
            // groupStart1
            // 
            this.groupStart1.Controls.Add(this.radioNo1);
            this.groupStart1.Controls.Add(this.radioYes1);
            this.groupStart1.Location = new System.Drawing.Point(18, 132);
            this.groupStart1.Name = "groupStart1";
            this.groupStart1.Size = new System.Drawing.Size(176, 29);
            this.groupStart1.TabIndex = 3;
            this.groupStart1.TabStop = false;
            this.groupStart1.Text = "Start First";
            // 
            // radioNo1
            // 
            this.radioNo1.AutoSize = true;
            this.radioNo1.Location = new System.Drawing.Point(137, 12);
            this.radioNo1.Name = "radioNo1";
            this.radioNo1.Size = new System.Drawing.Size(39, 17);
            this.radioNo1.TabIndex = 1;
            this.radioNo1.TabStop = true;
            this.radioNo1.Text = "No";
            this.radioNo1.UseVisualStyleBackColor = true;
            this.radioNo1.CheckedChanged += new System.EventHandler(this.radioNo1_CheckedChanged);
            // 
            // radioYes1
            // 
            this.radioYes1.AutoSize = true;
            this.radioYes1.Checked = true;
            this.radioYes1.Location = new System.Drawing.Point(86, 11);
            this.radioYes1.Name = "radioYes1";
            this.radioYes1.Size = new System.Drawing.Size(43, 17);
            this.radioYes1.TabIndex = 0;
            this.radioYes1.TabStop = true;
            this.radioYes1.Text = "Yes";
            this.radioYes1.UseVisualStyleBackColor = true;
            this.radioYes1.CheckedChanged += new System.EventHandler(this.radioYes1_CheckedChanged);
            // 
            // groupSym1
            // 
            this.groupSym1.Controls.Add(this.radioO1);
            this.groupSym1.Controls.Add(this.radioX1);
            this.groupSym1.Location = new System.Drawing.Point(18, 85);
            this.groupSym1.Name = "groupSym1";
            this.groupSym1.Size = new System.Drawing.Size(176, 29);
            this.groupSym1.TabIndex = 2;
            this.groupSym1.TabStop = false;
            this.groupSym1.Text = "Symbol:";
            // 
            // radioO1
            // 
            this.radioO1.AutoSize = true;
            this.radioO1.Location = new System.Drawing.Point(137, 6);
            this.radioO1.Name = "radioO1";
            this.radioO1.Size = new System.Drawing.Size(33, 17);
            this.radioO1.TabIndex = 1;
            this.radioO1.TabStop = true;
            this.radioO1.Text = "O";
            this.radioO1.UseVisualStyleBackColor = true;
            this.radioO1.CheckedChanged += new System.EventHandler(this.radioO1_CheckedChanged);
            // 
            // radioX1
            // 
            this.radioX1.AutoSize = true;
            this.radioX1.Checked = true;
            this.radioX1.Location = new System.Drawing.Point(86, 6);
            this.radioX1.Name = "radioX1";
            this.radioX1.Size = new System.Drawing.Size(32, 17);
            this.radioX1.TabIndex = 0;
            this.radioX1.TabStop = true;
            this.radioX1.Text = "X";
            this.radioX1.UseVisualStyleBackColor = true;
            this.radioX1.CheckedChanged += new System.EventHandler(this.radioX1_CheckedChanged);
            // 
            // groupName1
            // 
            this.groupName1.Controls.Add(this.textBox1);
            this.groupName1.Location = new System.Drawing.Point(18, 50);
            this.groupName1.Name = "groupName1";
            this.groupName1.Size = new System.Drawing.Size(176, 29);
            this.groupName1.TabIndex = 1;
            this.groupName1.TabStop = false;
            this.groupName1.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player 1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupStart2);
            this.panel2.Controls.Add(this.groupSym2);
            this.panel2.Controls.Add(this.groupName2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(230, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 191);
            this.panel2.TabIndex = 4;
            // 
            // groupStart2
            // 
            this.groupStart2.Controls.Add(this.radioNo2);
            this.groupStart2.Controls.Add(this.radioYes2);
            this.groupStart2.Location = new System.Drawing.Point(18, 132);
            this.groupStart2.Name = "groupStart2";
            this.groupStart2.Size = new System.Drawing.Size(176, 29);
            this.groupStart2.TabIndex = 3;
            this.groupStart2.TabStop = false;
            this.groupStart2.Text = "Start First";
            // 
            // radioNo2
            // 
            this.radioNo2.AutoSize = true;
            this.radioNo2.Checked = true;
            this.radioNo2.Enabled = false;
            this.radioNo2.Location = new System.Drawing.Point(137, 12);
            this.radioNo2.Name = "radioNo2";
            this.radioNo2.Size = new System.Drawing.Size(39, 17);
            this.radioNo2.TabIndex = 1;
            this.radioNo2.TabStop = true;
            this.radioNo2.Text = "No";
            this.radioNo2.UseVisualStyleBackColor = true;
            // 
            // radioYes2
            // 
            this.radioYes2.AutoSize = true;
            this.radioYes2.Enabled = false;
            this.radioYes2.Location = new System.Drawing.Point(86, 11);
            this.radioYes2.Name = "radioYes2";
            this.radioYes2.Size = new System.Drawing.Size(43, 17);
            this.radioYes2.TabIndex = 0;
            this.radioYes2.TabStop = true;
            this.radioYes2.Text = "Yes";
            this.radioYes2.UseVisualStyleBackColor = true;
            // 
            // groupSym2
            // 
            this.groupSym2.Controls.Add(this.radioO2);
            this.groupSym2.Controls.Add(this.radioX2);
            this.groupSym2.Location = new System.Drawing.Point(18, 85);
            this.groupSym2.Name = "groupSym2";
            this.groupSym2.Size = new System.Drawing.Size(176, 29);
            this.groupSym2.TabIndex = 2;
            this.groupSym2.TabStop = false;
            this.groupSym2.Text = "Symbol:";
            // 
            // radioO2
            // 
            this.radioO2.AutoSize = true;
            this.radioO2.Checked = true;
            this.radioO2.Enabled = false;
            this.radioO2.Location = new System.Drawing.Point(137, 6);
            this.radioO2.Name = "radioO2";
            this.radioO2.Size = new System.Drawing.Size(33, 17);
            this.radioO2.TabIndex = 1;
            this.radioO2.TabStop = true;
            this.radioO2.Text = "O";
            this.radioO2.UseVisualStyleBackColor = true;
            // 
            // radioX2
            // 
            this.radioX2.AutoSize = true;
            this.radioX2.Enabled = false;
            this.radioX2.Location = new System.Drawing.Point(86, 6);
            this.radioX2.Name = "radioX2";
            this.radioX2.Size = new System.Drawing.Size(32, 17);
            this.radioX2.TabIndex = 0;
            this.radioX2.TabStop = true;
            this.radioX2.Text = "X";
            this.radioX2.UseVisualStyleBackColor = true;
            // 
            // groupName2
            // 
            this.groupName2.Controls.Add(this.textBox2);
            this.groupName2.Location = new System.Drawing.Point(18, 50);
            this.groupName2.Name = "groupName2";
            this.groupName2.Size = new System.Drawing.Size(176, 29);
            this.groupName2.TabIndex = 1;
            this.groupName2.TabStop = false;
            this.groupName2.Text = "Name:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(70, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Player 2";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(180, 273);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupPlayers
            // 
            this.groupPlayers.Controls.Add(this.radio5);
            this.groupPlayers.Controls.Add(this.radio4);
            this.groupPlayers.Controls.Add(this.radio3);
            this.groupPlayers.Controls.Add(this.radio2);
            this.groupPlayers.Controls.Add(this.radio1);
            this.groupPlayers.Controls.Add(this.radio0);
            this.groupPlayers.Location = new System.Drawing.Point(19, 14);
            this.groupPlayers.Name = "groupPlayers";
            this.groupPlayers.Size = new System.Drawing.Size(404, 35);
            this.groupPlayers.TabIndex = 6;
            this.groupPlayers.TabStop = false;
            this.groupPlayers.Text = "Players";
            // 
            // radio0
            // 
            this.radio0.AutoSize = true;
            this.radio0.Checked = true;
            this.radio0.Location = new System.Drawing.Point(7, 12);
            this.radio0.Name = "radio0";
            this.radio0.Size = new System.Drawing.Size(83, 17);
            this.radio0.TabIndex = 0;
            this.radio0.TabStop = true;
            this.radio0.Text = "Two Players";
            this.radio0.UseVisualStyleBackColor = true;
            this.radio0.CheckedChanged += new System.EventHandler(this.radio0_CheckedChanged);
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Location = new System.Drawing.Point(97, 12);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(44, 17);
            this.radio1.TabIndex = 1;
            this.radio1.TabStop = true;
            this.radio1.Text = "AI-1";
            this.radio1.UseVisualStyleBackColor = true;
            this.radio1.CheckedChanged += new System.EventHandler(this.radio1_CheckedChanged);
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Location = new System.Drawing.Point(148, 12);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(44, 17);
            this.radio2.TabIndex = 2;
            this.radio2.TabStop = true;
            this.radio2.Text = "AI-2";
            this.radio2.UseVisualStyleBackColor = true;
            this.radio2.CheckedChanged += new System.EventHandler(this.radio2_CheckedChanged);
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Location = new System.Drawing.Point(198, 12);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(44, 17);
            this.radio3.TabIndex = 3;
            this.radio3.TabStop = true;
            this.radio3.Text = "AI-3";
            this.radio3.UseVisualStyleBackColor = true;
            this.radio3.CheckedChanged += new System.EventHandler(this.radio3_CheckedChanged);
            // 
            // radio4
            // 
            this.radio4.AutoSize = true;
            this.radio4.Location = new System.Drawing.Point(260, 12);
            this.radio4.Name = "radio4";
            this.radio4.Size = new System.Drawing.Size(44, 17);
            this.radio4.TabIndex = 4;
            this.radio4.TabStop = true;
            this.radio4.Text = "AI-4";
            this.radio4.UseVisualStyleBackColor = true;
            this.radio4.CheckedChanged += new System.EventHandler(this.radio4_CheckedChanged);
            // 
            // radio5
            // 
            this.radio5.AutoSize = true;
            this.radio5.Location = new System.Drawing.Point(315, 12);
            this.radio5.Name = "radio5";
            this.radio5.Size = new System.Drawing.Size(44, 17);
            this.radio5.TabIndex = 5;
            this.radio5.TabStop = true;
            this.radio5.Text = "AI-5";
            this.radio5.UseVisualStyleBackColor = true;
            this.radio5.CheckedChanged += new System.EventHandler(this.radio5_CheckedChanged);
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 308);
            this.Controls.Add(this.groupPlayers);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormSetting";
            this.Text = "Setting";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupStart1.ResumeLayout(false);
            this.groupStart1.PerformLayout();
            this.groupSym1.ResumeLayout(false);
            this.groupSym1.PerformLayout();
            this.groupName1.ResumeLayout(false);
            this.groupName1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupStart2.ResumeLayout(false);
            this.groupStart2.PerformLayout();
            this.groupSym2.ResumeLayout(false);
            this.groupSym2.PerformLayout();
            this.groupName2.ResumeLayout(false);
            this.groupName2.PerformLayout();
            this.groupPlayers.ResumeLayout(false);
            this.groupPlayers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupStart1;
        private System.Windows.Forms.RadioButton radioNo1;
        private System.Windows.Forms.RadioButton radioYes1;
        private System.Windows.Forms.GroupBox groupSym1;
        private System.Windows.Forms.RadioButton radioO1;
        private System.Windows.Forms.RadioButton radioX1;
        private System.Windows.Forms.GroupBox groupName1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupStart2;
        private System.Windows.Forms.RadioButton radioNo2;
        private System.Windows.Forms.RadioButton radioYes2;
        private System.Windows.Forms.GroupBox groupSym2;
        private System.Windows.Forms.RadioButton radioO2;
        private System.Windows.Forms.RadioButton radioX2;
        private System.Windows.Forms.GroupBox groupName2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupPlayers;
        private System.Windows.Forms.RadioButton radio5;
        private System.Windows.Forms.RadioButton radio4;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.RadioButton radio0;
    }
}