using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data.Repository.IRepository
{
  public interface IUnitOfWork
  {
    ICustomerRepository CustomerRepository { get; }

    IAccTypeRepository AccTypeRepository { get; }
    IAccDpstRepository AccDpstRepository { get; }
    IAccLoanRepository AccLoanRepository { get; }
    ITransDpstRepository TransDpstRepository { get; }
    ITransLoanRepository TransLoanRepository { get; }

    IDocTypeRepository DocTypeRepository { get; }
    IDocRepository DocRepository { get; }
    IInfoRepository InfoRepository { get; }

    Task<bool> Complete();
    bool HasChanges();
  }
}