using System.Collections.Generic;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySqlX.Protocol.X;
using MySqlX.XDevAPI.CRUD;
using MySqlX.XDevAPI.Common;

namespace MySqlX.XDevAPI.Relational;

public class TableSelectStatement : FilterableStatement<TableSelectStatement, Table, RowResult>
{
	internal FindParams findParams = new FindParams();

	internal TableSelectStatement(Table t, params string[] projection)
		: base(t, (string)null)
	{
		findParams.Projection = projection;
		base.FilterData.IsRelational = true;
	}

	public override RowResult Execute()
	{
		return Execute(base.Target.Session.XSession.FindRows, this);
	}

	public TableSelectStatement LockShared(LockContention lockOption = LockContention.Default)
	{
		if (!base.Session.InternalSession.GetServerVersion().isAtLeast(8, 0, 3))
		{
			throw new MySqlException(string.Format(ResourcesX.FunctionalityNotSupported, "8.0.3"));
		}
		findParams.Locking = RowLock.SharedLock;
		findParams.LockingOption = lockOption;
		SetChanged();
		return this;
	}

	public TableSelectStatement LockExclusive(LockContention lockOption = LockContention.Default)
	{
		if (!base.Session.InternalSession.GetServerVersion().isAtLeast(8, 0, 3))
		{
			throw new MySqlException(string.Format(ResourcesX.FunctionalityNotSupported, "8.0.3"));
		}
		findParams.Locking = RowLock.ExclusiveLock;
		findParams.LockingOption = lockOption;
		SetChanged();
		return this;
	}

	public TableSelectStatement GroupBy(params string[] groupBy)
	{
		if (groupBy == null)
		{
			return this;
		}
		List<string> list = new List<string>();
		foreach (string text in groupBy)
		{
			if (text != null)
			{
				list.Add(text);
			}
		}
		findParams.GroupBy = ((list.Count > 0) ? list.ToArray() : null);
		SetChanged();
		return this;
	}

	public TableSelectStatement Having(string having)
	{
		findParams.GroupByCritieria = having;
		SetChanged();
		return this;
	}

	public TableSelectStatement OrderBy(params string[] order)
	{
		base.FilterData.OrderBy = order;
		SetChanged();
		return this;
	}
}
