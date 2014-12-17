using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_HotelApp.data_
{
    public class IOManager
    {
        private static string SEP = "\\";
        private static string WORK_DIR = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        private static string DIR = WORK_DIR + SEP + "data";
        public static string DIR_HOTELS = DIR + SEP + "hotels";
        public static string DIR_ROOMS = DIR + SEP + "rooms";
        public static string DIR_BOOKINGS = DIR + SEP + "bookings";

        public static void createFile(string dir, string name)
        {
            if (!File.Exists(name))
            {
                File.Create(name).Close();
            }

        }

        public static String readFile(string dir, string name)
        {
            string path = GetPath(dir, name);
            if (!File.Exists(path))
            {
                return null;
            }
            return File.ReadAllText(name, Encoding.UTF8);
        }

        private static string GetPath(string dir, string name)
        {
            return String.Join(SEP, dir, name);
        }

        public static void updateFile(string dir, string name, string data)
        {
            string path = GetPath(dir, name);
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            File.WriteAllText(path, data, Encoding.UTF8);
        }

        public static void deleteFile(string dir, string name)
        {
            string path = GetPath(dir, name);
            if (!File.Exists(path))
            {
                File.Delete(path);
            }
        }

        public static string[] GetFiles(string dir)
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            return Directory.GetFiles(dir);
        }
    }
}
