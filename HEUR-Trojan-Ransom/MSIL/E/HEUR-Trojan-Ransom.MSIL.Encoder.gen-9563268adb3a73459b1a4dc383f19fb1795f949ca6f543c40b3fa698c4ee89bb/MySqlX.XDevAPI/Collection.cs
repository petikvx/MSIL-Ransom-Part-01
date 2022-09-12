using System;
using System.Collections.Generic;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.CRUD;
using MySqlX.XDevAPI.Common;

namespace MySqlX.XDevAPI;

public class Collection : DatabaseObject
{
	internal Collection(Schema schema, string name)
		: base(schema, name)
	{
	}

	public AddStatement Add(params object[] items)
	{
		if (items == null)
		{
			throw new ArgumentNullException();
		}
		AddStatement addStatement = new AddStatement(this);
		addStatement.Add(items);
		return addStatement;
	}

	public RemoveStatement Remove(string condition)
	{
		if (string.IsNullOrWhiteSpace(condition))
		{
			throw new ArgumentNullException("condition", Resources.ParameterNullOrEmpty);
		}
		return new RemoveStatement(this, condition);
	}

	public Result RemoveOne(object id)
	{
		if (id == null)
		{
			throw new ArgumentNullException("id");
		}
		if (string.IsNullOrWhiteSpace(id.ToString()))
		{
			throw new ArgumentNullException("id", Resources.ParameterNullOrEmpty);
		}
		return Remove("_id = :id").Bind("id", id).Execute();
	}

	public ModifyStatement Modify(string condition)
	{
		if (string.IsNullOrWhiteSpace(condition))
		{
			throw new ArgumentNullException("condition", Resources.ParameterNullOrEmpty);
		}
		return new ModifyStatement(this, condition);
	}

	public Result ReplaceOne(object id, object doc)
	{
		if (id == null)
		{
			throw new ArgumentNullException("id");
		}
		string value = id.ToString();
		if (string.IsNullOrWhiteSpace(value))
		{
			throw new ArgumentNullException("id", Resources.ParameterNullOrEmpty);
		}
		if (doc == null)
		{
			throw new ArgumentNullException("doc");
		}
		DbDoc one = GetOne(id);
		ModifyStatement modifyStatement = Modify("_id = :id").Bind("id", value);
		DbDoc dbDoc = ((doc is DbDoc) ? (doc as DbDoc) : new DbDoc(doc));
		if (one != null)
		{
			foreach (KeyValuePair<string, object> value2 in one.values)
			{
				if (value2.Key != "_id")
				{
					modifyStatement.Unset(value2.Key);
				}
			}
		}
		foreach (KeyValuePair<string, object> value3 in dbDoc.values)
		{
			if (value3.Key != "_id")
			{
				modifyStatement.Set(value3.Key, value3.Value);
			}
		}
		return modifyStatement.Execute();
	}

	public Result AddOrReplaceOne(object id, object doc)
	{
		if (!base.Session.InternalSession.GetServerVersion().isAtLeast(8, 0, 3))
		{
			throw new MySqlException(string.Format(ResourcesX.FunctionalityNotSupported, "8.0.3"));
		}
		if (id == null)
		{
			throw new ArgumentNullException("id");
		}
		if (string.IsNullOrWhiteSpace(id.ToString()))
		{
			throw new ArgumentNullException("id", Resources.ParameterNullOrEmpty);
		}
		if (doc == null)
		{
			throw new ArgumentNullException("doc");
		}
		DbDoc dbDoc = ((doc is DbDoc) ? (doc as DbDoc) : new DbDoc(doc));
		dbDoc.Id = id;
		AddStatement addStatement = Add(dbDoc);
		addStatement.upsert = true;
		return addStatement.Execute();
	}

	public long Count()
	{
		ValidateOpenSession();
		return base.Session.XSession.TableCount(base.Schema, base.Name, "Collection");
	}

	public FindStatement Find(string condition = null)
	{
		return new FindStatement(this, condition);
	}

	public void CreateIndex(string indexName, object indexDefinition)
	{
		new CreateCollectionIndexStatement(this, indexName, new DbDoc(indexDefinition)).Execute();
	}

	public void DropIndex(string indexName)
	{
		if (string.IsNullOrWhiteSpace(indexName))
		{
			throw new ArgumentNullException("indexName");
		}
		ValidateOpenSession();
		if (Convert.ToInt32(base.Session.XSession.ExecuteQueryAsScalar($"SELECT COUNT(*)>0 FROM information_schema.statistics WHERE table_schema = '{base.Schema.Name}' AND table_name = '{base.Name}' AND index_name = '{indexName}'")) == 1)
		{
			base.Session.XSession.DropCollectionIndex(base.Schema.Name, base.Name, indexName);
		}
	}

	public override bool ExistsInDatabase()
	{
		ValidateOpenSession();
		return base.Session.XSession.TableExists(base.Schema, base.Name);
	}

	public DbDoc GetOne(object id)
	{
		if (id == null)
		{
			throw new ArgumentNullException("id");
		}
		if (string.IsNullOrWhiteSpace(id.ToString()))
		{
			throw new ArgumentNullException("id", Resources.ParameterNullOrEmpty);
		}
		return Find("_id = :id").Bind("id", id).Execute().FetchOne();
	}
}
public class Collection<T> : Collection
{
	public Collection(Schema s, string name)
		: base(s, name)
	{
	}

	public AddStatement Add(T value)
	{
		return Add(new DbDoc(value));
	}
}
