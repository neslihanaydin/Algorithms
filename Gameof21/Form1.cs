using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neslihan300359919BonusLab6
{
    public partial class Form1 : Form
    {
        //Classes that have been created ; Card, Heart:Card, Spade:Card, Diamond:Card, Clove:Card, Player, Deck
        Player jessica;
        Player owen;
        Player jack;
        Player david;
        Deck deck;
        List<Player> players;
        Player bet; //When the user clicked the bet button then related function assign the player to the bet variable.
        public Form1()
        {
            InitializeComponent();
            resetGame(); //It resets the game and buttons' situtations

            //ListView configurations
            listView1.View = View.Details;
            listView1.GridLines = true;

            listView1.Columns.Add("Player", 100);
            listView1.Columns.Add("Card1", 100);
            listView1.Columns.Add("Card2", 100);
            listView1.Columns.Add("Card3", 100);
            listView1.Columns.Add("Total", 100);
            listView1.Columns.Add("Status", 100);
        }

       

        private void disableBetButtons() //In some circumstances Bet buttons should be disabled
        {
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
        }
        private void disableMoreCardsButton() //In some circumstances More Cards buttons should be disabled
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e) //More Cards button for Player 1.In this case Jessica.
        {
            button1.Enabled = false;
            jessica.addCard(deck.giveCard());//addCard to Jessica Player
            checkStatus(); //Check status, if we clicked to More Cards button. Card's sum might be 21. And this comes from addCard function controls.
        }
        private void button2_Click(object sender, EventArgs e) //More Cards button for Player 2.In this case Owen.
        {
            button2.Enabled = false;
            owen.addCard(deck.giveCard());
            checkStatus();
        }
        private void button3_Click(object sender, EventArgs e) //More Cards button for Player 3.In this case Jack.
        {
            button3.Enabled = false;
            jack.addCard(deck.giveCard());
            checkStatus();
        }

        private void button4_Click(object sender, EventArgs e) //More Cards button for Player 4.In this case David.
        {
            button4.Enabled = false;
            david.addCard(deck.giveCard());
            checkStatus();
        }

        private void button5_Click(object sender, EventArgs e)  //Bet button for Player 1.In this case Jessica.
        {
            string message = "You bet on player 1";
            disableBetButtons(); //When the user has bet for a player, then all bet buttons will be disabled.
            MessageBox.Show(message); //Show "You bet on player X" message box
            label3.Text = message; //Label3 is the label below the Bet buttons. 
            bet = jessica; //This means, clicked the jessica's bet button.
        }

        private void button6_Click(object sender, EventArgs e) //Bet button for Player 2.In this case Owen.
        {
            string message = "You bet on player 2";
            disableBetButtons();
            MessageBox.Show(message);
            label3.Text = message;
            bet = owen;
        }

        private void button7_Click(object sender, EventArgs e)//Bet button for Player 3.In this case Jack.
        {
            string message = "You bet on player 3";
            disableBetButtons();
            MessageBox.Show(message);
            label3.Text = message;
            bet = jack;
        }

        private void button8_Click(object sender, EventArgs e)//Bet button for Player 4.In this case David.
        {
            string message = "You bet on player 4";
            disableBetButtons();
            MessageBox.Show(message);
            label3.Text = message;
            bet = david;
        }

        private void button9_Click(object sender, EventArgs e) //Button9 is the Deal Button. When the user clicked this button, then it should be start a new Game. User shoul click at the beginnning.
        {
            //With Deal button, the program will deal two cards for each player.
            button9.Enabled = false; //Deal button is disabled
            button10.Enabled = true; // Reset button is enabled
            button11.Enabled = true; //Final Result button is enabled
            label3.Text = "Results";
            newGame();
        }


        private void newGame()
        {

            //when new game starts, enable all More Cards and Bet buttons
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            bet = null;
            deck = new Deck(); //create a new deck object
            jessica = new Player(name: "Jessica", moreButton: button1, betButton: button5); // every player has their buttons
            jack = new Player(name: "Jack", moreButton: button3, betButton: button7);
            david = new Player(name: "David", moreButton: button4, betButton: button8);
            owen = new Player(name: "Owen", moreButton: button2, betButton: button6);
            players = new List<Player>(); //users will be holded here with their deck

            //activated user's buttons and give two cards to them.
            jessica.resetButton(); 
            jessica.addCard(deck.giveCard());
            jessica.addCard(deck.giveCard());

            owen.resetButton();
            owen.addCard(deck.giveCard());
            owen.addCard(deck.giveCard());

            jack.resetButton();
            jack.addCard(deck.giveCard());
            jack.addCard(deck.giveCard());

            david.resetButton();
            david.addCard(deck.giveCard());
            david.addCard(deck.giveCard());

            //add users to players list
            players.Add(jessica);
            players.Add(owen);
            players.Add(jack);
            players.Add(david);

         
            checkStatus(); // When two cards given, player might be win. It's decided in the player.addCard() function
        }

        private void checkStatus()
        {
            foreach (Player player in players)
            {
                if (player.status == "Winner") //It checks the player.status variable. If the user is winner then shows the Message Box.And call the announce Winner
                {
                    string message = "Player" + player.name + player.status;
                    MessageBox.Show(message);
                    announceWinner(); //If there is a winner than program should show the winner and list the user's cards and score.
                }
            }
        }

        private void announceWinner()
        {
            calculateResult();
            writeResult(); //Write scores on the ListView
            disableMoreCardsButton(); //When winners listed then more cards buttons should be disabled
            disableBetButtons(); //When winners listed then bet buttons should be disabled
            button9.Enabled = false; //Disable the Deal button
            button11.Enabled = false; //Disable the Final Result
            //At the end, just Reset button is enabled.
        }


        private void calculateResult()
        {
            Player bestPointPlayer = null; //volatile the highest score player. In the beginning it's null
            int[] points = new int[4]; // Scores of the players
            int index = 0; //index for player to add cardSums to point array
            foreach (Player player in players)
            {
                int cardSum = player.calculateCardSum(); //it sums the player's card
                if (cardSum <= 21) // the cardSum must be lower or equal than 21 to calculate winners 
                {
                    if(bestPointPlayer == null) // if bestPointPlayer is equal null this means any player has lower than 22 point yet
                    {
                        bestPointPlayer = player;
                    }
                    else if(cardSum > bestPointPlayer.calculateCardSum()) // this works after first bestPointPlayer check. it compares bestPointPlayer and other players
                    {
                        bestPointPlayer = player;
                    }
                    points[index] = cardSum; // it adds the cardSum to the points array
                    
                }
                index++;
            }
            if(bestPointPlayer != null) // no one has lower than 22 point. it means bestPointPlayer has not assigned. Every player lost the game
            {

                int[] sortedPoints = new int[4]; //to sort points create a new sortedPoints Array. 
                points.CopyTo(sortedPoints, 0);
                Array.Sort(sortedPoints);
                Array.Reverse(sortedPoints); //sort descending

                if (sortedPoints[0] != sortedPoints[1]) // If the biggest two points is not equal then we have a winner
                {
                    bestPointPlayer.status = "Winner";
                }
                else // this means it finds out the equal point's players
                {
                    foreach (Player player in players)
                    {
                        if (player.calculateCardSum() == sortedPoints[0])
                        {
                            player.status = "Handled";
                        }
                    }
                }

                if (bet != null) //This means user clicked bet button for one player
                {
                    if (bet.name == bestPointPlayer.name)
                    {
                        label4.Text = "Player " + bet.name + " won, you are right";
                    }
                    else
                    {
                        label4.Text = "Player " + bet.name + " lose, you are not right";
                    }

                }
            }

        }


        private void writeResult() //It writes the points and cards to the ListView
        {
            foreach (Player player in players)
            {
                var satir = new ListViewItem(player.getRow());
                listView1.Items.Add(satir);
            }
        }

        private void resetGame()
        {

            disableMoreCardsButton();
            disableBetButtons();
            
            button9.Enabled = true;
            button10.Enabled = false;
            button11.Enabled = false;
            label3.Text = "Results";
            label4.Text = "Place your bet by clicking the bet buttons under each player";
            listView1.Items.Clear();
            

        }

        private void button10_Click(object sender, EventArgs e) //Reset button clicked
        {
            
            bet = null;
            resetGame();
        }


        private void button11_Click(object sender, EventArgs e) // when Final result button clicked then call the announceWinner() function
        {
            announceWinner();
        }

       


       
    }
}
