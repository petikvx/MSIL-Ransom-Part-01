using MySqlX.XDevAPI.Common;

namespace MySqlX.XDevAPI.Relational;

public class TableDeleteStatement : FilterableStatement<TableDeleteStatement, Table, Result>
{
	internal TableDeleteStatement(Table table, string condition)
		: base(table, condition)
	{
		base.FilterData.IsRelational = true;
	}

	public TableDeleteStatement OrderBy(params string[] order)
	{
		base.FilterData.OrderBy = order;
		SetChanged();
		return this;
	}

	public override Result Execute()
	{
		return Execute(base.Target.Session.XSession.DeleteRows, this);
	}
}
