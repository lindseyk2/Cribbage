using System;
using System.Collections.Generic;
using Final_Project.Casting;

namespace Final_Project
{
    public class CardDeck
    {
        private List<string> _deck = new List<string>();
        private string _card;

        public CardDeck()
        {

        }

        private void CreateDeck()
        {
            int number = 1;
            for (int i = 0; i < 52; i++)
            {
                if (i <= 13)
                {
                    string suite = number + "Spade";
                    _deck.Add(suite);
                    number++;
                }
                if (i <= 26)
                {
                    number = 1;
                   string suite = number + "Clubs";
                    _deck.Add(suite);
                    number++; 
                }
                if (i <= 39)
                {
                    number = 1;
                    string suite = number + "Dimonds";
                    _deck.Add(suite);
                    number++;
                }
                else
                {
                    number = 1;
                    string suite = number + "Hearts";
                    _deck.Add(suite);
                    number++;
                }
            }
        }
        public string RandomCard()
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(0, _deck.Count);
            _card = _deck[number];
            return _card;
        }
    }
}