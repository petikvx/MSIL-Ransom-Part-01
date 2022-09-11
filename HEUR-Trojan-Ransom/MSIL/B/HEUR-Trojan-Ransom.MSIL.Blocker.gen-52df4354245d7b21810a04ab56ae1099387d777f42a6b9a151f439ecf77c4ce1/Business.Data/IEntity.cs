using System.Linq;

namespace Business.Data;

public interface IEntity
{
	IQueryable<T> Get<T>() where T : class, new();
}
