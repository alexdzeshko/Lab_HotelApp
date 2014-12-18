using Lab_HotelApp.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_HotelApp.data_
{
    public class DataManager
    {
        
        private static volatile DataManager instance;
        private static object syncRoot = new Object();

        private List<Hotel> _hotels;

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

        public static Hotel DEFAULT_HOTEL = new Hotel().FromString(Hotel1);

        public List<Hotel> getMockHotels()
        {
            if (_hotels == null)
            {
                _hotels = new List<Hotel>();
            }
            if (_hotels.Count == 0)
            {
                foreach (string h in MockHotels)
                {
                    Hotel hotel = new Hotel().FromString(h);
                    _hotels.Add(hotel);
                }
            }
            return _hotels;
        }

        public void AddHotel(Hotel hotel)
        {
            if (hotel != null)
            {
                hotel.ID = GetNewHotelId();
                IOManager.updateFile(IOManager.DIR_HOTELS, hotel.ID.ToString(), hotel.GetWrittableString());
            }
            
        }

        public List<Hotel> GetHotels()
        {
            List<Hotel> result = new List<Hotel>();
            foreach (string fileName in IOManager.GetFiles(IOManager.DIR_HOTELS))
            {
                string hotelData = IOManager.ReadFile(fileName);
                Hotel hotel = new Hotel().FromString(hotelData);
                result.Add(hotel);
            }
            //TODO
            return result;
        }

        private int GetNewHotelId()
        {
            int result = 0;
            string[] files = IOManager.GetFiles(IOManager.DIR_HOTELS);
            if (files.Length > 0)
            {
                result = Int32.Parse(Path.GetFileNameWithoutExtension(files[files.Length-1]))+1;
            }
            return result;
        }

        public static void DeleteHotel(Hotel hotel)
        {
            IOManager.deleteFile(IOManager.DIR_HOTELS, hotel.ID.ToString());
        }

        internal static void UpdateHotel(Hotel hotel)
        {
            IOManager.updateFile(IOManager.DIR_HOTELS, hotel.ID.ToString(), hotel.GetWrittableString());
        }
    }
}
