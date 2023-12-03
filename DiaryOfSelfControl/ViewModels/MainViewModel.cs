using System;
using System.Windows.Input;
using DiaryOfSelfControl.Infrastructure.Commands;
using DiaryOfSelfControl.Infrastructure.ViewModels.Base;

namespace DiaryOfSelfControl.ViewModels;

public class MainViewModel : BaseViewModel
{
    #region Properties

    #region GeneralInfoViewModel : GeneralInfoViewModel - Description

    private GeneralInfoViewModel _generalInfoViewModel;

    /// <summary> Description </summary>
    public GeneralInfoViewModel GeneralInfoViewModel
    {
        get => _generalInfoViewModel;
        set => SetField(ref _generalInfoViewModel, value);
    }

    #endregion GeneralInfoViewModel

    #endregion

    #region Commands

    #region AddRecordCommand : Добавление новой записи

    /// <summary> Добавление новой записи </summary>
    public ICommand AddRecordCommand { get; set; }

    private void OnAddRecordCommandExecuted(object? parameter)
    {
        var dateTime = DateTime.Now;
        // TODO Проверять нет ли такой записи
        if (dateTime.Hour is > 5 and < 13)
        {
            // TODO Add morning record
        }
        else if (dateTime.Hour is > 16 and < 23)
        {
            // TODO Add night record
        }
        
        // TODO Вывести меню с доп вкладками
    }

    private bool CanAddRecordCommandExecute(object? parameter) => true;

    #endregion AddRecord

    #endregion

    #region Constructor

    public MainViewModel()
    {
        GeneralInfoViewModel = new GeneralInfoViewModel();
        
        AddRecordCommand = new RelayCommand(OnAddRecordCommandExecuted, CanAddRecordCommandExecute);
    }

    #endregion
}