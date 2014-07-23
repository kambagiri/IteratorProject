using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorProject
{
    class Enumerator1 : IEnumerator<int>
    {
        private int i = -1;
        private MyIntList IntList;

        private Func<int, bool> NewFilter;
        private IEnumerator<int> NewMyList;

        public Enumerator1() { }

        public Enumerator1(IEnumerable<int> list)
        {
            this.NewMyList = list.GetEnumerator();
        }

        public Enumerator1(Func<int, bool> filter, IEnumerable<int> list)
        {
            // TODO: Complete member initialization
            this.NewFilter = filter;
            this.NewMyList = list.GetEnumerator();
        }

        public bool MoveNext()
        {
            i++;
            return i < IntList.MyList.Count;
        }

        public int Current { get { return IntList.MyList[i]; } }

        object IEnumerator<int>.Current { get { return NewMyList.Current; } }
            

        public int Current   // If not defined shows 2 errors : IEnumerator.Current in explicit interface declaration is not a member of interface.
        {
            get
            { return NewMyList.Current; }
        } 
        public void Dispose() { }

        public void Reset() { throw new NotSupportedException(); }
    }
}
