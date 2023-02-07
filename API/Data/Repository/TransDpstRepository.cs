using API.Data.Repository.IRepository;
using API.Entities;

namespace API.Data.Repository
{
  public class TransDpstRepository : Repository<TransDpst>, ITransDpstRepository
  {
    private readonly DataContext _db;
    public TransDpstRepository(DataContext db) : base(db)
    {
      _db = db;
    }

    public async Task<TransDpst> UpdateAsync(TransDpst entity)
    {
      _db.TransDpst.Update(entity);
      await _db.SaveChangesAsync();
      return entity;
    }
  }
}