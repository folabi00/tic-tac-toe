using System;

namespace TicTacToeGame
{
    class Program
    {
        static char[,] PlayField = 
        {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' }

        };

        static int turns = 0;

        static void Main(string[] args)
        {
            int player = 2;
            int input = 0;
            bool inputCorrect = true;


            do 
            {

                if (player == 2)
                {
                    player = 1;
                    EnterXorO(player, input);
                }

                else if (player == 1)
                {
                    player = 2;
                    EnterXorO(player, input);
                }



                SetField();
                #region

                char[] playerChars =  { 'X', 'O' };
                foreach (char playerch in playerChars) 
                { 
                    if (((PlayField[0,0] == playerch) && (PlayField[0, 1] == playerch) && (PlayField[0, 2] == playerch))
                        || ((PlayField[1, 0] == playerch) && (PlayField[1, 1] == playerch) && (PlayField[1, 2] == playerch))
                        || ((PlayField[2, 0] == playerch) && (PlayField[2, 1] == playerch) && (PlayField[2, 2] == playerch))
                        || ((PlayField[0, 0] == playerch) && (PlayField[1, 0] == playerch) && (PlayField[2, 0] == playerch))
                        || ((PlayField[0, 1] == playerch) && (PlayField[1, 1] == playerch) && (PlayField[2, 1] == playerch))
                        || ((PlayField[0, 2] == playerch) && (PlayField[1, 2] == playerch) && (PlayField[2, 2] == playerch))
                        || ((PlayField[0, 0] == playerch) && (PlayField[1, 1] == playerch) && (PlayField[2, 2] == playerch))
                        || ((PlayField[0, 2] == playerch) && (PlayField[1, 1] == playerch) && (PlayField[2, 0] == playerch))
                          
                        )
                    {
                        if(playerch == 'X')
                        {
                            Console.WriteLine("\nplayer 1 has won");
                        }
                        else
                        {
                            Console.WriteLine("\nplayer 2 has won");
                        }
                        Console.WriteLine("press any key to reset game");
                        Console.Read();
                        ReSetField();
                        break;
                        
                        
                    }
                    else if (turns == 10)
                    {
                        Console.WriteLine("\nWE HAVE A DRAW");
                        Console.WriteLine("press any key to reset game");
                        Console.Read();
                        ReSetField();
                        break;

                    }
                    
                } 

                #endregion

                #region

                do
                { 
                    Console.Write("\nPlayer {0} : Choose your Field" , player);
                    try 
                    { 
                        input = Convert.ToInt32(Console.ReadLine()); 
                    } 
                    catch 
                    { 
                        Console.WriteLine("choose a number"); 
                    }

                    if ((input == 1) && (PlayField[0, 0] == '1'))
                        inputCorrect = true;
                    else if ((input == 2) && (PlayField[0, 1] == '2'))
                        inputCorrect = true;
                    else if ((input == 3) && (PlayField[0, 2] == '3'))
                        inputCorrect = true;
                    else if ((input == 4) && (PlayField[1, 0] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (PlayField[1, 1] == '5'))
                        inputCorrect = true;
                    else if ((input == 6) && (PlayField[1, 2] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (PlayField[2, 0] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (PlayField[2, 1] == '8'))
                        inputCorrect = true;
                    else if ((input == 9) && (PlayField[2, 2] == '9'))
                        inputCorrect = true;
                    else
                    {
                        inputCorrect = false;
                        Console.WriteLine("\n Wrong input, Please select another field");
                    }
                } while (!inputCorrect);

                #endregion


            } while (true);
        }


        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", PlayField[0,0], PlayField[0, 1], PlayField[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", PlayField[1, 0], PlayField[1, 1], PlayField[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", PlayField[2, 0], PlayField[2, 1], PlayField[2, 2]);
            Console.WriteLine("     |     |     ");
            turns++;
        }
        public static void ReSetField()
        {
            char[,] PlayFieldReset =
            {
                    {'1','2','3' },
                    {'4','5','6' },
                    {'7','8','9' }

            };

            PlayField = PlayFieldReset;
            SetField();
            turns = 0;
        }

        public static void EnterXorO(int player, int input)
        {
            char PlayerSign = ' ';

            if (player == 1)
                PlayerSign = 'X';
            else if (player == 2)
                PlayerSign = 'O';

            switch (input)
            {
                case 1: PlayField[0, 0] = PlayerSign; break;
                case 2: PlayField[0, 1] = PlayerSign; break;
                case 3: PlayField[0, 2] = PlayerSign; break;
                case 4: PlayField[1, 0] = PlayerSign; break;
                case 5: PlayField[1, 1] = PlayerSign; break;
                case 6: PlayField[1, 2] = PlayerSign; break;
                case 7: PlayField[2, 0] = PlayerSign; break;
                case 8: PlayField[2, 1] = PlayerSign; break;
                case 9: PlayField[2, 2] = PlayerSign; break;

            }
        }
    }
}
