using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_HotelApp.model
{
    public class Room : IModel
    {
        private string _type;

        private int _bedCount;
        
        private double _price;

        private HashSet<Preference> _preferenceList;

        public Room(string type, int bedCount, int price)
        {
            _type = type;
            _bedCount = bedCount;
            _price = price;
            _preferenceList = new HashSet<Preference>();
        }

        public Room()
        {
            // TODO: Complete member initialization
        }

        public IModel fromString(string data)
        {
            string[] vals = data.Split('~');
            return new Room(vals[0], Int16.Parse(vals[1]), Int16.Parse(vals[2]));
        }

        public string toString()
        {
            return String.Join("~", _type, _bedCount.ToString(), _price.ToString());
        }
    }
}
