
class Solution
{
    public static int MaxProfit(List<int> prices)
    {
        int minPrice = int.MaxValue;
        int maxPrice = 0;
        
        foreach(int n in prices)
        {
            if(n < minPrice){
                minPrice = n;
            }
        else if(n - minPrice > maxPrice)
        {
                maxPrice = n - minPrice;
            }
            
        }
        
        return maxPrice;
    }
}

/*use single pass greedy algo

In this we make optimal choice locally at each step,
in the hopes of getting optimal soluntion.
in single pass -> we go thriough the array once tracking 
only few variables.

template:
intitlialize(best, current)
foreach(elme in arrray)
{
//make greedy decision based on current state
//update tracking variables
}

space and time: we iterate through once which gives us O(N) time
and O(1) space since we need only 2 variables*/