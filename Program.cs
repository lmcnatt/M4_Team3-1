// Tic-Tac-Toe Game
using Helper;

HelperTools ht = new HelperTools();

string[] gameBoard = new string[9];
int player1Choice = 0;
int player2Choice = 0;
int winner = 0;
bool gameOver = false;

Console.WriteLine("Welcome to Tic-Tac-Toe!");

Console.WriteLine("Here are the options for the gameboard:\n" +
                  "1 2 3\n" +
                  "4 5 6\n" +
                  "7 8 9");

do
{
    Console.WriteLine("Player 1, Please make your move");
    player1Choice = int.Parse(Console.ReadLine()) - 1;
    gameBoard[player1Choice] = "X";
    ht.printBoard(gameBoard);

    Console.WriteLine("Player 2, Please make your move");
    player1Choice = int.Parse(Console.ReadLine()) - 1;
    gameBoard[player1Choice] = "O";
    ht.printBoard(gameBoard);

    winner = ht.getWinner(gameBoard);

    if (winner == 0) // No win yet
    {
        gameOver = false;
    }
    else if (winner == 1) // Player 1 won
    {
        gameOver = true;
        Console.WriteLine("Player 1 Wins!");
    }
    else if (winner == 2) // Player 2 won
    {
        gameOver = true;
        Console.WriteLine("Player 2 Wins!");
    }
    else if (winner == 3) // Tie
    {
        gameOver = true;
        Console.WriteLine("It's a Tie!");
    }
} while (!gameOver);

