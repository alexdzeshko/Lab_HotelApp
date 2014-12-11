using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_HotelApp.model
{
    public abstract class Person : IModel
    {
        private string _name;

        private DateTime _birthDate;

        public Person(string name, DateTime birthDate)
        {
            _name = name;
            _birthDate = birthDate;
        }

        public string Name { get; set; }
        public DateTime BirthDay { get; set; }

        public abstract IModel fromString(string data);

        public string toString()
        {
            return String.Join("~", _name, _birthDate);
        }
    }
}
