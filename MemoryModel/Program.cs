using System;
using System.Collections.Generic;

namespace MemoryModel
{
    class Program
    {
        static void Main(string[] args)
        {
            int jacob = 4;
            string ronil = "Ronil";
            int[] keagan = { 6, 7, 2 }; //always a reference type
            for (var will = 0; will < keagan.Length; will++)
            { Console.WriteLine(keagan[will]); }
            double denzel = 3.14159;
            var atchu = jacob;
            jacob++;
            string[] sabir = { "cat", "dog" };
            {
                var chris = keagan;
                chris[2] = 42;
                string[] umar = { "perch", "cod", "eel" };
                sabir = umar;
                sabir[1] = "bass";
                var sam = ronil;
                ronil = umar[0];
            }
            denzel = keagan[2];
        }
        /*public static int FindLowest(List<int> nums)
        {
            if (nums.Count == 0) return int.MaxValue;
            int result = Int32.MaxValue;
            foreach (var x in nums)
            {
                if (x < result)
                {
                    result = x;
                }
            }
            return result;
        } */
    }
}
