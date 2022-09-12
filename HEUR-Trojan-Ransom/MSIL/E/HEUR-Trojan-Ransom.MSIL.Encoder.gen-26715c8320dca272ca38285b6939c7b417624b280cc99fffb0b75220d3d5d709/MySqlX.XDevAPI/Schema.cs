using System;
using System.Collections.Generic;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.X.XDevAPI.Common;
using MySqlX.XDevAPI.Relational;

namespace MySqlX.XDevAPI;

public class Schema : DatabaseObject
{
	public new BaseSession Session { get; private set; }

	internal Schema(BaseSession session, string name)
		: base(null, name)
	{
		base.Schema = this;
		Session = session;
	}

	public List<Collection> GetCollections()
	{
		ValidateOpenSession();
		return Session.XSession.GetObjectList<Collection>(this, new string[1] { "COLLECTION" });
	}

	public List<Table> GetTables()
	{
		ValidateOpenSession();
		return Session.XSession.GetObjectList<Table>(this, new string[2] { "TABLE", "VIEW" });
	}

	public Collection GetCollection(string name, bool ValidateExistence = false)
	{
		Collection collection = new Collection<DbDoc>(this, name);
		if (ValidateExistence)
		{
			ValidateOpenSession();
			if (!collection.ExistsInDatabase())
			{
				throw new MySqlException($"Collection '{name}' does not exist.");
			}
		}
		return collection;
	}

	public Collection<T> GetCollection<T>(string name)
	{
		return new Collection<T>(this, name);
	}

	public Table GetCollectionAsTable(string name)
	{
		return GetTable(name);
	}

	public Table GetTable(string name)
	{
		return new Table(this, name);
	}

	public Collection CreateCollection(string collectionName, bool ReuseExisting = false)
	{
		ValidateOpenSession();
		Collection result = new Collection(this, collectionName);
		try
		{
			if (Session.Version.isAtLeast(8, 0, 19))
			{
				CreateCollectionOptions createCollectionOptions = default(CreateCollectionOptions);
				createCollectionOptions.ReuseExisting = ReuseExisting;
				CreateCollectionOptions options = createCollectionOptions;
				Session.XSession.CreateCollection(base.Name, collectionName, options);
			}
			else
			{
				Session.XSession.CreateCollection(base.Name, collectionName);
			}
		}
		catch (MySqlException ex) when (ex.Code == 1050)
		{
			if (!ReuseExisting)
			{
				throw ex;
			}
			return result;
		}
		return new Collection(this, collectionName);
	}

	public Collection CreateCollection(string collectionName, CreateCollectionOptions options)
	{
		ValidateOpenSession();
		Collection result = new Collection(this, collectionName);
		try
		{
			Session.XSession.CreateCollection(base.Name, collectionName, options);
			return new Collection(this, collectionName);
		}
		catch (MySqlException ex) when (ex.Code == 5015)
		{
			throw new MySqlException(string.Format("{0}{1}{2}", ex.Message, ", ", ResourcesX.SchemaCreateCollectionMsg));
		}
		catch (MySqlException ex2) when (ex2.Code == 1050)
		{
			if (!options.ReuseExisting)
			{
				throw ex2;
			}
			return result;
		}
		catch (MySqlException ex3)
		{
			throw ex3;
		}
	}

	public Collection ModifyCollection(string collectionName, ModifyCollectionOptions? options)
	{
		ValidateOpenSession();
		try
		{
			Session.XSession.ModifyCollection(base.Name, collectionName, options);
			return new Collection(this, collectionName);
		}
		catch (MySqlException ex) when (ex.Code == 5157)
		{
			throw new MySqlException(string.Format("{0}{1}{2}", ex.Message, ", ", ResourcesX.SchemaCreateCollectionMsg));
		}
		catch (MySqlException ex2)
		{
			throw ex2;
		}
	}

	public void DropCollection(string name)
	{
		if (string.IsNullOrWhiteSpace(name))
		{
			throw new ArgumentNullException("name");
		}
		ValidateOpenSession();
		if (GetCollection(name).ExistsInDatabase())
		{
			Session.XSession.DropCollection(base.Name, name);
		}
	}

	public override bool ExistsInDatabase()
	{
		ValidateOpenSession();
		string sql = $"SELECT COUNT(*) FROM information_schema.schemata WHERE schema_name like '{base.Name}'";
		return (long)Session.InternalSession.ExecuteQueryAsScalar(sql) > 0L;
	}
}
