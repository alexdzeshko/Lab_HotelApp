using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_HotelApp.model
{
    class Employee : Person, IEmployeeOperation
    {

        public Employee(string name, DateTime bday, string rank, string salary)
            : base(name, bday)
        {
            Rank = rank;
            Salary = salary;
        }

        public string Rank { get; set; }
        public string Salary { get; set; }

        public override Person FromString(string data)
        {
            return null;
        }
    }
}
