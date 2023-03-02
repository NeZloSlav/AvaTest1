using Avalonia.Controls;

namespace AvaTest1.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        ClassHelper.NavigateClass.currentWindow = this;
    }
}