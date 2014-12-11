using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_HotelApp.model
{
    public class Hotel : IModel
    {
        private int _ID;
        private string _Name;
        private string _Adress;
        private List<Room> _Rooms;
        private List<Preference> _Preferences;

        public Hotel(int id, String name, String adress, List<Room> rooms, List<Preference> preferences) {
            Name = name;
            Adress = adress;

            Rooms = rooms;
            Preferences = preferences;
        }

        public Hotel()
        {
            
            // TODO: Complete member initialization
        }


        public int ID
        {
            //set the person name
            set { this._ID = value; }
            //get the person name 
            get { return this._ID; }
        }

        public string Name
        {
            //set the person name
            set { this._Name = value; }
            //get the person name 
            get { return this._Name; }
        }

        public string Adress
        {
            //set the adress
            set { this._Adress = value; }
            //get the adress 
            get { return this._Adress; }
        }

        public List<Room> Rooms
        {
            //set the adress
            set { this._Rooms = value; }
            //get the adress 
            get { return this._Rooms; }
        }

        public List<Preference> Preferences
        {
            //set the adress
            set { this._Preferences = value; }
            //get the adress 
            get { return this._Preferences; }
        }



        public IModel fromString(string data)
        {
            string[] d = data.Split('~');
            return new Hotel(Int16.Parse(d[0]), d[1], d[2], new List<Room>(), new List<Preference>());
        }

        public string toString()
        {
             
            return String.Empty;
        }

        public override string ToString() {
            return String.Join(" : ", _Name, _Adress, "rooms = " + _Rooms.Count, getPreferenceString());
        }

        private object getPreferenceString()
        {
            string s = "";
            foreach (Preference p in Preferences)
            {
                s += p.Value+", ";
            }
            return s;
        }
    }
}
