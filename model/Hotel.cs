﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_HotelApp.model
{
    public class Hotel : Model<Hotel>
    {
        private int _ID;
        private string _Name;
        private string _Adress;
        private List<Room> _Rooms;
        private List<Preference> _Preferences;

        public Hotel(int id, String name, String adress, List<Room> rooms, List<Preference> preferences) {
            ID = id;
            Name = name;
            Adress = adress;

            Rooms = rooms;
            Preferences = preferences;
        }

        public Hotel()
        {
            
            // TODO: Complete member initialization
        }
        public Hotel(String name, String adress)
        {
            Name = name;
            Adress = adress;
            Rooms = new List<Room>();
            Preferences = new List<Preference>();
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



        public override Hotel FromString(string data)
        {
            if (data == null)
            {
                return null;
            }
            string[] d = data.Split('~');
            int id = Int32.Parse(d[0]);
            return new Hotel(id, d[1], d[2], new List<Room>(), new List<Preference>());
        }

        public override string GetWrittableString()
        {
             
            return String.Join("~", ID, Name, Adress);
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
