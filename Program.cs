using System;
using Final_Project.Services;
using Final_Project.Casting;
using Final_Project.Scripting;
using System.Collections.Generic;

namespace Final_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the cast
            Dictionary<string, List<Actor>> cast = new Dictionary<string, List<Actor>>();

            // Board
            cast["Board"] = new List<Actor>();

            Board board = new Board();
            cast["Board"].Add(board);

            // The Scores
            cast["Scores"] = new List<Actor>();

            Point userPosition = new Point(Constants.SCORE_USER_X, Constants.SCORE_USER_Y);
            Score user = new Score(userPosition);
            cast["Scores"].Add(user);

            Point NPCPosition = new Point(Constants.SCORE_NPC_X, Constants.SCORE_NPC_Y);
            Score NPC = new Score(NPCPosition);
            cast["Scores"].Add(NPC);

            // Laid Cards Count
            cast["Count"] = new List<Actor>();

            Point countPosition = new Point(650, 350);
            Score count = new Score(countPosition);
            cast["Count"].Add(count);

            // Face Up Card
            cast["Cards"] = new List<Actor>();
            
            Point faceUpCardPosition = new Point(Constants.DECK_X, Constants.DECK_Y);
            Card faceUpCard = new Card(faceUpCardPosition);
            cast["Cards"].Add(faceUpCard);

            // Player's Hand
            cast["PlayerCards"] = new List<Actor>();
            int x1 = 200;
            for (int i = 0; i < 6; i++)
            {
                Point userHand = new Point(x1, 520);
                Card card = new Card(userHand);
                cast["PlayerCards"].Add(card);
                x1 += 65;
            }

            // NPC's Hand
            cast["NPCCards"] = new List<Actor>();
            int x2 = 200;
            for (int i = 0; i < 6; i = i + 1)
            {
                Point userHand = new Point(x2, 10);
                Card card = new Card(userHand);
                cast["NPCCards"].Add(card);
                x2 += 65;
            }

            // Crib
            cast["Crib"] = new List<Actor>();

            Point cribPosition = new Point(20, 520);
            Card crib = new Card(cribPosition);
            cast["Crib"].Add(crib);

            // Create the script
            Dictionary<string, List<Action>> script = new Dictionary<string, List<Action>>();

            OutputService outputService = new OutputService();
            InputService inputService = new InputService();
            PhysicsService physicsService = new PhysicsService();
            AudioService audioService = new AudioService();

            script["output"] = new List<Action>();
            script["input"] = new List<Action>();
            script["update"] = new List<Action>();

            DrawActorsAction drawActorsAction = new DrawActorsAction(outputService);
            script["output"].Add(drawActorsAction);

            // TODO: Add additional actions here to handle the input, move the actors, handle collisions, etc.

            // Start up the game
            outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y, "Cribbage", Constants.FRAME_RATE);
            // audioService.StartAudio();
            // audioService.PlaySound(Constants.SOUND_START);

            Director theDirector = new Director(cast, script);
            theDirector.Direct();

            audioService.StopAudio();
        }
    }
}
