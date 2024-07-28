using System.Collections;

Console.WriteLine("Insert a element: ");
var input = Console.ReadLine();

var hashTable = new Hashtable();
hashTable.Add(1, input);

Console.WriteLine($"Value inserted: {hashTable[1]}");

hashTable.Add(2, "test 01");
hashTable.Add(3, "test 02");

Console.WriteLine("Add new value: ");
input = Console.ReadLine();
hashTable.Add(4, input);

Console.WriteLine("Insert A key: ");
var key = Int32.Parse(Console.ReadLine());

if (hashTable.ContainsKey(key))
    Console.WriteLine($"The value is: {hashTable[key]}");
else
    Console.WriteLine($"This key don't exists");
