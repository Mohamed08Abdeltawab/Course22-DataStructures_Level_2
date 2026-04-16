using System.Collections;

#region Working with ArrayList
Console.WriteLine("\n\nHomogeneous ");
ArrayList list = new ArrayList();
list.Add(10);
list.Add(20);
list.Add(30);


Console.WriteLine("Elements in ArrayList:");
foreach (var item in list)
{
    Console.WriteLine(item);
}


list.Remove(20); // Removing an element
Console.WriteLine("After removing an element:");
foreach (var item in list)
{
    Console.WriteLine(item);
}

Console.WriteLine("\n\nHeterogeneous ");
ArrayList list2 = new ArrayList(); // Creating an ArrayList
list2.Add(10); // Adding elements
list2.Add("Hello");
list2.Add(true);

Console.WriteLine("Total elements in ArrayList: " + list2.Count);


Console.WriteLine("Content of ArrayList using index:");
for (int i = 0; i < list2.Count; i++)
{
    Console.WriteLine("Index " + i + ": " + list2[i]);
}


#endregion


#region Filtering ArrayList with Linq
ArrayList arrList = new ArrayList { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


//we use cast here to convert it to int first then we apply the filter.
var evenNumbers = arrList.Cast<int>().Where(num => num % 2 == 0);


Console.WriteLine("All even numbers:");
foreach (var num in evenNumbers)
{
    Console.WriteLine(num);
}

#endregion


#region Aggregate Functions in ArrayList with Linq
ArrayList arrayList = new ArrayList { 10, 5, 20, 15, 30 };

var minValue = arrayList.Cast<int>().Min();
var maxValue = arrayList.Cast<int>().Max();
var Sum = arrayList.Cast<int>().Sum();
var Average = arrayList.Cast<int>().Average();
var Count = arrayList.Cast<int>().Count();

Console.WriteLine("\nArrayList Items: ");
for (int i = 0; i < arrayList.Count; i++)
{
    Console.Write(arrayList[i].ToString() + " ");
}

Console.WriteLine("\n\nMinimum value in the ArrayList: " + minValue);
Console.WriteLine("Maximum value in the ArrayList: " + maxValue);
Console.WriteLine("Sum values in the ArrayList: " + Sum);
Console.WriteLine("Average values in the ArrayList: " + Average);
Console.WriteLine("Count Items in the ArrayList: " + Count);


arrayList.Sort();
Console.WriteLine("\nArrayList Items After Sorting: ");
for (int i = 0; i < arrayList.Count; i++)
{
    Console.Write(arrayList[i].ToString() + " ");
}


#endregion

