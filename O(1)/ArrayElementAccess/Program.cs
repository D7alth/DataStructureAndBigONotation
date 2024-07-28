var arr = new int[] { 1, 3, 5, 6, 7, 8, 2, 11, 0 }; // Array with fixed elements O(1)
Console.WriteLine("Index: ");
var index = Int32.Parse(Console.ReadLine());
var result = ArrayElementAccess(index, arr);
Console.WriteLine(result);

static int ArrayElementAccess(int index, int[] arr)
{
    if (index < 0 || index >= arr.Length)
        return -1;
    return arr[index];
}
