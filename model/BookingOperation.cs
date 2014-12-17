using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_HotelApp.model
{
    public class BookingOperation : Model<BookingOperation>
    {
        private Hotel _hotel;
        private Customer _customer;
        private List<Room> mRoomList;
        private int mGuestCount;

        public BookingOperation()
        {

        }

        public override BookingOperation FromString(string data)
        {
            string[] vals = data.Split('~');
            //todo
            return new BookingOperation();
        }

        public override string GetWrittableString()
        {
            return String.Join("~", _hotel.ID, _customer.Name, mGuestCount);
        }
    }
    
}
