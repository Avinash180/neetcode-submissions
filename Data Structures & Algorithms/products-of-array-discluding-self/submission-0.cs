public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int nonZeroProduct = 1;
        int product = 1;
        int noOfZeroes= 0;
        int[] result = new int[nums.Length];
        foreach(int num in nums){
            if(num==0){
                noOfZeroes++;
            }
            else{
                nonZeroProduct = nonZeroProduct * num;
            }
        }
        if(noOfZeroes>1){
            return result;
        }
        else{
            product = noOfZeroes == 1 ? 0 : nonZeroProduct;
            for(int i=0;i<nums.Length;i++){
                if(nums[i]==0){
                    result[i] = nonZeroProduct;
                }
                else{
                    result[i] = product / nums[i];
                }
            }
        }
        return result;
    }
}
