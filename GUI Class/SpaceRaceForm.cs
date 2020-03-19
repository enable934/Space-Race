using System;
using System.Drawing;
using System.Windows.Forms;
using Game_Logic_Class;
using Object_Classes;

namespace GUI_Class
{
    public partial class SpaceRaceForm : Form
    {
        // The numbers of rows and columns on the screen.
        const int NUM_OF_ROWS = 7;
        const int NUM_OF_COLUMNS = 8;

        // When we update what's on the screen, we show the movement of a player 
        // by removing them from their old square and adding them to their new square.
        // This enum makes it clear that we need to do both.
        enum TypeOfGuiUpdate { AddPlayer, RemovePlayer };


        public SpaceRaceForm()
        {
            InitializeComponent();

            Board.SetUpBoard();
            ResizeGUIGameBoard();
            SetUpGUIGameBoard();
            SetupPlayersDataGridView();
            DetermineNumberOfPlayers();
            SpaceRaceGame.SetUpPlayers();
            PrepareToPlay();
        }






        /// <summary>
        /// Resizes the entire form, so that the individual squares have their correct size, 
        /// as specified by SquareControl.SQUARE_SIZE.  
        /// This method allows us to set the entire form's size to approximately correct value 
        /// when using Visual Studio's Designer, rather than having to get its size correct to the last pixel.
        /// Pre:  none.
        /// Post: the board has the correct size.
        /// </summary>
        private void ResizeGUIGameBoard()
        {
            const int SQUARE_SIZE = SquareControl.SQUARE_SIZE;
            var currentHeight = tlpBoard.Size.Height;
            var currentWidth = tlpBoard.Size.Width;
            var desiredHeight = SQUARE_SIZE * NUM_OF_ROWS;
            var desiredWidth = SQUARE_SIZE * NUM_OF_COLUMNS;
            var increaseInHeight = desiredHeight - currentHeight;
            var increaseInWidth = desiredWidth - currentWidth;
            this.Size += new Size(increaseInWidth, increaseInHeight);
            tlpBoard.Size = new Size(desiredWidth, desiredHeight);

        }// ResizeGUIGameBoard


        /// <summary>
        /// Creates a SquareControl for each square and adds it to the appropriate square of the tableLayoutPanel.
        /// Pre:  none.
        /// Post: the tableLayoutPanel contains all the SquareControl objects for displaying the board.
        /// </summary>
        private void SetUpGUIGameBoard()
        {
            for (var squareNum = Board.StartSquareNumber; squareNum <= Board.FinishSquareNumber; squareNum++)
            {
                var square = Board.Squares[squareNum];
                var squareControl = new SquareControl(square, SpaceRaceGame.Players);
                AddControlToTableLayoutPanel(squareControl, squareNum);
            }//endfor

        }// end SetupGameBoard

        private void AddControlToTableLayoutPanel(Control control, int squareNum)
        {
            var screenRow = 0;
            var screenCol = 0;
            MapSquareNumToScreenRowAndColumn(squareNum, out screenRow, out screenCol);
            tlpBoard.Controls.Add(control, screenCol, screenRow);
        }// end Add Control


        /// <summary>
        /// For a given square number, tells you the corresponding row and column number
        /// on the TableLayoutPanel.
        /// Pre:  none.
        /// Post: returns the row and column numbers, via "out" parameters.
        /// </summary>
        /// <param name="squareNumber">The input square number.</param>
        /// <param name="rowNumber">The output row number.</param>
        /// <param name="columnNumber">The output column number.</param>
        private static void MapSquareNumToScreenRowAndColumn(int squareNum, out int screenRow, out int screenCol)
        {
            // Code needs to be added here to do the mapping
            var col = squareNum % NUM_OF_COLUMNS;
            double flooring = squareNum / NUM_OF_COLUMNS;
            var row = Convert.ToInt32(Math.Floor(flooring));
            if (row % 2 == 1) screenCol = NUM_OF_ROWS - col;
            else screenCol = col;
            screenRow = NUM_OF_ROWS - 1 - row;


        }//end MapSquareNumToScreenRowAndColumn


        private void SetupPlayersDataGridView()
        {
            // Stop the playersDataGridView from using all Player columns.
            dgvPlayers.AutoGenerateColumns = false;
            // Tell the playersDataGridView what its real source of data is.
            dgvPlayers.DataSource = SpaceRaceGame.Players;

        }// end SetUpPlayersDataGridView


