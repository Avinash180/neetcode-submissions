public class Solution {
    public int MaxProfit(int[] prices) {
        int l=0,r=1,maxProfit=0;
        while(r<prices.Length){
            if(prices[l]>prices[r]){
                l=r;
            }
            else{
                maxProfit = Max(maxProfit, prices[r]-prices[l]);
            }
            r++;
        }
        return maxProfit;
    }
    public int Max(int a, int b){
        return a>b?a:b;
    }
}
