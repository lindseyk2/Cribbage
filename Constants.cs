using System;

namespace Final_Project
{
    /// <summary>
    /// This is a set of program wide constants to be used in other classes.
    /// </summary>
    public static class Constants
    {
        public const int MAX_X = 800;
        public const int MAX_Y = 600;
        public const int FRAME_RATE = 30;

        public const int DEFAULT_FONT_SIZE = 20;
        public const int DEFAULT_TEXT_OFFSET = 4;

        public const int CARD_HEIGHT = 70;
        public const int CARD_WIDTH = 60;

        public const int BOARD_WIDTH = 400;
        public const int BOARD_HEIGHT = 100;
        public const int BOARD_X = 200;
        public const int BOARD_Y = 250;


        public const int GAME_PEICE_HEIGHT = 15;
        public const int GAME_PEICE_WIDTH = 5;

        public const int SCORE_HEIGHT = 25;
        public const int SCORE_WIDTH = 35;
        public const int SCORE_USER_X = 150;
        public const int SCORE_USER_Y = 327;
        public const int SCORE_NPC_X = 150;
        public const int SCORE_NPC_Y = 250;

        public const int LAIDCARD_X = 625;
        public const int LAIDCARD_Y = 275;
        public const int LAIDCARD_HEIGHT = 50;
        public const int LAIDCARD_WIDTH = 50;

        public const int DECK_X = 75;
        public const int DECK_Y = 265;

