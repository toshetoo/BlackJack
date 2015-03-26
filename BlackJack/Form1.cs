using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        static int money = 500;
        static int playerScore = 0;
        static int dealerScore = 0;
        static int pot = 0;
        static int[] cards = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        static string[] faces = { "J", "Q", "K", "A" };
        Random rnd = new Random();

        private void PlayerWin()
        {
            MessageBox.Show("Game ended. Player won!");
            money += pot * 2;
            pot = 0;
            playerScore = 0;
            dealerScore = 0;
            lblMoneyValue.Text = money.ToString();
            lblPot.Text = "";
            lblPlayerScore.Text = "";
            lblDealerScore.Text = "";
            lblDealerCards.Text = "";
            lblPlayerCards.Text = "";
            btnDraw.Visible = false;
            btnHold.Visible = false;
            btnBetFifty.Enabled = true;
            btnBetTen.Enabled = true;
        }
        private void DealerWin()
        {
            MessageBox.Show("Game ended. Dealer won!");
            pot = 0;
            playerScore = 0;
            dealerScore = 0;
            lblPot.Text = "";
            lblPlayerScore.Text = "";
            lblDealerScore.Text = "";
            lblDealerCards.Text = "";
            lblPlayerCards.Text = "";
            btnDraw.Visible = false;
            btnHold.Visible = false;
            btnBetFifty.Enabled = true;
            btnBetTen.Enabled = true;
        }
        private void PlayerFaces(int pIndexFaces)
        {
            if (faces[pIndexFaces] == "A")
            {
                playerScore += 11;
                lblPlayerScore.Text = playerScore.ToString();
            }
            else
            {
                playerScore += 10;
                lblPlayerScore.Text = playerScore.ToString();
            }
        }
        private void DealerFaces(int dFaceIndex)
        {
            if (faces[dFaceIndex] == "A")
            {
                dealerScore += 11;
                lblDealerScore.Text = dealerScore.ToString();
            }
            else
            {
                dealerScore += 10;
                lblDealerScore.Text = dealerScore.ToString();
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void lblMoneyValue_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDraw.Visible = false;
            btnHold.Visible = false;
            btnStart.Visible = false;
            lblMoneyValue.Text = money.ToString();
            lblPlayerScore.Text = playerScore.ToString();
            lblDealerScore.Text = dealerScore.ToString();
        }

        private void btnBetTen_Click(object sender, EventArgs e)
        {
            money -= 10;
            pot += 10;
            lblMoneyValue.Text = money.ToString();
            lblPot.Text = pot.ToString();
            btnStart.Visible = true;
            
        }

        private void btnBetFifty_Click(object sender, EventArgs e)
        {
            money -= 50;
            pot += 50;
            lblMoneyValue.Text = money.ToString();
            lblPot.Text = pot.ToString();
            btnStart.Visible = true;
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnBetTen.Enabled = false;
            btnBetFifty.Enabled = false;
            int firstNum = 0;
            int secondNum = 0;
            firstNum = rnd.Next(0, 300);
            secondNum = rnd.Next(0, 300);

            //MessageBox.Show("f: " + firstNum + " s: " + secondNum + " ");

            int pIndexCards = rnd.Next(0, cards.Length);
            int pSecondCard = rnd.Next(0, cards.Length);

            int indexCards = rnd.Next(0, cards.Length);
            int secondCard = rnd.Next(0, cards.Length);

            int pIndexFaces = rnd.Next(0, faces.Length);
            int pSecondFaces = rnd.Next(0, faces.Length);
            int indexFaces = rnd.Next(0, faces.Length);
            int secondFaces = rnd.Next(0, faces.Length);

            if (firstNum > secondNum)
            {
                lblDealerCards.Text += cards[indexCards].ToString() + " " + cards[secondCard].ToString();
                lblPlayerCards.Text += cards[pIndexCards].ToString() + " " + cards[pSecondCard].ToString();
                playerScore += cards[pIndexCards] + cards[pSecondCard];
                dealerScore += cards[indexCards] + cards[secondCard];
                lblDealerScore.Text = dealerScore.ToString();
                lblPlayerScore.Text = playerScore.ToString();

            }
            else if (firstNum == secondNum)
            {
                lblDealerCards.Text += faces[indexFaces].ToString() + " " + faces[secondFaces].ToString();
                lblPlayerCards.Text += faces[pIndexFaces].ToString() + " " + faces[pSecondFaces].ToString();

                DealerFaces(indexFaces);
                DealerFaces(secondFaces);


                PlayerFaces(pIndexFaces);
                PlayerFaces(pSecondFaces);


            }
            else
            {
                lblDealerCards.Text += cards[indexCards].ToString() + " " + faces[indexFaces].ToString();
                lblPlayerCards.Text += cards[pIndexCards].ToString() + " " + faces[pIndexFaces].ToString();

                playerScore += cards[pIndexCards];
                dealerScore += cards[indexCards];

                DealerFaces(indexFaces);
                PlayerFaces(pIndexFaces);

            }

            if (playerScore == 21)
            {
                PlayerWin();
            }
            else if (dealerScore == 21)
            {
                DealerWin();
            }

            btnDraw.Visible = true;
            btnHold.Visible = true;
            btnStart.Visible = false;
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            int pCardIndex = rnd.Next(0, cards.Length);
            int dCardIndex = rnd.Next(0, cards.Length);
            int pFaceIndex = rnd.Next(0, faces.Length);
            int dFaceIndex = rnd.Next(0, faces.Length);

            int firstNum = 0;
            int secondNum = 0;
            firstNum = rnd.Next(0, 300);
            secondNum = rnd.Next(0, 300);

           // MessageBox.Show("f: " + firstNum + " s: " + secondNum + " ");
            if (dealerScore == 19 || dealerScore == 20)
            {
                if (firstNum >= secondNum)
                {
                    lblPlayerCards.Text += " " + cards[pCardIndex].ToString();
                    Thread.Sleep(1500);
                    playerScore += cards[pCardIndex];
                    lblPlayerScore.Text = playerScore.ToString();
                    
                }
                else
                {
                    lblPlayerCards.Text += " " + faces[pFaceIndex].ToString();
                    Thread.Sleep(1500);                                        
                    PlayerFaces(pFaceIndex);

                }
            }
            else
            {
                if (firstNum >= secondNum)
                {
                    lblPlayerCards.Text += " " + cards[pCardIndex].ToString();
                    Thread.Sleep(1500);
                    lblDealerCards.Text += " " + cards[dCardIndex].ToString();
                    playerScore += cards[pCardIndex];
                    lblPlayerScore.Text = playerScore.ToString();
                    dealerScore += cards[dCardIndex];
                    lblDealerScore.Text = dealerScore.ToString();
                }
                else
                {
                    lblPlayerCards.Text += " " + faces[pFaceIndex].ToString();
                    Thread.Sleep(1500);
                    lblDealerCards.Text += " " + faces[dFaceIndex].ToString();

                    DealerFaces(dFaceIndex);
                    PlayerFaces(pFaceIndex);

                }
            }

            if (playerScore == dealerScore)
            {
                Console.WriteLine("Equal points. No winner!");
                money += pot;
                pot = 0;
                lblMoneyValue.Text = money.ToString();
                lblDealerCards.Text = "";
                lblDealerScore.Text = "";
                lblPlayerCards.Text = "";
                lblPlayerScore.Text = "";
                btnDraw.Visible = false;
                btnHold.Visible = false;
                btnBetFifty.Enabled = true;
                btnBetTen.Enabled = true;
            }
            else if (playerScore == 21 && dealerScore!=21)
            {
                PlayerWin();
            }
            else if (dealerScore == 21 && playerScore!=21)
            {
                DealerWin();
            }
            if (playerScore > 21)
            {
                DealerWin();

            }
            else if (dealerScore > 21)
            {
                PlayerWin();
            }
        }
        private void btnHold_Click(object sender, EventArgs e)
        {

            if ((dealerScore > playerScore) && dealerScore < 21)
            {
                DealerWin();
            }
            else if (playerScore == dealerScore)
            {
                Console.WriteLine("Equal points. No winner!");
                money += pot;
                pot = 0;
                lblMoneyValue.Text = money.ToString();
                lblDealerCards.Text = "";
                lblDealerScore.Text = "";
                lblPlayerCards.Text = "";
                lblPlayerScore.Text = "";
                btnDraw.Visible = false;
                btnHold.Visible = false;
                btnBetFifty.Enabled = true;
                btnBetTen.Enabled = true;
            }
            else if (dealerScore > 21)
            {
                PlayerWin();
            }
            else
            {
                int dCardIndex = rnd.Next(0, cards.Length);
                int dFaceIndex = rnd.Next(0, faces.Length);

                int firstNum = 0;
                int secondNum = 0;
                firstNum = rnd.Next(0, 300);
                secondNum = rnd.Next(0, 300);

               // MessageBox.Show("f: " + firstNum + " s: " + secondNum + " ");

                if (firstNum >= secondNum)
                {

                    Thread.Sleep(1500);
                    lblDealerCards.Text += " " + cards[dCardIndex].ToString();
                    dealerScore += cards[dCardIndex];
                    lblDealerScore.Text = dealerScore.ToString();
                }
                else
                {
                    Thread.Sleep(1500);
                    lblDealerCards.Text += " " + faces[dFaceIndex].ToString();

                    DealerFaces(dFaceIndex);
                    if (dealerScore > 21)
                    {
                        PlayerWin();
                    }
                }
                if (dealerScore > 21)
                {
                    PlayerWin();
                }
            }
        }
     }
}


