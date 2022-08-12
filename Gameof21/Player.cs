using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neslihan300359919BonusLab6
{
    public class Player
    {
        public string name;
        public List<Card> cards = new List<Card>();
        public string status = "Lose";
        Button moreButton;
        Button betButton;

        public Player(string name, Button moreButton, Button betButton)
        {
            this.name = name;
            this.moreButton = moreButton;
            this.betButton = betButton;
        }

        
        public void addCard(Card card)
        {
            this.cards.Add(card);
            int sum = calculateCardSum();
            if(sum > 21)
            {
                status = "Lose";
                moreButton.Enabled = false; 
                betButton.Enabled = false;
            }else if(sum == 21)
            {
                status = "Winner";
            }
        }

        public void resetButton()
        {
            moreButton.Enabled = true;
            betButton.Enabled = true;
        }

        public String[] getRow()
        {
            string[] row = new string[6];
            row[0] = name;
            for (int i = 1; i < 4; i++)
            {
                try
                {
                    row[i] = cards[i - 1].cardType.ToString() + "-" + cards[i - 1].number.ToString();
                }
                catch (Exception)
                {
                }
               
            }
            row[4] = calculateCardSum().ToString();
            row[5] = status;
            return row;
        }

        public int calculateCardSum()
        {
            int sum = 0;
            foreach (Card card in cards)
            {
                sum += card.number;
            }
            return sum;
        }
    }
}
