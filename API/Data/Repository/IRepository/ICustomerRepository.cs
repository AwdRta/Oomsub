using API.Entities;

namespace API.Data.Repository.IRepository
{
  public interface ICustomerRepository : IRepository<Customer>
  {
    Task<Customer> UpdateAsync(Customer entity);
  }
}