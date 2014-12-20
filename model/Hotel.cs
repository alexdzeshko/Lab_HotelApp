using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_HotelApp.model
{
    public class Hotel : Model<Hotel>
    {

        public Hotel(int id, String name, String adress, List<int> rooms) {
            ID = id;
            Name = name;
            Adress = adress;

            Rooms = rooms;
        }

        public Hotel()
        {
            // TODO: Complete member initialization
        }

        public Hotel(String name, String adress)
        {
            Name = name;
            Adress = adress;
            Rooms = new List<int>();
        }

        public string Name { get; set; }

        public string Adress { get; set; }

        public List<int> Rooms { get; set; }

        public string About { get; set; }

        public override Hotel FromString(string data)
        {
            if (data == null)
            {
                return null;
            }
            string[] d = data.Split('~');
            int id = Int32.Parse(d[0]);

            List<int> rooms = new List<int>();
            foreach (string rid in d[4].Split(','))
            {
                if(!String.IsNullOrEmpty(rid)) rooms.Add(Int32.Parse(rid));
            }

            Hotel hotel = new Hotel(id, d[1], d[2], rooms);
            hotel.About = d[3];
            return hotel;
        }

        public override string GetWrittableString()
        {
            return String.Join("~", ID, Name, Adress, About, RoomIdsString());
        }

        private string RoomIdsString()
        {
            string result = "";
            if (Rooms.Count > 0)
            {
                foreach (int id in Rooms)
                {
                    result += id.ToString() + ",";
                }
                result = result.Substring(0, result.Length - 1);
            }
            return result;
        }
        public override string ToString() {
            return String.Join(" : ", Name, Adress, "rooms = " + Rooms.Count);
        }

    }
}
