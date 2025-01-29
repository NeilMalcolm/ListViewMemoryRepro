namespace ItemSelectedRepro;

public partial class NoLeaksPage : ContentPage
{
    public NoLeaksPage()
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