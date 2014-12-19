using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_HotelApp.model
{
    public class Customer : Person
    {

        public Customer(string name, DateTime bday, string email, string ccNumber, string ccHolder)
            : base(name, bday)
        {
            Email = email;
            CcNumber = ccNumber;
            CcNumber = ccHolder;
        }
        public string Email { get; set; }
        public string CcNumber { get; set; }
        public string CcHolderName { get; set; }

        public override Person FromString(string data)
        {
            return null;//TODO:
        }
    }
}
