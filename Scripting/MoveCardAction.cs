using System.Collections.Generic;
using Final_Project.Casting;
using Final_Project.Services;


namespace Final_Project.Scripting
{
    //An action to move the card from the player hand onto the board
    public class MoveCardAction : Action
    {
        InputService _inputService;
        TurnService _turnService;

        public MoveCardAction(InputService inputService, TurnService turnService)
        {
            _inputService = inputService;
            _turnService = turnService;
        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            Point mousePosition = _inputService.GetMouseClick();
            int mouseX = mousePosition.GetX();
            int mouseY = mousePosition.GetY();

            List<Actor> playerCards = cast["PlayerCards"];
            List<Actor> playedPlayer = cast["PlayedPlayerCards"];
            List<Actor> crib = cast["Crib"];
            List<Actor> countPlayedCards = cast["Count"];
            Card pass = (Card)cast["Pass"][0];
            Score npcScore = (Score)cast["Scores"][1];
            int count = playerCards.Count;
            
            foreach(Card card in playerCards)
            {
                int leftEdge = card.GetLeftEdge();
                int rightEdge = card.GetRightEdge();
                int top = card.GetTopEdge();
                int bottom = card.GetBottomEdge();

                int passLeftEdge = pass.GetLeftEdge();
                int passRightEdge = pass.GetRightEdge();
                int passTop = pass.GetTopEdge();
                int passBottom = pass.GetBottomEdge();

                if(_inputService.ISMouseClick() && _turnService.IsPlayerTurn())
                {
                    if(mouseX >= leftEdge && mouseX <= rightEdge)
                    {
                        if(mouseY >= top && mouseY <= bottom)
                        {
                            if (count > 4)
                            {
                                Point cribPosition = new Point(20, 520);
                                card.SetPosition(cribPosition);
                                crib.Add(card);

                                _turnService.EndPlayerTurn();
                            }
                            else
                            {
                                int totalCount = 0;
                                foreach (Score countPlayedCard in countPlayedCards)
                                {
                                    totalCount += countPlayedCard.GetScore();
                                }
                                int cardValue = card.GetCardValue();
                                
                                if (totalCount + cardValue > 31)
                                {
                                    
                                }
                                else
                                {
                                    Point position = new Point(Constants.LAIDCARD_X, Constants.LAIDCARD_Y);
                                    card.SetPosition(position);
                                    playedPlayer.Add(card);
                                    _turnService.EndPlayerTurn();
                                }
                            }
                        }
                    }
                    else if (mouseX >= passLeftEdge && mouseX <= passRightEdge)
                    {
                        if (mouseY >= passTop && mouseY <= passBottom)
                        {
                            _turnService.EndPlayerTurn();
                            int npcCurrentScore = npcScore.GetScore();
                            int npcNewScore = npcCurrentScore + 1;
                            npcScore.SetScore(npcNewScore);
                        }
                    }
                }
            }
            foreach(Card card in crib)
            {
                playerCards.Remove(card);
            }
            foreach(Card card in playedPlayer)
            {
                playerCards.Remove(card);
            }
        }
    }
}