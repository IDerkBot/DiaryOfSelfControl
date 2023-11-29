namespace DiaryOfSelfControl.Models.DatabaseEntities;

public class User
{
    public int Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public byte Access { get; set; }
}