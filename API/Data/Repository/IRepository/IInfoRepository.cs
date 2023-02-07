using API.Entities;

namespace API.Data.Repository.IRepository
{
  public interface IInfoRepository : IRepository<Info>
  {
    Task<Info> UpdateAsync(Info entity);
  }
}