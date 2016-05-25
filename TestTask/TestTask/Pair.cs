using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    public class Pair<TLabel>
    {
        public Pair(TLabel start, TLabel end)
        {
            Start = start;
            End = end;
        }

        public TLabel Start { get; private set; }
        public TLabel End { get; private set; }
    }
}
