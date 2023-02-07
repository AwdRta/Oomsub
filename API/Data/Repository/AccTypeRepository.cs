using API.Data.Repository.IRepository;
using API.Entities;

namespace API.Data.Repository
{
  public class AccTypeRepository : Repository<AccType>, IAccTypeRepository
  {
    private readonly DataContext _db;
    public AccTypeRepository(DataContext db) : base(db)
    {
      _db = db;
    }

    public async Task<AccType> UpdateAsync(AccType entity)
    {
      _db.AccType.Update(entity);
      await _db.SaveChangesAsync();
      return entity;
    }
  }
}