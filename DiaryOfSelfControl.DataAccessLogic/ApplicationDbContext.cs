using DiaryOfSelfControl.Models.DatabaseEntities;
using Microsoft.EntityFrameworkCore;

namespace DiaryOfSelfControl.DataAccessLogic;

public sealed class ApplicationDbContext : DbContext
{
    public ApplicationDbContext() => Database.EnsureCreated();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DiaryOfSelfControl;Trusted_Connection=True");
    }
    
    public DbSet<Diary> Diaries { get; set; }
    public DbSet<Exercise> Exercises { get; set; }
    public DbSet<ExerciseRecord> ExerciseRecords { get; set; }
    public DbSet<Food> Foods { get; set; }
    public DbSet<Person> Persons { get; set; }
    public DbSet<Record> Records { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<FoodRecord> FoodRecords { get; set; }
}