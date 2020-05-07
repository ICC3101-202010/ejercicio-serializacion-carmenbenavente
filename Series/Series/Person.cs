using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.IO;


namespace Series
{
    [Serializable]
    public class Person
    {
        string Name;
        string LastName;
        string Age;

        public string Name1 { get => Name; set => Name = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public string Age1 { get => Age; set => Age = value; }

        public Person(string name, string lastname, string age)
        {
            Name = name;
            LastName = lastname;
            Age = age;
        }
    }
}
