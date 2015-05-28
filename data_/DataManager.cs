using Lab_HotelApp.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;


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

        public static string Hotel1 = "0~Hotel_1~Grodno~Lorem Ipsum~";
        public static string Hotel2 = "1~Hotel_2~Minsk~0~0";
        public static string Hotel3 = "2~Hotel_3~Minsk~0~0";
        public static string Hotel4 = "3~Hotel_4~Grodno~0~0";

        public static string[] MockHotels = { Hotel1, Hotel2, Hotel3, Hotel4 };

        public static Hotel DEFAULT_HOTEL = new Hotel().FromString(Hotel1);
        public static Room DEFAULT_ROOM = new Room(0, "Basic room", 1, 10);

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
                IOManager.updateFile(IOManager.DIR_HOTELS, hotel.ID.ToString(), SerializeObject(hotel));
            }
            
        }

        
            private string SerializeObject<T>(T toSerialize)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(toSerialize.GetType());

                using (StringWriter textWriter = new StringWriter())
                {
                    xmlSerializer.Serialize(textWriter, toSerialize);
                    return textWriter.ToString();
                }
            }

            public T DeserializeFromString<T>(string objectData)
            {
                return (T)DeserializeFromString(objectData, typeof(T));
            }

            public object DeserializeFromString(string objectData, Type type)
            {
                var serializer = new XmlSerializer(type);
                object result;

                using (TextReader reader = new StringReader(objectData))
                {
                    result = serializer.Deserialize(reader);
                }

                return result;
            }
        
        

        public List<Hotel> GetHotels()
        {
            List<Hotel> result = new List<Hotel>();
            foreach (string fileName in IOManager.GetFiles(IOManager.DIR_HOTELS))
            {
                string hotelData = IOManager.ReadFile(fileName);
                Hotel hotel = DeserializeFromString<Hotel>(hotelData);//new Hotel().FromString(hotelData);
                result.Add(hotel);
            }
            //TODO
            Thread.Sleep(1000);
            return result;
        }

        public Task<List<Hotel>> GetHotelsAsync()
        {
            return Task.Factory.StartNew<List<Hotel>>(() => GetHotels());
        }

        public int GetNewHotelId()
        {
            return GetNewID(IOManager.DIR_HOTELS);
        }

        public int GetNewRoomId()
        {
            return GetNewID(IOManager.DIR_ROOMS);
        }

        private int GetNewID(string dir)
        {
            int result = 0;
            string[] files = IOManager.GetFiles(dir);
            if (files.Length > 0)
            {
                result = Int32.Parse(Path.GetFileNameWithoutExtension(files[files.Length - 1])) + 1;
            }
            return result;
        }

        public void DeleteHotel(Hotel hotel)
        {
            IOManager.deleteFile(IOManager.DIR_HOTELS, hotel.ID.ToString());
            Thread.Sleep(1000);
        }

        internal void UpdateHotel(Hotel hotel)
        {
            IOManager.updateFile(IOManager.DIR_HOTELS, hotel.ID.ToString(), SerializeObject(hotel)//hotel.GetWrittableString()
                );
            Thread.Sleep(1000);
        }

        internal Task UpdateHotelAsync(Hotel hotel)
        {
            return Task.Factory.StartNew(()=> UpdateHotel(hotel));
        }

        public List<Room> GetRooms(Hotel hotel)
        {
            List<Room> result = new List<Room>();
            foreach (int rid in hotel.Rooms)
            {
                string data = IOManager.ReadFile(IOManager.DIR_ROOMS, rid.ToString());
                if (!String.IsNullOrEmpty(data))
                {
                    Room room = DeserializeFromString<Room>(data);
                    result.Add(room);
                }
            }
            return result;
        }

        public Task<List<Room>> GetRoomsAsync(Hotel hotel)
        {
            return Task.Factory.StartNew<List<Room>>(() => GetRooms(hotel));
        }

        internal void UpdateRoom(Room room)
        {
            IOManager.updateFile(IOManager.DIR_ROOMS, room.ID.ToString(), SerializeObject(room));
            Thread.Sleep(1000);
        }

        internal Task UpdateRoomAsync(Room room)
        {
            return Task.Factory.StartNew(() => UpdateRoom(room));
        }
    }
}
