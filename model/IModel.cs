using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_HotelApp.model
{
    public abstract class Model<T>
    {
        public abstract T FromString(String data);

        public abstract String GetWrittableString();
    }
}
