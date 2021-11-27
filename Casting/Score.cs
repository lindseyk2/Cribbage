using System;

namespace Final_Project.Casting
{
    //The Actor for displaying the score 
    public class Score : Actor
    {
        public Score(Point position)
        {
            Point velocity = new Point(0,0);
            SetVelocity(velocity);
            SetHeight(Constants.SCORE_HEIGHT);
            SetWidth(Constants.SCORE_WIDTH);
            //SetText("0");
            //SetImage(Constants.IMAGE_BOARD);
            SetPosition(position);
        }
    }
}