using System;
using System.Collections.Generic;
using MySqlX.XDevAPI.Common;

namespace MySqlX.XDevAPI.CRUD;

public class AddStatement : CrudStatement<Result>
{
	private List<DbDoc> _DbDocs = new List<DbDoc>();

	internal bool upsert;

	internal AddStatement(Collection collection)
		: base(collection)
	{
	}

	public AddStatement Add(params object[] items)
	{
		if (items == null)
		{
			throw new ArgumentNullException();
		}
		_DbDocs.AddRange(GetDocs(items));
		return this;
	}

	public override Result Execute()
	{
		ValidateOpenSession();
		if (_DbDocs.Count == 0)
		{
			return new Result(null);
		}
		return base.Target.Session.XSession.Insert(base.Target, _DbDocs.ToArray(), null, upsert);
	}
}
