using System;

namespace Checkerboard_Pattern_of_Asterisks
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Write an app that uses only the output statements
               Console.Write( "* " );
               Console.Write( " " );
               Console.WriteLine();
               to display the checkerboard pattern. A Console.WriteLine method call with no arguments outputs a single newline character. 
               [Hint: Repetition statements are required.]

             */

            int Length = 16;
            int Height = 8;

            for (int i = 0; i <= Height; i++)
            {
                if (i % 2 == 0)
                    Console.Write("* ");
                else
                    Console.Write("");

                for (int j = 0; j <= Length; j++)
                {
                    if (j % 2 == 0)
                        Console.Write(" ");
                    else
                        Console.Write("* ");
                }
                Console.WriteLine("");
            }
        }
    }
}
