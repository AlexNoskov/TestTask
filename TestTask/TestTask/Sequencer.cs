using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    public class Sequencer<TLabel>
    {
        public Sequencer(IList<Pair<TLabel>> input)
        {
            if (input != null)
            { Input = input; }
            else
            {
                Input = new List<Pair<TLabel>>();
            }

            _notOrdered = Input.ToList();
            _ordered = new List<Pair<TLabel>>(_notOrdered.Capacity);
        }

        public IList<Pair<TLabel>> Input
        { get; private set; }
        public IList<Pair<TLabel>> NotOrdered
        { get { return _notOrdered; } }
        public IList<Pair<TLabel>> Ordered
        { get { return _ordered; } }

        private List<Pair<TLabel>> _notOrdered;
        private List<Pair<TLabel>> _ordered;
        private Func<FindArgs<TLabel>, FindArgs<TLabel>> Find;
        private Pair<TLabel> _pointReturn;

        public void PutOrder()
        {
            if (_notOrdered.Count > 0)
            {
                Find = Find_Direct;
                _pointReturn = _notOrdered[0];

                PutOrderRecurcive(new FindArgs<TLabel>(0, _pointReturn));
            }
        }

        private void PutOrderRecurcive(FindArgs<TLabel> args)
        {
            if (args != null)
            {
                _notOrdered.Remove(args.Item);
                _ordered.Insert(args.Index, args.Item);

                FindArgs<TLabel> next = Find(args);
                PutOrderRecurcive(next);
            }
        }
        private FindArgs<TLabel> Find_Direct(FindArgs<TLabel> args)
        {
            foreach (var pair in _notOrdered)
            {
                if (pair.Start.Equals(args.Item.End))
                {
                    FindArgs<TLabel> result = new FindArgs<TLabel>(args.Index + 1, pair);
                    return result;
                }
            }

            Find = Find_Reverse;
            FindArgs<TLabel> lastPoint = new FindArgs<TLabel>(0, _pointReturn);
            return Find_Reverse(lastPoint);
        }
        private FindArgs<TLabel> Find_Reverse(FindArgs<TLabel> args)
        {
            foreach (var pair in _notOrdered)
            {
                if (pair.End.Equals(args.Item.Start))
                {
                    FindArgs<TLabel> result = new FindArgs<TLabel>(0, pair);
                    return result;
                }
            }

            return null;
        }
    }
}
