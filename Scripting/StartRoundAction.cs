using System.Collections.Generic;
using Final_Project.Casting;
using Final_Project.Services;


namespace Final_Project.Scripting
{
    //An action to Create a new Hand
    public class StartRoundAction : Action
    {
        TurnService _turnService;

        public StartRoundAction(TurnService turnService)
        {
            _turnService = turnService;
        }
        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            List<Actor> playerCards = cast["PlayerCards"];
            List<Actor> playedPlayer = cast["PlayedPlayerCards"];
            List<Actor> npcCards = cast["NPCCards"];
            List<Actor> playedNPC = cast["PlayedNPCCards"];
            List<Actor> cards = cast["Cards"];
            List<Actor> crib = cast["Crib"];
            CardDeck cardDeck = new CardDeck();
            
            //int count = playerCards.Count + npcCards.Count;
            
            if (_turnService.IsStartRound())
            {
                // Clear the board of cards
                List<Actor> clearCards = new List<Actor>();
                foreach (Actor card in cards)
                {
                    clearCards.Add(card);
                }
                foreach (Actor card in crib)
                {
                    clearCards.Add(card);
                }
                foreach (Actor card in playedPlayer)
                {
                    clearCards.Add(card);
                }
                foreach (Actor card in playedNPC)
                {
                    clearCards.Add(card);
                }
                foreach (Actor card in clearCards)
                {
                    cards.Remove(card);
                    crib.Remove(card);
                    playedPlayer.Remove(card);
                    playedNPC.Remove(card);
                }

                // Player Hand
                int x1 = 200;
                for (int i = 0; i < 6; i++)
                {
                    Point userHand = new Point(x1, 520);
                    Card playerCard = cardDeck.RandomCard();
                    playerCard.SetPosition(userHand);
                    //playerCard.GetText();
                    cast["PlayerCards"].Add(playerCard);
                    x1 += 65;
                }

                // NPC Hand
                int x2 = 200;
                for (int i = 0; i < 6; i = i + 1)
                {
                    Point npcHand = new Point(x2, 10);
                    Card npcCard = cardDeck.RandomCard();
                    npcCard.SetPosition(npcHand);
                    npcCard.SetImage(Constants.IMAGE_BACK_OF_CARD);
                    cast["NPCCards"].Add(npcCard);
                    x2 += 65;
                }                

                // Adds a face up
                Point faceUpCardPosition = new Point(Constants.DECK_X, Constants.DECK_Y);
                Card faceUpCard = cardDeck.RandomCard();
                faceUpCard.SetPosition(faceUpCardPosition);
                //faceUpCard.GetText();
                cast["Cards"].Add(faceUpCard);

                _turnService.SetStartRound(false);
                _turnService.SetEndRound(true);
            }
        }
    }
}