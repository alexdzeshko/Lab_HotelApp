using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_HotelApp.model
{
    abstract class Person : IModel
    {
        private string _name;

        private DateTime _birthDate;
    }
}
