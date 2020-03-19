using System;
//DO NOT DELETE the two following using statements *********************************
using Game_Logic_Class;
using Object_Classes;


namespace Space_Race
{
    class Console_Class
    {
        /// <summary>
        /// Algorithm below currently plays only one game
        /// 
        /// when have this working correctly, add the abilty for the user to 
        /// play more than 1 game if they choose to do so.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            DisplayIntroductionMessage();
            StartGame();

        }//end Main


        /// <summary>
        /// Display a welcome message to the console
        /// Pre:    none.
        /// Post:   A welcome message is displayed to the console.
        /// </summary>
        static void DisplayIntroductionMessage()
        {
            Console.WriteLine($"{"",10}Welcome to Space Race.\n");

        } //end DisplayIntroductionMessage
        static void DisplayInstructionMessage()
        {
            Console.WriteLine($"{"",10}This game is for 2 to 6 players");
            Console.Write($"{"",10}How many players (2-6): ");
        }

        /// <summary>
        /// Displays a prompt and waits for a keypress.
        /// Pre:  none
        /// Post: a key has been pressed.
        /// </summary>
        static void PressEnter()
        {
            Console.Write("\nPress Enter to play a round ...\n");
            Console.ReadLine();
        } // end PressAny
        static void DisplayCurrentRound(ref string round)
        {
            Console.WriteLine($"{"",10}{round} round\n");
            foreach (var player in SpaceRaceGame.Players)
            {
                Console.WriteLine($"{"",10}{player.Name} on square {player.Position} with {player.RocketFuel} yottawatt of power remaining");
            }
            round = "Next";
        }
        static void DisplayWinners()
        {
            Console.WriteLine($"\n{"",10}The following player(s) finished the game\n");
            foreach (var player in SpaceRaceGame.Players)
            {
                if (player.AtFinish) Console.WriteLine($"{"",20}{player.Name}");
            }
            Console.WriteLine($"\n{"",10}Induvidial players finished with the at the locations specified.\n");
            foreach (var player in SpaceRaceGame.Players)
            {
                Console.WriteLine($"{"",20}{player.Name} with {player.RocketFuel} yattowatt of power at square {player.Position}\n");
            }
            Console.WriteLine($"{"",10}Press Enter key to continue ...");
            Console.ReadLine();
        }
        static void StartGame()
        {
            DisplayInstructionMessage();
            if (Int32.TryParse(Console.ReadLine(), out var numberOfPlayers) && numberOfPlayers <= 6 && numberOfPlayers >= 2)
            {
                Board.SetUpBoard();
                SpaceRaceGame.NumberOfPlayers = numberOfPlayers;
                SpaceRaceGame.SetUpPlayers();
                var round = "First";
                while (SpaceRaceGame.IsGameActive())
                {
                    PressEnter();
                    SpaceRaceGame.PlayOneRound();
                    DisplayCurrentRound(ref round);
                }
                DisplayWinners();
                PlayAgain();
            }
            else
            {
                Console.WriteLine("\nError: invalid number of players entered.\n");
                StartGame();
            }
        }
        static void PlayAgain()
        {
            Console.Write($"\n{"",10}Play Again? (Y or N): ");
            var answer = Console.ReadLine();
            if (answer.ToUpper().Equals("Y"))
            {
                StartGame();
            }
            else
            {
                Console.WriteLine($"{"",10}Thanks for playing Space Race.");
                Console.WriteLine($"{"",10}Press Enter to terminate program ...");
                Console.ReadLine();
            }
        }



    }//end Console class
}
