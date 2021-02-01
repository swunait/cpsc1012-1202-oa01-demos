/*  Purpose:    A Paper-Rock-Scissor game against the computer
 *  
 *  Input:      player hand
 * 
 *  Process:    Determine if the player hand beats the computer hand or losses or it is a tie.
 *              
 *              1) playerHand is scissor
 *                  - computerHand is rock then player loses
 *                  - computerHand is paper then player wins
 *                  - computerHand is scissor then tie game
 *              2) playerHand is rock
 *                  - computerHand is rock then tie game
 *                  - computerHand is paper then player loses
 *                  - computerHand is scissor then player wins
 *              2) playerHand is paper
 *                  - computerHand is rock then player wins
 *                  - computerHand is paper then tie game
 *                  - computerHand is scissor then player loses
 *  
 *  Output:     A message showing the computer hand, the player hand, and the game results (win, lose, draw)
 * 
 * */
using System;

namespace RockPaperScissor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
