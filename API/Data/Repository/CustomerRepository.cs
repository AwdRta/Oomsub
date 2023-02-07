using API.Data.Repository.IRepository;
using API.Entities;

namespace API.Data.Repository
{
  public class CustomerRepository : Repository<Customer>, ICustomerRepository
  {
    private readonly DataContext _db;
    public CustomerRepository(DataContext db) : base(db)
    {
      _db = db;
    }

    public async Task<Customer> UpdateAsync(Customer entity)
    {
      _db.Customer.Update(entity);
      await _db.SaveChangesAsync();
      return entity;
    }
  }
}