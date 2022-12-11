using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKreta.Form
{
    class TextBox
    {
        public string data;
        private int cursorPos;
        private int x, y;
        private bool is_pwd;

        public TextBox(int p_x, int p_y, bool p_is_pwd = false, string p_data = "")
        {
            x = p_x;
            y = p_y;
            data = p_data;
            is_pwd = p_is_pwd;

            Console.SetCursorPosition(x, y);
            Console.Write(data);
        }

        public void focus()
        {
            cursorPos = 0;
            Console.SetCursorPosition(x, y);

            bool consoleDirty = (data.Length > 0);

            ConsoleKeyInfo key;
            while ((key = Console.ReadKey(true)).Key != ConsoleKey.Tab)
            {
                if (consoleDirty) {
                    for (int i = 0; i < data.Length; i++) {
                        Console.SetCursorPosition(x + i, y);
                        Console.Write(" ");
                    }

                    Console.SetCursorPosition(x, y);
                    data = "";
                    consoleDirty = false;
                }

                if (key.Key == ConsoleKey.Backspace) {
                    if (cursorPos <= 0) continue;

                    Console.SetCursorPosition(x + cursorPos - 1, y);
                    Console.Write(" ");
                    Console.SetCursorPosition(x + --cursorPos, y);

                    data = data.Remove(data.Length - 1);

                    continue;
                }

                
                Console.SetCursorPosition(x + cursorPos++, y);
                Console.Write(is_pwd ? '*' : key.KeyChar);
                data += key.KeyChar;
            }
        }
    }
}
