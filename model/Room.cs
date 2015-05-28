using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab_HotelApp.model
{
    public class Room : Model<Room>
    {

        public Room(int id, string type, int bedCount, int price)
        {
            ID = id;
            Type = type;
            BedCount = bedCount;
            Price = price;
            Preferences = new List<Preference>();
        }

        public Room()
        {
            // TODO: Complete member initialization
        }

        public override Room FromString(string data)
        {
            string[] vals = data.Split('~');
            Room room = new Room(Int32.Parse(vals[0]), vals[1], Int32.Parse(vals[2]), Int32.Parse(vals[3]));  
            room.Preferences = Preference.FromString(vals[4]);
            return room;
        }

        public override string GetWrittableString()
        {
            return String.Join("~", ID, Type, BedCount.ToString(), Price.ToString(), Preference.GetWrittableString(Preferences));
        }

        public string Type { get; set; }

        public int BedCount { get; set; }

        public double Price { get; set; }

        public void AddPreference(Preference preference)
        {
            Preferences.Add(preference);
        }

        [XmlElement("Preference")]
        public List<Preference> Preferences { get; set; }
    }
}
