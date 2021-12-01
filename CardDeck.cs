using System;
using System.Collections.Generic;
using Final_Project.Casting;

namespace Final_Project
{
    public class CardDeck
    {
        private List<Card> _deck = new List<Card>();

        public CardDeck()
        {
            CreateDeck();
        }

        private void CreateDeck()
        {
            int sNumber = 1;
            int cNumber = 1;
            int dNumber = 1;
            int hNumber = 1;
             
            for (int i = 0; i < 52; i++)
            {
                if (i < 13)
                {   
                    Card card = new Card();
                    card.SetSuit("Spade"); 
                    card.SetCardValue(sNumber);
                    card.SetText(sNumber + "\n S");
                    _deck.Add(card);
                    sNumber++;
                }
                else if (i >= 13 && i < 26)
                {
                    Card card = new Card();
                    card.SetSuit("Club"); 
                    card.SetCardValue(cNumber);
                    card.SetText(cNumber + "\n C");
                    _deck.Add(card);
                    cNumber++;
                }
                else if (i >= 26 && i < 39)
                {
                    Card card = new Card();
                    card.SetSuit("Dimond"); 
                    card.SetCardValue(dNumber);
                    card.SetText(dNumber + "\n D");
                    _deck.Add(card);
                    dNumber++;
                }
                else if (i >= 39 && i < 52)
                {
                    Card card = new Card();
                    card.SetSuit("Heart"); 
                    card.SetCardValue(hNumber);
                    card.SetText(hNumber + "\n H");
                    _deck.Add(card);
                    hNumber++;
                }
            }
        }
        public Card RandomCard()
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(0, _deck.Count);
            Card randomCard = _deck[number];
            _deck.Remove(randomCard);
            return randomCard;
        }
    }
}