using DernekSitesi.Data;
using DernekSitesi.Data.Concrete;
using DernekSitesi.Entities;
using DernekSitesi.Service.Abstract;

namespace DernekSitesi.Service.Concrete
{
	public class Service<T> : Repository<T>, IService<T> where T : class, IEntity, new()
	{
		public Service(DatabaseContext context) : base(context)
		{
		}
	}
}
