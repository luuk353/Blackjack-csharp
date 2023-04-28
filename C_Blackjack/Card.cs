using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Blackjack
{



    public enum Rank
    {
        Ace,
        Two,               
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
    }

    public enum Suit
    {
        Hearts,
        Diamonds,
        Spades,             
        Clubs
    }



    public class Card
    {
        static string[] color = { "Hearts", "Diamonds", "Clubs", "Spades" };
        static string[] value = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
        public Rank Rank { get; private set; }
        public Suit Suit { get; private set; }

        public Card(Rank rank, Suit suit)
        {
            this.Rank = rank;
            this.Suit = suit;
        }

        public int GetValue(int totalpoints = 0)
        {

            switch (Rank)
            {
                case Rank.Ace:
                    return totalpoints > 10 ? 1 : 11;
                case Rank.Two:
                    return 2;
                case Rank.Three:
                    return 3;
                case Rank.Four:
                    return 4;
                case Rank.Five:
                    return 5;
                case Rank.Six:
                    return 6;
                case Rank.Seven:
                    return 7;               
                case Rank.Nine:
                    return 8;
                case Rank.Ten:
                case Rank.Jack:
                case Rank.Queen:
                case Rank.King:
                    return 10;
                default:
                    return (int)Rank;
            }

        }


        public override string ToString()
        {
            return $"{value[(int)Rank]} of {color[(int)Suit]}";    
        }
    }

}
