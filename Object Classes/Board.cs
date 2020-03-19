using System;
using System.Diagnostics;

namespace Object_Classes
{
    /// <summary>
    /// Models a game board for Space Race consisting of three different types of squares
    /// 
    /// Ordinary squares, Wormhole squares and Blackhole squares.
    /// 
    /// landing on a Wormhole or Blackhole square at the end of a player's move 
    /// results in the player moving to another square
    /// 
    /// </summary>
    public static class Board
    {
        /// <summary>
        /// Models a game board for Space Race consisting of three different types of squares
        /// 
        /// Ordinary squares, Wormhole squares and Blackhole squares.
        /// 
        /// landing on a Wormhole or Blackhole square at the end of a player's move 
        /// results in the player moving to another square
        /// 
        /// 
        /// </summary>

        public const int NumberOfSquares = 56;
        public const int StartSquareNumber = 0;
        public const int FinishSquareNumber = NumberOfSquares - 1;

        private static readonly Square[] squares = new Square[NumberOfSquares];

        public static Square[] Squares
        {
            get
            {
                Debug.Assert(squares != null, "squares != null",
                   "The game board has not been instantiated");
                return squares;
            }
        }

        public static Square StartSquare
        {
            get
            {
                return squares[StartSquareNumber];
            }
        }


        /// <summary>
        ///  Eight Wormhole squares.
        ///  
        /// Each row represents a Wormhole square number, the square to jump forward to and the amount of fuel consumed in that jump.
        /// 
        /// For example {2, 22, 10} is a Wormhole on square 2, jumping to square 22 and using 10 units of fuel
        /// 
        /// </summary>
        private static int[,] wormHoles =
        {
            {2, 22, 10},
            {3, 9, 3},
            {5, 17, 6},
            {12, 24, 6},
            {16, 47, 15},
            {29, 38, 4},
            {40, 51, 5},
            {45, 54, 4}
        };

        /// <summary>
        ///  Eight Blackhole squares.
        ///  
        /// Each row represents a Blackhole square number, the square to jump back to and the amount of fuel consumed in that jump.
        /// 
        /// For example {10, 4, 6} is a Blackhole on square 10, jumping to square 4 and using 6 units of fuel
        /// 
        /// </summary>
        private static int[,] blackHoles =
        {
            

            {10, 4, 6},
            {26, 8, 18},
            {30, 19, 11},
            {35,11, 24},
            {36, 34, 2},
            {49, 13, 36},
            {52, 41, 11},
            {53, 42, 11}
        };


        /// <summary>
        /// Parameterless Constructor
        /// Initialises a board consisting of a mix of Ordinary Squares,
        ///     Wormhole Squares and Blackhole Squares.
        /// 
        /// Pre:  none
        /// Post: board is constructed
        /// </summary>
        public static void SetUpBoard()
        {
            Class1 prestn = null;
            var firstname = prestn?.Name ?? "und";
            Console.WriteLine(firstname);
            // Create the 'start' square where all players will start.
            squares[StartSquareNumber] = new Square("Start", StartSquareNumber);

            // Create blockholes.
            for (var i = 0; i < blackHoles.Length/3; i++)
            {
                var number = blackHoles[i, 0];
                var name = $"{number}";
                var next = blackHoles[i, 1];
                var fuel = blackHoles[i, 2];
                squares[number] = new BlackholeSquare(name, number, next, fuel);
            }
            // Create wormholes.
            for (var i = 0; i < wormHoles.Length/3; i++)
            {
                var number = wormHoles[i, 0];
                var name = $"{number}";
                var next = wormHoles[i, 1];
                var fuel = wormHoles[i, 2];
                squares[number] = new WormholeSquare(name, number, next, fuel);
            }
            // Create ordinary squares.
            for (var i = 1; i < FinishSquareNumber; i++)
            {
                var name = $"{i}";
                var number = i;
                if (squares[i] == null) squares[i] = new Square(name,number);
            }
            

            // Create the 'finish' square.
            squares[FinishSquareNumber] = new Square("Finish", FinishSquareNumber);
        } // end SetUpBoard

        /// <summary>
        /// Finds the destination square and the amount of fuel used for either a 
        /// Wormhole or Blackhole Square.
        /// 
        /// pre: squareNum is either a Wormhole or Blackhole square number
        /// post: destNum and amount are assigned correct values.
        /// </summary>
        /// <param name="holes">a 2D array representing either the Wormholes or Blackholes squares information</param>
        /// <param name="squareNum"> a square number of either a Wormhole or Blackhole square</param>
        /// <param name="destNum"> destination square's number</param>
        /// <param name="amount"> amont of fuel used to jump to the deestination square</param>
        private static void FindDestSquare(int[,] holes, int squareNum, out int destNum, out int amount)
        {
            destNum = 0; amount = 0;
            destNum = holes[squareNum, 1];
            amount = holes[squareNum, 2];
        } //end FindDestSquare

    }

    public class Class1
    {
        public string Name;
    }

//end class Board
}