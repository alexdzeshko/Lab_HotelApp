using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_HotelApp.model
{
    public class BookingOperation : Model<BookingOperation>
    {

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
            return String.Join("~", Hotel.ID, Customer.Name, GuestCount);
        }

        public Hotel Hotel { get; set; }
        public Customer Customer { get; set; }
        public List<Room> RoomList { get; set; }
        public int GuestCount { get; set; }
    }
    
}
