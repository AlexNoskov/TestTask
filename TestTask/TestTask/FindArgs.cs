using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    public class FindArgs<TLabel>
    {
        public FindArgs(Int32 index, Pair<TLabel> item)
        {
            Index = index;
            Item = item;
        }

        public Int32 Index { get; private set; }
        public Pair<TLabel> Item { get; private set; }
    }
}
