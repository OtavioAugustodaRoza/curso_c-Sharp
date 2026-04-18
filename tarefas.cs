public class Solution {
    public int MaiorNumero(int[] nums) {
        int maior = nums[0];
        foreach(int n in nums)
        {
            if(n > maior)
            {
                maior = n;
            }
            
        }
        return maior;
    }

    public int[] InverterArray(int[] nums) {
        int control = 0;
        int[] arr = new int[nums.Length];
        for(int i = nums.Length -1 ; i >= 0; i--)
        {
            arr[control] = nums[i];
            control++;
        }
        return arr;
    }
    public bool TemDuplicata(int[] nums) {
        foreach( int n in nums)
        {
            int see = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if(n == nums[i])
                {
                    see++;
                }
            }
            if(see > 1)
            {
                return true;
            }
            
        }
        return false;
    }
    

}