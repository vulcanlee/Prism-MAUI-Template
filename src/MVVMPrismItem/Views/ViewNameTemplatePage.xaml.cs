using PrismApp1.ViewModels;

namespace PrismApp1.Views;

public partial class ViewNameTemplatePage : ContentPage
{
    public ViewNameTemplatePage(ViewNameTemplatePageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}

