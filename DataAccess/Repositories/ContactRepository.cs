using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;

namespace DataAccess.Repositories
{
    public class ContactRepository : EfEntityRepositoryBase<Contact, Context>, IContactDal
    {
    }
}
