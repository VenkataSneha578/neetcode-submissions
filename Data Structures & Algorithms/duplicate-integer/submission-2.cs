public class Solution {
    public bool hasDuplicate(int[] nums) {
        if(nums.Length==0){
            return false;
        }
        HashSet<int> set= new HashSet<int>(nums);
        if(nums.Length!=set.Count){
            return true;
        }
    return false;
    }
}