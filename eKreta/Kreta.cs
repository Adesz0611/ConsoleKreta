using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKreta
{
    class Kreta
    {
        public static string Base(string ist)
        {
            return $"https://{ist}.ekreta.hu";
        }

        public static string IDP = "https://idp.e-kreta.hu";
    }
}
