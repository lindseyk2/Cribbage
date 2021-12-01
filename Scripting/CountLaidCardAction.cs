using System;
using System.Collections.Generic;
using Final_Project.Casting;
using Final_Project.Services;


namespace Final_Project.Scripting
{
    //An action to count the number of cards in the laid down pile
    public class CountLaidCardAction : Action
    {
        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            List<Actor> playedPlayer = cast["PlayedPlayerCards"];
            List<Actor> playedNPC = cast["PlayedNPCCards"];
            List<Actor> counts = cast["Count"];

            int totalCount = 0;

            foreach (Card card in playedPlayer)
            {
                totalCount += card.GetCardValue();
            }
            foreach (Card card in playedNPC)
            {
                totalCount += card.GetCardValue();
            }
            foreach (Score count in counts)
            {
                count.SetScore(totalCount);
            }
        }
    }
}