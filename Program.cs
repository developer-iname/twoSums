// See https://aka.ms/new-console-template for more information
int[] numbers = {2,7,11,15};
int target = 9;

foreach(int number in TwoSum(numbers,target))
{
    Console.WriteLine(number);
}

int[] TwoSum(int[] nums, int target) {
    int sumReturned = 0;
    for(int x = 0; x < nums.Length; x++)
    {
        if(nums[x] > target)
        {
            break;
        }
        else
        {
            for(int i = x + 1; i < nums.Length; i++)
            {
                if(nums[i] > target)
                {
                    break;
                }
                sumReturned = nums[x] + nums[i];
                if(sumReturned == target)
                {
                    return new int[] {x,i};
                }
            }
        }
    }
    return new int[0];
}