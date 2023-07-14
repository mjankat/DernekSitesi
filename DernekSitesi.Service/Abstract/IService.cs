using DernekSitesi.Data.Abstract;
using DernekSitesi.Entities;

namespace DernekSitesi.Service.Abstract
{
	public interface IService<T> : IRepository<T> where T : class,IEntity, new()
	{
	}
}
