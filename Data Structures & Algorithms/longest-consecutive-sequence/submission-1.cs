public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);
        int maxCount = 0;
        
        foreach(int num in set){
            if(!set.Contains(num-1)){
                int currentNum = num;
                int currentCount = 1;

                while(set.Contains(currentNum+1)){
                    currentCount++;
                    currentNum++;
                }

                maxCount = Max(maxCount, currentCount);
            }
        }

        return maxCount;
    }
    public int Max(int a, int b){
        return a>b?a:b;
    }
}
