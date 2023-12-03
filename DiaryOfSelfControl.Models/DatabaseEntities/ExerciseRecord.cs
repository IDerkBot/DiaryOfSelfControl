namespace DiaryOfSelfControl.Models.DatabaseEntities;

public class ExerciseRecord : RecordBase
{
    public int Id { get; set; }
    public Exercise Exercise { get; set; }

    public int BurnedCalories { get; set; }

    public TimeSpan Duration { get; set; }
    public double Value { get; set; }
}