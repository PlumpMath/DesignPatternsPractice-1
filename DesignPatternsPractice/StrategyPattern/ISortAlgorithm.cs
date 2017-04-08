using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.StrategyPattern
{
    interface ISortAlgorithm<T> where T : IComparable<T>
    {
        T[] Ascending(T[] i);

        T[] Descending(T[] i);
    }
}
