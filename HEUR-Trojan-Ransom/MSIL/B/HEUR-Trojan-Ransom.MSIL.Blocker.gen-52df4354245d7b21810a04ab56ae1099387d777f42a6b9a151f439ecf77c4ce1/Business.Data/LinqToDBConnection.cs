using System;
using System.Collections.Generic;
using System.Data;
using LinqToDB;
using LinqToDB.Data;
using LinqToDB.DataProvider;

namespace Business.Data;

public abstract class LinqToDBConnection<IEntity> : DataConnection, IDisposable, ITransaction, IConnection, IData2 where IEntity : class, Business.Data.IEntity
{
	public abstract IEntity Entity { get; }

	Business.Data.IEntity IConnection.Entity => Entity;

	IDbTransaction ITransaction.Transaction => ((DataConnection)this).get_Transaction();

	private static int ForEach<T>(IEnumerable<T> obj, Func<T, int> func)
	{
		int num = 0;
		foreach (T item in obj)
		{
			int num2 = func(item);
			if (Convert.ToInt32(-1.0) != num2)
			{
				num += num2;
				continue;
			}
			return num2;
		}
		return num;
	}

	public LinqToDBConnection()
	{
	}

	public LinqToDBConnection(string configuration)
		: base(configuration)
	{
	}

	public LinqToDBConnection(string providerName, string connectionString)
		: base(providerName, connectionString)
	{
	}

	public LinqToDBConnection(IDataProvider provider, string conString)
		: base(provider, conString)
	{
	}

	public void BeginTransaction()
	{
		((DataConnection)this).BeginTransaction();
	}

	public void BeginTransaction(IsolationLevel isolationLevel)
	{
		((DataConnection)this).BeginTransaction(isolationLevel);
	}

	public void Commit()
	{
		((DataConnection)this).CommitTransaction();
	}

	public void Rollback()
	{
		((DataConnection)this).RollbackTransaction();
	}

	public int Save<T>(IEnumerable<T> obj)
	{
		return this.ExecutePack(() => ForEach(obj, (T item) => DataExtensions.Insert<T>((IDataContext)(object)this, item, (string)null, (string)null, (string)null)));
	}

	public int Save<T>(T obj)
	{
		return this.ExecutePack(() => DataExtensions.Insert<T>((IDataContext)(object)this, obj, (string)null, (string)null, (string)null));
	}

	public int SaveWithInt32Identity<T>(T obj)
	{
		return this.ExecutePack(() => DataExtensions.InsertWithInt32Identity<T>((IDataContext)(object)this, obj, (string)null, (string)null, (string)null));
	}

	public long SaveWithInt64Identity<T>(T obj)
	{
		return this.ExecutePack(() => DataExtensions.InsertWithInt64Identity<T>((IDataContext)(object)this, obj, (string)null, (string)null, (string)null));
	}

	public int SaveOrUpdate<T>(IEnumerable<T> obj)
	{
		return this.ExecutePack(() => ForEach(obj, (T item) => DataExtensions.InsertOrReplace<T>((IDataContext)(object)this, item, (string)null, (string)null, (string)null)));
	}

	public int SaveOrUpdate<T>(T obj)
	{
		return this.ExecutePack(() => DataExtensions.InsertOrReplace<T>((IDataContext)(object)this, obj, (string)null, (string)null, (string)null));
	}

	public int Update<T>(IEnumerable<T> obj)
	{
		return this.ExecutePack(() => ForEach(obj, (T item) => DataExtensions.Update<T>((IDataContext)(object)this, item, (string)null, (string)null, (string)null)));
	}

	public int Update<T>(T obj)
	{
		return this.ExecutePack(() => DataExtensions.Update<T>((IDataContext)(object)this, obj, (string)null, (string)null, (string)null));
	}

	public int Delete<T>(IEnumerable<T> obj)
	{
		return this.ExecutePack(() => ForEach(obj, (T item) => DataExtensions.Delete<T>((IDataContext)(object)this, item, (string)null, (string)null, (string)null)));
	}

	public int Delete<T>(T obj)
	{
		return this.ExecutePack(() => DataExtensions.Delete<T>((IDataContext)(object)this, obj, (string)null, (string)null, (string)null));
	}

	public void BulkCopy<T>(IEnumerable<T> source) where T : class
	{
		DataConnectionExtensions.BulkCopy<T>((DataConnection)(object)this, source);
	}

	public void Dispose()
	{
		((DataConnection)this).DisposeCommand();
		((DataConnection)this).Dispose();
		if (((DataConnection)this).get_Transaction() != null)
		{
			((DataConnection)this).get_Transaction().Dispose();
		}
		if (((DataConnection)this).get_Connection() != null)
		{
			((DataConnection)this).get_Connection().Dispose();
		}
	}

	IDbCommand IConnection.CreateCommand()
	{
		return ((DataConnection)this).CreateCommand();
	}
}
