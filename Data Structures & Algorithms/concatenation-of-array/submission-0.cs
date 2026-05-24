public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int length = nums.Length;
        int[] result = new int[2*length];

        for(int i=0;i<length; i++){
            result[i] = nums[i];
            result[i+length] = nums[i];
        }

        return result;
    }
}