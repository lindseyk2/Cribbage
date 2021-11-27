using System;

namespace Final_Project.Casting
{
    //The Actor to be in charge of the laid down pile
    public class LaidCard : Actor
    {
        public LaidCard()
        {
            Point velocity = new Point(0,0);
            SetVelocity(velocity);
            SetHeight(Constants.LAIDCARD_HEIGHT);
            SetWidth(Constants.LAIDCARD_WIDTH);
            //SetImage(Constants.IMAGE_BOARD);
            Point position = new Point(Constants.LAIDCARD_X, Constants.LAIDCARD_Y);
            SetPosition(position);
        }
    }
}