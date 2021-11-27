using System;

namespace Final_Project.Casting
{
    //The Actor for displaying the board
    public class Board : Actor
    {
        public Board()
        {
            Point velocity = new Point(0,0);
            SetVelocity(velocity);
            SetHeight(Constants.BOARD_HEIGHT);
            SetWidth(Constants.BOARD_WIDTH);
            //SetImage(Constants.IMAGE_BOARD);
            Point position = new Point(Constants.BOARD_X, Constants.BOARD_Y);
            SetPosition(position);
        }
    }
}