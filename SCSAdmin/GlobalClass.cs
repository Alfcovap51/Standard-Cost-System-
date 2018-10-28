using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCSAdmin
{
    class GlobalClass
    {
        private static string _company = "La Soledad";

        public static string company
        {
            get { return _company; }
            set { _company = value; }
        }


    }
}
