public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> hashSet = new HashSet<int>();
        bool result = true;
        foreach(int num in nums){
            result = hashSet.Add(num);
            if(!result){
                return true;
            }
        }
        return false;
    }
}