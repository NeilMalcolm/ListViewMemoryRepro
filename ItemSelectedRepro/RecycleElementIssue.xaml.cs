using System;
using Microsoft.Maui.Controls;

namespace ItemSelectedRepro;

public partial class RecycleElementIssue : ContentPage
{
    public RecycleElementIssue()
    {
        InitializeComponent();
        App.AddWeakReference(RecycleElementList);
        App.AddWeakReference(this);
    }

    private void GoBack(object? sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}