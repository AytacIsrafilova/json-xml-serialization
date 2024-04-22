using Serialization.Model;
using System.Text.Json;
using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Serialization
{
    public  class Program
    {
        static void Main(string[] args)
        {
            //var book = new Book
            //{
            //    Name = "Satranc",
            //    Genre = "Klassika",
            //    Price = 5,
            //    Count = 10,
            //};

            //string json = JsonConvert.SerializeObject(book);

            //Console.WriteLine(json);






            //string json = "{\"Name\":\"Satranc\"," +
            //                "\"Genre\":\"Klassika\"," +
            //                "\"Price\":5," +
            //                "\"Count\":10}";

            //Book book = JsonConvert.DeserializeObject<Book>(json);


            //Console.WriteLine($"Name:{book.Name}");
            //Console.WriteLine($"Genre:{book.Genre}");
            //Console.WriteLine($"Price:{book.Price}");
            //Console.WriteLine($"Count:{book.Count}");











            //var person = new Person
            //{
            //    Name = "Filankes",
            //    Surname = "Filankesov",
            //    Age = 23,
            //    Profession = "Muhendis",
            //};

            //XmlSerializer serializer = new XmlSerializer(typeof(Person));

            //using (StringWriter writer = new StringWriter())
            //{
            //    serializer.Serialize(writer, person);
            //    string xml = writer.ToString();
            //    Console.WriteLine(xml);
            //}


            



            //string xml = "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
            //             "<Person>" +
            //             "<Name>Filankes</Name>" +
            //             "<Surname>Filankesov</Surname>" +
            //             "<Age>23</Age>" +
            //             "<Profession>Muhendis</Profession>>" +
            //             "</Person>";

            //XmlSerializer serializer = new XmlSerializer(typeof(Person));


            //using (StringReader reader = new StringReader(xml))
            //{
            //    Person person = (Person)serializer.Deserialize(reader);


            //    Console.WriteLine($"First Name: {person.Name}");
            //    Console.WriteLine($"Last Name: {person.Surname}");
            //    Console.WriteLine($"Age: {person.Age}");
            //    Console.WriteLine($"Email: {person.Profession}");
            //}




















            

            
            
        }
    }
    
}
