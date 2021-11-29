using System.Collections.Generic;
using Final_Project.Casting;
using Final_Project.Services;


namespace Final_Project.Scripting
{
    //An action to move the card from the player hand onto the board
    public class MoveCardAction : Action
    {
        InputService _inputService;

        public MoveCardAction(InputService inputService)
        {
            _inputService = inputService;
        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            Point mousePosition = _inputService.GetMouseClick();
            int mouseX = mousePosition.GetX();
            int mouseY = mousePosition.GetY();

            List<Actor> playerCards = cast["PlayerCards"];
            List<Actor> cards = cast["Cards"];
            foreach(Card card in playerCards)
            {
                int leftEdge = card.GetLeftEdge();
                int rightEdge = card.GetRightEdge();
                int top = card.GetTopEdge();
                int bottom = card.GetBottomEdge();

                if(_inputService.ISMouseClick())
                {
                    if(mouseX >= leftEdge && mouseX <= rightEdge)
                    {
                        if(mouseY >= top && mouseY <= bottom)
                        {
                            Point position = new Point(Constants.LAIDCARD_X, Constants.LAIDCARD_Y);
                            card.SetPosition(position);
                            cards.Add(card);
                        }
                    }
                }
            }
            foreach(Card card in cards)
            {
                playerCards.Remove(card);
            }
        }
    }
}