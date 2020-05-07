using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace Series
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select an option: \n 1.Create person \n 2. See registerd people \n 3. Save data \n 4. Upload data ");

            string r,n,l,a,t;
            List<Person> list = new List<Person>();
            r = Console.ReadLine();
            if (r== "1")
            {
                Console.WriteLine("Enter Name");
                n = Console.ReadLine();
                Console.WriteLine("Enter Lastame");
                l = Console.ReadLine();
                Console.WriteLine("Enter Age");
                a = Console.ReadLine();
                Person p = new Person(n, l, a);
                list.Add(p);
            }
            else if (r == "2")
            {
                foreach (Person j in list)
                {
                    t = j.Name1 + j.LastName1 + j.Age1;
                    Console.WriteLine(t);
                }
            }
            else if (r == "3")
            {
                foreach (Person j in list)
                {
                    IFormatter formatter = new SoapFormatter();
                    Stream stream = new FileStream("People.soap", FileMode.Create, FileAccess.Write, FileShare.None);
                    formatter.Serialize(stream, j);
                    stream.Close();
                }
            }
            else if (r == "4")
            {
                IFormatter formatter = new SoapFormatter();
                Stream stream = new FileStream("People.soap", FileMode.Open, FileAccess.Read, FileShare.Read);
                Person obj = Person.formatter.Deserialize(stream);
                stream.Close();
            }
        }
    }
}
