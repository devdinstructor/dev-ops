void main()
{
	var arr = new int { 1, 3, 5, 6 };
	var idx = Find(arr, 9);
	Console.WriteLine(idx);
}

public int Find(int[] arr, int num)
{
	var pos = -1;
	for (var idx = 0; idx < arr.Length; idx++)
	{
		if (arr[idx] != num)
		{
			continue;
		}
		
		pos = idx;
		break;
	}
	
	return idx;
}
