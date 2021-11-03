using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /*********** TO DO ***********\
        * Popravitit prikaz rezlutata *
        \*****************************/

        #region privatne promenljive

        private int player = 1;
        private bool validMove = true;
        private int playerOneWins = 0;
        private int playerTwoWins = 0;
        
        #endregion


        #region Polja

        private void btnField1_Click(object sender, EventArgs e)
        {
            if (btnField1.Text == string.Empty)
            {
                btnField1.Text = PlayerChar();
                validMove = true;
            }
            else
            {
                MessageBox.Show("Ovo polje je vec zauzeto");
                validMove = false;
            }
            checkForWin();
            NextTurn(validMove);
        }

        private void btnField2_Click(object sender, EventArgs e)
        {
            if (btnField2.Text == string.Empty)
            {
                btnField2.Text = PlayerChar();
                validMove = true;
            }
            else
            {
                MessageBox.Show("Ovo polje je vec zauzeto");
                validMove = false;
            }
            checkForWin();
            NextTurn(validMove);
        }

        private void btnField3_Click(object sender, EventArgs e)
        {
            if (btnField3.Text == string.Empty)
            {
                btnField3.Text = PlayerChar();
                validMove = true;
            }
            else
            {
                MessageBox.Show("Ovo polje je vec zauzeto");
                validMove = false;
            }
            checkForWin();
            NextTurn(validMove);
        }

        private void btnField4_Click(object sender, EventArgs e)
        {
            if (btnField4.Text == string.Empty)
            {
                btnField4.Text = PlayerChar();
                validMove = true;
            }
            else
            {
                MessageBox.Show("Ovo polje je vec zauzeto");
                validMove = false;
            }
            checkForWin();
            NextTurn(validMove);
        }

        private void btnField5_Click(object sender, EventArgs e)
        {
            if (btnField5.Text == string.Empty)
            {
                btnField5.Text = PlayerChar();
                validMove = true;
            }
            else
            {
                MessageBox.Show("Ovo polje je vec zauzeto");
                validMove = false;
            }
            checkForWin();
            NextTurn(validMove);
        }

        private void btnField6_Click(object sender, EventArgs e)
        {
            if (btnField6.Text == string.Empty)
            {
                btnField6.Text = PlayerChar();
                validMove = true;
            }
            else
            {
                MessageBox.Show("Ovo polje je vec zauzeto");
                validMove = false;
            }
            checkForWin();
            NextTurn(validMove);
        }

        private void btnField7_Click(object sender, EventArgs e)
        {
            if (btnField7.Text == string.Empty)
            {
                btnField7.Text = PlayerChar();
                validMove = true;
            }
            else
            {
                MessageBox.Show("Ovo polje je vec zauzeto");
                validMove = false;
            }
            checkForWin();
            NextTurn(validMove);
        }

        private void btnField8_Click(object sender, EventArgs e)
        {
            if (btnField8.Text == string.Empty)
            {
                btnField8.Text = PlayerChar();
                validMove = true;
            }
            else
            {
                MessageBox.Show("Ovo polje je vec zauzeto");
                validMove = false;
            }
            checkForWin();
            NextTurn(validMove);
        }

        private void btnField9_Click(object sender, EventArgs e)
        {
            if (btnField9.Text == string.Empty)
            {
                btnField9.Text = PlayerChar();
                validMove = true;
            }
            else
            {
                MessageBox.Show("Ovo polje je vec zauzeto");
                validMove = false;
            }
            checkForWin();
            NextTurn(validMove);
        }
        #endregion

        private void secondPlayer_Click(object sender, EventArgs e)
        {

        }

        #region Pomocne f-je
        
        /// <summary>
        /// Odredjuje koje slovo da se prikaze na polju
        /// </summary>
        /// <returns></returns>
        public string PlayerChar()
        {
            if (player == 1)
                return Convert.ToString('X');
            else
                return Convert.ToString('O');
        }

        /// <summary>
        /// Odredjuje koji igrac ce igrati sledeci potez
        /// </summary>
        public void NextTurn(bool validMove)
        {
            if (validMove)
            {
                if (player == 1)
                    player++;
                else
                    player = 1;
            }
        }

        /// <summary>
        /// Porverava da li ima pobednika
        /// </summary>
        public void checkForWin()
        {
            bool winner = false;
            if (
                    /********************* Sve horizontalne kombinacije ********************/
                    ((btnField1.Text == PlayerChar()) && (PlayerChar() == btnField2.Text) && (btnField2.Text == PlayerChar()) && (PlayerChar() == btnField3.Text)) ||
                    ((btnField4.Text == PlayerChar()) && (PlayerChar() == btnField5.Text) && (PlayerChar() == btnField5.Text) && (PlayerChar() == btnField6.Text)) ||
                    ((btnField7.Text == PlayerChar()) && (PlayerChar() == btnField8.Text) && (PlayerChar() == btnField8.Text) && (PlayerChar() == btnField9.Text)) ||
                    /********************* Sve vertikalne kombinacije *********************/
                    ((btnField1.Text == PlayerChar()) && (PlayerChar() == btnField4.Text) && (PlayerChar() == btnField4.Text) && (PlayerChar() == btnField7.Text)) ||
                    ((btnField2.Text == PlayerChar()) && (PlayerChar() == btnField5.Text) && (PlayerChar() == btnField5.Text) && (PlayerChar() == btnField8.Text)) ||
                    ((btnField3.Text == PlayerChar()) && (PlayerChar() == btnField6.Text) && (PlayerChar() == btnField6.Text) && (PlayerChar() == btnField9.Text)) ||
                    /************************ Sve kose kombinacije *************************/
                    ((btnField1.Text == PlayerChar()) && (PlayerChar() == btnField5.Text) && (PlayerChar() == btnField5.Text) && (PlayerChar() == btnField9.Text)) ||
                    ((btnField3.Text == PlayerChar()) && (PlayerChar() == btnField5.Text) && (PlayerChar() == btnField5.Text) && (PlayerChar() == btnField7.Text)) 
                )
            {
                winner = true;     
            }

            if (winner)
            {
                if (player == 1)
                {
                    MessageBox.Show("Player one je pobedio");
                    playerOneWins++;
                   // numberOfWindPlayer1_Click();
                }
                else
                {
                    MessageBox.Show("Player two je pobedio");
                    playerTwoWins++;
                   // numberOfWindPlayer2_Click();
                }
                newGame();
            }
        }
        /// <summary>
        /// Stavlja vrednosti svih polja na prazam string
        /// </summary>
        public void newGame()
        {
            btnField1.Text = string.Empty;
            btnField2.Text = string.Empty;
            btnField3.Text = string.Empty;
            btnField4.Text = string.Empty;
            btnField5.Text = string.Empty;
            btnField6.Text = string.Empty;
            btnField7.Text = string.Empty;
            btnField8.Text = string.Empty;
            btnField9.Text = string.Empty;
        }
        #endregion       
    }
}