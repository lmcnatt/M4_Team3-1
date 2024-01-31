// Tic-Tac-Toe Game
using Helper;

HelperTools ht = new HelperTools();

string[] gameBoard = new string[9];
int player1Choice = 0;
int player2Choice = 0;
string player = "";
int winner = 0;
bool gameOver = false;

Console.WriteLine("Welcome to Tic-Tac-Toe!");

Console.WriteLine("Here are the options for the gameboard:\n" +
                  "1 2 3\n" +
                  "4 5 6\n" +
                  "7 8 9");

// do
// {
player = "p1";
Console.WriteLine("Player 1, Please make your first move");
player1Choice = int.Parse(Console.ReadLine()) - 1;
ht.printBoard(gameBoard, player);

player = "p2";
Console.WriteLine("Player 2, Please make your first move");
player1Choice = int.Parse(Console.ReadLine()) - 1;
ht.printBoard(gameBoard, player);

winner = ht.getWinner(gameBoard);

if (winner == 0) // No win yet
{
    gameOver = false;
}
else if (winner == 1) // Player 1 won
{
    gameOver = true;
}
else if (winner == 2) // Player 2 won
{
    gameOver = true;
}
else if (winner == 3) // Tie
{
    gameOver = true;
}
// } while (!gameOver);

