using System;
using MySqlX.XDevAPI.Common;

namespace MySqlX.XDevAPI.CRUD;

public class RemoveStatement : FilterableStatement<RemoveStatement, Collection, Result>
{
	internal RemoveStatement(Collection collection, string condition)
		: base(collection, condition)
	{
	}

	public RemoveStatement Sort(params string[] order)
	{
		base.FilterData.OrderBy = order;
		SetChanged();
		return this;
	}

	[Obsolete("Where(string condition) has been deprecated since version 8.0.17.")]
	public new RemoveStatement Where(string condition)
	{
		return base.Where(condition);
	}

	public override Result Execute()
	{
		return Execute(base.Target.Session.XSession.DeleteDocs, this);
	}
}
