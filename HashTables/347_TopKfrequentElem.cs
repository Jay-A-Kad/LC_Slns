class Solution
{
    public static List<int> TopKFrequentElements(List<int> nums, int k)
    {
        if(nums.Count == 0) return new List<int>();
        var freq = new Dictionary<int,int>();
        foreach(int n in nums){
            if(freq.ContainsKey(n)){
                freq[n]++;
            }else{
                freq[n] = 1;
            }
        }
        return freq.OrderByDescending(pair => pair.Value)
            .Take(k)
            .Select(pair => pair.Key)
            .ToList();
    }
}

/*
Frequency counting with dictionairy
freq.OrderByDescending(pair => pair.Value)Sorts the dictionary's key-value pairs by frequency, 
highest first.Take(k)Keeps only the first k pairs.
Select(pair => pair.Key)
Extracts just the number from each pair.
ToList()Converts the result to a List<int>

space and time: O(n log K)time adn O(n) space
need to process each number ocen and use heap siz3e of k*/