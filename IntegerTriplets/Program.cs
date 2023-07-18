using System;
using System.Collections.Generic;

class Triplets
{
  
    public static List<List<int>> FindTriplets(int[] nums, int sum)
    {
        Array.Sort(nums);

        List<List<int>> pair = new List<List<int>>();
        SortedSet<string> set = new SortedSet<string>();

        for (int i = 0; i < nums.Length - 2; i++)
        {
            for (int j = i + 1; j < nums.Length - 1; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[j] + nums[k] == sum)
                    {
                        string str = nums[i] + ":" + nums[j] + ":" + nums[k];

                        if (!set.Contains(str))
                        {
                            pair.Add(new List<int> { nums[i], nums[j], nums[k] });
                            set.Add(str);
                        }
                    }
                }
            }
        }
        return pair;
    }

  
    public static void Main(string[] args)
    {
        int[] nums = { 12, 3, 6, 1, 6, 9 };   
        int sum = 24;

        List<List<int>> triplets = FindTriplets(nums, sum);

       
        if (triplets.Count != 0)
        {
            Console.Write("[");
            for (int i = 0; i < triplets.Count; i++)
            {
                List<int> l = triplets[i];
                Console.Write("[");
                for (int j = 0; j < l.Count; j++)
                {
                    Console.Write(l[j]);
                    if (l.Count != j + 1)
                        Console.Write(", ");
                }
                Console.Write("]");
                if (triplets.Count != i + 1)
                    Console.Write(",");
            }
            Console.Write("]");
        }
        else
        {
            Console.WriteLine("No triplets can be formed");
        }
    }
}


