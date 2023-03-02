using System;
using System.Reactive;
using Avalonia.Controls;
using AvaTest1.Views;
using ReactiveUI;

namespace AvaTest1.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private string _userInput;
    private string _buttonContent = "Стереть";
    private string _nextWindowContent = "Перейти";
    

    public MainWindowViewModel()
    {
        
        EraseCommand = ReactiveCommand.Create(() =>
        {
            UserInput = "";  
        });

        CloseAllCommand = ReactiveCommand.Create(() =>
        {
            Environment.Exit(0);
        });

        NextWindowCommand = ReactiveCommand.Create(() =>
        {
            /*ProfileView profileView = new ProfileView();*/
            
            ClassHelper.NavigateClass.ChangeWindow(new ProfileView());
            
            
        });
    }
    
    public string UserInput
    {
        get => _userInput;
        set => this.RaiseAndSetIfChanged(ref _userInput, value);
    }

    public string NextWindowContent
    {
        get => _nextWindowContent;
    }
    
    public string ButtonContent
    {
        get => _buttonContent;
    }
    
    public ReactiveCommand<Unit, Unit> NextWindowCommand { get; }

    public ReactiveCommand<Unit, Unit> EraseCommand { get; }
    
    public ReactiveCommand<Unit, Unit> CloseAllCommand { get; }
}