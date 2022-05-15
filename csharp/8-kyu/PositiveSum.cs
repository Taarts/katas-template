using System;
using System.Linq; // I don't know about this yet, the solution below is pre-Linq

public class Kata
{
    public static int PositiveSum(int[] arr)
    {
        int sum = 0;

        if (arr != null)
        {
            foreach (int i in arr)
            {
                if (i > 0)
                {
                    sum += i;
                }
                else
                {
                    sum += 0;
                }
            }
            return sum;
        }
        return 0;
    }
}
// this is the linq statement
// using System;
// using System.Linq;

// public class Kata
// {
//   public static int PositiveSum(int[] arr)
//   {
//     return arr.Where(x => x > 0).Sum();
//   }
// }