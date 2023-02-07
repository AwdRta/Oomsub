using API.Entities;

namespace API.Data.Repository.IRepository
{
  public interface IAccTypeRepository : IRepository<AccType>
  {
    Task<AccType> UpdateAsync(AccType entity);
  }
}