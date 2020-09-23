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
            Character player = new Character();

            FileStream file = File.Open(@"char.xml", FileMode.OpenOrCreate);

            charSerializer.Serialize(file, charSerializer);

            file.Close();




           
        }
    }
}
