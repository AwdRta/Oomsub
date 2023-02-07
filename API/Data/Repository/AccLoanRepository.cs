using API.Data.Repository.IRepository;
using API.Entities;

namespace API.Data.Repository
{
  public class AccLoanRepository : Repository<AccLoan>, IAccLoanRepository
  {
    private readonly DataContext _db;
    public AccLoanRepository(DataContext db) : base(db)
    {
      _db = db;
    }

    public async Task<AccLoan> UpdateAsync(AccLoan entity)
    {
      _db.AccLoan.Update(entity);
      await _db.SaveChangesAsync();
      return entity;
    }
  }
}