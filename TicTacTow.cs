using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Name: Abdullah Alsheikh
* Student ID# 009571287
* Assignmet#1 CECS 475 TicTacToe  
*/
namespace Assignment_1_CECS475
{
   

    class TicTacToe
    {//Start of the class
        //Constant Variable for the Board Size (3X3)
        private const int BOARDSIZE = 3;
        //The Board Array for the board display
        private static int[,] board;


        public void Play()
        {
            
            board = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };//Intsilizing board 
            
            bool rungame = true;
           
            int numberofturns = 0;//count the number of un-blanks

            while (rungame)
            {
                
                PlayerChoose("Player1");
                PrintBoard();
                numberofturns++;// increment the number of un-blanks 
               if(numberofturns >= 9)
                {
                   
                   endgame("Tie");
                }
                PlayerChoose("Player2");
                PrintBoard();
                numberofturns++;
                if (numberofturns >= 9)
                {
                   
                   endgame("Tie");
                }
             }//end of While

        }//end of method

        public  void WinnerCheck(int x, int y, int playerNumber)
        {
            switch (x)//Checking the Row
            {
                case 0://Checking Row = 0
                    switch (y)//Checking Colume
                    {
                        case 0://Checking Row = 0 and Colum = 0 
                            if (board[x, y] == playerNumber && board[x, y + 1] == playerNumber && board[x, y + 2] == playerNumber)
                            { 
                                endgame("Player" + playerNumber);
                            }
                            else if (board[x, y] == playerNumber && board[x + 1, y] == playerNumber && board[x + 2, y] == playerNumber)
                            {
                                endgame("Player" + playerNumber);
                            }
                            else if (board[x, y] == playerNumber && board[x + 1, y + 1] == playerNumber && board[x + 2, y + 2] == playerNumber)
                            {
                                endgame("Player" + playerNumber);
                            }
                            break;
                        case 1://Checking Row = 0 and Colum =1
                            if (board[x, y] == playerNumber && board[x, y - 1] == playerNumber && board[x, y + 1] == playerNumber)
                            {
                                endgame("Player" + playerNumber);
                            }
                            else if (board[x, y] == playerNumber && board[x + 1, y] == playerNumber && board[x + 2, y] == playerNumber)
                            {
                                endgame("Player" + playerNumber);
                            }
                            break;
                        case 2://Checking Row = 0 and Colum = 2
                            if (board[x, y] == playerNumber && board[x, y - 1] == playerNumber && board[x, y - 2] == playerNumber)
                            {
                                endgame("Player" + playerNumber);
                            }
                            else if (board[x, y] == playerNumber && board[x + 1, y] == playerNumber && board[x + 2, y] == playerNumber)
                            {
                                endgame("Player" + playerNumber);
                            }
                            else if (board[x, y] == playerNumber && board[x + 1, y - 1] == playerNumber && board[x + 2, y - 2] == playerNumber)
                            {
                                endgame("Player" + playerNumber);
                            }
                            break;
                    }
                    break;
                case 1://Checking  Row =1
                    switch (y)
                    {
                        case 0://Checking Row = 1 and Colum = 0
                            if (board[x, y] == playerNumber && board[x + 1, y] == playerNumber && board[x - 1, y] == playerNumber)
                            {
                                endgame("Player" + playerNumber);
                            }
                            else if (board[x, y] == playerNumber && board[x, y + 1] == playerNumber && board[x, y + 2] == playerNumber)
                            {
                                endgame("Player" + playerNumber);
                            }
                            break;
                        case 1://Checking Row = 1 and Colum = 1
                            if (board[x, y] == playerNumber && board[x - 1, y - 1] == playerNumber && board[x + 1, y + 1] == playerNumber)
                            {
                                endgame("Player" + playerNumber);
                            }
                            else if (board[x, y] == playerNumber && board[x - 1, y] == playerNumber && board[x + 1, y] == playerNumber)
                            {
                                endgame("Player" + playerNumber);
                            }
                            else if (board[x, y] == playerNumber && board[x - 1, y + 1] == playerNumber && board[x + 1, y - 1] == playerNumber)
                            {
                                endgame("Player" + playerNumber);
                            }
                            else if (board[x, y] == playerNumber && board[x, y + 1] == playerNumber && board[x, y - 1] == playerNumber)
                            {
                                endgame("Player" + playerNumber);
                            }
                            break;
                        case 2:// Checking Row =1 and Colum = 2
                            if (board[x, y] == playerNumber && board[x + 1, y] == playerNumber && board[x - 1, y] == playerNumber)
                            {
                                endgame("Player" + playerNumber);
                            }
                            else if (board[x, y] == playerNumber && board[x, y - 1] == playerNumber && board[x, y - 2] == playerNumber)
                            {
                                endgame("Player" + playerNumber);
                            }
                            break;
                    }
                    break;
                case 2://Checking Row = 2
                    switch (y)
                    {
                        case 0://Checking Row = 2 and Colum = 0 
                            if (board[x, y] == playerNumber && board[x - 1, y] == playerNumber && board[x - 2, y] == playerNumber)
                            {
                                endgame("Player" + playerNumber);
                            }
                            else if (board[x, y] == playerNumber && board[x - 1, y + 1] == playerNumber && board[x - 2, y + 2] == playerNumber)
                            {
                                endgame("Player" + playerNumber);
                            }
                            else if (board[x, y] == playerNumber && board[x, y + 1] == playerNumber && board[x, y + 2] == playerNumber)
                            {
                                endgame("Player" + playerNumber);
                            }
                            break;
                        case 1://Checking Row = 2 and Colum = 1
                            if (board[x, y] == playerNumber && board[x, y - 1] == playerNumber && board[x, y + 1] == playerNumber)
                            {
                                endgame("Player" + playerNumber);
                            }
                            else if (board[x, y] == playerNumber && board[x - 1, y] == playerNumber && board[x - 2, y] == playerNumber)
                            {
                                endgame("Player" + playerNumber);
                            }
                            break;
                        case 2://Checking Row = 2 and Colum = 2
                            if (board[x, y] == playerNumber && board[x - 1, y] == playerNumber && board[x - 2, y] == playerNumber)
                            {
                                endgame("Player" + playerNumber);
                            }
                            else if (board[x, y] == playerNumber && board[x - 1, y - 1] == playerNumber && board[x - 2, y - 2] == playerNumber)
                            {
                                endgame("Player" + playerNumber);
                            }
                            else if (board[x, y] == playerNumber && board[x, y - 1] == playerNumber && board[x, y - 2] == playerNumber)
                            {
                                endgame("Player" + playerNumber);
                            }
                            break;
                    }
                    break;
                default://Defaul incase of incorrect varable passed
                    Console.WriteLine("Error");
                    break;
            }
        }
        
