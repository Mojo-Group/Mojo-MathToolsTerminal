using System;

public class TicTacToe
{
    private char[,] board = new char[3, 3];
    private char currentPlayer;

    public TicTacToe()
    {
        currentPlayer = 'X';
        InitializeBoard();
    }

    private void InitializeBoard()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                board[i, j] = ' ';
            }
        }
    }

    public void PlayGame()
    {
        int turns = 0;

        while (true)
        {
            Console.Clear();
            PrintBoard();
            Console.WriteLine($"Player {currentPlayer}, please enter your move (row, column) (0-2): ");
            string input = Console.ReadLine();
            string[] positions = input.Split(',');

            if (positions.Length != 2 ||
                !int.TryParse(positions[0], out int row) ||
                !int.TryParse(positions[1], out int col) ||
                row < 0 || row > 2 ||
                col < 0 || col > 2 ||
                board[row, col] != ' ')
            {
                Console.WriteLine("Invalid move. Please try again.");
                continue;
            }

            board[row, col] = currentPlayer;
            turns++;

            if (CheckWinner())
            {
                Console.Clear();
                PrintBoard();
                Console.WriteLine($"Player {currentPlayer} wins!");
                break;
            }

            if (turns == 9)
            {
                Console.Clear();
                PrintBoard();
                Console.WriteLine("It's a draw!");
                break;
            }

            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
        }
    }

    private void PrintBoard()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"{board[i, 0]} | {board[i, 1]} | {board[i, 2]}");
            if (i < 2) Console.WriteLine("---------");
        }
    }

    private bool CheckWinner()
    {
        // Check rows
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != ' ')
                return true;
        }

        // Check columns
        for (int i = 0; i < 3; i++)
        {
            if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != ' ')
                return true;
        }

        // Check diagonals
        if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != ' ')
            return true;
        if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != ' ')
            return true;

        return false;
    }
}
