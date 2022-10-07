// Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.

// You must implement a solution with a linear runtime complexity and use only constant extra space.

int[] nums = {5, 7, 6, 5, 7};


var result = nums.GroupBy(x => x).Select(x => new {Number = x.Key, Count = x.Count()});

foreach (var x in result)
{
        if (x.Count == 1)
        {
            Console.WriteLine($"This number only appears once: {x.Number}");
            // return x.Number;
        }
}

if (nums.Length == 1)
    Console.WriteLine($"The array's length is 1, so the final answer is: {nums[0]}");
// return nums[0];