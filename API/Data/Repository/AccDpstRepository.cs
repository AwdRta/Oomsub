using API.Data.Repository.IRepository;
using API.Entities;

namespace API.Data.Repository
{
  public class AccDpstRepository : Repository<AccDpst>, IAccDpstRepository
  {
    private readonly DataContext _db;
    public AccDpstRepository(DataContext db) : base(db)
    {
      _db = db;
    }

    public async Task<AccDpst> UpdateAsync(AccDpst entity)
    {
      _db.AccDpst.Update(entity);
      await _db.SaveChangesAsync();
      return entity;
    }
  }
}