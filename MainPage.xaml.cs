using Wasserzaehler.ViewModels;

namespace Wasserzaehler;

public partial class MainPage : ContentPage
{
    

    public MainPage()
    {
        InitializeComponent();
        this.BindingContext = new MainViewModels();
    }


}
