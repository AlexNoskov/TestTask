using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask;

namespace UnitTestProject
{
    public class SourceValues_Sequencer_City
    {
        static SourceValues_Sequencer_City()
        {
            Pair_1_2 = new Pair<String>("Мельбурн", "Кельн");
            Pair_2_3 = new Pair<String>("Кельн", "Москва");
            Pair_3_4 = new Pair<String>("Москва", "Париж");

            One = CreateOne();
            Direct = CreateDirect();
            LikeTask = CreateLikeTask();            
        }

        public static Pair<String> Pair_1_2;
        public static Pair<String> Pair_2_3;
        public static Pair<String> Pair_3_4;

        public static List<Pair<String>> One;
        public static List<Pair<String>> Direct;
        public static List<Pair<String>> LikeTask;

        private static List<Pair<String>> CreateOne()
        {
            List<Pair<String>> result = new List<Pair<String>>();
            result.Add(Pair_1_2);
            return result;
        }

        private static List<Pair<String>> CreateDirect()
        {
            List<Pair<String>> result = new List<Pair<String>>();

            result.Add(Pair_1_2);
            result.Add(Pair_2_3);
            result.Add(Pair_3_4);

            return result;
        }
        private static List<Pair<String>> CreateLikeTask()
        {
            List<Pair<String>> result = new List<Pair<String>>();

            result.Add(Pair_1_2);
            result.Add(Pair_3_4);
            result.Add(Pair_2_3);           

            return result;
        }        
    }
}
