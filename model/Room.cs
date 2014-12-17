using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_HotelApp.model
{
    public class Room : Model<Room>
    {
        private HashSet<Preference> _preferenceList;

        public Room(string type, int bedCount, int price)
        {
            Type = type;
            BedCount = bedCount;
            Price = price;
            _preferenceList = new HashSet<Preference>();
        }

        public Room()
        {
            // TODO: Complete member initialization
        }

        public override Room FromString(string data)
        {
            string[] vals = data.Split('~');
            return new Room(vals[0], Int16.Parse(vals[1]), Int16.Parse(vals[2]));
        }

        public override string GetWrittableString()
        {
            return String.Join("~", Type, BedCount.ToString(), Price.ToString());
        }

        public string Type { get; set; }

        public int BedCount { get; set; }

        public double Price { get; set; }

        public void AddPreference(Preference preference)
        {
            _preferenceList.Add(preference);
        }

        public HashSet<Preference> Preferences { 
            get { return this._preferenceList; }

            set { this._preferenceList = value; } 
        }
    }
}
