using System;
using System.Collections.Generic;
using Final_Project.Casting;
using Final_Project.Services;


namespace Final_Project.Scripting
{
    //An action to move the NPC card
    public class NPCMoveAction : Action
    {
        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            List<Actor> playerCards = cast["PlayerCards"];
            List<Actor> npcCards = cast["NPCCards"];
            List<Actor> playedNPC = cast["PlayedNPCCards"];
            List<Actor> crib = cast["Crib"];

            Random randomGenerator = new Random();
            int number = randomGenerator.Next(0, npcCards.Count);
            
            if (npcCards.Count > playerCards.Count)
            {
                if (npcCards.Count > 4)
                {
                    Actor card = npcCards[number];

                    Point cribPosition = new Point(20, 520);
                    card.SetPosition(cribPosition);
                    
                    crib.Add(card);
                    npcCards.Remove(card);
                }
                else
                {
                    Actor card = npcCards[number];

                    Point laidPosition = new Point(Constants.LAIDCARD_X, Constants.LAIDCARD_Y);
                    card.SetPosition(laidPosition);
                    
                    playedNPC.Add(card);
                    npcCards.Remove(card);
                }
            }
        }
    }
}