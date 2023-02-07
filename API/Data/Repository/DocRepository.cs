using API.Data.Repository.IRepository;
using API.Entities;

namespace API.Data.Repository
{
  public class DocRepository : Repository<Doc>, IDocRepository
  {
    private readonly DataContext _db;
    public DocRepository(DataContext db) : base(db)
    {
      _db = db;
    }

    public async Task<Doc> UpdateAsync(Doc entity)
    {
      _db.Doc.Update(entity);
      await _db.SaveChangesAsync();
      return entity;
    }
  }
}