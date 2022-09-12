using System.Collections.Generic;
using MySqlX.XDevAPI.Common;

namespace MySqlX.XDevAPI.CRUD;

public abstract class CrudStatement<TResult> : TargetedBaseStatement<Collection, TResult> where TResult : Result
{
	internal CrudStatement(Collection collection)
		: base(collection)
	{
	}

	protected IEnumerable<DbDoc> GetDocs(object[] items)
	{
		foreach (object obj in items)
		{
			yield return (obj is DbDoc) ? (obj as DbDoc) : new DbDoc(obj);
		}
	}
}
