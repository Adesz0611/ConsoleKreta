using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKreta.Form
{
    class TextBox
    {
        private string data;
        private int cursorPos;
        private int x, y;

        public TextBox(int p_x, int p_y, string p_data = "veszc-ipari")
        {
            x = p_x;
            y = p_y;
            data = p_data;
        }

        public void focus()
        {
            cursorPos = 0;
            ConsoleKeyInfo key;
            while ((key = Console.ReadKey(true)).Key != ConsoleKey.Tab)
            {
                if (key.Key == ConsoleKey.Backspace) {
                    if (cursorPos <= 0) continue;

                    Console.SetCursorPosition(x + cursorPos - 1, y);
                    Console.Write(" ");
                    Console.SetCursorPosition(x + --cursorPos, y);

                    /* Ilyen egy szar programozási nyelvet, hogy minden egyes string műveletnél
                     * új memóriát kell foglalnia ennek az okádéknak :<
                     */
                    data = data.Remove(data.Length - 1);

                    continue;
                }

                
                Console.SetCursorPosition(x + cursorPos++, y);
                Console.Write(key.KeyChar);
                data += key.KeyChar;
            }
        }
    }
}
