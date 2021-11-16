using System;

namespace Open_Lab_04._03
{
    public class StringTools
    {
        public string RemoveFirstLast(string original)
        {
            int a = original.Length-1;
            original = original.Remove(a, 1);
            original = original.Remove(0, 1);
            return original;
        }
    }
}
