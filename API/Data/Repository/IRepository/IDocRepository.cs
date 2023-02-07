using API.Entities;

namespace API.Data.Repository.IRepository
{
  public interface IDocRepository : IRepository<Doc>
  {
    Task<Doc> UpdateAsync(Doc entity);
  }
}