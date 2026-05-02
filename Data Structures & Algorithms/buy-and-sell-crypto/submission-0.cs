public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int length = prices.Length;
        int l=0, r=1;

        while(r<length){
            if(prices[r]>prices[l]){
                maxProfit = Max(maxProfit, prices[r]-prices[l]);
            }
            else{
                l=r;
            }
            r++;
        }

        return maxProfit;
    }
    public int Max(int a, int b){
        if(a>b) return a;
        return b;
    }
}
