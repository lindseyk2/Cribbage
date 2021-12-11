using System.Collections.Generic;
using Final_Project.Casting;
using Final_Project.Services;


namespace Final_Project.Scripting
{
    //An action to End a round
    public class EndRoundAction : Action
    {
        TurnService _turnService;

        public EndRoundAction(TurnService turnService)
        {
            _turnService = turnService;
        }
        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            List<Actor> playedPlayerCards = cast["PlayedPlayerCards"];
            List<Actor> playedNPCCards = cast["PlayedNPCCards"];
            List<Actor> crib = cast["Crib"];
            Card faceUpCard = (Card)cast["Cards"][0];
            Score playerScore = (Score)cast["Scores"][0];
            Score npcScore = (Score)cast["Scores"][1];

            if (_turnService.IsEndRound() && playedPlayerCards.Count + playedNPCCards.Count == 8)
            {
                // Player Hand
                int x1 = 200;
                foreach (Card playerCard in playedPlayerCards)
                {
                    Point userHand = new Point(x1, 520);
                    playerCard.SetPosition(userHand);
                    x1 += 65;
                }

                // NPC Hand
                int x2 = 200;
                foreach (Card npcCard in playedNPCCards)
                {
                    Point npcHand = new Point(x2, 10);
                    npcCard.SetPosition(npcHand);
                    x2 += 65;
                }
                
                //Player Deal
                if (_turnService.IsPlayerDeal())
                {
                    //Count NPC Score First
                    int newNPCScore = CountScore(playedNPCCards, faceUpCard) + npcScore.GetScore();
                    npcScore.SetScore(newNPCScore);

                    //Remove NPC Hand
                    List<Actor> clearNPCCards = new List<Actor>();
                    foreach (Actor card in playedNPCCards)
                    {
                        clearNPCCards.Add(card);
                    }
                    foreach (Actor card in clearNPCCards)
                    {
                        playedNPCCards.Remove(card);
                    }
                    
                    //Check to see if NPC won the game
                    if (npcScore.GetScore() >= 121)
                    {
                        //Game is finished
                    }

                    else
                    {
                        //Count Player Score without Crib
                        int newPlayerScore = CountScore(playedPlayerCards, faceUpCard) + playerScore.GetScore();
                        playerScore.SetScore(newPlayerScore);

                        //Remove Player Hand
                        List<Actor> clearPlayerCards = new List<Actor>();
                        foreach (Actor card in playedPlayerCards)
                        {
                            clearPlayerCards.Add(card);
                        }
                        foreach (Actor card in clearPlayerCards)
                        {
                            playedPlayerCards.Remove(card);
                        }

                        //Check to see if Player won the game without Crib
                        if (playerScore.GetScore() >= 121)
                        {
                            //Game is finished
                        }
                        else
                        {
                            //Count Player Score with crib
                            int cribScore = CountScore(crib, faceUpCard) + playerScore.GetScore();
                            playerScore.SetScore(cribScore);

                            //Remove Crib
                            List<Actor> clearCrib = new List<Actor>();
                            foreach (Actor card in crib)
                            {
                                clearCrib.Add(card);
                            }
                            foreach (Actor card in clearCrib)
                            {
                                crib.Remove(card);
                            }

                            //Check to see if Player won the game with Crib
                            if (playerScore.GetScore() >= 121)
                            {
                                //Game is finsihed
                            }
                            else
                            {
                                _turnService.SetEndRound(false);
                                _turnService.SetStartRound(true);
                                _turnService.SetPlayerDeal(false);
                                _turnService.SetNPCDeal(true);
                            }
                        }
                    }
                }

                //NPC Deal
                else if (_turnService.IsNPCDeal())
                {
                    //Count Player Score first
                    int newPlayerScore = CountScore(playedPlayerCards, faceUpCard) + playerScore.GetScore();
                    playerScore.SetScore(newPlayerScore);

                    //Remove Player Hand
                    List<Actor> clearPlayerCards = new List<Actor>();
                    foreach (Actor card in playedPlayerCards)
                    {
                        clearPlayerCards.Add(card);
                    }
                    foreach (Actor card in clearPlayerCards)
                    {
                        playedPlayerCards.Remove(card);
                    }

                    //Check to see if Player won the game
                    if (playerScore.GetScore() >= 121)
                    {
                        //Game is finished
                    }
                    else
                    {
                        //Count NPC hand without the crib
                        int newNPCScore = CountScore(playedNPCCards, faceUpCard) + npcScore.GetScore();
                        npcScore.SetScore(newNPCScore);

                        //Remove NPC Hand
                        List<Actor> clearNPCCards = new List<Actor>();
                        foreach (Actor card in playedNPCCards)
                        {
                            clearNPCCards.Add(card);
                        }
                        foreach (Actor card in clearNPCCards)
                        {
                            playedNPCCards.Remove(card);
                        }

                        //Check to see if NPC won the game WITHOUT the Crib
                        if (npcScore.GetScore() >= 121)
                        {
                            //Game is finished
                        }
                        else 
                        {
                            //Count NPC hand with the crib
                            int cribScore = CountScore(crib, faceUpCard) + npcScore.GetScore();
                            npcScore.SetScore(cribScore);

                            //Remove Crib
                            List<Actor> clearCrib = new List<Actor>();
                            foreach (Actor card in crib)
                            {
                                clearCrib.Add(card);
                            }
                            foreach (Actor card in clearCrib)
                            {
                                crib.Remove(card);
                            }

                            //Check to see if NPC won the game WITH the Crib
                            if (npcScore.GetScore() >= 121)
                            {
                                //Game is finished
                            }
                            else
                            {
                                _turnService.SetEndRound(false);
                                _turnService.SetStartRound(true);
                                _turnService.SetPlayerDeal(true);
                                _turnService.SetNPCDeal(false);
                            }
                        }
                    }
                }
            }
        }
        private int CountScore(List<Actor> hand, Card faceUpCard)
        {
            // Used Mr. Murphy code to help with scoring from https://www.codeproject.com/Articles/15468/Cribbage-Hand-Counting-Library

            int score = 0;

            //Hand
            Card card1 = (Card)hand[0];
            Card card2 = (Card)hand[1];
            Card card3 = (Card)hand[2];
            Card card4 = (Card)hand[3];
            
            //Make a list of all five cards
            List<Card> cards = new List<Card>();
            cards.Add(card1);
            cards.Add(card2);
            cards.Add(card3);
            cards.Add(card4);
            cards.Add(faceUpCard);

            //Create a new list of list called setOf2
            List<List<Card>> setOf2 = new List<List<Card>>();
            List<Card> pair1 = new List<Card>();
            pair1.Add(cards[0]);
            pair1.Add(cards[1]);
            List<Card> pair2 = new List<Card>();
            pair2.Add(cards[0]);
            pair2.Add(cards[2]);
            List<Card> pair3 = new List<Card>();
            pair3.Add(cards[0]);
            pair3.Add(cards[3]);
            List<Card> pair4 = new List<Card>();
            pair4.Add(cards[0]);
            pair4.Add(cards[4]);
            List<Card> pair5 = new List<Card>();
            pair5.Add(cards[1]);
            pair5.Add(cards[2]);
            List<Card> pair6 = new List<Card>();
            pair6.Add(cards[1]);
            pair6.Add(cards[3]);
            List<Card> pair7 = new List<Card>();
            pair7.Add(cards[1]);
            pair7.Add(cards[4]);
            List<Card> pair8 = new List<Card>();
            pair8.Add(cards[2]);
            pair8.Add(cards[3]);
            List<Card> pair9 = new List<Card>();
            pair9.Add(cards[2]);
            pair9.Add(cards[4]);
            List<Card> pair10 = new List<Card>();
            pair10.Add(cards[3]);
            pair10.Add(cards[4]);

            setOf2.Add(pair1);
            setOf2.Add(pair2);
            setOf2.Add(pair3);
            setOf2.Add(pair4);
            setOf2.Add(pair5);
            setOf2.Add(pair6);
            setOf2.Add(pair7);
            setOf2.Add(pair8);
            setOf2.Add(pair9);
            setOf2.Add(pair10);

            //Create a new list called setOf3
            List<List<Card>> setOf3= new List<List<Card>>();
            List<Card> tripple1 = new List<Card>();
            tripple1.Add(cards[0]);
            tripple1.Add(cards[1]);
            tripple1.Add(cards[2]);
            List<Card> tripple2 = new List<Card>();
            tripple2.Add(cards[0]);
            tripple2.Add(cards[1]);
            tripple2.Add(cards[3]);
            List<Card> tripple3 = new List<Card>();
            tripple3.Add(cards[0]);
            tripple3.Add(cards[2]);
            tripple3.Add(cards[3]);
            List<Card> tripple4 = new List<Card>();
            tripple4.Add(cards[1]);
            tripple4.Add(cards[2]);
            tripple4.Add(cards[3]);
            List<Card> tripple5 = new List<Card>();
            tripple5.Add(cards[0]);
            tripple5.Add(cards[1]);
            tripple5.Add(cards[4]);
            List<Card> tripple6 = new List<Card>();
            tripple6.Add(cards[0]);
            tripple6.Add(cards[2]);
            tripple6.Add(cards[4]);
            List<Card> tripple7 = new List<Card>();
            tripple7.Add(cards[1]);
            tripple7.Add(cards[2]);
            tripple7.Add(cards[4]);
            List<Card> tripple8 = new List<Card>();
            tripple8.Add(cards[0]);
            tripple8.Add(cards[3]);
            tripple8.Add(cards[4]);
            List<Card> tripple9 = new List<Card>();
            tripple9.Add(cards[1]);
            tripple9.Add(cards[3]);
            tripple9.Add(cards[4]);
            List<Card> tripple10 = new List<Card>();
            tripple10.Add(cards[2]);
            tripple10.Add(cards[3]);
            tripple10.Add(cards[4]);
            
            setOf3.Add(tripple1);
            setOf3.Add(tripple2);
            setOf3.Add(tripple3);
            setOf3.Add(tripple4);
            setOf3.Add(tripple5);
            setOf3.Add(tripple6);
            setOf3.Add(tripple7);
            setOf3.Add(tripple8);
            setOf3.Add(tripple9);
            setOf3.Add(tripple10);

            //Create a new list called setOf4
            List<List<Card>> setOf4= new List<List<Card>>();
            List<Card> quad1 = new List<Card>();
            quad1.Add(cards[0]);
            quad1.Add(cards[1]);
            quad1.Add(cards[2]);
            quad1.Add(cards[3]);
            List<Card> quad2 = new List<Card>();
            quad2.Add(cards[0]);
            quad2.Add(cards[1]);
            quad2.Add(cards[2]);
            quad2.Add(cards[4]);
            List<Card> quad3 = new List<Card>();
            quad3.Add(cards[0]);
            quad3.Add(cards[1]);
            quad3.Add(cards[3]);
            quad3.Add(cards[4]);
            List<Card> quad4 = new List<Card>();
            quad4.Add(cards[0]);
            quad4.Add(cards[2]);
            quad4.Add(cards[3]);
            quad4.Add(cards[4]);
            List<Card> quad5 = new List<Card>();
            quad5.Add(cards[1]);
            quad5.Add(cards[2]);
            quad5.Add(cards[3]);
            quad5.Add(cards[4]);

            setOf4.Add(quad1);
            setOf4.Add(quad2);
            setOf4.Add(quad3);
            setOf4.Add(quad4);
            setOf4.Add(quad5);

            //Create a list called setOf5
            List<List<Card>> setOf5= new List<List<Card>>();
            List<Card> allCards = new List<Card>();
            allCards.Add(cards[0]);
            allCards.Add(cards[1]);
            allCards.Add(cards[2]);
            allCards.Add(cards[3]);
            allCards.Add(cards[4]);

            //Put the setOf2, setOf3, setOf4, setOf5 into a list called sets
            List<List<List<Card>>> sets = new List<List<List<Card>>>();
            sets.Add(setOf2);
            sets.Add(setOf3);
            sets.Add(setOf4);
            sets.Add(setOf5);
    
            //Check to see if there is any pairs
            for (int i = 0; i < setOf2.Count; i++)
            {
                if (setOf2[i][0].GetCardValue() == setOf2[i][1].GetCardValue())
                {
                    score += 2;
                }
            }

            //Check to see if there is any 15's
            for (int i = 0; i < setOf2.Count; i++)
            {
                if (setOf2[i][0].GetCardValue() + setOf2[i][1].GetCardValue() == 15)
                {
                    score += 2;
                }
            }

            for (int i = 0; i < setOf3.Count; i++)
            {
                if (setOf3[i][0].GetCardValue() + setOf3[i][1].GetCardValue() +
                setOf3[i][2].GetCardValue() == 15)
                {
                    score += 2;
                }
            }

            for (int i = 0; i < setOf4.Count; i++)
            {
                if (setOf4[i][0].GetCardValue() + setOf4[i][1].GetCardValue() +
                setOf4[i][2].GetCardValue() + setOf4[i][3].GetCardValue() == 15)
                {
                    score += 2;
                }
            }

            for (int i = 0; i < setOf5.Count; i++)
            {
                if (setOf5[i][0].GetCardValue() + setOf5[i][1].GetCardValue() +
                setOf5[i][2].GetCardValue() + setOf5[i][3].GetCardValue() +
                setOf5[i][4].GetCardValue() == 15)
                {
                    score += 2;
                }
            }

            //Check to see if nibs
            foreach (Card card in hand)
            {
                if ((card.GetCardValue() == 11) && (card.GetSuit() == faceUpCard.GetSuit()))
                {
                    score += 1;
                }
            }
            
            return score;
        }
    }
}