        public const string IMAGE_BACK_OF_CARD = "./Assets/PNG-cards-1.3/Back_of_Card.png";
        public const string IMAGE_BOARD = "./Assets/PNG-cards-1.3/Board.png";
        public const string IMAGE_ACE_OF_SPADE = "./Assets/PNG-cards-1.3/ace_of_spades.png";
        public const string IMAGE_ACE_OF_CLUB = "./Assets/PNG-cards-1.3/ace_of_clubs.png";
        public const string IMAGE_ACE_OF_HEART = "./Assets/PNG-cards-1.3/ace_of_hearts.png";
        public const string IMAGE_ACE_OF_DIAMOND = "./Assets/PNG-cards-1.3/ace_of_diamonds.png";
        public const string IMAGE_2_OF_SPADE = "./Assets/PNG-cards-1.3/2_of_spades.png";
        public const string IMAGE_2_OF_CLUB = "./Assets/PNG-cards-1.3/2_of_clubs.png";
        public const string IMAGE_2_OF_HEART = "./Assets/PNG-cards-1.3/2_of_hearts.png";
        public const string IMAGE_2_OF_DIAMOND = "./Assets/PNG-cards-1.3/2_of_diamonds.png";
        public const string IMAGE_3_OF_SPADE = "./Assets/PNG-cards-1.3/3_of_spades.png";
        public const string IMAGE_3_OF_CLUB = "./Assets/PNG-cards-1.3/3_of_clubs.png";
        public const string IMAGE_3_OF_HEART = "./Assets/PNG-cards-1.3/3_of_hearts.png";
        public const string IMAGE_3_OF_DIAMOND = "./Assets/PNG-cards-1.3/3_of_diamonds.png";
        public const string IMAGE_4_OF_SPADE = "./Assets/PNG-cards-1.3/4_of_spades.png";
        public const string IMAGE_4_OF_CLUB = "./Assets/PNG-cards-1.3/4_of_clubs.png";
        public const string IMAGE_4_OF_HEART = "./Assets/PNG-cards-1.3/4_of_hearts.png";
        public const string IMAGE_4_OF_DIAMOND = "./Assets/PNG-cards-1.3/4_of_diamonds.png";
        public const string IMAGE_5_OF_SPADE = "./Assets/PNG-cards-1.3/5_of_spades.png";
        public const string IMAGE_5_OF_CLUB = "./Assets/PNG-cards-1.3/5_of_clubs.png";
        public const string IMAGE_5_OF_HEART = "./Assets/PNG-cards-1.3/5_of_hearts.png";
        public const string IMAGE_5_OF_DIAMOND = "./Assets/PNG-cards-1.3/5_of_diamonds.png";
        public const string IMAGE_6_OF_SPADE = "./Assets/PNG-cards-1.3/6_of_spades.png";
        public const string IMAGE_6_OF_CLUB = "./Assets/PNG-cards-1.3/6_of_clubs.png";
        public const string IMAGE_6_OF_HEART = "./Assets/PNG-cards-1.3/6_of_hearts.png";
        public const string IMAGE_6_OF_DIAMOND = "./Assets/PNG-cards-1.3/6_of_diamonds.png";
        public const string IMAGE_7_OF_SPADE = "./Assets/PNG-cards-1.3/7_of_spades.png";
        public const string IMAGE_7_OF_CLUB = "./Assets/PNG-cards-1.3/7_of_clubs.png";
        public const string IMAGE_7_OF_HEART = "./Assets/PNG-cards-1.3/7_of_hearts.png";
        public const string IMAGE_7_OF_DIAMOND = "./Assets/PNG-cards-1.3/7_of_diamonds.png";
        public const string IMAGE_8_OF_SPADE = "./Assets/PNG-cards-1.3/8_of_spades.png";
        public const string IMAGE_8_OF_CLUB = "./Assets/PNG-cards-1.3/8_of_clubs.png";
        public const string IMAGE_8_OF_HEART = "./Assets/PNG-cards-1.3/8_of_hearts.png";
        public const string IMAGE_8_OF_DIAMOND = "./Assets/PNG-cards-1.3/8_of_diamonds.png";
        public const string IMAGE_9_OF_SPADE = "./Assets/PNG-cards-1.3/9_of_spades.png";
        public const string IMAGE_9_OF_CLUB = "./Assets/PNG-cards-1.3/9_of_clubs.png";
        public const string IMAGE_9_OF_HEART = "./Assets/PNG-cards-1.3/9_of_hearts.png";
        public const string IMAGE_9_OF_DIAMOND = "./Assets/PNG-cards-1.3/9_of_diamonds.png";
        public const string IMAGE_10_OF_SPADE = "./Assets/PNG-cards-1.3/10_of_spades.png";
        public const string IMAGE_10_OF_CLUB = "./Assets/PNG-cards-1.3/10_of_clubs.png";
        public const string IMAGE_10_OF_HEART = "./Assets/PNG-cards-1.3/10_of_hearts.png";
        public const string IMAGE_10_OF_DIAMOND = "./Assets/PNG-cards-1.3/10_of_diamonds.png";
        public const string IMAGE_J_OF_SPADE = "./Assets/PNG-cards-1.3/jack_of_spades2.png";
        public const string IMAGE_J_OF_CLUB = "./Assets/PNG-cards-1.3/jack_of_clubs2.png";
        public const string IMAGE_J_OF_HEART = "./Assets/PNG-cards-1.3/jack_of_hearts2.png";
        public const string IMAGE_J_OF_DIAMOND = "./Assets/PNG-cards-1.3/jack_of_diamonds2.png";
        public const string IMAGE_Q_OF_SPADE = "./Assets/PNG-cards-1.3/queen_of_spades2.png";
        public const string IMAGE_Q_OF_CLUB = "./Assets/PNG-cards-1.3/queen_of_clubs2.png";
        public const string IMAGE_Q_OF_HEART = "./Assets/PNG-cards-1.3/queen_of_hearts2.png";
        public const string IMAGE_Q_OF_DIAMOND = "./Assets/PNG-cards-1.3/queen_of_diamonds2.png";
        public const string IMAGE_K_OF_SPADE = "./Assets/PNG-cards-1.3/king_of_spades2.png";
        public const string IMAGE_K_OF_CLUB = "./Assets/PNG-cards-1.3/king_of_clubs2.png";
        public const string IMAGE_K_OF_HEART = "./Assets/PNG-cards-1.3/king_of_hearts2.png";
        public const string IMAGE_K_OF_DIAMOND = "./Assets/PNG-cards-1.3/king_of_diamonds2.png";
    }
}