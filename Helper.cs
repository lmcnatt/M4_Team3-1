using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    
    internal class HelperTools
    {
        public void printBoard(string[] guesses) //this prints
        {
            for (int i = 0; i < guesses.Length; i++)
            {
                if (guesses[i] == null)
                {
                    guesses[i] = " ";
                }
            }
            string finalOutput = " " + guesses[0] + " | " + guesses[1] + " | " + guesses[2] + " " + "\n";
            finalOutput = finalOutput + "---+---+---" + "\n";
            finalOutput = finalOutput + " " + guesses[3] + " | " + guesses[4] + " | " + guesses[5] + " " + "\n";
            finalOutput = finalOutput + "---+---+---" + "\n";
            finalOutput = finalOutput + " " + guesses[6] + " | " + guesses[7] + " | " + guesses[8] + " ";
            Console.WriteLine(finalOutput);
            for (int i = 0; i < guesses.Length; i++)
            {
                if (guesses[i] == " ")
                {
                    guesses[i] = null;
                }
            }
        }

        public int getWinner(string[] board)
        {
            int winner = 0;
            bool checkTie = true;
            for (int i = 0; i < board.Length; i += 3) // checking rows
            {
                if (board[i] == board[i + 1] && board[i] == board[i + 2] && board[i] != null)
                {
                    if (board[i] == "X")
                    {
                        winner = 1;
                    }
                    else
                    {
                        winner = 2;
                    }
                }
            }

            // Check columns
            for (int i = 0; i < 3; i++)
            {
                if (board[i] == board[i + 3] && board[i] == board[i + 6] && board[i] != null)
                {
                    if (board[i] == "X")
                    {
                        winner = 1;
                    }
                    else
                    {
                        winner = 2;
                    } 
                }
            }

            // Check diagonals
            if (board[0] == board[4] && board[0] == board[8] && board[0] != null)
            {
                if (board[0] == "X")
                {
                    winner = 1;
                }
                else
                {
                    winner = 2;
                }  
            }

            if (board[2] == board[4] && board[2] == board[6] && board[2] != null)
            {
                if (board[2] == "X")
                {
                    winner = 1;
                }
                else
                {
                    winner = 2;
                }  
            }
            for (int i = 0; i < board.Length; i ++)
            {
                if (board[i] == null)
                {
                    checkTie = false;
                }
            }
            if (checkTie == true && winner == 0)
            {
                winner = 3;
            }
            return winner;
        }

        public bool validMoveP1(int player1Choice, string[] gameBoard)
        {
            bool result = true; // Default to a valid guess

            if (!int.TryParse(player1Choice.ToString(), out _)) // Check to make sure it is a number
            {
                Console.WriteLine("Sorry, you have to type a number");
                result = false;
            }
            else if (player1Choice < 0 || player1Choice >= gameBoard.Length)
            {
                Console.WriteLine("Invalid choice. Please choose a number between 1 and 9");
                result = false;
            }
            else if (gameBoard[player1Choice] != null) // Check to see if the space is taken
            {
                Console.WriteLine("Sorry, someone has already gone there.");
                result = false;
            }

            return result;
        }

        public bool validMoveP2(int player2Choice, string[] gameBoard)
        {
            bool result = true; // Default to a valid guess

            if (!int.TryParse(player2Choice.ToString(), out _)) // Check to make sure it is a number
            {
                Console.WriteLine("Sorry, you have to type a number");
                result = false;
            }
            else if (player2Choice < 0 || player2Choice >= gameBoard.Length)
            {
                Console.WriteLine("Invalid choice. Please choose a number between 1 and 9");
                result = false;
            }
            else if (gameBoard[player2Choice] != null) // Check to see if the space is taken
            {
                Console.WriteLine("Sorry, someone has already gone there.");
                result = false;
            }

            return result;
        }
    }

}

