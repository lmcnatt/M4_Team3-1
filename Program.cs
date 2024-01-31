// Tic-Tac-Toe Game
using Helper;

HelperTools ht = new HelperTools();

string[] gameBoard = new string[9];
bool gameOver = false;

Console.WriteLine("Welcome to Tic-Tac-Toe!");

Console.WriteLine("Here are the options for the gameboard:\n" +
                  "1 2 3\n" +
                  "4 5 6\n" +
                  "7 8 9");

do
{
    Console.WriteLine("Player 1, Please make your first move");

} while (!gameOver);

