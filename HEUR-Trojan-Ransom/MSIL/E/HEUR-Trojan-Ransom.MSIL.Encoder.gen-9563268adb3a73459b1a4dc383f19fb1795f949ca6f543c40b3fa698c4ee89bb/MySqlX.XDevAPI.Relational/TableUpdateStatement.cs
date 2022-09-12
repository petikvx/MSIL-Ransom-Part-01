using System.Collections.Generic;
using MySqlX.XDevAPI.CRUD;
using MySqlX.XDevAPI.Common;
using Mysqlx.Crud;

namespace MySqlX.XDevAPI.Relational;

public class TableUpdateStatement : FilterableStatement<TableUpdateStatement, Table, Result>
{
	internal List<UpdateSpec> updates = new List<UpdateSpec>();

	internal TableUpdateStatement(Table table)
		: base(table, (string)null)
	{
		base.FilterData.IsRelational = true;
		base.FilterData.Parameters = new Dictionary<string, object>();
	}

	public override Result Execute()
	{
		return Execute(base.Target.Session.XSession.UpdateRows, this);
	}

	public TableUpdateStatement Set(string tableField, object value)
	{
		updates.Add(new UpdateSpec(UpdateOperation.Types.UpdateType.Set, tableField).SetValue(value));
		SetChanged();
		return this;
	}

	public TableUpdateStatement OrderBy(params string[] order)
	{
		base.FilterData.OrderBy = order;
		SetChanged();
		return this;
	}
}
