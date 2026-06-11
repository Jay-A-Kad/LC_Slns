using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public static List<int> TwoSum(List<int> arr, int target)
    {
       var map = new Dictionary<int,int>();
        for(int i = 0 ;i < arr.Count ;i++)
        {
            int complement = target - arr[i];
            if(map.TryGetValue(complement, out int j)) // or map.ContainsKey(target - arr[i])
            {
                return new List<int> {j,i}; // or return new int[] {map[target - arr[i]] , i}
            }
            map[arr[i]] = i;
        }
        return null;
    }
}


/*hash complement approach 
space and time : O(N) time , O(N) space
since we iterate through array once hence O(N) 
and in the worst case store every num in hash map (O(N) space)*/