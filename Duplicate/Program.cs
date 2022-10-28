public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        List<int> result = new List<int>(nums);
        
        int count = 0;
        for (int i = 0; i < result.Count - i; i++)
        {
            for (int j = 0; j < result.Count-i-1; j++)
            {
                if (result[j] == result[j + 1])
                {

                    result.RemoveAt(j + 1);
                    


                }


            }

        }

        count = result.Count;
        foreach (var item in result)
        {
            Console.WriteLine(item);

        }

       return count;


    }

    public static void Main(string[] args)
    {
        Solution sl = new Solution();
        int[] nums = {1,1,2,2,3,4,5,4,9,7,1};

        Console.WriteLine(sl.RemoveDuplicates(nums));

       

    }
}