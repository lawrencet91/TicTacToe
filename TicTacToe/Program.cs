using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        //Create 3x3 Array for the board
        static char[] board = { '0', '1', '2', '3', '4', '5', '6', '7', '8' };
        static bool playerTurn = true;
        static int playerChoice;
        static int result = 0;

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Player 1 = X \n");
                Console.WriteLine("Player 2 = O \n");
                if(!playerTurn)
                {
                    Console.WriteLine("Player 2 Turn");
                }
                else
                {
                    Console.WriteLine("Player 1 Turn");
                }
                GameBoard();
                playerChoice = int.Parse(Console.ReadLine());
                switch (playerChoice)
                {
                    case 0:
                        if(board[0]!='X'&&board[0]!='O')
                        {
                            if(!playerTurn)
                            {
                                board[0] = 'O';
                                playerTurn = true;
                            }
                            else
                            {
                                board[0] = 'X';
                                playerTurn = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error! {0} is filled with {1}",playerChoice,board[0]);                    
                        }
                        break;
                    case 1:
                        if (board[1] != 'X' && board[1] != 'O')
                        {
                            if (!playerTurn)
                            {
                                board[1] = 'O';
                                playerTurn = true;
                            }
                            else
                            {
                                board[1] = 'X';
                                playerTurn = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error! {0} is filled with {1}", playerChoice, board[1]);
                        }
                        break;
                    case 2:
                        if (board[2] != 'X' && board[2] != 'O')
                        {
                            if (!playerTurn)
                            {
                                board[2] = 'O';
                                playerTurn = true;
                            }
                            else
                            {
                                board[2] = 'X';
                                playerTurn = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error! {0} is filled with {1}", playerChoice, board[2]);
                        }
                        break;
                    case 3:
                        if (board[3] != 'X' && board[3] != 'O')
                        {
                            if (!playerTurn)
                            {
                                board[3] = 'O';
                                playerTurn = true;
                            }
                            else
                            {
                                board[3] = 'X';
                                playerTurn = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error! {0} is filled with {1}", playerChoice, board[3]);
                        }
                        break;
                    case 4:
                        if (board[4] != 'X' && board[4] != 'O')
                        {
                            if (!playerTurn)
                            {
                                board[4] = 'O';
                                playerTurn = true;
                            }
                            else
                            {
                                board[4] = 'X';
                                playerTurn = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error! {0} is filled with {1}", playerChoice, board[4]);
                        }

                        break;
                    case 5:
                        if (board[5] != 'X' && board[5] != 'O')
                        {
                            if (!playerTurn)
                            {
                                board[5] = 'O';
                                playerTurn = true;
                            }
                            else
                            {
                                board[5] = 'X';
                                playerTurn = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error! {0} is filled with {1}", playerChoice, board[5]);
                        }
                        break;
                    case 6:
                        if (board[6] != 'X' && board[6] != 'O')
                        {
                            if (!playerTurn)
                            {
                                board[6] = 'O';
                                playerTurn = true;
                            }
                            else
                            {
                                board[6] = 'X';
                                playerTurn = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error! {0} is filled with {1}", playerChoice, board[6]);
                        }
                        break;
                    case 7:
                        if (board[7] != 'X' && board[7] != 'O')
                        {
                            if (!playerTurn)
                            {
                                board[7] = 'O';
                                playerTurn = true;
                            }
                            else
                            {
                                board[7] = 'X';
                                playerTurn = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error! {0} is filled with {1}", playerChoice, board[7]);
                        }
                        break;
                    case 8:
                        if (board[8] != 'X' && board[8] != 'O')
                        {
                            if (!playerTurn)
                            {
                                board[8] = 'O';
                                playerTurn = true;
                            }
                            else
                            {
                                board[8] = 'X';
                                playerTurn = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error! {0} is filled with {1}", playerChoice, board[8]);
                        }
                        break;
                }
                result = CheckResult();
            } while (result != 1 && result != -1);
            {
                Console.Clear();
                GameBoard();
                if(result == 1)
                {
                    if(!playerTurn)
                    {
                        Console.WriteLine("Player 1 has won");
                    }else
                    {
                        Console.WriteLine("Player 2 has won");

                    }
                }
                else
                {
                    Console.WriteLine("Draw");
                }
            }
        }

        private static void GameBoard()
        {
            Console.WriteLine("{0}  | {1}  | {2}",board[0], board[1], board[2]);
            Console.WriteLine("___|___ |___");
            Console.WriteLine("{0}  | {1}  | {2}", board[3], board[4], board[5]);
            Console.WriteLine("___|___ |___");
            Console.WriteLine("{0}  | {1}  | {2}", board[6], board[7], board[8]);
        }

        private static int CheckResult()
        {
            if(board[0]==board[1]&&board[1]==board[2])
            {
                result = 1;
            }
            else if (board[3] == board[4] && board[4] == board[5])

            {
                result = 1;
            }
            else if (board[6] == board[7] && board[7] == board[8])

            {
                result = 1;
            }
            else if (board[0] == board[3] && board[3] == board[6])

            {
                result = 1;
            }
            else if (board[1] == board[4] && board[4] == board[7])

            {
                result = 1;
            }
            else if (board[2] == board[5] && board[5] == board[8])

            {
                result = 1;
            }
            else if (board[0] == board[4] && board[4] == board[8])

            {
                result = 1;
            }
            else if (board[2] == board[4] && board[4] == board[6])

            {
                result = 1;
            }
            else if (CheckDraw())
            {
                result = -1;
            }
            else
            {
                result = 0;
            }
            return result;
        }

        private static bool CheckDraw()
        {
            bool flag = true;
            foreach(char a in board)
            {
               if((a=='X')||(a=='O'))
                {
                    flag = true;
                }
               else
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
