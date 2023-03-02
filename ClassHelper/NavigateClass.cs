using Avalonia.Controls;

namespace AvaTest1.ClassHelper;

public class NavigateClass
{
    public static Window currentWindow;
    private static Window previousWindow;

    public static void ChangeWindow(Window nextWindow)
    {
        nextWindow.Show();
        currentWindow.Close();
    }
}