using System;
using Microsoft.Maui.Controls;

namespace ItemSelectedRepro;

public partial class NoLeaksPage : ContentPage
{
    public NoLeaksPage()
    {
        InitializeComponent();
        App.AddWeakReference(HasUnevenRowsList);
        App.AddWeakReference(this);
    }

    private void GoBack(object? sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}