public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> remainderSumDictionary = new Dictionary<int, int>();

        for(int i=0; i<nums.Length;i++){
            var remainderSum = target - nums[i];

            if(remainderSumDictionary.ContainsKey(remainderSum)){
                return new int[]{remainderSumDictionary[remainderSum],i};
            }

            if(!remainderSumDictionary.ContainsKey(nums[i])){
                remainderSumDictionary[nums[i]] = i;
            }
        }

        return new int[]{};
    }
}
