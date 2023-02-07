using API.Data.Repository.IRepository;
using API.Entities;

namespace API.Data.Repository
{
  public class TransLoanRepository : Repository<TransLoan>, ITransLoanRepository
  {
    private readonly DataContext _db;
    public TransLoanRepository(DataContext db) : base(db)
    {
      _db = db;
    }

    public async Task<TransLoan> UpdateAsync(TransLoan entity)
    {
      _db.TransLoan.Update(entity);
      await _db.SaveChangesAsync();
      return entity;
    }
  }
}