using API.Entities;

namespace API.Data.Repository.IRepository
{
  public interface IAccLoanRepository : IRepository<AccLoan>
  {
    Task<AccLoan> UpdateAsync(AccLoan entity);
  }
}