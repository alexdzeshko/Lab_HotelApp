using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_HotelApp.model
{
    public class Preference
    {
        private String _Value;

        public Preference()
        {

        }

        public Preference(String value)
        {
            this._Value = value;
        }

        public string Value {
            get { return this._Value; }
        }

        public static List<Preference> FromString(String data)
        {
            List<Preference> result = new List<Preference>();
            foreach(string p in data.Split(',')) {
                result.Add(new Preference(p));
            }
            return result;
        }

        public static string GetWrittableString(List<Preference> prefs)
        {
            string result = "";
            if (prefs.Count > 0)
            {
                foreach (Preference p in prefs)
                {
                    result += p.Value + ",";
                }
                result = result.Substring(0, result.Length - 1);
            }
            return result;
        }
    }
}
