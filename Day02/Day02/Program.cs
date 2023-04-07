using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;

namespace Day02
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


    
    ╔═══════════╗ 
    ║Return type║ Return type defines the type of the data being returned.
    ╚═══════════╝
    │
    │
    └── If NO data is returned, then use "void" for the return type.
    │    public void PrintSomething()
    │    {
    │        Console.WriteLine("Something");
    │    }
    │
    │
    └── If a method returns data, then the return type must match the type of the data being returned.
        public float GetMyGrade()
        {
            return 99.9F; //returning a float so set return type to float
        }

    ╔══════════╗ 
    ║Parameters║ Parameters define the data passed to the method.
    ╚══════════╝
    │
    │
    └── If NO data is passed to the method, leave the parenthesis empty. EX: ( )
    │    public void PrintSomething()
    │   {  }
    │
    │
    └── If passing data to the method, then define the variable the method will use to store the data.
        Parameters are just variables therefore parameters need 2 things: <type> <name>
        Example:
        public void PrintMyGrade(float myGrade)
        {
            Console.WriteLine($"My grade is {myGrade}");
        }

        

     */
    internal class Program
    {
        static int Factor(ref int num, int factor)
        {
            int orig = num;
            num *= factor;
            return orig;
        }
        static Random randy = new Random();
        static void Main(string[] args)
        {
            int n = 5, factor = 3;
            int original = Factor(ref n, factor);
            Console.WriteLine($"{original} * {factor} = {n}");
            Console.WriteLine();

            /*   
                ╔══════════════════════════════╗ 
                ║Parameters: Pass by Reference.║
                ╚══════════════════════════════╝ 
                Sends the variable itself to the method. The method parameter gives the variable a NEW name (i.e. an alias)
                  
                NOTE: if the method assigns a new value to the parameter, the variable used when calling the method will change too.
                    This is because the parameter is actually just a new name for the other variable.
            */
            string spider = "Spiderman";
            bool isEven = PostFix(ref spider);

            /*
                CHALLENGE 1:

                    Write a method to curve the grade variable.
                    1) pass it in by reference
                    2) calculate a 5% curve
                    3) curve the parameter in the method
                    4) return the curve amount
             
            */
            double grade = randy.NextDouble() * 100;
            double curved = Curve(ref grade);
            Console.WriteLine($"My grade was curved by {curved} to {grade}");

            double toddsGrade= randy.NextDouble() * 100;
            Curve(ref toddsGrade, out double toddsCurve);
            Console.WriteLine($"Todd's grade was curved by {toddsCurve} to {toddsGrade}");



            /*  
                ╔═══════════════════════════╗ 
                ║Parameters: Out Parameters.║
                ╚═══════════════════════════╝  
                  A special pass by reference parameter. 
                  DIFFERENCES:
                    the out parameter does NOT have to be initialized before sending to the method
                    the method MUST assign a value to the parameter before returning

            */
            ConsoleColor randoColor; //don't have to initialize it
            GetRandomColor(out randoColor);
            Console.BackgroundColor = randoColor;
            Console.WriteLine("Hello Gotham!");
            Console.ResetColor();


            /*
                CHALLENGE 2:

                    Write a method to calculate the stats on a list of grades
                    1) create a list of grades in main and add a few grades to it
                    2) create a method to calculate the min, max, and avg. 
                        use out parameters to pass this data back from the method.
                    3) print out the min, max, and avg
             
            */
            List<double> pg2 = new List<double>();
            for (int i = 0; i < 10; i++)
                pg2.Add(randy.NextDouble() * 100);
            Stats(pg2, out double min, out double max, out double avg);
            Console.WriteLine("-------PG2----------");
            foreach (var pg2grade in pg2)
                Console.WriteLine($"{pg2grade,7:N2}");
            Console.WriteLine($"Min: {min}\nMax: {max}\nAverage: {avg}");

            (double pg2Min, double pg2Max, double pg2Avg) = Stats(pg2);



            /*   
                ╔═════════╗ 
                ║ List<T> ║
                ╚═════════╝ 

                [  Removing from a List  ]

                There are 2 main ways to remove from a list:
                1) bool Remove(item).  will remove the first one in the list that matches item. returns true if a match is found else removes false.
                2) RemoveAt(index). will remove the item from the list at the index

            */
            List<string> dc = new() { "Batman", "Wonder Woman", "Aquaman", "Superman", "Aquaman", "Aquaman" };
            //{ "Batman", "Wonder Woman", "Aquaman", "Superman", "Aquaman", "Aquaman" }
            //{ "Batman", "Wonder Woman", "Superman", "Aquaman", "Aquaman", "Aquaman" }
            bool found = dc.Remove("Aquaman");
            if(found)
                Console.WriteLine("The first Aquaman was removed.");

            dc.RemoveAt(dc.Count - 1);//removes the last item
            Console.WriteLine("The last Aquaman in the list was removed.");

            /*
                CHALLENGE 3:

                    Using the list of grades you created in CHALLENGE 2, remove the min and max grades from the list.
                    Print the grades.
            */

            pg2.Remove(min);
            pg2.Remove(max);


            dc = new() { "Batman", "Aquaman", "Wonder Woman", "Aquaman", "Aquaman", "Superman", "Aquaman", "Aquaman" };
            for (int i = 0;i < dc.Count;i++)
            {
                if (dc[i] == "Aquaman")
                {
                    dc.RemoveAt(i);
                    i--;
                }
            }
            //OR...use a reverse for loop
            for (int i = dc.Count - 1; i >= 0; i--)
            {
                if (dc[i] == "Aquaman")
                {
                    dc.RemoveAt(i);
                }
            }
            Console.WriteLine("UPDATED Justice League");
            foreach (var hero in dc)
            {
                Console.WriteLine(hero);
            }



        }

        static (double,double,double) Stats(List<double> grades)
        {
            double min = double.MaxValue;
            double max = double.MinValue;
            double sum = 0;
            foreach (var grade in grades)
            {
                min = Math.Min(grade, min);
                max = Math.Max(grade, max);
                sum += grade;
            }
            double avg = sum / grades.Count;
            return (min, max, avg);
        }

        static void Stats(List<double> grades, out double min, out double max, out double avg)
        {
            min = double.MaxValue; 
            max = double.MinValue;
            double sum = 0;
            foreach (var grade in grades)
            {
                min = Math.Min(grade, min);
                max = Math.Max(grade, max);
                sum += grade;
            }
            avg = sum / grades.Count;
        }

        static double Curve(ref double gradeToCurve)
        {
            double curveAmount = gradeToCurve * 0.05;
            gradeToCurve += curveAmount;
            return curveAmount;
        }
        //tuples
        static void Curve(ref double gradeToCurve, out double curveAmount)
        {
            curveAmount = gradeToCurve * 0.05;
            gradeToCurve += curveAmount;
        }

        private static void GetRandomColor(out ConsoleColor outColor)
        {
            //the method MUST initialize the outColor parameter
            outColor = (ConsoleColor)randy.Next(16);

        }

        static bool PostFix(ref string hero) //hero is now an alias to the variable used when calling PostFix. In this case, hero is an alias to the spider variable.
        {
            int postFix = randy.Next(100);
            hero += $"-{postFix}"; //updating hero now also updates spider
            return postFix % 2 == 0; //isEven
        }
    }
}
