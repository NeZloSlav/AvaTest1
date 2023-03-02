using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaTest1.Views;

public partial class ProfileView : Window
{
    public ProfileView()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}