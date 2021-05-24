using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_v2
{
    class ConcreteIterator : Iterator
    {
        private ConcreteAggregate _aggregate;
        private int _current = 0;
        private bool _reverse;

        public ConcreteIterator(ConcreteAggregate aggregate, bool reverse)
        {
            _aggregate = aggregate;
            _reverse = reverse;

            if (_reverse)
                _current = aggregate.Count() - 1;
        }

        public override Student First()
        {
            if (_reverse)
                return _aggregate.GetItems()[_aggregate.Count() - 1];
            return _aggregate.GetItems()[0];
        }

        public override Student Next()
        {
            int updatedPosition = _current + (_reverse ? -1 : 1);
            if (updatedPosition >= 0 && updatedPosition < _aggregate.Count())
            {
                _current = updatedPosition;
                return _aggregate.GetItems()[updatedPosition];
            }    
            return null;
        }

        public override Student CurrentItem()
        {
            return _aggregate.GetItems()[_current];
        }

        public override bool IsDone()
        {
            return _current < 0 || _current >= _aggregate.Count();
        }
    }
}
