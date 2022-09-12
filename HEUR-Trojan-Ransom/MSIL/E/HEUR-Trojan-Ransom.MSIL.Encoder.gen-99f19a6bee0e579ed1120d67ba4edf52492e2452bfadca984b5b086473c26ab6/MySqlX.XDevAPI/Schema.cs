using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
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

	public Collection CreateCollection(string collectionName, bool ReuseExistingObject = false)
	{
		ValidateOpenSession();
		Collection collection = new Collection(this, collectionName);
		if (ReuseExistingObject && collection.ExistsInDatabase())
		{
			return collection;
		}
		Session.XSession.CreateCollection(base.Name, collectionName);
		return new Collection(this, collectionName);
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
