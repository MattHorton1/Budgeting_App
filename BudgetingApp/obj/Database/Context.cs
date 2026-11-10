using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Earning> Earnings { get; set; }
    public DbSet<Expenditure> Expenditures { get; set; }
    public DbSet<Projection> Projections { get; set; }
    public DbSet<Goal> Goals { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Specify your database connection string here
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BudgetingAppDb;Trusted_Connection=True;");
    }
}