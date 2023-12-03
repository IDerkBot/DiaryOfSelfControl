using System;
using System.Collections.Generic;
using DiaryOfSelfControl.Infrastructure.ViewModels.Base;
using DiaryOfSelfControl.Models;
using DiaryOfSelfControl.Models.DatabaseEntities;

namespace DiaryOfSelfControl.ViewModels;

public class GeneralInfoViewModel : BaseViewModel
{
    #region Records : IEnumerator<RecordBase> - Список записей

    private IEnumerable<RecordBase> _records;

    /// <summary> Description </summary>
    public IEnumerable<RecordBase> Records
    {
        get => _records;
        set => SetField(ref _records, value);
    }

    #endregion Records

    public GeneralInfoViewModel()
    {
        var exercise = new Exercise()
        {
            Id = 1, Name = "БЕГ"
        };
        Records = new List<RecordBase>
        {
            new Record
            {
                DateTime = DateTime.Now,
                DiastolicPressure = 140,
                SystolicPressure = 100,
                Pulse = 90,
                StepsCount = 35405
            },
            new Record
            {
                DateTime = DateTime.Now,
                DiastolicPressure = 140,
                SystolicPressure = 100,
                Pulse = 90,
                Temperature = 36.6,
                IsMorning = true
            },
            new ExerciseRecord()
            {
                DateTime = DateTime.Now,
                BurnedCalories = 300,
                DiastolicPressure = 140,
                SystolicPressure = 100,
                Duration = new TimeSpan(0,1,30,25),
                Exercise = exercise
            }
        };
    }
}