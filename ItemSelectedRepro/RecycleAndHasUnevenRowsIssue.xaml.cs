namespace ItemSelectedRepro;

public partial class RecycleAndHasUnevenRowsIssue : ContentPage
{
    public RecycleAndHasUnevenRowsIssue()
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