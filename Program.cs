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

            // The pile
            cast["Pile"] = new List<Actor>();

            LaidCard pile = new LaidCard();
            cast["Pile"].Add(pile);

            // The deck
            cast["Deck"] = new List<Actor>();

            Deck deck = new Deck();
            cast["Deck"].Add(deck);

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
