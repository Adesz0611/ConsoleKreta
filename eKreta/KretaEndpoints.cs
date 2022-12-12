using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKreta
{
    class KretaEndpoints
    {
        public static string token = "/connect/token";
        public static string nonce = "/nonce";
        public static string notes = "/ellenorzo/V3/Sajat/Feljegyzesek";
        public static string events = "/ellenorzo/V3/Sajat/FaliujsagElemek";
        public static string student = "/ellenorzo/V3/Sajat/TanuloAdatlap";
        public static string evaluations = "/ellenorzo/V3/Sajat/Ertekelesek";
        public static string absences = "/ellenorzo/V3/Sajat/Mulasztasok";
        public static string groups = "/ellenorzo/V3/Sajat/OsztalyCsoportok";
        public static string classAverages = "/V3/Sajat/Ertekelesek/Atlagok/OsztalyAtlagok";
        public static string timetable = "/ellenorzo/V3/Sajat/OrarendElemek";
        public static string announcedTests = "/ellenorzo/V3/Sajat/BejelentettSzamonkeresek";
        public static string homeworks = "/ellenorzo/V3/Sajat/HaziFeladatok";
        public static string homeworkDone = "/ellenorzo/V3/Sajat/HaziFeladatok/Megoldva";
        public static string capabilities = "/ellenorzo/V3/Sajat/Intezmenyek";
    }
}
