using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace Day04
{
    internal class Program
    {
        enum Weapon
        {
            Sword, Axe, Spear, Mace
        }
        static void Main(string[] args)
        {
            /*
                ╔═════════╗ 
                ║Searching║
                ╚═════════╝ 
             
                There are 2 ways to search a list: linear search or binary search
             
                CHALLENGE 1:

                    Convert Linear Search algorithm into a method. 
                        The method should take 2 parameters: list of ints to search, int to search for.
                        The method should return -1 if NOT found or the index if found.
                     
                    The algorithm:
                        1) start at the beginning of the list
                        2) compare each item in the list to the search item
                        3) if found, return the index
                        4) if reach the end of the list, return -1 which means not found
                    
            */



            /*   
                ╔══════════════════════════╗ 
                ║ Dictionary<TKey, TValue> ║
                ╚══════════════════════════╝ 
                
                [  Creating a Dictionary  ]
                
                Dictionary<TKey, TValue>  - the TKey is a placeholder for the type of the keys. TValue is a placeholder for the type of the values.
                
                When you want to create a Dictionary variable, replace TKey with whatever type of data you want to use for the keys and
                replace TValue with the type you want to use for the values.
            */
           
            Dictionary<Weapon, int> backpack = new Dictionary<Weapon, int>();//will store the counts of each kind of weapon

            List<int> nums = new() { 1, 2, 3, 4 };
            nums.Add(5);
            nums.Add(6);
            Dictionary<string, double> menu = new Dictionary<string, double>()
            {
                //{ key, value } key-value pair
                { "Hamburger", 13.99 },
                { "Tater tots", 4.99 }
            };
            menu.Add("Fish sticks", 10.99);
            menu.Add("Chicken alfredo", 15.99);
            try
            {
                menu.Add("Chicken alfredo", 17.99);//cause an exception
            }
            catch (ArgumentException aex)
            {
            }
            catch (Exception ex)
            {
            }
            menu.TryAdd("Chicken alfredo", 17.99);

            menu["Wings"] = 9.99;
            menu["Mac and cheese"] = 11.99;
            menu["Mac and cheese"] = 13.99;//will NOT cause an exception. will overwrite.





            /*  
                ╔══════════════════════════╗ 
                ║ Dictionary<TKey, TValue> ║
                ╚══════════════════════════╝ 

                [  Adding items to a Dictionary  ]

                There are 3 ways to add items to a Dictionaruy:
                1) on the initializer. 
                2) using the Add method. 
                3) using [key] = value
            */
            backpack = new Dictionary<Weapon, int>()
            {
                {Weapon.Sword, 5 }
            };
            backpack.Add(Weapon.Axe, 2);
            backpack[Weapon.Spear] = 1;

            /*
                CHALLENGE 2:

                    Create a Dictionary that stores names (string) and grades. Call the variable grades.
             
            
                CHALLENGE 3:

                    Add students and grades to your dictionary that you created in CHALLENGE 2.
             
            */
            Random rando = new Random();
            Dictionary<string, double> grades = new()
            {
                {"Cristian",  rando.NextDouble() * 100 },
                {"Jacob",  rando.NextDouble() * 100 },
                {"John",  rando.NextDouble() * 100 }
            };
            grades.Add("Joseph", rando.NextDouble() * 100);
            grades.Add("Kavion", rando.NextDouble() * 100);
            grades.Add("Kevin", rando.NextDouble() * 100);

            grades["Sebastian"] = rando.NextDouble() * 100;
            grades["Thomas"] = rando.NextDouble() * 100;
            grades["Asha"] = rando.NextDouble() * 100;




            /*   
                ╔══════════════════════════╗ 
                ║ Dictionary<TKey, TValue> ║
                ╚══════════════════════════╝ 

                [  Looping over a Dictionary  ]

                You should use a foreach loop when needing to loop over the entire dictionary.
               
            */
            foreach (KeyValuePair<Weapon,int> weaponCount in backpack)
                Console.WriteLine($"You have {weaponCount.Value} {weaponCount.Key}");

            Console.OutputEncoding = Encoding.UTF8;
            //Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("de-DE");
            //Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("de-DE");
            Console.WriteLine("----Welcome to Kevin's Bistro----");
            foreach (KeyValuePair<string, double> menuItem in menu)
            {
                string name = menuItem.Key;
                double price = menuItem.Value;
                Console.WriteLine($"{name,-20} {price,7:C2}");//C currency
            }
            //for (int i = 0; i < menu.Count; i++)
            //{
            //    KeyValuePair<string,double> price = menu.ElementAt(i);
            //}

            /*
                CHALLENGE 4:

                    Loop over your grades dictionary and print each student name and grade.
             
            */





            /*   
                ╔══════════════════════════╗ 
                ║ Dictionary<TKey, TValue> ║
                ╚══════════════════════════╝ 

                [  Checking for a key in a Dictionary  ]

                There are 2 ways to see if a key is in the dictionary:
                1) ContainsKey(key)
                2) TryGetValue(key, out value)
               
            */            
            if(backpack.ContainsKey(Weapon.Axe))
                Console.WriteLine($"{Weapon.Axe} count: {backpack[Weapon.Axe]}");

            if(backpack.TryGetValue(Weapon.Spear, out int spearCount))
                Console.WriteLine($"{Weapon.Spear} count: {spearCount}");


            /*
                CHALLENGE 5:

                    Using either of the 2 ways to check for a key, look for a specific student in the dictionary. 
                    If the student is found, print out the student's grade
                    else print out a message that the student was not found
             
            */







            /*   
                ╔══════════════════════════╗ 
                ║ Dictionary<TKey, TValue> ║
                ╚══════════════════════════╝ 

                [  Updating a value for a key in a Dictionary  ]

                To update an exisiting value in the dictionary, use the [ ]
                
               
            */
            backpack[Weapon.Mace] = 0; //sell all maces



            /*
                CHALLENGE 6:

                    Pick any student and curve the grade (add 5) that is stored in the grades dictionary
             
            */
        }
    }
}
