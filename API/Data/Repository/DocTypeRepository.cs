using API.Data.Repository.IRepository;
using API.Entities;

namespace API.Data.Repository
{
  public class DocTypeRepository : Repository<DocType>, IDocTypeRepository
  {
    private readonly DataContext _db;
    public DocTypeRepository(DataContext db) : base(db)
    {
      _db = db;
    }

    public async Task<DocType> UpdateAsync(DocType entity)
    {
      _db.DocType.Update(entity);
      await _db.SaveChangesAsync();
      return entity;
    }
  }
}