public class Solution {
    public int MaxArea(int[] heights) {
        int l=0, r=heights.Length-1;
        int currentMinHeight = 0;
        int currentMaxArea = 0;
        while(l<r){
            currentMinHeight = Min(heights[l],heights[r]);
            currentMaxArea = Max(currentMaxArea, (r-l)*currentMinHeight);

            if(heights[l]<heights[r]){
                l++;
            }
            else{
                r--;
            }
        }

        return currentMaxArea;
    }
    public int Max(int a, int b){
        return a>b?a:b;
    }
    public int Min(int a, int b){
        return a<b?a:b;
    }
}
