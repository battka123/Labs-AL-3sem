using System.IO;
using System;
using System.Xml.Serialization;
using AnimalClasses.abstract_classes;
using AnimalClasses.classes;
/*
class Program
{
    static void Main()
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Cow));

        using (FileStream fs = new FileStream("C:\\C#\\Lab08\\animal.xml", FileMode.OpenOrCreate))
        {
            Animal cow = xmlSerializer.Deserialize(fs) as Cow;
            Console.WriteLine($"Country: {cow?.Country}\nHide from other animals: {cow?.HideFromOtherAnimals}\n" +
                              $"Name: {cow?.Name}\nClassification: {cow?.GetClassificationAnimal}");
            Console.ReadLine();
        }
    }
}
*/