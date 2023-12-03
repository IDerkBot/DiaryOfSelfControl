namespace DiaryOfSelfControl.Models.DatabaseEntities;

public class FoodRecord : RecordBase
{
    public int Id { get; set; }
    public Food Food { get; set; }
    public double Weight { get; set; }
}