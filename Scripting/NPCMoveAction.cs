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
            List<Actor> cards = cast["Cards"];

            Random randomGenerator = new Random();
            int number = randomGenerator.Next(0, npcCards.Count);
            
            if(npcCards.Count > playerCards.Count)
            {
                Actor card = npcCards[number];

                Point position = new Point(Constants.LAIDCARD_X, Constants.LAIDCARD_Y);
                card.SetPosition(position);
                cards.Add(card);
            }
            foreach(Actor card in cards)
            {
                npcCards.Remove(card);
            }
        }
    }
}