using Lab_HotelApp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_HotelApp.data_
{
    public class DataManager
    {
        //todo singleton

        public List<Hotel> getHotel()
        {

            IOManager.readFile("hotel.txt");
        }
    }
}
