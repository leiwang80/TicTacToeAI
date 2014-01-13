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
    public partial class FormGame : Form
    {
        FormSetting formSetting;
        internal Game game;

        public FormGame()
        {
            InitializeComponent();

            game = new Game();
            setDisplay();
        }

        public void setDisplay(string rollText = "")
        {
            if (game.isPlayerSet == false)
            {
                panelNotice.Visible = true;
                panelGame.Visible = false;
            }
            else
            {
                panelNotice.Visible = false;
                panelGame.Visible = true;

                labelPlayer1.Text = game.players[1].name + " - " + game.players[1].symbol;
                labelPlayer2.Text = game.players[2].name + " - " + game.players[2].symbol;
                labelTurn.Text = "Turn:  " + game.players[game.currentID].name;

                buttonC00.Text = game.players[game.ticBoard[0, 0]].symbol;
                buttonC01.Text = game.players[game.ticBoard[0, 1]].symbol;
                buttonC02.Text = game.players[game.ticBoard[0, 2]].symbol;
                buttonC10.Text = game.players[game.ticBoard[1, 0]].symbol;
                buttonC11.Text = game.players[game.ticBoard[1, 1]].symbol;
                buttonC12.Text = game.players[game.ticBoard[1, 2]].symbol;
                buttonC20.Text = game.players[game.ticBoard[2, 0]].symbol;
                buttonC21.Text = game.players[game.ticBoard[2, 1]].symbol;
                buttonC22.Text = game.players[game.ticBoard[2, 2]].symbol;

                buttonC00.Enabled = (game.ticBoard[0, 0] == 0) ? true : false;
                buttonC01.Enabled = (game.ticBoard[0, 1] == 0) ? true : false;
                buttonC02.Enabled = (game.ticBoard[0, 2] == 0) ? true : false;
                buttonC10.Enabled = (game.ticBoard[1, 0] == 0) ? true : false;
                buttonC11.Enabled = (game.ticBoard[1, 1] == 0) ? true : false;
                buttonC12.Enabled = (game.ticBoard[1, 2] == 0) ? true : false;
                buttonC20.Enabled = (game.ticBoard[2, 0] == 0) ? true : false;
                buttonC21.Enabled = (game.ticBoard[2, 1] == 0) ? true : false;
                buttonC22.Enabled = (game.ticBoard[2, 2] == 0) ? true : false;

                if (game.newStart && game.players[game.currentID].isAI)
                {
                    MessageBox.Show(game.players[2].name + " play first turn in the game.");
                    Position p = game.AINextPosition(game.AILevel);
                    AIMove(p);
                }
            }
        }

        internal void AIMove(Position p)        
        {
            game.ticBoard[p.x, p.y] = game.currentID;
            ProcessClick();
        }

        private void ProcessClick()
        {
            game.newStart = false;

            if (game.CheckWinning() == 0)
            {
                game.switchPlayer();
                setDisplay();
            }
            else
            {
                setDisplay();
                DialogResult result = MessageBox.Show(game.players[game.currentID].name + 
                    " win!  Do you want start over?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    game.ticBoard = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
                    setDisplay();
                }
                else
                    Application.Exit();
            }
        }


        private void exitStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingStripMenuItem_Click(object sender, EventArgs e)
        {
            formSetting = new FormSetting();
            formSetting.Show();
        }


        private void newStripMenuItem_Click(object sender, EventArgs e)
        {
            game = new Game();
            setDisplay();
        }


        private void buttonC00_Click(object sender, EventArgs e)
        {
            game.ticBoard[0, 0] = game.currentID;
            ProcessClick();
        }

        private void buttonC01_Click(object sender, EventArgs e)
        {
            game.ticBoard[0, 1] = game.currentID;
            ProcessClick();
        }

        private void buttonC02_Click(object sender, EventArgs e)
        {
            game.ticBoard[0, 2] = game.currentID;
            ProcessClick();
        }

        private void buttonC10_Click(object sender, EventArgs e)
        {
            game.ticBoard[1, 0] = game.currentID;
            ProcessClick();
        }

        private void buttonC11_Click(object sender, EventArgs e)
        {
            game.ticBoard[1, 1] = game.currentID;
            ProcessClick();
        }

        private void buttonC12_Click(object sender, EventArgs e)
        {
            game.ticBoard[1, 2] = game.currentID;
            ProcessClick();
        }

        private void buttonC20_Click(object sender, EventArgs e)
        {
            game.ticBoard[2, 0] = game.currentID;
            ProcessClick();
        }

        private void buttonC21_Click(object sender, EventArgs e)
        {
            game.ticBoard[2, 1] = game.currentID;
            ProcessClick();
        }

        private void buttonC22_Click(object sender, EventArgs e)
        {
            game.ticBoard[2, 2] = game.currentID;
            ProcessClick();
        }

    }
}
