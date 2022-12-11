using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKreta
{
    class Menu
    {
        private static string[] menupontok = new string[] { "Értékelések", "Órarend", "Személyes adatok", "Kilépés"};
        private static int highlighted = 0;

        private static void drawMenu()
        {
            for (int i = 0; i < menupontok.Length; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - menupontok[i].Length / 2, i + 8);
                if (i == highlighted)
                {
                    Console.BackgroundColor = Settings.ForegroundColor;
                    Console.ForegroundColor = Settings.BackgroundColor;
                }

                Console.Write(menupontok[i]);

                Console.BackgroundColor = Settings.BackgroundColor;
                Console.ForegroundColor = Settings.ForegroundColor;
            }
        }

        public static State MenuInterface()
        {
            Console.Clear();
            Logo.DrawEkreta();
            drawMenu();

            ConsoleKey inputKey;
            while ((inputKey = Console.ReadKey(true).Key) != ConsoleKey.Enter)
            {
                switch (inputKey)
                {
                    case ConsoleKey.UpArrow:
                        highlighted = Math.Max(0, --highlighted);
                        break;
                    case ConsoleKey.DownArrow:
                        highlighted = Math.Min(menupontok.Length - 1, ++highlighted);
                        break;
                }
                drawMenu();
            }

            return new[]{ State.ERTEKELESEK, State.ORAREND, State.SZEMELYES_ADATOK, State.KILEPES}[highlighted];
        }
    }
}
