namespace ItemSelectedRepro;

public partial class RecycleElementIssue : ContentPage
{
    public RecycleElementIssue()
    {
        InitializeComponent();
    }
    
    protected override void OnDisappearing()
    {;
        foreach (var view in this.GetVisualTreeDescendants())
        {
            App.AddWeakReference(view);
        }
        
        base.OnDisappearing();
    }
}