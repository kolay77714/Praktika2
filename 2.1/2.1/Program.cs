//2.1
/*using System;
using System.Linq;
using System.Collections.Generic;

namespace Egorprogramm
{
    class Program
    {
        ////static void Main()
        {*/

//ЗАДАНИЕ 1   
/*        string j = "cd";
        string S = "aabbccd";
        int count = 0;
        for (int i = 0; i < S.Length; i++)
        {
            if (j.Contains(S[i].ToString()))
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}
}*/



//ЗАДАНИЕ 2

/*   int[] candidates = { 2, 5, 2, 1, 2 };
     int target = 5;

     List<List<int>> results = CombinationSum(candidates, target);

     foreach (List<int> result in results)
     {
         Console.WriteLine(string.Join(" ", result));
     }
 }

 static List<List<int>> CombinationSum(int[] candidates, int target)
 {
     List<List<int>> results = new List<List<int>>();
     Array.Sort(candidates);
     int i = 0;
     while (i < candidates.Length)
     {
         int current = candidates[i];
         if (current > target) break;
         if (current == target)
         {
             results.Add(new List<int> { current });
             break;
         }
         var subResults = CombinationSum(candidates.Skip(i + 1).ToArray(), target - current);
         foreach (var subResult in subResults)
         {
             subResult.Insert(0, current);
             results.Add(subResult);
         }
         while (i < candidates.Length && candidates[i] == current) i++;
     }
     return results;
 }
}
}*/


//ЗАДАНИЕ 3
i/*nt[] nums1 = { 1, 2, 3, 4 };
int[] nums2 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
int[] nums3 = { 1, 2, 3, 1 };
Console.WriteLine(nums1.Distinct().Count() != nums1.Length);
Console.WriteLine(nums2.Distinct().Count() != nums2.Length);
Console.WriteLine(nums3.Distinct().Count() != nums3.Length);
}
}
}*/