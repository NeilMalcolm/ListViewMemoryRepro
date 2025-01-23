using System;
using System.Collections.Generic;
using Microsoft.Maui.Controls;

namespace ItemSelectedRepro;

public partial class App : Application
{
    public static List<KeyValuePair<string, WeakReference>> WeakReferences { get; } = new();
    
    public static void AddWeakReference(object obj)
    {
        WeakReferences.Add(new (obj.GetType().Name, new WeakReference(obj)));
    }
    
	public App()
	{
		InitializeComponent();
		MainPage = new NavigationPage(new MainPage());
	}
}