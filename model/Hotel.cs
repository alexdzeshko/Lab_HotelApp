using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_HotelApp.model
{
    class Hotel : IModel
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
    }
}
