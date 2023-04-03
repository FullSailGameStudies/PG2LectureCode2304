using System;
using System.Collections.Generic;
using System.Linq;

namespace Day01
{
    /*                    METHODS          
                                                               
                ╔══════╗ ╔═══╗ ╔══════════╗ ╔════════════════╗ 
                ║public║ ║int║ ║SomeMethod║ ║(int someParam) ║ 
                ╚══════╝ ╚═══╝ ╚══════════╝ ╚════════════════╝ 
                    │      │         │               │         
              ┌─────┘      │         └──┐            └───┐     
         ┌────▼────┐   ┌───▼───┐   ┌────▼───┐       ┌────▼────┐
         │ Access  │   │ Return│   │ Method │       │Parameter│
         │ modifier│   │ type  │   │  Name  │       │  list   │
         └─────────┘   └───────┘   └────────┘       └─────────┘
    
            Vocabulary:
        
                  method(or function) : https://www.w3schools.com/cs/cs_methods.php
                      a block of code that can be referenced by name to run the code it contains.

                  parameter: https://www.w3schools.com/cs/cs_method_parameters.php
                      a variable in the method definition.The list of parameters appear between the ( ) in a method header.

                  arguments:
                      when a method is called, arguments are the data you pass into the method's parameters
        
                  return type: https://www.w3schools.com/cs/cs_method_parameters_return.php
                      the value returned when a method finishes.
                      A return type must be specified on a method.
                      If no data is returned, use void.
    
        
                  List<T>: https://www.tutorialsteacher.com/csharp/csharp-list#:~:text=C%23%20-%20List%3CT%3E%201%20List%3CT%3E%20Characteristics%20List%3CT%3E%20equivalent,8%20Check%20Elements%20in%20List%20...%20More%20items
                    a collection of strongly typed objects that can be accessed by index. Indexes start at 0.



             Lecture videos:
                  METHODS LECTURE:
                  https://fullsailedu-my.sharepoint.com/:v:/g/personal/ggirod_fullsail_com/EW0hLKhQiBdFjOGq1WG6oRoB9TTQWJd1L9ic6VRiEYwgdg?e=J7uZXt
                  Chapters: Method Basics through Method Examples

                  LIST LECTURE:
                  https://fullsailedu-my.sharepoint.com/:v:/g/personal/ggirod_fullsail_com/ERG1iZHKJgFIoj6W8dhxPPgBIIY-Ot1b6Ueh-50Ggfcikg?e=goT9d6
                  Chapters: Array Basics through Looping Examples.

     */


