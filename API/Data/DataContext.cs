using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<AccType> AccType { get; set; }
    public DbSet<AccDpst> AccDpst { get; set; }
    public DbSet<TransDpst> TransDpst { get; set; }
    public DbSet<AccLoan> AccLoan { get; set; }
    public DbSet<TransLoan> TransLoan { get; set; }
    public DbSet<Customer> Customer { get; set; }
    public DbSet<DocType> DocType { get; set; }
    public DbSet<Doc> Doc { get; set; }
    public DbSet<Info> Info { get; set; }
  }
}