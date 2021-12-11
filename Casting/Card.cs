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
    }
}