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

	public override Result Execute()
	{
		return Execute(base.Target.Session.XSession.DeleteDocs, this);
	}
}
