using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public static bool ContainsDuplicate(List<int> nums)
    {
        var seen = new HashSet<int>();
        foreach(int n in nums)
        {
            if(!seen.Add(n)) return true;
        }
        return false;
    }
}

/*hashset duplicate detection
space and time: O(n) and O(n)
we need to process each number once
and store seen numbers in hash set*/