using System;

namespace Final_Project.Casting
{
    //The Actor for displaying the score 
    public class Score : Actor
    {
        private int _score = 0;
        public Score(Point position)
        {
            Point velocity = new Point(0,0);
            SetVelocity(velocity);
            SetHeight(Constants.SCORE_HEIGHT);
            SetWidth(Constants.SCORE_WIDTH);
            SetText(_score.ToString());
            SetPosition(position);
        }

        public void SetScore(int score)
        {
            _score = score;
        }

        public int GetScore()
        {
            return _score;
        }
    }
}