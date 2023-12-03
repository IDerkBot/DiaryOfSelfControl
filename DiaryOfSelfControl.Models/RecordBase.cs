namespace DiaryOfSelfControl.Models;

public class RecordBase
{
    public DateTime DateTime { get; set; }
    
    public int Pulse { get; set; }
    public int DiastolicPressure { get; set; }
    public int SystolicPressure { get; set; }
    
    public uint WellBeing { get; set; }
}