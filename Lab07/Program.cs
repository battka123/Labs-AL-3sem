using System.Reflection;
using System.Xml;
using AnimalClasses;
using AnimalClasses.classes;
using AnimalClasses.abstract_classes;
using AnimalClasses.enums;
using System;

class Program
{
    static void Main(string[] args)
    {
        XmlDocument xmlDoc = new XmlDocument();

        XmlElement rootElement = xmlDoc.CreateElement("ClassDiagram");
        xmlDoc.AppendChild(rootElement);

        // get all types from AnimalClasses assembly
        Assembly assembly = Assembly.Load("AnimalClasses");
        Type[] types = assembly.GetTypes();

        foreach (Type type in types)
        {
            // class-enum difference
            string t;
            if (type.IsClass)
            {
                t = "Class";
            }
            else
            {
                t = "Enum";
            }

            // take to xml classes and enums created in AnimalClasses
            if (type.Namespace.Contains("AnimalClasses"))
            {
                XmlElement element = xmlDoc.CreateElement(t);
                rootElement.AppendChild(element);

                // add name attribute
                element.SetAttribute("name", type.Name);

                // get comment attribute
                CommentAttribute comment = (CommentAttribute)type.GetCustomAttribute(typeof(CommentAttribute));

                if (comment != null)
                {
                    // element for comment
                    XmlElement commentElement = xmlDoc.CreateElement("Comment");
                    commentElement.InnerText = comment.Comment;
                    element.AppendChild(commentElement);
                }

                // get all properties and put in xml
                object[] properties = type.GetProperties();

                foreach (var prop in properties)
                {
                    XmlElement propertyElement = xmlDoc.CreateElement("Property");
                    propertyElement.InnerText = prop.ToString();
                    element.AppendChild(propertyElement);
                }

                //get all methods ant put in xml
                object[] methods = type.GetMethods(BindingFlags.DeclaredOnly);

                foreach (var method in methods)
                {
                    XmlElement methodElement = xmlDoc.CreateElement("Method");
                    methodElement.InnerText = method.ToString();
                    element.AppendChild(methodElement);
                }
            }

        }

        // save xml-document
        xmlDoc.Save("C:\\C#\\Lab07\\ClassDiagram.xml");

    }
}