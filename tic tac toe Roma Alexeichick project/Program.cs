using System;
using System.Numerics;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] board = new char[3, 3];
            int movesPlayed = 0;
            InitializeBoard(board);
            char player = ' ';
            Console.WriteLine("Welcome to the game of tic tac toe");
            Console.WriteLine("please choose your charecter");
            Console.WriteLine("for 'X' type: 1");
            Console.WriteLine("for 'O' type: 2");

            while (true)
            {
                int.TryParse(Console.ReadLine(), out int choise);
                if (choise == 0)
                {
                    Console.WriteLine("you can choose only '1' or '2'");
                    continue;
                }
                else if (choise == 1)
                {
                    player = 'X';
                    break;
                }
                else if (choise == 2)
                {
                    player = 'O';
                    break;
                }
                else
                {
                    Console.WriteLine("you can choose only '1' or '2'");
                    continue;
                }

            }
            


            while (true)
            {
                Console.Clear();
                Console.WriteLine($"it player '{player}' turn");
                PrintBoard(board);
                Console.WriteLine($"please enter '{player}' row num");
                int row=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"please enter '{player}' cul num");
                int cul= Convert.ToInt32(Console.ReadLine());
                if (board[row,cul]!=' ')
                {
                    Console.WriteLine("please choose empty space only");
                    Console.WriteLine($"please enter '{player}' row num");
                    row = Convert.ToInt32(Console.ReadLine());    
                    Console.WriteLine($"please enter '{player}' cul num");
                    cul = Convert.ToInt32(Console.ReadLine());    
                }
                board[row,cul] = player;
                player = (player == 'X') ?  'O' :  'X';
                if (player == board[0, 0] && player == board[0, 1] && player == board[0, 2] ||
                player == board[1, 0] && player == board[1, 1] && player == board[1, 2] ||
                player == board[2, 0] && player == board[2, 1] && player == board[2, 2] ||
                player == board[0, 0] && player == board[1, 0] && player == board[2, 0] ||
                player == board[0, 1] && player == board[1, 1] && player == board[2, 1] ||
                player == board[0, 2] && player == board[1, 2] && player == board[2, 2] ||
                player == board[0, 0] && player == board[1, 1] && player == board[2, 2] ||
                player == board[2, 0] && player == board[1, 1] && player == board[0, 2]
                   )
                {
                    Console.Clear();
                    PrintBoard(board);
                    Console.WriteLine(player + " has won the game");
                    Console.ReadKey();
                    break;

                }
                
                movesPlayed++;
                if (movesPlayed == 9) 
                {
                    Console.WriteLine("it a draw");
                    break;
                }


            }

        }


        


        

        static void PrintBoard(char[,] board)
        {
            Console.WriteLine("");
            Console.WriteLine("    (0) (1) (2)");

            for (int row = 0; row < 3; row++)
            {
                Console.Write($"({row})| ");
                
                for (int col = 0; col < 3; col++)
                {

                    Console.Write(board[row, col]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
        }

        static void InitializeBoard(char[,] grid)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    grid[row, col] = ' ';
                }
            }
        }


    }
}