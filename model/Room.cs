using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_HotelApp.model
{
    class Room : IModel
    {
        private string mType;

        private int mBedCount;
        
        private double mPrice;

        private HashSet<Preference> mPreferenceList;
    }
}
