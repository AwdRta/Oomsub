using API.Data.Repository.IRepository;
using API.Entities;

namespace API.Data.Repository
{
  public class InfoRepository : Repository<Info>, IInfoRepository
  {
    private readonly DataContext _db;
    public InfoRepository(DataContext db) : base(db)
    {
      _db = db;
    }

    public async Task<Info> UpdateAsync(Info entity)
    {
      _db.Info.Update(entity);
      await _db.SaveChangesAsync();
      return entity;
    }
  }
}