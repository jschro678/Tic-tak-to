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
            int i= 0;
            while (i !=4)
            {
            player1turn(board);
            player2turn(board);
            i++;
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
static void updateboard(List<char>board, int turn, char player )
{
 board[turn-1] = player;
 displayboard(board);  
}
    }
}
