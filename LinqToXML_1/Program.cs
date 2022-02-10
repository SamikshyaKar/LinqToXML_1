// See https://aka.ms/new-console-template for more information
using System.Linq;
using System.Xml.Linq;
using System.Xml;



Console.WriteLine("Hello, World!");

XDocument xDocument = new XDocument(

                new XDeclaration("1.0", "utf-8", "yes"),
                 new XComment("New XML Document"),
                 new XElement("Customers",
                 new XElement("Customer", new XAttribute("ID", "A-101"),
                 new XElement("First", "Samu"),
                 new XElement("Second", "Samu1"),
                 new XElement("State", "CTC")

                     ))
               );
xDocument.Save("Customers.xml");




