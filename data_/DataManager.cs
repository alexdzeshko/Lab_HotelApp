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
        
        private static volatile DataManager instance;
        private static object syncRoot = new Object();

        private DataManager() {}

        public static DataManager Instance
        {
            get 
            {
                if (instance == null) 
                {
                    lock (syncRoot) 
                    {
                        if (instance == null) 
                            instance = new DataManager();
                    }
                }

                return instance;
            }
        }

        public static string Hotel1 = "0~Hotel_1~Grodno~0~0";
        public static string Hotel2 = "1~Hotel_2~Minsk~0~0";
        public static string Hotel3 = "2~Hotel_3~Minsk~0~0";
        public static string Hotel4 = "3~Hotel_4~Grodno~0~0";

        public static string[] MockHotels = { Hotel1, Hotel2, Hotel3, Hotel4 };


        public List<Hotel> getMockHotels()
        {
            List<Hotel> hotels = new List<Hotel>();
            foreach (string h in MockHotels)
            {
                Hotel hotel = new Hotel();
                hotel = (Hotel)hotel.fromString(h);
                hotels.Add(hotel);
            }
            return hotels;
        }

        public List<Hotel> getHotels()
        {

            IOManager.readFile("hotel.txt");
            //TODO
            return new List<Hotel>();
        }
    }
}
