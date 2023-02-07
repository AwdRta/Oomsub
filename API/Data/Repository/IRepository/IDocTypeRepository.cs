using API.Entities;

namespace API.Data.Repository.IRepository
{
  public interface IDocTypeRepository : IRepository<DocType>
  {
    Task<DocType> UpdateAsync(DocType entity);
  }
}