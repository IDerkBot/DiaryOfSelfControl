namespace DiaryOfSelfControl.Models.DatabaseEntities;

public class Person
{
    public int Id { get; set; }
    public string Surname { get; set; }
    public string Name { get; set; }
    public string? Patrinymic { get; set; }
    public bool IsMale { get; set; }
    public DateTime BirthDay { get; set; }
    public uint Age => DateTime.Now.Subtract(BirthDay).Days >= 365 ? (uint)(DateTime.Now.Subtract(BirthDay).Days / 365) : 0;
    
    public User User { get; set; }
}