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

            Point countPosition = new Point(633, 360);
            Score count = new Score(countPosition);
            cast["Count"].Add(count);

            // Face Up Card
            cast["Cards"] = new List<Actor>();

            cast["PlayedPlayerCards"] = new List<Actor>();

            cast["PlayedNPCCards"] = new List<Actor>();

            // Player's Hand
            cast["PlayerCards"] = new List<Actor>();

            // NPC's Hand
            cast["NPCCards"] = new List<Actor>();

            // Crib
            cast["Crib"] = new List<Actor>();

            // Create the script
            Dictionary<string, List<Action>> script = new Dictionary<string, List<Action>>();

            OutputService outputService = new OutputService();
            InputService inputService = new InputService();
            PhysicsService physicsService = new PhysicsService();
            AudioService audioService = new AudioService();
            TurnService turnService = new TurnService();

            script["output"] = new List<Action>();
            script["input"] = new List<Action>();
            script["update"] = new List<Action>();

            MoveCardAction moveCardAction = new MoveCardAction(inputService, turnService);
            script["input"].Add(moveCardAction);

            StartRoundAction startRoundAction = new StartRoundAction();
            script["update"].Add(startRoundAction);

            CountLaidCardAction countLaidCardAction = new CountLaidCardAction();
            script["update"].Add(countLaidCardAction);
            
            NPCMoveAction npcMoveAction = new NPCMoveAction(turnService);
            script["update"].Add(npcMoveAction);
            
            DrawActorsAction drawActorsAction = new DrawActorsAction(outputService);
            script["output"].Add(drawActorsAction);

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
