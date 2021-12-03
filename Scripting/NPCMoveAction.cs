using System;
using System.Collections.Generic;
using Final_Project.Casting;
using Final_Project.Services;


namespace Final_Project.Scripting
{
    //An action to move the NPC card
    public class NPCMoveAction : Action
    {
        TurnService _turnService;
        int _delay = 40;
        public NPCMoveAction(TurnService turnService)
        {
            _turnService = turnService;
        }
        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            
            if (_delay > 0)
            {
                _delay -=1;
            }
            else
            {
                List<Actor> playerCards = cast["PlayerCards"];
                List<Actor> npcCards = cast["NPCCards"];
                List<Actor> playedNPC = cast["PlayedNPCCards"];
                List<Actor> crib = cast["Crib"];
                List<Actor> countPlayedCards = cast["Count"];
                Score playerScore = (Score)cast["Scores"][0];

                Random randomGenerator = new Random();
                int number = randomGenerator.Next(0, npcCards.Count);

                _delay = 40;
            
                // if (npcCards.Count > playerCards.Count)
                if (_turnService.IsNPCTurn())
                {
                    if (npcCards.Count > 4)
                    {
                        Actor card = npcCards[number];

                        Point cribPosition = new Point(20, 520);
                        card.SetPosition(cribPosition);
                    
                        crib.Add(card);
                        npcCards.Remove(card);
                        _turnService.EndNPCTurn();
                    }
                    else
                    {
                        int totalCount = 0;
                        foreach (Score countPlayedCard in countPlayedCards)
                        {
                            totalCount += countPlayedCard.GetScore();
                        }

                        Card randomCard = (Card)npcCards[number];
                        int randomValue = randomCard.GetCardValue();

                            if (totalCount + randomValue > 31)
                            {                            
                                // int playerCurrentScore = playerScore.GetScore();
                                // int playerNewScore = playerCurrentScore + 1;
                                // playerScore.SetScore(playerNewScore);

                                Point laidPosition = new Point(Constants.LAIDCARD_X, Constants.LAIDCARD_Y);
                                randomCard.SetPosition(laidPosition);
                    
                                playedNPC.Add(randomCard);
                                _turnService.EndNPCTurn();
                            }
                            else
                            {
                                Point laidPosition = new Point(Constants.LAIDCARD_X, Constants.LAIDCARD_Y);
                                randomCard.SetPosition(laidPosition);
                    
                                playedNPC.Add(randomCard);
                                _turnService.EndNPCTurn();
                            }
    
                        foreach (Card card in playedNPC)
                        {
                            npcCards.Remove(card);
                        }
                    }
                }
            }
        }
    }
}