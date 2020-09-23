using System;
using System.IO;
using System.Xml.Serialization;

namespace XML
{
    class Program
    {
        static void Main(string[] args)
        {
        //    3 56 90
        // PowerUp p = new PowerUp();

        // p.name = "fungi";
        // p.x = 4; 
        // p.y = 3; 

        XmlSerializer serializer = new XmlSerializer(typeof(PowerUp));

        FileStream myFile = File.Open("powerup.xml", FileMode.OpenOrCreate);

        PowerUp p = (PowerUp) serializer.Deserialize(myFile);

        myFile.Close();

        System.Console.WriteLine(p.name);

        Console.ReadLine();
           
        }
    }
}
