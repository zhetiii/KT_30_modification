using System.Collections.Generic;

namespace KT_30
{
    public static class ListExtensions
    {
        public static void Swap<T>(this List<T> list, int i, int j)
        {
            if (list == null || i < 0 || j < 0 || i >= list.Count || j >= list.Count)
                return;

            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }

        public static bool IsEmpty<T>(this List<T> list)
        {
            if (list == null) return true;
            return list.Count == 0;
        }
    }
}