using System.Collections.Generic;
using Final_Project.Casting;
using Final_Project.Services;


namespace Final_Project.Scripting
{
    //An action to Create a new Hand
    public class StartRoundAction : Action
    {
        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            CardDeck cardDeck = new CardDeck();

            int x1 = 200;
            for (int i = 0; i < 6; i++)
            {
                Point userHand = new Point(x1, 520);
                Card card = new Card(userHand);
                cast["PlayerCards"].Add(card);
                x1 += 65;
            }

            int x2 = 200;
            for (int i = 0; i < 6; i = i + 1)
            {
                Point userHand = new Point(x2, 10);
                Card card = new Card(userHand);
                cast["NPCCards"].Add(card);
                x2 += 65;
            }

            Point faceUpCardPosition = new Point(Constants.DECK_X, Constants.DECK_Y);
            Card faceUpCard = new Card(faceUpCardPosition);
            cast["Cards"].Add(faceUpCard);

        }
    }
}