        public  void InsertValue(int x, int y, int playernumber)
        {
            //Taking the inserted parameters of the user
            try//Checking if the parameters are within the board
            {
                if (board[x, y] == 0)//Checking whether the position is empty
                {

                    board[x, y] = playernumber;//Inserting Values
                    WinnerCheck(x, y, playernumber);//Checking if the play is a winning play

                }
                else {//If the position is already filled
                    Console.WriteLine("Position has already been taken" +
                    "\nPlayer" + playernumber + " must choose another number");
                    PlayerChoose("Player" + playernumber);
                }
            }
            catch (IndexOutOfRangeException a)//Message for the user if the parameters are out of bound
            {
                Console.WriteLine("Error: Got out of the bound\nChoose a Location that is within the Board.");
                PlayerChoose("Player" + playernumber);
            }
            catch (Exception e)//General Error handling
            {
                Console.WriteLine("Error: There is an error with the input\nChoose another Location");
                PlayerChoose("Player" + playernumber);
            }
        }



        public  void PlayerChoose(String name)
        {
            Console.WriteLine(name+"'s Turn\n");//Displaying the current player
            Console.Write(name + " Row( 0 <= row < 3 ):");
            try//Hanfling if the user input is not interger 
            {
                int xlocation = Int32.Parse(Console.ReadLine());//Geting the Row
                Console.WriteLine("\n" + name.Substring(0, 1) + name.Substring(6) + "X-->" + xlocation);
                Console.Write("\n" + name + " Colum(0 <= colum < 3):");
                int ylocation = Int32.Parse(Console.ReadLine());//Getting the Colum
                Console.WriteLine("\n" + name.Substring(0, 1) + name.Substring(6) + "Y-->" + ylocation);
                InsertValue(xlocation, ylocation, Convert.ToInt32(name.Substring(6)));
            }
            catch (FormatException e)//If exeption related to user's varabial input
            {
                Console.WriteLine("Error: left varable blank.\nNeed to get Location, enter a number between 0 and 2.\nnot a black!");
                PlayerChoose(name);
            }catch(Exception a)//If Error is unknown
            {
                Console.WriteLine("Error: There is an unknow error from your input.\nEnter your a new location.");
                PlayerChoose(name);
            }
        }



        public  void endgame(String name)
        {
            PrintBoard();
            //Checking the results of the game
            if (name == "Tie")
            {
                Console.WriteLine("\n\n\nThe Game is a Tie\n\n\n");
            }
            else
            {
                Console.WriteLine("\n\n\nThe Winner is  " + name + "\n\n\n");
            }
            Environment.Exit(0);//Terminating the program
        }

        //Printing the board
        public void PrintBoard()
        {
            Console.WriteLine("-------------------------");
            for (int row = 0; row < BOARDSIZE; row++)
            {
                Console.Write("|");
                for (int colum = 0; colum < BOARDSIZE; colum++)
                {

                    try {
                            if(board[row,colum] == 0)
                            {
                            Console.Write("       |");
                            }
                            else
                            {
                                Console.Write("   " + board[row, colum] + "   |");
                            }
                       
                        }
                    catch (NullReferenceException e)
                    {
                        Console.Write("       |");
                    }
                }
                Console.WriteLine("\n-------------------------");
            }
        }

    }//End of Class
    //Main class
    class Game
    {
        //Main method
        static void Main(string[] args)
        {
            TicTacToe game = new TicTacToe();

            game.PrintBoard();
            game.Play();
           
        }
    }
}


