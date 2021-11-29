using System;

namespace Final_Project.Casting
{
    //The Actor for a playing Card
    public class Card : Actor
    {
        public Card(Point position)
        {
            Point velocity = new Point(0,0);
            SetVelocity(velocity);
            SetHeight(Constants.CARD_HEIGHT);
            SetWidth(Constants.CARD_WIDTH);
            //SetImage(Constants.IMAGE_BOARD);
            SetPosition(position);
        }
    }
}