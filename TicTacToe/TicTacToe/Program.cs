using System;

namespace TicTacToe
{
    class MainClass
    {

        static char[,] board =
        {
            {'1', '2', '3'},
            {'4', '5', '6'},
            {'7', '8', '9'}
        };

        static void ClearBoard()
        {
            board = new char[,]
             {
                 {'1', '2', '3'},
                 {'4', '5', '6'},
                 {'7', '8', '9'}
             };
            SetBoard();
            turns = 0;
        }

        static int turns = 0;

        static void SetBoard()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("  Welcome to TicTacToe!");
            Console.WriteLine("=========================");
            Console.WriteLine("\n");
            Console.WriteLine("  ----------------------");
            Console.WriteLine("  |      |      |      |");
            Console.WriteLine("  |  {0}   |  {1}   |  {2}   |", board[0, 0], board[0, 1], board[0, 2]);
            Console.WriteLine("  |      |      |      |");
            Console.WriteLine("  ----------------------");
            Console.WriteLine("  |      |      |      |");
            Console.WriteLine("  |  {0}   |  {1}   |  {2}   |", board[1, 0], board[1, 1], board[1, 2]);
            Console.WriteLine("  |      |      |      |");
            Console.WriteLine("  ----------------------");
            Console.WriteLine("  |      |      |      |");
            Console.WriteLine("  |  {0}   |  {1}   |  {2}   |", board[2, 0], board[2, 1], board[2, 2]);
            Console.WriteLine("  |      |      |      |");
            Console.WriteLine("  ----------------------");
            turns++;
        }

        public static void Game(int player, int input)
        {
            char token = ' ';
            if(player == 1)
            {
                token = 'O';
            }
            else if(player == 2)
            {
                token = 'X';
            }

                switch (input)
                {
                    case 1:
                        board[0, 0] = token;                    
                        break;  
                    case 2:
                        board[0, 1] = token;
                        break;
                    case 3:
                        board[0, 2] = token;
                        break;
                    case 4:
                        board[1, 0] = token;
                        break;
                    case 5:
                        board[1, 1] = token;
                        break;
                    case 6:
                        board[1, 2] = token;
                        break;
                    case 7:
                        board[2, 0] = token;
                        break;
                    case 8:
                        board[2, 1] = token;
                        break;
                    case 9:
                        board[2, 2] = token;
                        break;
                }
            

        }

        public static void Main(string[] args)
        {
            int player = 2;
            int input = 0;
            bool correctInput = true;

            SetBoard();

            do
            {
                if (player == 2)
                {
                    player = 1;
                    Game(player, input);
                }
                else if (player == 1)
                {
                    player = 2;
                    Game(player, input);

                }
                SetBoard();

                char[] tokens = { 'X', 'O' };

                foreach(char token in tokens)
                {
                    if(board[0,0] == token && board[0,1] == token && board[0,2] == token
                       ||board[1, 0] == token && board[1, 1] == token && board[1, 2] == token
                       ||board[2, 0] == token && board[2, 1] == token && board[2, 2] == token
                       ||board[0, 0] == token && board[1, 0] == token && board[2, 0] == token
                       ||board[0, 1] == token && board[1, 1] == token && board[2, 1] == token
                       ||board[2, 0] == token && board[2, 1] == token && board[2, 2] == token
                       ||board[0, 0] == token && board[1, 1] == token && board[2, 2] == token
                       ||board[0, 2] == token && board[1, 1] == token && board[2, 0] == token)
                    {
                        if(token == 'X')
                        {
                            Console.WriteLine("Congrats player 1, you win!");
                        }
                        else if(token == 'O')
                        {
                            Console.WriteLine("Congrats player 2, you win!");
                        }

                        Console.WriteLine("Press any key to restart");
                        Console.ReadKey();
                        ClearBoard();
                        break;
                    }
                    else if(turns == 9)
                    {
                        Console.WriteLine("It's a draw!");
                        Console.WriteLine("Press any key to restart");
                        Console.ReadKey();
                        ClearBoard();
                        break;
                    }
                }

                do
                {
                    Console.WriteLine("Player {0}, choose where to put your token", player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a number");
                    }

                    if((input == 1) && (board[0,0] == '1'))
                    {
                        correctInput = true;
                    }
                    else if((input == 2) && (board[0,1] == '2'))
                    {
                        correctInput = true;
                    }
                    else if((input == 3) && (board[0, 2] == '3'))
                    {
                        correctInput = true;
                    }
                    else if ((input == 4) && (board[1, 0] == '4'))
                    {
                        correctInput = true;
                    }
                    else if ((input == 5) && (board[1, 1] == '5'))
                    {
                        correctInput = true;
                    }
                    else if((input == 6) && (board[1, 2] == '6'))
                    {
                        correctInput = true;
                    }
                    else if ((input == 7) && (board[2, 0] == '7'))
                    {
                        correctInput = true;
                    }
                    else if ((input == 8) && (board[2, 1] == '8'))
                    {
                        correctInput = true;
                    }
                    else if ((input == 9) && (board[2, 2] == '9'))
                    {
                        correctInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Not a valid input, please type a correct input");
                        correctInput = false;
                    }
                }
                while (!correctInput);
            }
            while (true);

        }
    }
}
