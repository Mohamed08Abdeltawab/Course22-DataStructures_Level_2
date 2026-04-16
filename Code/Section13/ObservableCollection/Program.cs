using System.Collections.ObjectModel;

#region Creating and Adding Items to ObservableCollection
ObservableCollection<string> collection = new ObservableCollection<string>();
//adding 
collection.Add("One");
collection.Add("Two");
collection.Add("Three");

//print
foreach(var item in collection)
{
    Console.WriteLine(item);
}

#endregion