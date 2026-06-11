class Solution
{
    public static List<List<string>> GroupAnagrams(List<string> strs)
    {
        var groups = new Dictionary<string, List<string>>();
        foreach(string s in strs){
            char[] c = s.ToCharArray();
            Array.Sort(c);
            string key = new string(c);

            if(!groups.ContainsKey(key)){
                groups[key] = new List<string>();
            }
            groups[key].Add(s);
        }
        return groups.Values.ToList();
    }
}

/*grouping by computed keys

space and time: sortiong each word takes O(M, log M)
and do this for N words leading to O(NM log M) time
then the hash map stores keys and groups string whose size
is O(NM)

template:
here we group items by derived properties , compute a key
for each item, then append the item to list for the key
*/