﻿using System.Drawing;
using System.ComponentModel;
using Object_Classes;


namespace Game_Logic_Class
{
    public static class SpaceRaceGame
    {
        // Minimum and maximum number of players.
        public const int MIN_PLAYERS = 2;
        public const int MAX_PLAYERS = 6;

        private static int numberOfPlayers = 2;  //default value for test purposes only 
        public static int NumberOfPlayers
        {
            get
            {
                return numberOfPlayers;
            }
            set
            {
                numberOfPlayers = value;
            }
        }

        public static string[] names = { "One", "Two", "Three", "Four", "Five", "Six" };  // default values

        // Only used in Part B - GUI Implementation, the colours of each player's token
        private static Brush[] playerTokenColours = new Brush[MAX_PLAYERS] { Brushes.Yellow, Brushes.Red,
                                                                       Brushes.Orange, Brushes.White,
                                                                      Brushes.Green, Brushes.DarkViolet};
        /// <summary>
        /// A BindingList is like an array which grows as elements are added to it.
        /// </summary>
        private static BindingList<Player> players = new BindingList<Player>();
        public static BindingList<Player> Players
        {
            get
            {
                return players;
            }
        }

        // The pair of die
        private static Die die1 = new Die(), die2 = new Die();


        /// <summary>
        /// Set up the conditions for this game as well as
        ///   creating the required number of players, adding each player 
        ///   to the Binding List and initialize the player's instance variables
        ///   except for playerTokenColour and playerTokenImage in Console implementation.
        ///   
        ///     
        /// Pre:  none
        /// Post:  required number of players have been initialsed for start of a game.
        /// </summary>
        public static void SetUpPlayers()
        {
            players.Clear();
            for (var i = 0; i < numberOfPlayers; i++)
            {
                var player = new Player(names[i])
                {
                    RocketFuel = Player.INITIAL_FUEL_AMOUNT,
                    HasPower = true,
                    Position = Board.StartSquareNumber,
                    Location = Board.StartSquare,
                    AtFinish = false,
                    PlayerTokenColour = playerTokenColours[i]
                };
                players.Add(player);
            }

        }

        /// <summary>
        ///  Plays one round of a game
        /// </summary>
        public static void PlayOneRound()
        {
            for (var i = 0; i < numberOfPlayers; i++)
            {
                players[i].Play(die1, die2);
            }
        }
        /// <summary>
        ///  Plays one single turn of a round
        /// </summary>
        public static void PlaySingle(int counter)
        {
            Players[counter].Play(die1,die2);
            counter++;
            if (counter == MAX_PLAYERS)
            {
                counter = 0;
            }
        }
        /// <summary>
        ///  Checks was the game finished
        /// </summary>
        public static bool IsGameActive()
        {
            for (var i = 0; i < numberOfPlayers; i++)
            {
                if (players[i].AtFinish) return false;
            }
            return true;
        }
        public static bool LosedGame()
        {
            var isLosed = true;
            for (var i = 0; i < numberOfPlayers; i++)
            {
                if (players[i].HasPower) isLosed = false;
            }
            return isLosed;
        }
    }//end SnakesAndLadders
}