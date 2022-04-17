using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;

namespace DataAccess.Repositories
{
    public class AboutRepository : EfEntityRepositoryBase<About, Context>, IAboutDal
    {
    }
}
