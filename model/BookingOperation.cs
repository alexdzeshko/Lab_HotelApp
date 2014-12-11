using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_HotelApp.model
{
    public class BookingOperation : IModel
    {
        private Hotel mHotel;
        private Customer mCustomer;
        private List<Room> mRoomList;
        private int mGuestCount;

        public BookingOperation()
        {

        }

        public IModel fromString(string data)
        {
            string[] vals = data.Split('~');
            //todo
            return new BookingOperation();
        }

        public string toString()
        {
            return String.Join("~", mHotel.ID, mCustomer.Name, mGuestCount);
        }
    }
    
}
