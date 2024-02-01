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
        player1Choice = int.Parse(Console.ReadLine()) - 1;

    } while (!validMoveP1(player1Choice, gameBoard));

    gameBoard[player1Choice] = "X";
    ht.printBoard(gameBoard);

    do
    {
        Console.WriteLine("Player 2, Please make your move");
        player2Choice = int.Parse(Console.ReadLine()) - 1;

    } while (!validMoveP2(player2Choice, gameBoard));

    gameBoard[player2Choice] = "O";
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

bool validMoveP1(int player1Choice, string[] gameBoard)
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

bool validMoveP2(int player2Choice, string[] gameBoard)
{
    bool result = true; // Default to a valid guess
    for (int i = 0; i < gameBoard.Length; i++)
    {
        if (gameBoard[i] == null)
        {
            Console.WriteLine(i + " is null");
        }
        else
        {
            Console.WriteLine(gameBoard[i]);
        }
        
    }

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