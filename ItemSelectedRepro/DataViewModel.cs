using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ItemSelectedRepro;

public partial class DataViewModel : ObservableObject
{
    [ObservableProperty] 
    private ObservableCollection<ListItem> _items = new();

    [ObservableProperty] 
    private ListItem? _selectedItem;
    
    [RelayCommand]
    private void OnItemSelected(ListItem item)
    {
        System.Diagnostics.Debug.WriteLine($"Selected item: {item.Text}");
    }
    
    public DataViewModel()
    {
        List<ListItem> items = [];
        for (var i = 0; i < 25; i++)
        {
            items.Add(new ListItem($"Item {i}"));
        }

        Items = new (items);
    }
}

public class ListItem(string text)
{
    public string Text => text;
}