        /// <summary>
        /// Obtains the current "selected item" from the ComboBox
        ///  and
        ///  sets the NumberOfPlayers in the SpaceRaceGame class.
        ///  Pre: none
        ///  Post: NumberOfPlayers in SpaceRaceGame class has been updated
        /// </summary>
        private void DetermineNumberOfPlayers()
        {
            // Store the SelectedItem property of the ComboBox in a string
            var selected = (string)cbNumberOfPlayers.SelectedItem;
            // Parse string to a number
            var numberOfPlayers = Int32.Parse(selected);

            // Set the NumberOfPlayers in the SpaceRaceGame class to that number
            SpaceRaceGame.NumberOfPlayers = numberOfPlayers;

        }//end DetermineNumberOfPlayers

        /// <summary>
        /// The players' tokens are placed on the Start square
        /// </summary>
        private void PrepareToPlay()
        {
            // More code will be needed here to deal with restarting 
            // a game after the Reset button has been clicked. 
            //
            // Leave this method with the single statement 
            // until you can play a game through to the finish square
            // and you want to implement the Reset button event handler.
            //

            UpdatePlayersGuiLocations(TypeOfGuiUpdate.AddPlayer);

        }//end PrepareToPlay()


        /// <summary>
        /// Tells you which SquareControl object is associated with a given square number.
        /// Pre:  a valid squareNumber is specified; and
        ///       the tableLayoutPanel is properly constructed.
        /// Post: the SquareControl object associated with the square number is returned.
        /// </summary>
        /// <param name="squareNumber">The square number.</param>
        /// <returns>Returns the SquareControl object associated with the square number.</returns>
        private SquareControl SquareControlAt(int squareNum)
        {
            var screenRow = 0;
            var screenCol = 0;

            // Uncomment the following lines once you've added the tableLayoutPanel to your form. 
            //     and delete the "return null;" 
            //
            MapSquareNumToScreenRowAndColumn(squareNum, out screenRow, out screenCol);
            return (SquareControl)tlpBoard.GetControlFromPosition(screenCol, screenRow);
        }


        /// <summary>
        /// Tells you the current square number of a given player.
        /// Pre:  a valid playerNumber is specified.
        /// Post: the square number of the player is returned.
        /// </summary>
        /// <param name="playerNumber">The player number.</param>
        /// <returns>Returns the square number of the player.</returns>
        private int GetSquareNumberOfPlayer(int playerNumber)
        {
            return SpaceRaceGame.Players[playerNumber].Position;
        }//end GetSquareNumberOfPlayer


        /// <summary>
        /// When the SquareControl objects are updated (when players move to a new square),
        /// the board's TableLayoutPanel is not updated immediately.  
        /// Each time that players move, this method must be called so that the board's TableLayoutPanel 
        /// is told to refresh what it is displaying.
        /// Pre:  none.
        /// Post: the board's TableLayoutPanel shows the latest information 
        ///       from the collection of SquareControl objects in the TableLayoutPanel.
        /// </summary>
        private void RefreshBoardTablePanelLayout()
        {
            tlpBoard.Invalidate(true);
        }

        /// <summary>
        /// When the Player objects are updated (location, etc),
        /// the players DataGridView is not updated immediately.  
        /// Each time that those player objects are updated, this method must be called 
        /// so that the players DataGridView is told to refresh what it is displaying.
        /// Pre:  none.
        /// Post: the players DataGridView shows the latest information 
        ///       from the collection of Player objects in the SpaceRaceGame.
        /// </summary>
        private void UpdatesPlayersDataGridView()
        {
            SpaceRaceGame.Players.ResetBindings();
        }

        /// <summary>
        /// At several places in the program's code, it is necessary to update the GUI board,
        /// so that player's tokens are removed from their old squares
        /// or added to their new squares. E.g. at the end of a round of play or 
        /// when the Reset button has been clicked.
        /// 
        /// Moving all players from their old to their new squares requires this method to be called twice: 
        /// once with the parameter typeOfGuiUpdate set to RemovePlayer, and once with it set to AddPlayer.
        /// In between those two calls, the players locations must be changed. 
        /// Otherwise, you won't see any change on the screen.
        /// 
        /// Pre:  the Players objects in the SpaceRaceGame have each players' current locations
        /// Post: the GUI board is updated to match 
        /// </summary>
        private void UpdatePlayersGuiLocations(TypeOfGuiUpdate typeOfGuiUpdate)
        {
            if (typeOfGuiUpdate == TypeOfGuiUpdate.AddPlayer)
            {
                for (var i = 0; i < SpaceRaceGame.NumberOfPlayers; i++)
                {
                    var control = SquareControlAt(GetSquareNumberOfPlayer(i));
                    control.ContainsPlayers[i] = true;
                }
            }
            else
            {
                for (var i = 0; i < SpaceRaceGame.Players.Count; i++)
                {
                    var control = SquareControlAt(GetSquareNumberOfPlayer(i));
                    control.ContainsPlayers[i] = false;
                }
            }
            RefreshBoardTablePanelLayout();//must be the last line in this method. Do not put inside above loop.
        } //end UpdatePlayersGuiLocations
        private void UpdatePlayerGuiLocations(TypeOfGuiUpdate typeOfGuiUpdate, int numberOfTurn)
        {
            if (typeOfGuiUpdate == TypeOfGuiUpdate.AddPlayer)
            {
                var control = SquareControlAt(GetSquareNumberOfPlayer(numberOfTurn));
                control.ContainsPlayers[numberOfTurn] = true;
            }
            else
            {
                var control = SquareControlAt(GetSquareNumberOfPlayer(numberOfTurn));
                control.ContainsPlayers[numberOfTurn] = false;
            }
            RefreshBoardTablePanelLayout();//must be the last line in this method. Do not put inside above loop.
        } //end UpdatePlayersGuiLocations

