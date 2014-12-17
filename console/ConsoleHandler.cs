using Lab_HotelApp.data_;
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
        public static string HELP = "'-sh' for show all hotels, \n '-oh {hotel name}' to view hotel info, \n '-ah {[hotel name]|[adress]|[preferences]}' to create new hotel"+
            "'-dh {hotel name}' to delete hotel, \n '-upd {hotel name} {param} {value}'";

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

        public static string ProcessInput(string[] args)
        {
            if (args.Length == 0)
            {
                return "Empty args";
            }
            string command = args[0];
            string result = "";
            if (command.Equals(Command.HELP._commandName))
            {
                result = HELP;
            } 
            else if(Command.SHOW_HOTELS._commandName.Equals(command))
            {
                foreach (Hotel h in DataManager.Instance.GetHotels()) {
                    
                    result+=h.ToString();
                    result+="\n";
                }

            }
            else if (Command.ADD_HOTEL._commandName.Equals(command))
            {
                //foreach (Hotel h in DataManager.Instance.AddHotel(DataManager.DEFAULT_HOTEL))
                //{
                //    result += h.ToString();
                //    result += "\n";
                //}

            }
            else
            {
                result = "invalid command";
            }
            return result;
        }
    }
}
