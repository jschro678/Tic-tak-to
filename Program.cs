using System;
using System.Collections.Generic;
namespace Tic_Tac_To // Jared Schroeder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char>board = new List<char>{'1','2','3','4','5','6','7','8','9'};
            displayboard(board);
           int winner = 0;
            while (winner ==0)
            {
                player1turn(board);
               winner= checkWinner(board);
                if (winner ==1)
                {
                    Console.WriteLine("Congrats player 1 you won");
                }
                else if (winner ==0)
                {
                int tie = checktie(board);
                if (tie ==0)
                {
                player2turn(board);
                winner=checkWinner(board);
                if (winner ==1)
                {
                    Console.WriteLine("Congrats player 2 you won");
                }
                }
                else if (tie ==1)
                {
                    Console.WriteLine("It is a tie");
                    winner = 1;
                }
                }
            } 
            
        }
    static void displayboard(List<char>board)
{
    Console.WriteLine(board[0]+"|"+board[1]+"|"+board[2]);
    Console.WriteLine("-+-+-");
    Console.WriteLine(board[3]+"|"+board[4]+"|"+board[5]);
    Console.WriteLine("-+-+-");
    Console.WriteLine(board[6]+"|"+board[7]+"|"+board[8]);
}  
static void player1turn(List<char>board)
{
    char player1 ='x';
    Console.WriteLine("x's turn to choose a square (1-9): ");
    int turn = int.Parse(Console.ReadLine());
    updateboard(board,turn,player1);

}
static void player2turn(List<char>board)
{
    char player2 ='o';
    Console.WriteLine("o's turn to choose a square (1-9): ");
    int turn = int.Parse(Console.ReadLine());
    updateboard(board,turn,player2);
}
static int checkWinner(List<char>board)
{
     if (board[0] == board[1] && board[1] == board[2])
            {
                return 1;
            }
            else if (board[3] == board[4] && board[4] == board[5])
            {
                return 1;
            }
            else if (board[6] == board[7] && board[7] == board[8])
            {
                return 1;
            }
            else if (board[0] == board[3] && board[3] == board[6])
            {
                return 1;
            }
            else if (board[1] == board[4] && board[4] == board[7])
            {
            return 1;
            }
            else if (board[2] == board[5] && board[5] == board[8])
            {
                return 1;
            }
            else if (board[0] == board[4] && board[4] == board[8])
            {
                return 1;
            }
            else if (board[2] == board[4] && board[4] == board[6])
            {
                return 1;
            }
            else
            {
                return 0;
            }
}

static int checktie(List<char>board)
{
  if (board[0] != '1' && board[1] != '2' && board[2] != '3' && board[3] != '4' && board[4] != '5' && board[5] != '6' && board[6] != '7' && board[7] != '8' && board[8] != '9')
            {
                return 1;
            }
            else
            {
                return 0;
            }               
}
static void updateboard(List<char>board, int turn, char player )
{
if (board[turn-1] !='o')
{
    if (board[turn-1] !='x')
    {
        board[turn-1] = player;
        displayboard(board);
 
    }
    else
    {
        Console.WriteLine("Sorry that square is already taken, please try again");
        if (player =='x')
        {
            player1turn(board);
        }
        else
        {
            player2turn(board);
        }   
    }

}
else
{
    Console.WriteLine("Sorry that square is already taken, please try again");
    if (player =='x')
    {
        player1turn(board);
    }
    else
    {
        player2turn(board);
    }   
}

    }
    }
}
