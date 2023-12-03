namespace DiaryOfSelfControl.Models.DatabaseEntities;

public class Diary
{
    public int Id { get; set; }
    public User User { get; set; }
    public IEnumerable<Record> Records { get; set; }
    public IEnumerable<ExerciseRecord> Exercise { get; set; }
    public IEnumerable<FoodRecord> Foods { get; set; }
}