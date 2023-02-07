using API.Data.Repository.IRepository;

namespace API.Data.Repository
{
  public class UnitOfWork : IUnitOfWork
  {
    public ICustomerRepository CustomerRepository => throw new NotImplementedException();

    public IAccTypeRepository AccTypeRepository => throw new NotImplementedException();

    public IAccDpstRepository AccDpstRepository => throw new NotImplementedException();

    public IAccLoanRepository AccLoanRepository => throw new NotImplementedException();

    public ITransDpstRepository TransDpstRepository => throw new NotImplementedException();

    public ITransLoanRepository TransLoanRepository => throw new NotImplementedException();

    public IDocTypeRepository DocTypeRepository => throw new NotImplementedException();

    public IDocRepository DocRepository => throw new NotImplementedException();

    public IInfoRepository InfoRepository => throw new NotImplementedException();

    public Task<bool> Complete()
    {
      throw new NotImplementedException();
    }

    public bool HasChanges()
    {
      throw new NotImplementedException();
    }
  }
}