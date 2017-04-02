using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelliFunctions
{
    public static class Functions
    {
        public static int[] Sort(int[] elems)
        {
            int[] result = new int[elems.Length];
            Array.Copy(elems, result, elems.Length);
            // selection sort is slow, but a fast implementation is not the goal
            for (int i = 0; i < result.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[j] < result[minIndex])
                        minIndex = j;
                }

                int tmp = result[minIndex];
                result[minIndex] = result[i];
                result[i] = tmp;
            }
            return result;
        }

        public static int[] Union(int[] a1, int[] a2)
        {
            List<int> result = new List<int>(a1);
            foreach (var b in a2)
            {
                bool found = false;
                foreach(var a in a1)
                {
                    if (a == b)
                        found = true;
                }

                if (!found)
                    result.Add(b);
            }

            return result.ToArray();
        }

        public static Tuple<int,int>[] XandYIsOdd(int[] array)
        {
            List<Tuple<int, int>> result = new List<Tuple<int, int>>();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    int first = ((array[i] % 2) + 2) % 2;
                    int second = ((array[j] % 2) + 2) % 2;
                    int sum = (first + second);
                    if (sum == 1)
                        result.Add(new Tuple<int, int>(array[i], array[j]));
                }
            }

            return result.ToArray();
        }
    }
}
