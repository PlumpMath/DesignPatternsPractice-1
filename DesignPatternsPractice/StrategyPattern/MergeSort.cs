using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.StrategyPattern
{
    class MergeSort<T> : ISortAlgorithm<T> where T : IComparable<T>
    {
        public T[] Ascending(T[] arr)
        {

            return sort(arr, SortOrder.Ascending);
        }

        public T[] Merge(T[] arr1, T[] arr2, SortOrder order)
        {
            T[] arr = new T[arr1.Count() + arr2.Count()];

            var p1 = 0;
            var p2 = 0;
            var i = 0;
            while(i < arr.Count())
            {
                if (p1 >= arr1.Count())
                    while (p2 < arr2.Count())
                        arr[i++] = arr2[p2++];

                if (p2 >= arr2.Count())
                    while (p1 < arr1.Count())
                        arr[i++] = arr1[p1++];

                if(p1 < arr1.Count() && p2 < arr2.Count())
                {
                    if (order == SortOrder.Ascending)
                    {
                        if (arr1[p1].CompareTo(arr2[p2]) < 0)
                        {
                            arr[i] = arr1[p1];
                            i++;
                            p1++;
                        }
                        else
                        {
                            arr[i] = arr2[p2];
                            i++;
                            p2++;
                        }
                    }
                    else if (order == SortOrder.Descending)
                    {
                        if (arr1[p1].CompareTo(arr2[p2]) > 0)
                        {
                            arr[i] = arr1[p1];
                            i++;
                            p1++;
                        }
                        else
                        {
                            arr[i] = arr2[p2];
                            i++;
                            p2++;
                        }
                    }
                }

            }

            return arr;
        }

        private T[] sort(T[] arr, SortOrder order)
        {
            if (arr.Count() <= 2)
            {
                if (arr.Count() == 1)
                    return arr;
                else
                {
                    T[] mergeArr = new T[2];
                    if (arr[0].CompareTo(arr[1]) < 0)
                    {
                        if(order == SortOrder.Ascending)
                        {
                            mergeArr[0] = arr[0];
                            mergeArr[1] = arr[1];
                        }
                        else
                        {
                            mergeArr[0] = arr[1];
                            mergeArr[1] = arr[0];
                        }
                    }
                    else
                    {
                        if(order == SortOrder.Ascending)
                        {
                            mergeArr[0] = arr[1];
                            mergeArr[1] = arr[0];
                        }
                        else
                        {
                            mergeArr[0] = arr[0];
                            mergeArr[1] = arr[1];
                        }

                    }
                    return mergeArr;
                }
            }
            else
            {
                var count = arr.Count();

                T[] arr1 = new T[count / 2];
                T[] arr2 = new T[count - count / 2];

                for (int j = 0; j < count / 2; j++)
                {
                    arr1[j] = arr[j];
                }

                for (int k = 0; k < (count - count / 2); k++)
                {
                    arr2[k] = arr[count / 2 + k];
                }

                arr1 = sort(arr1, order);
                arr2 = sort(arr2, order);

                return Merge(arr1, arr2, order);
            }
        }

        public T[] Descending(T[] arr)
        {
            return sort(arr, SortOrder.Descending);
        }
    }

    enum SortOrder
    {
        Ascending,
        Descending
    }
}
