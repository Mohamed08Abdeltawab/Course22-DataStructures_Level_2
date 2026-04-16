/*
 
 
 ObservableCollection: Overview
An ObservableCollection is a dynamic data collection that provides notifications when items get added, removed, or when the entire list is refreshed. It is the "gold standard" for data binding in .NET applications (WPF, MAUI, Avalonia).

How It Works
The core "magic" of this collection lies in the implementation of an interface called INotifyCollectionChanged.

The Event: Whenever you perform an operation (Add, Remove, Move, Clear), the collection automatically fires an event called CollectionChanged.

The Listener: The User Interface (UI) "listens" to this event.

The Update: When the event fires, the UI automatically re-renders the specific part of the list that changed without needing to reload the entire screen.

Advantages (Pros)
Automatic UI Updates: You don't have to manually call "Refresh" or re-assign data sources to your UI elements.

Decoupling: It allows for a clean MVVM (Model-View-ViewModel) architecture. The logic layer just updates the data, and the UI layer reacts automatically.

Two-Way Sync: Ideal for scenarios where the UI and the underlying data must stay perfectly in sync at all times.

Granular Notifications: It tells the UI exactly what happened (e.g., "Item #3 was removed"), which allows for smooth animations and better performance during updates.

Disadvantages (Cons)
Performance Overhead: Because it fires events for every single change, it is slower than a standard List<T>. If you are adding 10,000 items in a loop, it will fire 10,000 events, which can freeze the UI.

Single-Threaded: By default, it expects updates to happen on the UI Thread. Modifying it from a background thread often causes a crash unless specifically handled.

Internal Property Blindness: It only monitors the list itself. If you change a property inside an object (like changing a user's age), the collection will not notify the UI. The object itself must handle that notification.

Memory Usage: It consumes slightly more memory than a simple list due to the event-handling infrastructure.

When to use it?
Use it when the collection is bound to a UI element (like a ListView or DataGrid).

Avoid it for heavy data processing, background calculations, or internal logic where no UI is involved. Use List<T> instead for those cases
 
 
 */



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

#region Responding to Changes in ObservableCollection
// Creating an ObservableCollection
ObservableCollection<string> Items = new ObservableCollection<string>();
// Subscribing to the CollectionChanged event
Items.CollectionChanged += Items_CollectionChanged;


// Modifying the ObservableCollection
Items.Add("Item 1");
Items.Add("Item 2");
Items.Add("Item 3");


Items.RemoveAt(1);
Items.Insert(0, "New Item");
Items[1] = "Replaced Item"; // Replace action
Items.Move(0, 2); // Move action


// Printing the Final Collection
Console.WriteLine("\nFinal Collection:");
foreach (var item in Items)
{
    Console.WriteLine(item);
}

//creating method to handle collection changes
static void Items_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
{
    Console.WriteLine("\nCollection Changed:");


    // Handling Collection Changes
    switch (e.Action)
    {
        case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
            Console.WriteLine("Added:");
            foreach (var newItem in e.NewItems)
            {
                Console.WriteLine("- " + newItem);
            }
            break;


        case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
            Console.WriteLine("Removed:");
            foreach (var oldItem in e.OldItems)
            {
                Console.WriteLine("- " + oldItem);
            }
            break;


        case System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
            Console.WriteLine("Replaced:");
            foreach (var oldItem in e.OldItems)
            {
                Console.WriteLine("- " + oldItem);
            }
            Console.WriteLine("With:");
            foreach (var newItem in e.NewItems)
            {
                Console.WriteLine("- " + newItem);
            }
            break;


        case System.Collections.Specialized.NotifyCollectionChangedAction.Move:
            Console.WriteLine("Moved:");
            Console.WriteLine($"- From index {e.OldStartingIndex} to index {e.NewStartingIndex}");
            break;
    }
}
#endregion