// Java program for the above approach
import java.util.*;
class 4ni19is088{

// Function to print the elements
// of Subarray with maximum sum
static void SubarrayWithMaxSum(Vector<Integer> nums)
{
	// Initialize currMax and globalMax
	// with first value of nums
	int endIndex = 0, currMax = nums.get(0);
	int globalMax = nums.get(0);

	// Iterate for all the elements
	// of the array
	for (int i = 1; i < nums.size(); ++i)
	{

	// Update currMax
	currMax = Math.max(nums.get(i),
						nums.get(i) + currMax);

	// Check if currMax is greater
	// than globalMax
	if (currMax > globalMax)
	{
		globalMax = currMax;
		endIndex = i;
	}
	}

	int startIndex = endIndex;

	// Traverse in left direction to
	// find start Index of subarray
	while (startIndex >= 0)
	{
	globalMax -= nums.get(startIndex);

	if (globalMax == 0)
		break;

	// Decrement the start index
	startIndex--;
	}

	// Printing the elements of
	// subarray with max sum
	for(int i = startIndex; i <= endIndex; ++i)
	{
	System.out.print(nums.get(i) + " ");
	}
}

// Driver Code
public static void main(String[] args)
{
	// Given array arr[]
	Vector<Integer> arr = new Vector<Integer>();
	arr.add(-2);
	arr.add(-5);
	arr.add(6);
	arr.add(-2);
	arr.add(-3);
	arr.add(1);
	arr.add(5);
	arr.add(-6);

	// Function call
	SubarrayWithMaxSum(arr);
}
}

// This code is contributed by Rajput-Ji
