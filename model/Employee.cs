using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_HotelApp.model
{
    class Employee : Person, IEmployeeOperation
    {
        private string _rank;
        private string _salary;

        public Employee(string name, DateTime bday, string rank, string salary)
            : base(name, bday)
        {
            _rank = rank;
            _salary = salary;
        }

        public string Rank { get; set; }
        public string Salary { get; set; }

        public override IModel fromString(string data)
        {
            return null;
        }
    }
}
