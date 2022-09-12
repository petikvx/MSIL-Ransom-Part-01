using System.Collections.Generic;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySqlX.Protocol.X;
using MySqlX.XDevAPI.Common;

namespace MySqlX.XDevAPI.CRUD;

public class FindStatement : FilterableStatement<FindStatement, Collection, DocResult>
{
	internal FindParams findParams = new FindParams();

	internal FindStatement(Collection c, string condition)
		: base(c, condition)
	{
	}

	public FindStatement Fields(params string[] columns)
	{
		if (columns == null)
		{
			return this;
		}
		List<string> list = new List<string>();
		foreach (string text in columns)
		{
			if (text != null)
			{
				list.Add(text);
			}
		}
		findParams.Projection = ((list.Count > 0) ? list.ToArray() : null);
		SetChanged();
		return this;
	}

	public override DocResult Execute()
	{
		return Execute(base.Target.Session.XSession.FindDocs, this);
	}

	public FindStatement LockShared(LockContention lockOption = LockContention.Default)
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

	public FindStatement LockExclusive(LockContention lockOption = LockContention.Default)
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

	public FindStatement GroupBy(params string[] groupBy)
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

	public FindStatement Having(string having)
	{
		findParams.GroupByCritieria = having;
		SetChanged();
		return this;
	}

	public FindStatement Sort(params string[] order)
	{
		base.FilterData.OrderBy = order;
		SetChanged();
		return this;
	}
}
