using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCounter
{
    /*
     * AtCounter and MyProgram by Matthew Tootoonchi
 
     * 
     * AtCounter will create a 2D array filled with '@' or '-' randomly with dimensions of user input then
     * find the number of '@' next to each other of user input, then after the user stops the program it will 
     * finally print out the created 2D array.
     * 
     */
     public class MyProgram
     {
         public static void Main(string[] args)
         {
             Console.WriteLine("AtCounter will create a 2D array filled with \'@\' or \'-\' \nrandomly with dimensions of user input then find the number \nof \'@\' next to each other of user input, then after the \nuser stops the program it will finally print out the \ncreated 2D array.\n\n");
             Console.Write("How many rows do you want in your matrix: ");
             int a = checkInt(Console.ReadLine());    //The rows in our 2D array.
             Console.Write("\nHow many columns do you want in your matrix: ");
             int b = checkInt(Console.ReadLine());    //The columns in our 2D array.
             if (a < 0 || b < 0)
             {
                 Console.WriteLine("\n\nYou have stopped the program or you put an invalid input.\n");
             }
             else
             {
                 matrix num = new matrix(a, b);  //Creates a 2D array filled randomly with '@' or '-' with dimensions of user input
                 int row = 0;
                 int col = 0;
                 while (true)   //Keeps asking the user where in the 2D array you want to search for '@' until the user stops it.
                 {
                     Console.Write("\n\nWhat is the row you want to look at\nor type \"0\" or lower to stop: ");
                     row = checkInt(Console.ReadLine()) - 1;  //Tells the user which row you want to look at from 1 to a;
                     if (row < 0 || row > a - 1)  //Array out of bounds case and user end.
                     {
                         Console.WriteLine("\n\nYou have stopped the program or you put an invalid input.\nThe matrix looks like this.\n");
                         break;
                     }
                     else
                     {
                         Console.Write("\nWhat is the column you want to look at\nor type \"0\" or lower to stop: ");
                         col = checkInt(Console.ReadLine()) - 1;   //Tells the user which column you want to look at from 1 to b;
                         if (col < 0 || col > b - 1)   //Array out of bounds case and user end.
                         {
                             Console.WriteLine("\n\nYou have stopped the program or you put an invalid input.\nThe matrix looks like this.\n");
                             break;
                         }
                         else
                         {
                             Console.WriteLine("\nYou have " + num.point(row, col) + "@ next to each other.");   //Prints the number of @ together.
                         }
                     }
                 }
                num.printmatrix();   //Prints randomly generated 2D array.
                Console.WriteLine("\nPress enter to exit the program.");
                Console.ReadLine();
             }
         }
         private static int checkInt(string a)
         {
             if (int.TryParse(a, out int b))
             {
                 return Convert.ToInt32(a);
             }
             else
             {
                 return -1;
             }
         }
     }
}