        /// <summary>
        /// Handle the Exit button being clicked.
        /// Pre:  the Exit button is clicked.
        /// Post: the game is terminated immediately
        /// </summary>
        private void btExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        static bool singleMode = false;
        static int numberOfTurn = 0;
        private void btGameRoll_Click(object sender, EventArgs e)
        {
            cbNumberOfPlayers.Enabled = false;
            if (!singleMode)
            {
                UpdatePlayersGuiLocations(TypeOfGuiUpdate.RemovePlayer);
                SpaceRaceGame.PlayOneRound();
                UpdatePlayersGuiLocations(TypeOfGuiUpdate.AddPlayer);
                UpdatesPlayersDataGridView();
                btGameReset.Enabled = true;
                dgvPlayers.Enabled = false;
                cbNumberOfPlayers.Enabled = false;
            }
            else
            {
                dgvPlayers.Enabled = false;
                btExit.Enabled = false;
                btGameReset.Enabled = false;
                UpdatePlayerGuiLocations(TypeOfGuiUpdate.RemovePlayer, numberOfTurn);
                SpaceRaceGame.PlaySingle(numberOfTurn);
                UpdatePlayerGuiLocations(TypeOfGuiUpdate.AddPlayer, numberOfTurn);
                UpdatesPlayersDataGridView();
                numberOfTurn++;
                if (numberOfTurn == SpaceRaceGame.NumberOfPlayers)
                {
                    btGameReset.Enabled = true;
                    dgvPlayers.Enabled = true;
                    btExit.Enabled = true;
                    numberOfTurn = 0;
                }

            }
            if (!SpaceRaceGame.IsGameActive()||SpaceRaceGame.LosedGame())
            {
                FinishGame();
            }
        }
        private void FinishGame()
        {
            dgvPlayers.Enabled = true;
            var winners = "";
            for (var i = 0; i < SpaceRaceGame.Players.Count; i++)
            {
                if (SpaceRaceGame.Players[i].AtFinish) winners += SpaceRaceGame.Players[i].Name + "\n";
            }
            MessageBox.Show("The following player(s) finished the game" +
                $"\n{winners}");
            btGameRoll.Enabled = false;
            btExit.Enabled = true;
            btGameReset.Enabled = true;
        }
        private void rbtStepYes_Click(object sender, EventArgs e)
        {
            gbSingleStep.Enabled = false;
            singleMode = true;
            btGameRoll.Enabled = true;
            cbNumberOfPlayers.Enabled = true;
        }

        private void rbtStepNo_Click(object sender, EventArgs e)
        {
            gbSingleStep.Enabled = false;
            singleMode = false;
            btGameRoll.Enabled = true;
            cbNumberOfPlayers.Enabled = true;
        }
        private void cbNumberOfPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetermineNumberOfPlayers();
            UpdatePlayersGuiLocations(TypeOfGuiUpdate.RemovePlayer);
            PrepareToPlay();
            cbNumberOfPlayers.Enabled = false;
            btGameReset.Enabled = false;
        }

        private void btGameReset_Click(object sender, EventArgs e)
        {
            rbtStepYes.Checked = false;
            rbtStepNo.Checked = false;
            cbNumberOfPlayers.Text = SpaceRaceGame.MAX_PLAYERS.ToString();
            cbNumberOfPlayers.Enabled = true;
            UpdatePlayersGuiLocations(TypeOfGuiUpdate.RemovePlayer);
            DetermineNumberOfPlayers();
            SpaceRaceGame.SetUpPlayers();
            dgvPlayers.Enabled = true;
            btExit.Enabled = true;
            btGameReset.Enabled = true;
            btGameRoll.Enabled = false;
            gbSingleStep.Enabled = true;
            PrepareToPlay();
        }
    }// end class
}
