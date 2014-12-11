using Lab_HotelApp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_HotelApp.console
{
    class ConsoleHandler
    {
        class Command
        {
            public static readonly Command HELP= new Command("Help","-h");
            public static readonly Command SHOW_HOTELS= new Command("Show hotels","-sh");
            public static readonly Command OPEN_HOTEL= new Command("Open hotel","-oh");
            public static readonly Command ADD_HOTEL= new Command("Add hotel","-ah");
            public static readonly Command DEL_HOTEL= new Command("Delete hotel","-dh");
            public static readonly Command UPD_PARAM= new Command("Update param","-upd");

            public static Command[] commandList = { HELP, SHOW_HOTELS, OPEN_HOTEL, ADD_HOTEL, DEL_HOTEL, UPD_PARAM };

            public string _name, _commandName;

            private Command(String name, string commandName) {
                _name = name;
                _commandName = commandName;
            }
        }

        class Data
        {
            public static string Hotel1 = "0~Hotel_1~Grodno~0~0";
            public static string Hotel2 = "1~Hotel_2~Minsk~0~0";
            public static string Hotel3 = "2~Hotel_3~Minsk~0~0";
            public static string Hotel4 = "3~Hotel_4~Grodno~0~0";

            public static string[] Hotels = { Hotel1, Hotel2, Hotel3, Hotel4};
        }

        public static string ProcessInput(string[] args)
        {
            string command = args[0];
            string result = "";
            if (command.Equals(Command.HELP._commandName))
            {
                foreach (string h in Data.Hotels) {
                    Hotel hotel = (Hotel)new Hotel().fromString(h);
                    //result+=hotel.toString();
                    result+=h;
                    result+="\n";
                }
            
            }
            return result;
        }
    }
}
