using Microsoft.Win32;
using System;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MemoryGameWindowsFormApp
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        bool gameOn = false;
        const int ROWS = 4;
        const int COLUMNS = 5;
        int previousCardMatch;
        double currentTime;
        int[,] cardArr = new int[ROWS, COLUMNS];
        Image[,] imageArr = new Image[ROWS, COLUMNS];
        int guessedCards;
        string previousCard = "";

        public Form1()
        {
            InitializeComponent();
            setGame();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\MemoryGameApp");
            if (key.GetValue("BestTime") == null)
            {
                key.SetValue("BestTime", currentTime);
                key.Close();
            }
            else
            {
                double bestTime;
                bool exists = double.TryParse(key.GetValue("BestTime").ToString(), out bestTime);
                if (currentTime < bestTime)
                {
                    key.SetValue("BestTime", currentTime);
                    key.Close();
                }
                currentTime = 0;
                lblTimer.Text = "Timer: " + currentTime;
                lblBest.Text = "Best: " + Math.Round(bestTime, 1) + "s";
                timer.Stop();
                setGame();
            }
        }

        private void setGame()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\MemoryGameApp");
            if ((key != null) && (key.GetValue("BestValue") != null))
            {
                double bestTime = double.Parse(key.GetValue("BestTime").ToString());
                lblBest.Text = "Best: " + Math.Round(bestTime, 1) + "s";
            }

            foreach (var pictureBox in Controls.OfType<PictureBox>())
            {
                pictureBox.Image = MemoryGameWindowsFormApp.Properties.Resources.cardBack;
                pictureBox.Enabled = true;
            }

            ArrayList usedNumbers = new ArrayList();

            for (int r = 0; r < ROWS; r++)
            {
                if (r == (ROWS/2))
                {
                    usedNumbers = new ArrayList();
                }
                for (int c = 0; c < COLUMNS; c++)
                {
                    int cardAssign;
                    bool newNum = false;
                    do
                    {
                        cardAssign = rand.Next((ROWS * COLUMNS) / 2);
                        newNum = !scanArrayList(usedNumbers, cardAssign);
                    } while (!newNum);

                    usedNumbers.Add(cardAssign);
                    cardArr[r, c] = cardAssign;

                    //This is the only part that needs to be edited if game is scaled above or bellow 20 cards
                    switch (cardAssign)
                    {
                        case 0:
                            imageArr[r, c] = MemoryGameWindowsFormApp.Properties.Resources._10H;
                            break;
                        case 1:
                            imageArr[r, c] = MemoryGameWindowsFormApp.Properties.Resources._2D;
                            break;
                        case 2:
                            imageArr[r, c] = MemoryGameWindowsFormApp.Properties.Resources._3C;
                            break;
                        case 3:
                            imageArr[r, c] = MemoryGameWindowsFormApp.Properties.Resources._4H;
                            break;
                        case 4:
                            imageArr[r, c] = MemoryGameWindowsFormApp.Properties.Resources._5S;
                            break;
                        case 5:
                            imageArr[r, c] = MemoryGameWindowsFormApp.Properties.Resources._6D;
                            break;
                        case 6:
                            imageArr[r, c] = MemoryGameWindowsFormApp.Properties.Resources.AS;
                            break;
                        case 7:
                            imageArr[r, c] = MemoryGameWindowsFormApp.Properties.Resources.JC;
                            break;
                        case 8:
                            imageArr[r, c] = MemoryGameWindowsFormApp.Properties.Resources.KH;
                            break;
                        case 9:
                            imageArr[r, c] = MemoryGameWindowsFormApp.Properties.Resources.QD;
                            break;
                    }
                }
            }
            guessedCards = 0;
            previousCardMatch = -1;
        }

        private bool scanArrayList(ArrayList arr, int target)
        {
            foreach (int num in arr)
            {
                if (num == target)
                {
                    return true;
                }
            }
            return false;
        }

        private void card_Click(object sender, EventArgs e)
        {
            if (!gameOn)
            {
                gameOn = true;
                timer.Start();
            }

            PictureBox c = (PictureBox)sender;
            string tag = (string)c.Tag;

            if (tag.Equals(previousCard))
            {
                c.Image = MemoryGameWindowsFormApp.Properties.Resources.cardBack;
                previousCard = "";
            }
            else
            {
                int cardRow = int.Parse(tag.ToString().Substring(0, 1));
                int cardCol = int.Parse(tag.ToString().Substring(2));

                if (previousCard.Equals(""))
                // no card up/ selecting the card
                {
                    previousCard = $"{cardRow},{cardCol}";
                    previousCardMatch = cardArr[cardRow, cardCol];
                    c.Image = imageArr[cardRow, cardCol];
                }
                else if (previousCardMatch == cardArr[cardRow, cardCol])
                // guess is right
                {
                    c.Image = imageArr[cardRow, cardCol];
                    foreach (PictureBox card in Controls.OfType<PictureBox>())
                    {
                        if (card.Tag.Equals(previousCard))
                        {
                            card.Enabled = false;
                            c.Enabled = false;
                            previousCard = "";
                            previousCardMatch = -1;
                            guessedCards += 2;
                            if (guessedCards == (ROWS * COLUMNS))
                            {
                                timer.Stop();
                                gameOn = false;
                            }
                            return;
                        }
                    }
                }
                else
                // guess is wrong
                {
                    c.Image = MemoryGameWindowsFormApp.Properties.Resources.cardBack;
                    foreach (PictureBox card in Controls.OfType<PictureBox>())
                    {
                        if (card.Tag.Equals(previousCard))
                        {
                            card.Image = MemoryGameWindowsFormApp.Properties.Resources.cardBack;
                            previousCardMatch = -1;
                            previousCard = "";
                            return;
                        }
                    }
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            currentTime += 0.1;
            lblTimer.Text = $"Timer: {Math.Round(currentTime, 1)}s";
        }
    }
}
