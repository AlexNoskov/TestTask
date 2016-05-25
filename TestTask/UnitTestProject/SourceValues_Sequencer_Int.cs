using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask;

namespace UnitTestProject
{
    public class SourceValues_Sequencer_Int
    {
        static SourceValues_Sequencer_Int()
        {
            Pair_1_2 = new Pair<Int32>(1, 2);
            Pair_2_3 = new Pair<Int32>(2, 3);
            Pair_3_4 = new Pair<Int32>(3, 4);
            Pair_4_5 = new Pair<Int32>(4, 5);

            One = CreateOne();
            Direct = CreateDirect();
            Reverse = CreateReverse();
            FillBadPerformance();
        }

        public static Pair<Int32> Pair_1_2;
        public static Pair<Int32> Pair_2_3;
        public static Pair<Int32> Pair_3_4;
        public static Pair<Int32> Pair_4_5;

        public static List<Pair<Int32>> One;
        public static List<Pair<Int32>> Direct;
        public static List<Pair<Int32>> Reverse;
        public static List<Pair<Int32>> BadPerformance;
        public static List<Pair<Int32>> BadPerformance_Direct;

        private static List<Pair<Int32>> CreateOne()
        {
            List<Pair<Int32>> result = new List<Pair<int>>();
            result.Add(Pair_1_2);
            return result;
        }

        private static List<Pair<Int32>> CreateDirect()
        {
            List<Pair<Int32>> result = new List<Pair<int>>();

            result.Add(Pair_1_2);
            result.Add(Pair_2_3);
            result.Add(Pair_3_4);
            result.Add(Pair_4_5);

            return result;
        }
        private static List<Pair<Int32>> CreateReverse()
        {
            List<Pair<Int32>> result = new List<Pair<int>>();

            result.Add(Pair_4_5);
            result.Add(Pair_3_4);
            result.Add(Pair_2_3);
            result.Add(Pair_1_2);

            return result;
        }
        private static void FillBadPerformance()
        {
            Int32 count = 10000;
            Int32 capacity = count + 1;
            BadPerformance = new List<Pair<int>>(capacity);
            BadPerformance_Direct = new List<Pair<int>>(capacity);

            for (int i=0; i<count; i++)
            {
                Pair<Int32> pair = new Pair<int>(i + 1, i + 2);
                BadPerformance.Add(pair);
                BadPerformance_Direct.Add(pair);
            }

            Pair<Int32> pairLast = new Pair<int>(count + 1, count + 2);
            BadPerformance.Insert(0, pairLast);
            BadPerformance_Direct.Add(pairLast);
        }
    }
}
