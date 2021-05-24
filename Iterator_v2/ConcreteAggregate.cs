using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_v2
{
    class ConcreteAggregate : Aggregate
    {
        private List<Student> _students = new List<Student>();
        private bool _reverse = false;

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this, _reverse);
        }

        public void ReverseDirection()
        {
            _reverse = !_reverse;
        }

        public int Count()
        {
            return _students.Count;
        }

        public List<Student> GetItems()
        {
            return _students;
        }

        public void AddItem(Student student)
        {
            _students.Add(student);
        }
    }
}
