using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKreta
{
    class User
    {
        private string username;
        private string password;
        private string ist;

        private string userAgent = "hu.ekreta.student/1.0.5/Android/0/0";
        private string clientID = "kreta-ellenorzo-mobile-android";

        private string bearer;

        public User(string username, string password, string ist)
        {
            this.username = username;
            this.password = password;
            this.ist = ist;
        }
    }
}
