using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKreta
{
    class Program
    {
        static void Main(string[] args)
        {
            // Engedélyezzük az UTF-8-as karakterek kiíratását a konzolban
            Console.OutputEncoding = Encoding.UTF8;
            Console.CursorVisible = false;

            // 130 x 40
            //Console.SetWindowSize(145, 40);

            //Logo.DrawEkreta();
            State state = State.BELEPES;
            User user;

            Console.BackgroundColor = Settings.BackgroundColor;
            Console.ForegroundColor = Settings.ForegroundColor;

            while (true)
            {
                switch (state) {
                    case State.BELEPES:
                        user = Login.LoginInterface();
                        state = State.MENU;
                        break;
                    case State.MENU:
                        state = Menu.MenuInterface();
                        break;
                    case State.ERTEKELESEK:
                        Console.Clear();
                        Console.Write("Értékelések");
                        Console.ReadKey();
                        state = State.MENU;
                        break;
                    case State.ORAREND:
                        Console.Clear();
                        Console.Write("Órarend");
                        Console.ReadKey();
                        state = State.MENU;
                        break;
                    case State.SZEMELYES_ADATOK:
                        Console.Clear();
                        Console.Write("Személyes adatok");
                        Console.ReadKey();
                        state = State.MENU;
                        break;
                    case State.KILEPES:
                        Environment.Exit(0);
                        break;
                }

            }
            
        }
    }
}
