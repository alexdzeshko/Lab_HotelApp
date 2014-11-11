using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_HotelApp.model
{
    class BookingOperation : IModel
    {
        private Hotel mHotel;
        private Customer mCustomer;
        private List<Room> mRoomList;
        private int mGuestCount;
    }
}