    internal class Program
    {
        static int Add(int n1, int n2)
        {
            return n1 + n2;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Hello Gotham!");
            int num1 = 23, num2 = 40;
            int sum = Add(num1, num2);//pass by value
            sum = Add(5, 2);
            PrintSum(sum);

            /*
              Calling a method
                use the methods name.
                1) if the method needs data (i.e. has parameters), you must pass data to the method that matches the parameter types
                2) if the method returns data, it is usually best to store that data in a variable on the line where you call the method.
             
            */

            /*
                ╔══════════════════════════╗ 
                ║Parameters: Pass by Value.║
                ╚══════════════════════════╝ 
             
                Copies the value to a new variable in the method.
                
                For example, the AddOne method has a parameter called localNumber. localNumber is a variable that is local ONLY to the method.
                The value of the variable in main, number, is COPIED to the variable in AddOne, localNumber.
              
            */
            int number = 5;
            int plusOne = AddOne(number);

            /*
                CHALLENGE 1:

                    call the Sum method on the t1000 calculator. Print the sum that is returned.
             
            */
            Calculator t1000 = new Calculator();
            int result = t1000.Sum(13, 420);
            //$ - interpolated string
            Console.WriteLine($"The sum of 13 and 420 is {result}");

            Calculator.WhoAmI();



            /*   
                ╔═════════╗ 
                ║ List<T> ║
                ╚═════════╝ 
                
                [  Creating a List  ]
                
                List<T>  - the T is a placeholder for a type. It is a "Generic Type Parameter" to the class.
                
                When you want to create a List variable, replace T with whatever type of data you want to store in the List.
            */
            string[] heroes = new string[10];
            List<string> names = new List<string>(10) { "Batman" };//this list stores strings and only strings.
            PrintInfo(names);//Count: 1 Capacity: 1? 3? 4?
            names.Add("The Greatest Detective");
            names.Add("The Caped Crusader");
            names.Add("The Best");
            names.Add("Bruce");
            PrintInfo(names);//Count: 5 Capacity: 8, 6, 4??
            names.Add("Joker");
            names.Add("Penguin");
            names.Add("Bane");
            names.Add("Riddler");
            PrintInfo(names);//Count: 9 Capacity: 12? 16? 14? 2.5?????
            names.Add("Poison Ivy");
            names.Add("Catwoman");
            PrintInfo(names);//Count: 11 Capacity: 20? 16??
            /*
                CHALLENGE 2:

                    Create a list that stores floats. Call the variable grades.
             
            */
            List<float> grades;//null. no list.
            grades = new();//empty list
            var scores = new List<int>();

            var anon = new { isGood = true };//anonymous type






            /*   
                ╔═════════╗ 
                ║ List<T> ║
                ╚═════════╝ 

                [  Adding items to a List  ]

                There are 2 ways to add items to a list:
                1) on the initializer. 
                2) using the Add method. 
            */
            List<char> letters = new List<char>() { 'B', 'a', 't', 'm', 'a', 'n' };
            letters.Add('!');

            /*
                CHALLENGE 3:

                    Add a few grades to the grades list you created in CHALLENGE 2.
             
            */
            Random rando = new();
            grades.Add((float)rando.NextDouble() * 100);
            grades.Add((float)rando.NextDouble() * 100);
            grades.Add((float)rando.NextDouble() * 100);
            grades.Add((float)rando.NextDouble() * 100);
            grades.Add((float)rando.NextDouble() * 100);





            /*   
                ╔═════════╗ 
                ║ List<T> ║
                ╚═════════╝ 

                [  Looping over a List  ]

                You can loop over a list with a for loop or a foreach loop.
                1) for loop. use the Count property in the for condition.
                2) foreach loop
            */

            for (int i = 0; i < letters.Count; i++)
            {
                Console.Write($" {letters[i]}");
                letters[i] = 'b';
            }

            foreach (var letter in letters)
                Console.Write($" {letter}");

            /*
             * Challenge 3.5
             *   loop over the grades list and print out each grade
             */
            for (int i = 0; i < grades.Count; i++)
            {

            }

            Console.WriteLine("\n\n--PG2 Grades--");
            foreach (var grade in grades)
            {
                //if (grade < 59.5) Console.ForegroundColor = ConsoleColor.Red;
                //else if(grade < 69.5) Console.ForegroundColor = ConsoleColor.DarkYellow;
                //else if (grade < 79.5) Console.ForegroundColor = ConsoleColor.Yellow;
                //else if (grade < 89.5) Console.ForegroundColor = ConsoleColor.Blue;
                //else Console.ForegroundColor = ConsoleColor.Green;

                //ternary operator
                // (condition) 
                // ? - what happens when the condition is true
                // : - what happens when the condition is false
                // an if-else
                Console.ForegroundColor = (grade < 59.5) ? ConsoleColor.Red :
                                          (grade < 69.5) ? ConsoleColor.DarkYellow :
                                          (grade < 79.5) ? ConsoleColor.Yellow :
                                          (grade < 89.5) ? ConsoleColor.Blue :
                                          ConsoleColor.Green;

                //,7 - will right-align in 7 spaces
                //:N2 - format as a number with 2 decimal places
                Console.WriteLine($"{grade,7:N2}");

                Console.ResetColor();
            }


            /*
                CHALLENGE 4:

                    1) Fix the Average method of the calculator class to calculate the average of the list parameter.
                    2) Call the Average method on the t1000 variable and pass your grades list to the method.
                    3) print the average that is returned.
             
            */
            float average = t1000.Average(grades);
            Console.WriteLine($"Average grade: {average}");


            Console.ReadKey(true);
        }

        private static void PrintInfo(List<string> names)
        {
            //Count: # of items that have been ADDED
            //Capacity: size (length) of the internal array
            Console.WriteLine($"Count: {names.Count}\tCapacity: {names.Capacity}");

        }

        private static void PrintSum(int sum)
        {
            Console.WriteLine($"My Sum: {sum}");
        }

        private static int AddOne(int localNumber)
        {
            return localNumber + 1;
        }


    }

    class Calculator
    {
        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static void WhoAmI()
        {
            Console.WriteLine("I am a T800 cybernetic organism.");
        }


        public float Average(List<float> numbers)
        {
            float avg = 0F;
            float sum = 0;
            //loop over the numbers and calculate the average
            for (int i = 0; i < numbers.Count; i++)
                sum += numbers[i];
            avg = sum / numbers.Count;

            return avg;
        }
    }
}
