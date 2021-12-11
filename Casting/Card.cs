using System;

namespace Final_Project.Casting
{
    //The Actor for a playing Card
    public class Card : Actor
    {
        private int _cardValue;
        private string _suit;
        public Card()
        {
            Point velocity = new Point(0,0);
            SetVelocity(velocity);
            SetHeight(Constants.CARD_HEIGHT);
            SetWidth(Constants.CARD_WIDTH);
            SetCardValue(_cardValue);
            SetSuit(_suit);
        }

        public void SetCardValue(int value)
        {
            _cardValue = value;
        }

        public int GetCardValue()
        {
            return _cardValue;
        }

        public void SetSuit(string suit)
        {
            _suit = suit;
        }

        public string GetSuit()
        {
            return _suit;
        }

        public string GetCardImage(string suit, int value)
        {
            //Spade first
            if (suit == "Spade" && value == 1)
            {
                return Constants.IMAGE_ACE_OF_SPADE;
            }
            else if (suit == "Spade" && value == 2)
            {
                return Constants.IMAGE_2_OF_SPADE;
            }
            else if (suit == "Spade" && value == 3)
            {
                return Constants.IMAGE_3_OF_SPADE;
            }
            else if (suit == "Spade" && value == 4)
            {
                return Constants.IMAGE_4_OF_SPADE;
            }
            else if (suit == "Spade" && value == 5)
            {
                return Constants.IMAGE_5_OF_SPADE;
            }
            else if (suit == "Spade" && value == 6)
            {
                return Constants.IMAGE_6_OF_SPADE;
            }
            else if (suit == "Spade" && value == 7)
            {
                return Constants.IMAGE_7_OF_SPADE;
            }
            else if (suit == "Spade" && value == 8)
            {
                return Constants.IMAGE_8_OF_SPADE;
            }
            else if (suit == "Spade" && value == 9)
            {
                return Constants.IMAGE_9_OF_SPADE;
            }
            else if (suit == "Spade" && value == 10)
            {
                return Constants.IMAGE_10_OF_SPADE;
            }
            else if (suit == "Spade" && value == 11)
            {
                _cardValue = 10;
                return Constants.IMAGE_J_OF_SPADE;

            }
            else if (suit == "Spade" && value == 12)
            {
                _cardValue = 10;
                return Constants.IMAGE_Q_OF_SPADE;

            }
            else if (suit == "Spade" && value == 13)
            {
                _cardValue = 10;
                return Constants.IMAGE_K_OF_SPADE;
            }
            //Clubs Second
            else if (suit == "Club" && value == 1)
            {
                return Constants.IMAGE_ACE_OF_CLUB;
            }
            else if (suit == "Club" && value == 2)
            {
                return Constants.IMAGE_2_OF_CLUB;
            }
            else if (suit == "Club" && value == 3)
            {
                return Constants.IMAGE_3_OF_CLUB;
            }
            else if (suit == "Club" && value == 4)
            {
                return Constants.IMAGE_4_OF_CLUB;
            }
            else if (suit == "Club" && value == 5)
            {
                return Constants.IMAGE_5_OF_CLUB;
            }
            else if (suit == "Club" && value == 6)
            {
                return Constants.IMAGE_6_OF_CLUB;
            }
            else if (suit == "Club" && value == 7)
            {
                return Constants.IMAGE_7_OF_CLUB;
            }
            else if (suit == "Club" && value == 8)
            {
                return Constants.IMAGE_8_OF_CLUB;
            }
            else if (suit == "Club" && value == 9)
            {
                return Constants.IMAGE_9_OF_CLUB;
            }
            else if (suit == "Club" && value == 10)
            {
                return Constants.IMAGE_10_OF_CLUB;
            }
            else if (suit == "Club" && value == 11)
            {
                _cardValue = 10;
                return Constants.IMAGE_J_OF_CLUB;
            }
            else if (suit == "Club" && value == 12)
            {
                _cardValue = 10;
                return Constants.IMAGE_Q_OF_CLUB;
            }
            else if (suit == "Club" && value == 13)
            {
                _cardValue = 10;
                return Constants.IMAGE_K_OF_CLUB;
            }
            //Dimonds Third
            else if (suit == "Diamond" && value == 1)
            {
                return Constants.IMAGE_ACE_OF_DIAMOND;
            }
            else if (suit == "Diamond" && value == 2)
            {
                return Constants.IMAGE_2_OF_DIAMOND;
            }
            else if (suit == "Diamond" && value == 3)
            {
                return Constants.IMAGE_3_OF_DIAMOND;
            }
            else if (suit == "Diamond" && value == 4)
            {
                return Constants.IMAGE_4_OF_DIAMOND;
            }
            else if (suit == "Diamond" && value == 5)
            {
                return Constants.IMAGE_5_OF_DIAMOND;
            }
            else if (suit == "Diamond" && value == 6)
            {
                return Constants.IMAGE_6_OF_DIAMOND;
            }
            else if (suit == "Diamond" && value == 7)
            {
                return Constants.IMAGE_7_OF_DIAMOND;
            }
            else if (suit == "Diamond" && value == 8)
            {
                return Constants.IMAGE_8_OF_DIAMOND;
            }
            else if (suit == "Diamond" && value == 9)
            {
                return Constants.IMAGE_9_OF_DIAMOND;
            }
            else if (suit == "Diamond" && value == 10)
            {
                return Constants.IMAGE_10_OF_DIAMOND;
            }
            else if (suit == "Diamond" && value == 11)
            {
                _cardValue = 10;
                return Constants.IMAGE_J_OF_DIAMOND;
            }
            else if (suit == "Diamond" && value == 12)
            {
                _cardValue = 10;
                return Constants.IMAGE_Q_OF_DIAMOND;
            }
            else if (suit == "Diamond" && value == 13)
            {
                _cardValue = 10;
                return Constants.IMAGE_K_OF_DIAMOND;
            }
            //Hearts Last
            else if (suit == "Heart" && value == 1)
            {
                return Constants.IMAGE_ACE_OF_HEART;
            }
            else if (suit == "Heart" && value == 2)
            {
                return Constants.IMAGE_2_OF_HEART;
            }
            else if (suit == "Heart" && value == 3)
            {
                return Constants.IMAGE_3_OF_HEART;
            }
            else if (suit == "Heart" && value == 4)
            {
                return Constants.IMAGE_4_OF_HEART;
            }
            else if (suit == "Heart" && value == 5)
            {
                return Constants.IMAGE_5_OF_HEART;
            }
            else if (suit == "Heart" && value == 6)
            {
                return Constants.IMAGE_6_OF_HEART;
            }
            else if (suit == "Heart" && value == 7)
            {
                return Constants.IMAGE_7_OF_HEART;
            }
            else if (suit == "Heart" && value == 8)
            {
                return Constants.IMAGE_8_OF_HEART;
            }
            else if (suit == "Heart" && value == 9)
            {
                return Constants.IMAGE_9_OF_HEART;
            }
            else if (suit == "Heart" && value == 10)
            {
                return Constants.IMAGE_10_OF_HEART;
            }
            else if (suit == "Heart" && value == 11)
            {
                _cardValue = 10;
                return Constants.IMAGE_J_OF_HEART;
            }
            else if (suit == "Heart" && value == 12)
            {
                _cardValue = 10;
                return Constants.IMAGE_Q_OF_HEART;
            }
            else if (suit == "Heart" && value == 13)
            {
                _cardValue = 10;
                return Constants.IMAGE_K_OF_HEART;
            }
            else
            {
                return Constants.IMAGE_BACK_OF_CARD;
            }
        }
    }
}