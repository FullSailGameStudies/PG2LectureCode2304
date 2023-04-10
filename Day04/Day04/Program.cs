using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Day04
{
    internal class Program
    {
        /*
         *   
            procedure bubbleSort(A : list of sortable items)
                n := length(A)
                repeat
                    swapped := false
                    for i := 1 to n - 1 inclusive do
                        if A[i - 1] > A[i] then
                            swap(A, i - 1, i)
                            swapped = true
                        end if
                    end for
                    n := n - 1
                while swapped
            end procedure
         */
        static void BubbleSort(List<string> unsorted) //: where T is IComparable
        {
            int n = unsorted.Count;
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i <= n - 1; i++)
                {
                    int compResult = unsorted[i - 1].CompareTo(unsorted[i]);
                    if (compResult > 0)
                    {
                        //swap(A, i - 1, i);
                        //int temp = A[i - 1];
                        //A[i - 1] = A[i];
                        //A[i] = temp;
                        (unsorted[i], unsorted[i - 1]) = (unsorted[i - 1], unsorted[i]);
                        swapped = true;
                    }
                }
                --n;
            } while (swapped);
        }

        static Random rando = new();
        static void RecurseMe()
        {
            //an exit condition
            int random = rando.Next(1000);
            if (random < 900)
            {
                Console.WriteLine(random);
                RecurseMe();
            }
        }
        static void Main(string[] args)
        {
            RecurseMe();
            //List<int> nums = new() { 5, 420, 13, 1, 7 };
            //BubbleSort(nums);
            //foreach (int x in nums)
            //    Console.Write($"{x} ");
            //Console.WriteLine(  );

            List<string> DC = new() { "Wonder Woman", "Flash", "Superman", "Batman", "Green Lantern", "Aquaman" };
            BubbleSort(DC);
            foreach (var x in DC)
                Console.Write($"{x} ");
            

            /*
                ╔═══════╗ 
                ║Sorting║
                ╚═══════╝ 
             
                Sorting is used to order the items in a list/array is a specific way
             
                CHALLENGE 1:

                    Convert this BubbleSort pseudo-code into a C# method             
                     
                    procedure bubbleSort(A : list of sortable items)
                      n := length(A)
                      repeat
                          swapped := false
                          for i := 1 to n - 1 inclusive do
                              if A[i - 1] > A[i] then
                                  swap(A, i - 1, i)
                                  swapped = true
                              end if
                          end for
                          n := n - 1
                      while swapped
                    end procedure
                    
            */

            //use CompareTo method.
            // -1  LESS THAN
            //  0  EQUAL TO
            //  1  GREATER THAN
            string s1 = "Batman", s2 = "Aquaman";
            Console.WriteLine(  );
            int compResult = s1.CompareTo(s2);
            if (compResult == 0)
            {
                Console.WriteLine($"{s1} EQUALS {s2}");
            }
            else if(compResult < 0)
            {
                Console.WriteLine($"{s1} LESS THAN {s2}");
            }
            else //if (compResult > 0)
            {
                Console.WriteLine($"{s1} GREATER THAN {s2}");
            }
            Console.WriteLine();


            //Recursion, Sorting, Searching

            /*
                ╔═════════╗ 
                ║Recursion║
                ╚═════════╝ 
             
                Recursion happens when a method calls itself. This creates a recursive loop.
                
                All recursive methods need an exit condition, something that prevents the loop from continuing.
              
            */
            Console.ReadKey();
            int N = 0;
            RecursiveLoop(N);
            Console.ResetColor();


            /*
                CHALLENGE 2:

                    convert this for loop to a recursive method called Bats. Call Bats here in Main.
             
                    for(int i = 0;i < 100;i++)
                    {
                        Console.Write((char)78);
                        Console.Write((char)65);
                        Console.Write(' ');
                    }
            */


            Console.ReadKey();
            Console.WriteLine();
            int i = 0;
            Bats(i);

            Console.Write((char)66);
            Console.Write((char)65);
            Console.Write((char)84);
            Console.Write((char)77);
            Console.Write((char)65);
            Console.Write((char)78);
            Console.WriteLine();

        }
        static void Bats(int i)
        {
            if(i < 100)//exit condition
            {
                Console.Write((char)78);
                Console.Write((char)65);
                Console.Write(' ');

                Bats(++i);//post vs pre
            }

        }


        static void RecursiveLoop(int N)
        {
            //an Exit Condition. This will stop the loop when N >= Console.WindowWidth
            if (N < Console.WindowWidth)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(' ');
                Thread.Sleep(20);

                RecursiveLoop(N + 1);//calls itself which makes the method recursive

                Thread.Sleep(20);
                Console.CursorLeft = N;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write(' ');
            }
        }
    }
}
