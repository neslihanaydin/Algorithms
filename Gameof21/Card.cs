using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neslihan300359919BonusLab6
{
    public enum CardType { Heart, Spade,Diamond, Clove }
    public class Card
    {
        public int number;
        public CardType cardType;

        public Card(int number, CardType type)
        {
            this.number = number;
            cardType = type;
        }
    }

    public class Cards
    {
        public Card[] cards = new Card[13];
        public Card[] getCards()
        {
            Random random = new Random();
            return cards.OrderBy(x => random.Next()).ToArray(); //Pick random card using LinQ
        }
    }


    //Heart, Spade,Diamind, Clove classes are inherited from Cards. They have enum type in their constructor
    public class Heart : Cards
    {
        public Heart()
        {
            for (int i = 1; i < 14; i++)
            {
                base.cards[i - 1] = new Card(number: i, type: CardType.Heart);
            }
        }
    }

    public class Spade: Cards
    {
        public Spade()
        {
            for (int i = 1; i < 14; i++)
            {
                base.cards[i - 1] = new Card(number: i, type: CardType.Spade);
            }
        }
    }

    public class Diamond: Cards
    {
        public Diamond()
        {
            for (int i = 1; i < 14; i++)
            {
                cards[i - 1] = new Card(number: i, type: CardType.Diamond);
            }
        }
    }

    public class Clove : Cards
    {
        public Clove()
        {
            for (int i = 1; i < 14; i++)
            {
                cards[i - 1] = new Card(number: i, type: CardType.Clove);
            }
        }
    }

    class Deck
    {
        public List<Card> cards = new List<Card>();

        public Deck()
        {
            List<Card> list = new List<Card>();
            Heart h= new Heart();
            list.AddRange(h.getCards());
            Spade s = new Spade();
            list.AddRange(s.getCards());
            Diamond d = new Diamond();
            list.AddRange(d.getCards());
            Clove c = new Clove();
            list.AddRange(c.getCards());
            Random random = new Random();
            cards = list.OrderBy(x => random.Next()).ToList();
        }

        public Card giveCard()
        {
            Card returnCard = cards.Last(); //give last card
            cards.RemoveAt(cards.Count - 1); // remove the given card
            return returnCard;
        }
    }
}
