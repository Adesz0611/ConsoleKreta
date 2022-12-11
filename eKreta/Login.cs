using System;
using eKreta.Form;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKreta
{
    class Login
    {
        private static string[] labels = new string[] { "Felhasználónév:", "Jelszó:", "IST:" };
        private static List<TextBox> textboxes = new List<TextBox>();

        public static User LoginInterface()
        {
            string username = "", password = "", ist = "";

            Console.Clear();
            Logo.DrawBelepes();

            PrintLabels();
            Console.CursorVisible = true;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 12, 8);

            //Console.ReadKey(true);
            TextBox t = new TextBox(Console.WindowWidth / 2 - 12, 8);
            t.focus();

            return new User(username, password, ist);
        }

        private static void PrintLabels() {
            int i = 6;
            foreach (var label in labels) {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 13 - label.Length, i += 2);
                Console.Write(label);
            }
        }
    }
}
