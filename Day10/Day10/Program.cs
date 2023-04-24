using Newtonsoft.Json;

namespace Day10
{

    /*
        ╔══════════╗ 
        ║ File I/O ║
        ╚══════════╝ 

        3 things are required for File I/O:
        1) Open the file
        2) read/write to the file
        3) close the file


        TIPS:
            use File.ReadAllText to open,read,close the file in 1 statement
            the using() statement can ensure that the file is closed

    */

    public enum Powers
    {
        Teleportation, Money, Invisibility, Explosions, LaserEyes, Flight, Speed, Strength, Magic, FreezeBreath, Swimming
    }
    public class Superhero
    {
        public string Name { get; set; }
        public string Secret { get; set; }
        public Powers SuperPower { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string dougPath = @"C:\temp\2304\doug.txt";
            char delimiter = '~';
            using (StreamWriter sw = new StreamWriter(dougPath))//IDisposable
            {
                sw.Write("Batman rules!");
                sw.Write(delimiter);
                sw.Write(5);
                sw.Write(delimiter);
                sw.Write(true);
                sw.Write(delimiter);
                sw.Write("Kevin is my hero.");
            }

            using (StreamReader sr = new StreamReader(dougPath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    string[] dougData = line.Split(delimiter);
                    foreach (var dougItem in dougData)
                    {
                        Console.WriteLine(dougItem);
                    }
                }
            }

            string dougText = File.ReadAllText(dougPath);//opens, reads, closes the file
            /*
                ╔══════════╗ 
                ║ File I/O ║
                ╚══════════╝ 

                [  Open the file  ]
                [  Write to the file  ]
                [  Close the file  ]
             
                you need the path to the file
                    use full path ( drive + directories + filename )
                    or use relative path ( directories + filename )
                    or current directory ( filename )


                
                using (StreamWriter sw = new StreamWriter(filePath)) // this line opens the file to write to it
                {                
                    //these lines write to the file
                    sw.Write("Batman");
                    sw.Write(54);
                    sw.Write(13.7);
                    sw.Write(true);

                }//this closes the file

            */

            string directories = @"C:\temp\2212"; //use @ in front of the string to ignore escape sequences inside the string
            string fileName = "tempFile.txt";
            string filePath = Path.Combine(directories, fileName); //use Path.Combine to get the proper directory separators





            /*
                ╔═══════════════════╗ 
                ║ Splitting Strings ║
                ╚═══════════════════╝ 

                taking 1 string a separating it into multiple pieces of data

                use the string's Split method

            */
            string csvString = "Batman;Bruce Wayne;Bats;;;The Dark Knight";
            string[] data = csvString.Split(';');
            csvString += "|Joker|Poison Ivy||Bane|Calendar Man|Penguin|The Riddler|Scarecrow|Mr. Freeze";
            data = csvString.Split(new char[] { ';', '|' }, StringSplitOptions.RemoveEmptyEntries);

            int index = 0;
            foreach (var item in data)
            {
                Console.WriteLine($"{++index}. {item}");
            }

            /*
                CHALLENGE 1:

                    read the data in from the file above and split the line to get the data
             
            */





            /*
                ╔═════════════╗ 
                ║ Serializing ║
                ╚═════════════╝ 

                Saving the state (data) of objects

            */

            List<Superhero> JLA = new();
            JLA.Add(new Superhero() { Name = "Batman", Secret = "Bruce Wayne", SuperPower = Powers.Money });
            JLA.Add(new Superhero() { Name = "Wonder Woman", Secret = "Diana Prince", SuperPower = Powers.Strength });
            JLA.Add(new Superhero() { Name = "Superman", Secret = "Clark Kent", SuperPower = Powers.Flight });
            JLA.Add(new Superhero() { Name = "Flash", Secret = "Barry Allen", SuperPower = Powers.Speed });
            JLA.Add(new Superhero() { Name = "Hawkman", Secret = "Dave", SuperPower = Powers.Flight });
            JLA.Add(new Superhero() { Name = "Aquaman", Secret = "Arthur Curry", SuperPower = Powers.Swimming });

            dougPath = Path.ChangeExtension(dougPath, "json");
            using (StreamWriter sw = new StreamWriter(dougPath))
            {
                using (JsonTextWriter jtw = new(sw))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Formatting = Formatting.Indented;
                    serializer.Serialize(jtw, JLA);
                }
            }

            File.WriteAllText(dougPath, JsonConvert.SerializeObject(JLA, Formatting.Indented));


            
            /*
                ╔═══════════════╗ 
                ║ Deserializing ║
                ╚═══════════════╝ 

                Recreating the objects from the saved state (data) of objects

            */

            filePath = "dougie.json";
            if(File.Exists(dougPath))
            {
                string dougieText = File.ReadAllText(dougPath);
                //Ctrl+K,S to surround text
                try
                {
                    List<Superhero> jla2 = JsonConvert.DeserializeObject<List<Superhero>>(dougieText);

                    Console.WriteLine(" The Justice League ");
                    foreach (var hero in jla2)
                    {
                        Console.WriteLine($"I am {hero.Name} (aka {hero.Secret}). I can do {hero.SuperPower}!");
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }

        }
    }
}