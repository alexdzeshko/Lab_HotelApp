using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_HotelApp.model
{
    public abstract class Person : Model<Person>
    {

        public Person(string name, DateTime birthDate)
        {
            Name = name;
            BirthDay = birthDate;
        }

        public string Name { get; set; }
        public DateTime BirthDay { get; set; }

        public override string GetWrittableString()
        {
            return String.Join("~", Name, BirthDay);
        }
    }
}
