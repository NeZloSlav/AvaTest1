using System;
using System.Collections;
using System.Collections.Generic;
using System.Reactive;
using Avalonia.Controls;
using AvaTest1.ClassHelper;
using AvaTest1.Models;
using AvaTest1.Services;
using AvaTest1.Views;
using ReactiveUI;

namespace AvaTest1.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private string _tbxLoginContent;
    private string _tbxPasswordContent;
    private User currentUser;
    
    public MainWindowViewModel()
    {
        LoginCommand = ReactiveCommand.Create(() =>
        {
            if (IsLogged())
            {
                CurrentUser.user = currentUser;
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.DataContext = new LoginWindowViewModel();
                NavigateClass.ChangeWindow(loginWindow);
            }

        });

        RegisterCommand = ReactiveCommand.Create(() =>
        {

        });
    }

    private bool IsLogged()
    {
        Database db = new Database();
        List<User> list = db.Users;

        foreach (var user in list)
        {
            if (user.Login == TbxLoginContent)
            {
                if (user.Password == TbxPasswordContent)
                {
                    currentUser = user;
                    return true;
                }

                return false;
            }
        }

        return false;
    }

    public string TbxLoginContent
    {
        get => _tbxLoginContent;
        set => this.RaiseAndSetIfChanged(ref _tbxLoginContent, value);
    }

    public string TbxPasswordContent
    {
        get => _tbxPasswordContent;
        set => this.RaiseAndSetIfChanged(ref _tbxPasswordContent, value);
    }
    
    public ReactiveCommand<Unit, Unit> LoginCommand { get; }
    public ReactiveCommand<Unit, Unit> RegisterCommand { get; }

}