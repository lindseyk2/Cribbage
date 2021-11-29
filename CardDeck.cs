using System;
using System.Collections.Generic;
using Final_Project.Casting;

namespace Final_Project
{
    public class CardDeck
    {
        private List<Card> _deck = new List<Card>();
        private Card _card = new Card();

        public CardDeck()
        {
            
        }

        private void CreateDeck()
        {
            int number = 1;
            for (int i = 0; i < 52; i++)
            {
                if (i < 13)
                {   
                    _card.SetSuit("Spade"); 
                    _card.SetCardValue(number);
                    _deck.Add(_card);
                    number++;
                }
                if (i < 26)
                {
                    number = 1;
                    _card.SetSuit("Club"); 
                    _card.SetCardValue(number);
                    _deck.Add(_card);
                    number++;
                }
                if (i < 39)
                {
                    number = 1;
                    _card.SetSuit("Dimond"); 
                    _card.SetCardValue(number);
                    _deck.Add(_card);
                    number++;
                }
                else
                {
                    number = 1;
                    _card.SetSuit("Heart"); 
                    _card.SetCardValue(number);
                    _deck.Add(_card);
                    number++;
                }
            }
        }
        public Card RandomCard()
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(0, _deck.Count);
            Card randomCard = _deck[number];
            return randomCard;
        }
    }
}