using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.StrategyPattern
{
    class Sort<T> where T : IComparable<T> 
    {
        private ISortAlgorithm<T> SortAlgorithm { get;  set; }
        private T[] array { get;  set; }

        public Sort(T[] arr, ISortAlgorithm<T> algo)
        {
            array = arr;
            SortAlgorithm = algo;
        }

        public T[] Ascending()
        {
            return SortAlgorithm.Ascending(array);
        }

        public T[] Descending()
        {
            return SortAlgorithm.Descending(array);
        }
    }
}
