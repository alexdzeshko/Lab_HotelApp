using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_HotelApp.model
{
    class Room : IModel
    {
        private string _type;

        private int _bedCount;
        
        private double _price;

        private HashSet<Preference> _preferenceList;
    }
}
