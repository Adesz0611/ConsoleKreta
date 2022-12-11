using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKreta
{
    class Logo
    {
        public static void DrawEkreta()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - 16, 1);
            Console.Write("        __ __       __  __");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 16, 2);
            Console.Write("  ___  / //_/______/_/ / /_____ _");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 16, 3);
            Console.Write(" / _ \\/ ,<  / ___/ _ \\/ __/ __ `/");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 16, 4);
            Console.Write("/  __/ /| |/ /  /  __/ /_/ /_/ /");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 16, 5);
            Console.Write("\\___/_/ |_/_/   \\___/\\__/\\__,_/");
        }

        public static void DrawBelepes()
        {
            // 37
            Console.SetCursorPosition(Console.WindowWidth / 2 - 18, 1);
            Console.Write("    ____       __ __         __");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 18, 2);
            Console.Write("   / __ )___  / //_/ ____  _/_/ _____");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 18, 3);
            Console.Write("  / __  / _ \\/ / _ \\/ __ \\/ _ \\/ ___/");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 18, 4);
            Console.Write(" / /_/ /  __/ /  __/ /_/ /  __(__  )");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 18, 5);
            Console.Write("/_____/\\___/_/\\___/ .___/\\___/____/");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 18, 6);
            Console.Write("                 /_/");
        }
    }
}