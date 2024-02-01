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
            for (int i = 0; i < 8; i++)
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
        }

        public int getWinner(string[] board)
        {
            int winner = 0;
            bool checkTie = true;
            for (int i = 0; i < 9; i += 3) // checking rows
            {
                if (board[i] == board[i + 1] && board[i] == board[i + 2])
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
                if (board[i] == board[i + 3] && board[i] == board[i + 6])
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
            if (board[0] == board[4] && board[0] == board[8])
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

            if (board[2] == board[4] && board[2] == board[6])
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
            for (int i = 0; i < 8; i ++)
            {
                if (board[0] == null)
                {
                    checkTie = false;
                }
            }
            if (checkTie == true)
            {
                winner = 3;
            }
            return winner;
        }
    }

}

