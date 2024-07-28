var arr = new int[] { 1, 2, 3, 5, 6, 7, 1, 32, 1, 52, 1, 43, 6, 9, 87, 77, 0 };
var start = 0;
var end = arr.Length - 1;
Console.WriteLine("Enter with a numeric value to search your index: ");
var target = Int32.Parse(Console.ReadLine());
Array.Sort(arr);
var index = BinarySearch(arr, target);
Console.WriteLine($"Iterative response : {index}");
index = RecursiveBinarySearch(arr, target, start, end);
Console.WriteLine($"Recursive response: {index}");

// Iterative implementation O(Log N)
static int BinarySearch(int[] arr, int target)
{
    var start = 0;
    var end = arr.Length - 1;
    while (start <= end)
    {
        int middle = start + (end - start) / 2;
        if (arr[middle] == target)
            return middle;
        else if (arr[middle] > target)
            end = middle - 1;
        else if (arr[middle] < target)
            start = middle + 1;
    }
    return -1;
}

// Recursive implementation O(Log N)
static int RecursiveBinarySearch(int[] arr, int target, int start, int end)
{
    if (start > end)
        return -1;
    int middle = start + (end - start) / 2;
    if (arr[middle] == target)
        return middle;
    else if (arr[middle] > target)
        return RecursiveBinarySearch(arr, target, start, middle - 1);
    else if (arr[middle] < target)
        return RecursiveBinarySearch(arr, target, middle + 1, end);
    return -1;
}
