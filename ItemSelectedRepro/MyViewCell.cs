using Microsoft.Maui.Controls;

namespace ItemSelectedRepro;

public class MyViewCell : ViewCell
{
    public MyViewCell()
    {
        App.AddWeakReference(this);
    }
}