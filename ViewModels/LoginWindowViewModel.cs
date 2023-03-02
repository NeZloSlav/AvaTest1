using AvaTest1.ClassHelper;


namespace AvaTest1.ViewModels;

public class LoginWindowViewModel : ViewModelBase
{
    public string HelloUser
    {
        get => $"Здравствуйте, {CurrentUser.user.Login}";
    }

    public string Login
    {
        get => CurrentUser.user.Login;
    }

    public string Password
    {
        get => CurrentUser.user.Password;
    }
}