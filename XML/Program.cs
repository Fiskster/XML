using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace XML
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer charSerializer = new XmlSerializer(typeof(Character));
            Character player;

            System.Console.WriteLine("Do you want to make a new character? (Y/N)");
            ConsoleKeyInfo UI = Console.ReadKey();
            if (UI.Key == ConsoleKey.Y)
            {
                player = new Character();
                Console.Clear();
                System.Console.WriteLine("How tall is your character?");
                string input = Console.ReadLine();
                bool succsess = int.TryParse(input, out player.height);
                System.Console.WriteLine("How much does your character Weigh?");
                string input2 = Console.ReadLine();
                bool succsess2 = int.TryParse(input2, out player.weight);
                System.Console.WriteLine("What is your characters name?");
                string name = Console.ReadLine();
                player.name = name;


                FileStream file = File.Open(@"char.xml", FileMode.OpenOrCreate);

                charSerializer.Serialize(file, player);

                file.Close();


            }
            else
            {
                using (FileStream file = File.Open(@"char.xml", FileMode.OpenOrCreate))
                {
                   player = (Character)charSerializer.Deserialize(file);
                }
            }
           Console.Clear();
            System.Console.WriteLine("Name: " + player.name);
            System.Console.WriteLine("Height: " + player.height);
            System.Console.WriteLine("Weight: " + player.weight);

            Console.ReadLine();













        }

    }
}
