using C__Blackjack;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;


namespace C__Blackjack
{
    public class PlayCards
    {
        public List<Card> Cards;

        public PlayCards()
        {
            Cards = new List<Card>();

            foreach (Rank r in Enum.GetValues(typeof(Rank)))
            {
                foreach (Suit s in Enum.GetValues(typeof(Suit)))
                {
                    Card newCard = new Card(r, s);
                    Cards.Add(newCard); 
                }
            }
        }



        public Card NextCard()
        {          
            var temp = this.Cards[0];
            Cards.RemoveAt(0);
            return temp;
        }

        public void ShuffleDeck()
        {
            List<Card> shuffledCards = new List<Card>();

            Random random = new Random();

            while (Cards.Count > 0)
            {
                int randomIndex = random.Next(Cards.Count);

                shuffledCards.Add(Cards[randomIndex]);

                Cards.RemoveAt(randomIndex);
            }
            Cards = shuffledCards;
        }
    }
}