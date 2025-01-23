using System;
using Microsoft.Maui.Controls;

namespace ItemSelectedRepro;

public partial class RecycleAndHasUnevenRowsIssue : ContentPage
{
    public RecycleAndHasUnevenRowsIssue()
    {
        InitializeComponent();
        App.AddWeakReference(IssuePageList);
        App.AddWeakReference(this);
    }

    private void GoBack(object? sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}