using System.IO;
using System;
using System.Xml.Serialization;
using AnimalClasses.abstract_classes;
using AnimalClasses.classes;
using AnimalClasses.enums;
/*
namespace Serialize
{
    public class Program
    {
        public static void Main()
        {
            // create Animal example
            Animal cow = new Cow
            {
                Country = "Russia",
                HideFromOtherAnimals = false,
                Name = "Murka",
                GetClassificationAnimal = eClassificationAnimal.Herbivores
            };

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Cow));

            // get stream and serialize object
            using (FileStream fs = new FileStream("C:\\C#\\Lab08\\animal.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, cow);
                Console.WriteLine("Serialized");
            }
        }
    }
}
*/