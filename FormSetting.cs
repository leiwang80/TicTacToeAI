using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class FormSetting : Form
    {
        int level;

        public FormSetting()
        {
            InitializeComponent();

            level = 0;
        }

        private void radioX1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioX1.Checked == true)
                radioO2.Checked = true;
            else
                radioX2.Checked = true;
        }

        private void radioO1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioO1.Checked == true)
                radioX2.Checked = true;
            else
                radioO2.Checked = true;

        }

        private void radioYes1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioYes1.Checked == true)
                radioNo2.Checked = true;
            else
                radioYes2.Checked = true;

        }

        private void radioNo1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioNo1.Checked == true)
                radioYes2.Checked = true;
            else
                radioNo2.Checked = true;

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            String name1, name2, symbol1, symbol2;
            Game game = Program.mainForm.game;
            game.isPlayerSet = true;

            name1 = (textBox1.Text == "") ? "Player 1" : textBox1.Text;
            name2 = (textBox2.Text == "") ? "Player 2" : textBox2.Text;

            if (radioX1.Checked == true)
            {
                symbol1 = "X";
                symbol2 = "O";
            }
            else
            {
                symbol1 = "O";
                symbol2 = "X";
            }

            game.players[1] = new Player(name1, symbol1);
            if (radio0.Checked == true)
                game.players[2] = new Player(name2, symbol2);
            else
                game.players[2] = new Player(name2, symbol2, true);
            game.AILevel = level;

            if (radioYes1.Checked == true)
                game.currentID = 1;
            else
                game.currentID = 2;

            Program.mainForm.setDisplay();
            this.Close();
        }

        private void processPlayerRadioChange()
        {
            if (radio0.Checked == true)
            {
                textBox2.Text = "";
                textBox2.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
                if (radio1.Checked == true)
                    textBox2.Text = "AI-1";
                else if (radio2.Checked == true)
                    textBox2.Text = "AI-2";
                else if (radio3.Checked == true)
                    textBox2.Text = "AI-3";
                else if (radio4.Checked == true)
                    textBox2.Text = "AI-4";
                else 
                    textBox2.Text = "AI-5";
            }

        }

        private void radio0_CheckedChanged(object sender, EventArgs e)
        {
            processPlayerRadioChange();
            level = 0;
        }

        private void radio1_CheckedChanged(object sender, EventArgs e)
        {
            processPlayerRadioChange();
            level = 1;
        }

        private void radio2_CheckedChanged(object sender, EventArgs e)
        {
            processPlayerRadioChange();
            level = 2;
        }

        private void radio3_CheckedChanged(object sender, EventArgs e)
        {
            processPlayerRadioChange();
            level = 3;
        }

        private void radio4_CheckedChanged(object sender, EventArgs e)
        {
            processPlayerRadioChange();
            level = 4;
        }

        private void radio5_CheckedChanged(object sender, EventArgs e)
        {
            processPlayerRadioChange();
            level = 5;
        }
    }
}
