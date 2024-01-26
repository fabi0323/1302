using System;

class Program
{
    static int boardSize = 8;
    static int[,] chessboard = new int[boardSize, boardSize];
    static int knightsPlaced = 0;

    static void Main()
    {
        Console.WriteLine("Welcome to the Knight Placement Game!");
        Console.WriteLine("Try to place as many knights as possible without one capturing another.");
        Console.WriteLine("Enter row and column to place a knight (e.g., 1 2):");

        while (true)
        {
            PlayGame();

            Console.Write("Do you want to play again? (y/n): ");
            string replayChoice = Console.ReadLine().ToLower();

            if (replayChoice != "y")
            {
                Console.WriteLine("Thanks for playing! Press Enter to exit.");
                break;
            }
            else
            {
                ResetGame();
            }
        }

        Console.ReadLine(); 
    }

    static void PlayGame()
    {
        while (true)
        {
            PrintBoard();
            string[] input = Console.ReadLine().Split();

            if (input.Length != 2 || !int.TryParse(input[0], out int row) || !int.TryParse(input[1], out int col) || row < 1 || row > boardSize || col < 1 || col > boardSize)
            {
                Console.WriteLine("Invalid input. Please enter a valid row and column within the board size.");
                continue;
            }

            if (chessboard[row - 1, col - 1] == 1)
            {
                Console.WriteLine("Invalid move! There is already a knight at this position. Please choose another position.");
                continue;
            }

            if (IsValidMove(row - 1, col - 1))
            {
                PlaceKnight(row - 1, col - 1);
                knightsPlaced++;

                if (knightsPlaced == 32 && !CheckAnyValidMove())
                {
                    Console.WriteLine($"Congratulations! You successfully placed 32 knights without any possible moves left. You won!");
                    PrintBoard();
                    break;
                }
            }
            else
            {
                Console.WriteLine($"Game Over! You placed a knight that can capture another knight. Knights placed: {knightsPlaced}");
                PrintBoardWithInvalidMove(row - 1, col - 1);
                break;
            }
        }
    }

    static void ResetGame()
    {
        Array.Clear(chessboard, 0, chessboard.Length);
        knightsPlaced = 0;
        Console.WriteLine("Game reset. Let's play again!");
    }

    static bool IsValidMove(int row, int col)
    {
        if (row >= 0 && row < boardSize && col >= 0 && col < boardSize && chessboard[row, col] == 0)
        {
            for (int i = -2; i <= 2; i++)
            {
                for (int j = -2; j <= 2; j++)
                {
                    if (Math.Abs(i) + Math.Abs(j) == 3 && row + i >= 0 && row + i < boardSize && col + j >= 0 && col + j < boardSize && chessboard[row + i, col + j] == 1)
                    {
                        return false; 
                    }
                }
            }

            return true; 
        }

        return false; 
    }

    static void PlaceKnight(int row, int col)
    {
        chessboard[row, col] = 1;
    }

    static void PrintBoard()
    {
        Console.WriteLine("Current Chessboard:");
        for (int i = 0; i < boardSize; i++)
        {
            for (int j = 0; j < boardSize; j++)
            {
                Console.Write(chessboard[i, j] == 1 ? "K " : ". ");
            }
            Console.WriteLine();
        }
    }

    static void PrintBoardWithInvalidMove(int row, int col)
    {
        Console.WriteLine("Current Chessboard (with X at invalid move):");
        for (int i = 0; i < boardSize; i++)
        {
            for (int j = 0; j < boardSize; j++)
            {
                if (i == row && j == col)
                {
                    Console.Write("X ");
                }
                else
                {
                    Console.Write(chessboard[i, j] == 1 ? "K " : ". ");
                }
            }
            Console.WriteLine();
        }
    }

    static bool CheckAnyValidMove()
    {
        for (int i = 0; i < boardSize; i++)
        {
            for (int j = 0; j < boardSize; j++)
            {
                if (IsValidMove(i, j))
                {
                    return true;
                }
            }
        }

        return false;
    }
}
