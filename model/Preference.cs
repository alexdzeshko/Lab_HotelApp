using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_HotelApp.model
{
    class Preference
    {
        private String _Value;

        public Preference(String value)
        {
            this._Value = value;
        }

        public string Value {
            get { return this._Value; }
        }
    }
}
