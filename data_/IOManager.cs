using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_HotelApp.data_
{
    class IOManager
    {

        private const string DIR = "data";

        public static void createFile(String name)
        {
            if (!File.Exists(name))
            {
                File.Create(name);
            }

        }

        public static String readFile(String name)
        {
            return File.ReadAllText(name, Encoding.UTF8);
        }

        public static void updateFile(String name, String data)
        {
            if (!File.Exists(name))
            {
                File.WriteAllText(name, data, Encoding.UTF8);
            }
        }
        public static void deleteFile(String name)
        {
            if (!File.Exists(name))
            {
                File.Delete(name);
            }
        }

    }
}
