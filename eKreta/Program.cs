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

            Logo.DrawBelepes();
            while (true)
            {
                switch (state) {
                    case State.BELEPES:
                        user = Login.LoginInterface();
                        Console.Clear();
                        Console.SetCursorPosition(0, 0);
                        user.Print();
                        Console.ReadKey();
                        break;
                }

            }
            
        }
    }
}
