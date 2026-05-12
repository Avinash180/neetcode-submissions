public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l=0, r=numbers.Length-1;
        while(l<r){
            int currentSum = numbers[l]+numbers[r];
            if(currentSum>target){
                r--;
            }
            else if(currentSum<target){
                l++;
            }
            else{
                return new int[2]{l+1,r+1};
            }
        }
        return new int[2]{0,0};
    }
}
