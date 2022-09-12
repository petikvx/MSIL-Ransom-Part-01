using System.Collections.Generic;
using MySqlX.XDevAPI.Common;

namespace MySqlX.XDevAPI.Relational;

public class TableInsertStatement : TargetedBaseStatement<Table, Result>
{
	internal string[] fields;

	internal List<object[]> values = new List<object[]>();

	internal object[] parameters;

	internal TableInsertStatement(Table table, string[] fields)
		: base(table)
	{
		this.fields = fields;
	}

	public override Result Execute()
	{
		ValidateOpenSession();
		return base.Target.Session.XSession.InsertRows(this);
	}

	public TableInsertStatement Values(params object[] values)
	{
		this.values.Add(values);
		return this;
	}
}
