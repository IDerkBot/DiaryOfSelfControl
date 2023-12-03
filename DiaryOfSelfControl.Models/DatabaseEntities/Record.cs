namespace DiaryOfSelfControl.Models.DatabaseEntities;

public class Record : RecordBase
{
    public int Id { get; set; }
    
    public bool IsMorning { get; set; }
    
    // INFO
    public double Temperature { get; set; }
    public bool Sleep { get; set; }

    public int StepsCount { get; set; }
    public bool PhysicalLesson { get; set; }
    public bool Section { get; set; }
    public bool Sport { get; set; }
}