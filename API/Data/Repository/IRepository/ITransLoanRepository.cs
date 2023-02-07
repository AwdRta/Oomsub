using API.Entities;

namespace API.Data.Repository.IRepository
{
  public interface ITransLoanRepository : IRepository<TransLoan>
  {
    Task<TransLoan> UpdateAsync(TransLoan entity);
  }
}