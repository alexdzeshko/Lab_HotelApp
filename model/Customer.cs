using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_HotelApp.model
{
    class Customer : Person
    {
        private string _email;
        private string _ccNumber;
        private string _ccHolderName;

        public Customer(string name, DateTime bday, string email, string ccNumber, string ccHolder)
            : base(name, bday)
        {
            _email = email;
            _ccNumber = ccNumber;
            _ccHolderName = ccHolder;
        }
        public string Email { get; set; }
        public string CcNumber { get; set; }
        public string CcHolderName { get; set; }

        public override IModel fromString(string data)
        {
            return null;
        }
    }
}
