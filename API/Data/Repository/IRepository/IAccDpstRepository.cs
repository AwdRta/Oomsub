using API.Entities;

namespace API.Data.Repository.IRepository
{
  public interface IAccDpstRepository : IRepository<AccDpst>
  {
    Task<AccDpst> UpdateAsync(AccDpst entity);
  }
}