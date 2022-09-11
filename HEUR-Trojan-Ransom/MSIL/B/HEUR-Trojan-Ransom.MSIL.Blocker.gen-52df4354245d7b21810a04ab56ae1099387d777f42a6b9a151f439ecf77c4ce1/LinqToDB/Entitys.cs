using System.Linq;
using Business.Data;
using LinqToDB.Data;
using LinqToDB.DataProvider;

namespace LinqToDB;

public abstract class Entitys : DataConnection, IEntity
{
	public Entitys()
	{
	}

	public Entitys(string configuration)
		: base(configuration)
	{
	}

	public Entitys(string providerName, string connectionString)
		: base(providerName, connectionString)
	{
	}

	public Entitys(IDataProvider dataProvider, string connectionString)
		: base(dataProvider, connectionString)
	{
	}

	public virtual IQueryable<T> Get<T>() where T : class, new()
	{
		return (IQueryable<T>)((DataConnection)this).GetTable<T>();
	}
}
