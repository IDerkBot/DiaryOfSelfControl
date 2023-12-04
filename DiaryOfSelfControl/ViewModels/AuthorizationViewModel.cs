using System;
using System.IO;
using System.Net;
using System.Windows;
using System.Windows.Input;
using DiaryOfSelfControl.Infrastructure.Commands;
using DiaryOfSelfControl.Infrastructure.ViewModels.Base;
using DiaryOfSelfControl.Views;

namespace DiaryOfSelfControl.ViewModels;

public class AuthorizationViewModel : BaseViewModel
{
    #region Private Properies

    private readonly string _appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
    private const string CompanyName = "StarFox";
    private const string ApplicationName = "DiaryOfSelfControl";
    private const string FileName = ".userdata";

    #endregion
    
    #region Properties

    #region Login : string - Логин пользователя

    private string _login;

    /// <summary> Логин пользователя </summary>
    public string Login
    {
        get => _login;
        set => SetField(ref _login, value);
    }

    #endregion Login

    #region Password : string - Пароль пользователя

    private string _password;

    /// <summary> Пароль пользователя </summary>
    public string Password
    {
        get => _password;
        set => SetField(ref _password, value);
    }

    #endregion Password

    #region RememberMe : bool - Указывает, запоминать логин и пароль пользователя

    private bool _rememberMe;

    /// <summary> Указывает, запоминать логин и пароль пользователя </summary>
    public bool RememberMe
    {
        get => _rememberMe;
        set => SetField(ref _rememberMe, value);
    }

    #endregion RememberMe
    
    #endregion
    
    #region Commands

    #region ShutdownCommand : Выключение программы

    /// <summary> Выключение программы </summary>
    public ICommand ShutdownCommand { get; set; }

    private void OnShutdownCommandExecuted(object? parameter)
    {
        Application.Current.Shutdown();
    }

    private bool CanShutdownCommandExecute(object? parameter) => true;

    #endregion Shutdown

    #region EnterCommand : Авторизация

    /// <summary> Авторизация </summary>
    public ICommand EnterCommand { get; set; }

    private void OnEnterCommandExecuted(object? parameter)
    {
        // TODO Авторизация

        if (RememberMe)
        {
            var path = $@"{_appData}\{CompanyName}\";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            path += $@"{ApplicationName}\";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            path += $"{FileName}";
            if (!File.Exists(path))
                File.Create(path);
        }

        if (string.IsNullOrWhiteSpace(Login))
        {
            MessageBox.Show("Вы не ввели логин");
        }
        else if (string.IsNullOrWhiteSpace(Password))
        {
            MessageBox.Show("Вы не ввели пароль");
        }
        
        // TODO Проверка пользователя
        
        // В случае если пользователь существует
        
        // Проверяем правильный пароль
        
        
        if(parameter is AuthorizationView view) view.Close();
        
        // TODO Запись данных в папку в случае если стоит галочка "Запомнить меня"
    }

    private bool CanEnterCommandExecute(object? parameter) => true;

    #endregion Enter

    #region LoadedCommand : Загрузка окна

    /// <summary> Загрузка окна </summary>
    public ICommand LoadedCommand { get; set; }

    private void OnLoadedCommandExecuted(object? parameter)
    {
        // TODO Проверить файл
        // Если он есть, то проверить стоит галочка или нет
        // Если стоит ввести данные в поля и авторизоваться

        var filePath = $@"{_appData}\{CompanyName}\{ApplicationName}\{FileName}";
        if (File.Exists(filePath))
        {
            
        }
    }

    private bool CanLoadedCommandExecute(object? parameter) => true;

    #endregion Loaded

    #endregion
    
    public AuthorizationViewModel()
    {
        LoadedCommand = new RelayCommand(OnLoadedCommandExecuted, CanLoadedCommandExecute);
        ShutdownCommand = new RelayCommand(OnShutdownCommandExecuted, CanShutdownCommandExecute);
        EnterCommand = new RelayCommand(OnEnterCommandExecuted, CanEnterCommandExecute);
    }
}