using System;

namespace Final_Project.Casting
{
    //The Actor to be incharge of 52 playing cards
    public class Deck : Actor
    {
        public Deck()
        {
            Point velocity = new Point(0,0);
            SetVelocity(velocity);
            SetHeight(Constants.CARD_HEIGHT);
            SetWidth(Constants.CARD_WIDTH);
            //SetImage(Constants.IMAGE_BOARD);
            Point position = new Point(Constants.DECK_X, Constants.DECK_Y);
            SetPosition(position);
        }
    }
}