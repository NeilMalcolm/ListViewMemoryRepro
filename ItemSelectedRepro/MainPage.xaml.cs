using System;
using System.Linq;
using System.Text;
using Microsoft.Maui.Controls;

namespace ItemSelectedRepro;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OpenIssue1Page(object sender, EventArgs e)
    {
        Navigation.PushAsync(new RecycleAndHasUnevenRowsIssue()
        {
            BindingContext = new DataViewModel()
        });
    }

    private void OpenIssue2Page(object sender, EventArgs e)
    {
        Navigation.PushAsync(new RecycleElementIssue()
        {
            BindingContext = new DataViewModel()
        });
    }

    private void OpenPageWithoutIssue(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NoLeaksPage()
        {
            BindingContext = new DataViewModel()
        });
    }

    private void CheckWeakReferenceButton_OnClicked(object? sender, EventArgs e)
    {
        StringBuilder sb = new();

        var references = App.WeakReferences
            .Where(x => x.Value.IsAlive)
            .ToList();

        sb.AppendLine($"There are {references.Count} alive references.");

        foreach (var reference in references)
        {
            sb.AppendLine($"- {reference.Value.Target?.GetType().Name}");
        }

        AliveReferencesLabel.Text = sb.ToString();

        sb.Clear();
        
        references = App.WeakReferences
            .Where(x => !x.Value.IsAlive)
            .ToList();
        
        sb.AppendLine($"There are {references.Count} dead references.");
        
        foreach (var reference in references)
        {
            sb.AppendLine($"- {reference.Key}");
        }
        DeadReferencesLabel.Text = sb.ToString();
    }

    private void CollectGarbage(object? sender, EventArgs e)
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();
        
        long totalMemory = GC.GetTotalMemory(false);
        double totalMemoryMb = totalMemory / (1024d * 1024d);


        MemoryUsageLabel.Text = $"{totalMemoryMb:F2}MB";
    }
}