using API.Entities;

namespace API.Data.Repository.IRepository
{
  public interface ITransDpstRepository : IRepository<TransDpst>
  {
    Task<TransDpst> UpdateAsync(TransDpst entity);
  }
}