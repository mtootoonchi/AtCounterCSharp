using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCounter
{
    /*
     * matrix by Matthew Tootoonchi
     * 
     * Creates a 2D array filled randomly with @ or - and has a method/function which finds how much @ are next 
     * to each other of user input and has another method/function that prints out the created 2D array.
     * 
     * The dimensions of tix and checked are the same.
     */
    public class matrix
    {
        private char[,] tix;  //The randomly filled 2D array of '@' and '-'.
        private bool[,] AtTracker;  //While counting the number of '@' in the 2D array this 2D array keeps track of each '@' so it doesn't count it again.
        private int Mrow;   //The number of rows in the 2D array.
        private int Mcol;   //The number of columns in the 2D array.

        /*
         * Creates a 2D array filled randomly with '@' or '-' and declares the max number of rows and columns and also declares checked.
         */
        public matrix(int a, int b)
        {
            this.Mrow = a;   //Declares the max number of rows.
            this.Mcol = b;   //Declares the max number of columns.
            tix = new char[a, b];
            Random ran = new Random();
            for (int i = 0; i < a; i++)   //Creates a 2D array named tix filled randomly with '@' or '-'.
            {
                for (int j = 0; j < b; j++)
                {
                    if (ran.Next(0, 2) == 1)
                    {
                        tix[i, j] = '@';
                    }
                    else
                    {
                        tix[i, j] = '-';
                    }
                }
            }
            AtTracker = new bool[a, b];
        }
        /*
         * Prints the 2D array tix.
         */
        public void printmatrix()
        {
            for (int i = 0; i < Mrow; i++)
            {
                for (int j = 0; j < Mcol; j++)
                {
                    Console.Write(tix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        /*
         * Fills the 2D array checked with "false" and calls check to check if there is a '@'.
         */
        public int point(int a, int b)
        {
            for (int i = 0; i < Mrow; i++)   //Fills the 2D array checked with "false."
            {
                for (int j = 0; j < Mcol; j++)
                {
                    AtTracker[i, j] = false;
                }
            }
            return check(a, b);   //Calls check to check if there is a '@'.
        }
        /*
         * Checks if there is a '@' and uses recursion to add them all up.
         */
        private int check(int a, int b)
        {
            if (a < 0 || b < 0 || a > Mrow - 1 || b > Mcol - 1 || tix[a, b] == '-' || AtTracker[a, b])  //Checks if there is the array is out of bounds, there isn't a '@' at tix, and if the space has been checked.
            {
                 return 0;
            }
            else
            {
                 AtTracker[a, b]=true;   //Keeps track of the spaces checked.
                 return check(a-1, b)+check(a+1, b)+check(a, b+1)+check(a, b-1)+1;   //Uses recursion to call the left, right, up, and down of the 2D array tix if there is a '@' and adds it all by 1.
            }
        }
        /*
         * Returns an empty toString().
         */
        public override string ToString()
        {
             return "";
        }
    }
}
