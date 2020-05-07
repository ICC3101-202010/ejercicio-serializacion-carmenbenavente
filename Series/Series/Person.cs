using System;
using System.Collections.Generic;
using System.Text;

namespace Series
{
    public class Person
    {
        string Name;
        string LastName;
        string Age;

        public string Name1 { get => Name; set => Name = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public string Age1 { get => Age; set => Age = value; }

        Person(string name, string lastname, string age)
        {
            name = Name;
            lastname = LastName;
            age = Age;
        }
    }
}
