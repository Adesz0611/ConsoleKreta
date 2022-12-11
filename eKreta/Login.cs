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

        private static void prepare()
        {
            textboxes.Add(new TextBox(Console.WindowWidth / 2 - 12, 8));
            textboxes.Add(new TextBox(Console.WindowWidth / 2 - 12, 10, true));
            textboxes.Add(new TextBox(Console.WindowWidth / 2 - 12, 12, false, "veszc-ipari"));

            Console.SetCursorPosition(Console.WindowWidth / 2, 14);
            Console.Write("Belépés");
        }

        public static User LoginInterface()
        {
            Console.Clear();
            Logo.DrawBelepes();

            PrintLabels();
            Console.CursorVisible = true;

            prepare();

            int i = 0;
            while (true) {
                if (i == 3) {
                    if (buttonFocus())
                        return new User(textboxes[0].data, textboxes[1].data, textboxes[2].data);
                }
                else {
                    textboxes[i].focus();
                }
                
                if (i++ == textboxes.Count) i = 0;
            }
        }

        private static void PrintLabels() {
            int i = 6;
            foreach (var label in labels) {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 13 - label.Length, i += 2);
                Console.Write(label);
            }
        }

        private static bool buttonFocus()
        {
            bool clicked = false;

            Console.CursorVisible = false;
            Console.SetCursorPosition(Console.WindowWidth / 2, 14);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Belépés");
            ConsoleKeyInfo k;
            while ((k = Console.ReadKey(true)).Key != ConsoleKey.Tab)
                if (k.Key == ConsoleKey.Enter)
                {
                    clicked = true;
                    break;
                }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            if (clicked) return true;

            Console.SetCursorPosition(Console.WindowWidth / 2, 14);
            Console.Write("Belépés");
            Console.CursorVisible = true;

            return false;
        }
    }
}
