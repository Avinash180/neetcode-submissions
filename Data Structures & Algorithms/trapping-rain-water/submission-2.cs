public class Solution {
    public int Trap(int[] height) {
        int l = 0, r = height.Length-1;
        int leftMax = height[l], rightMax = height[r];

        int result=0;
        

        while(l<r){
            if(leftMax<rightMax){
                l+=1;
                leftMax = Max(leftMax, height[l]);
                result += leftMax - height[l];
            }
            else{
                r-=1;
                rightMax = Max(rightMax, height[r]);
                result += rightMax - height[r];
            }
        }

        return result;
    }
    public int Max(int a, int b){
        return a > b ? a : b;
    }
}
