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
    // Validate the guess
    do
    {
        Console.WriteLine("Player 1, Please make your move");
        if (int.TryParse(Console.ReadLine(), out player1Choice))
        {
            player1Choice = player1Choice - 1;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }

    } while (!ht.validMoveP1(player1Choice, gameBoard));

    gameBoard[player1Choice] = "X";
    ht.printBoard(gameBoard);
    winner = ht.getWinner(gameBoard);


    if (winner == 0)
    {
            do
        {
            Console.WriteLine("Player 2, Please make your move");
            if (int.TryParse(Console.ReadLine(), out player2Choice))
            {
                player2Choice = player2Choice - 1;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

        } while (!ht.validMoveP2(player2Choice, gameBoard));

        gameBoard[player2Choice] = "O";
        ht.printBoard(gameBoard);
    }

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

