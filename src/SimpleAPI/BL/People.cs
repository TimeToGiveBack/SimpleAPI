using System;
using SimpleAPI;
using System.Collections.Generic;

namespace SimpleAPI
{
    public class People
    {
        
        public List<Person> GetMockList()
        {
            var people = new List<Person>();
            people.Add(new Person{FirsName ="Keagen", LastName = "Reddy", Region = "SA"});
            people.Add(new Person{FirsName ="Barry", LastName = "Ahern", Region = "SA"});
            people.Add(new Person{FirsName ="Ivan", LastName = "van den Bergh", Region = "SA"});
            people.Add(new Person{FirsName ="Paul", LastName = "Steinrisser", Region = "EU"});
            people.Add(new Person{FirsName ="Reinhard", LastName = "Schrei", Region = "EU"});
            //people.Add(new Person{FirsName ="Dave", LastName = "Shepherd", Region = "SA"});

            return people;

        }
    }
}