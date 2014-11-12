using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_HotelApp.model
{
    class Hotel : IModel
    {
        private string mName, mAdress;

        private List<Room> mRoomList;

        private HashSet<Preference> mPreferenceList;
    }
}
