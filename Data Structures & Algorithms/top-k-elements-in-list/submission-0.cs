public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int length = nums.Length;
        Dictionary<int, int> frequencies = new Dictionary<int,int>();
        for(int i=0;i<length;i++){
            if(frequencies.ContainsKey(nums[i])){
                frequencies[nums[i]]++;
            }
            else{
                frequencies[nums[i]]=1;
            }
        }

        var buckets = new List<int>[length+1];
        foreach(var item in frequencies){
            int freq = item.Value;

            if(buckets[freq]==null){
                buckets[freq] = new List<int>();
            }

            buckets[freq].Add(item.Key);
        }
        var result = new List<int>();
        for(int freq = buckets.Length-1; freq>=0 && result.Count<k; freq--){
            if(buckets[freq]==null)
            {
                continue;
            }
            foreach(int num in buckets[freq])
            {
                result.Add(num);
                if(result.Count == k){
                    break;
                }
            }
        }
        return result.ToArray();
    }
}
