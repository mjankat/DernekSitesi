using DernekSitesi.Data;
using DernekSitesi.Data.Concrete;
using DernekSitesi.Entities;

namespace DernekSitesi.Service.Concrete
{
	public class Service<T> : Repository<T> where T : class, IEntity, new()
	{
		public Service(DatabaseContext context) : base(context)
		{
		}
	}
}
