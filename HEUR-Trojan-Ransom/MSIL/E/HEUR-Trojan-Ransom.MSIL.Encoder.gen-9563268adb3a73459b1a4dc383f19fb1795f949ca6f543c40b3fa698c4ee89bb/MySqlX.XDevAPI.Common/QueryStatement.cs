using MySqlX.XDevAPI.CRUD;
using MySqlX.XDevAPI.Relational;

namespace MySqlX.XDevAPI.Common;

internal class QueryStatement
{
	internal string schema;

	internal string collection;

	internal bool isRelational;

	internal FilterParams filter;

	internal FindParams findParams;

	internal TableSelectStatement selectStatement;

	internal FindStatement findStatement;

	public QueryStatement(FindStatement statement)
	{
		findStatement = statement;
		SetValues(statement.Target, statement.FilterData, null, isRelational: false);
	}

	public QueryStatement(TableSelectStatement statement)
	{
		selectStatement = statement;
		SetValues(statement.Target, statement.FilterData, statement.findParams, isRelational: true);
	}

	private void SetValues(DatabaseObject target, FilterParams filter, FindParams findParams, bool isRelational)
	{
		schema = target.Schema.Name;
		collection = target.Name;
		this.isRelational = isRelational;
		this.filter = filter;
		this.findParams = findParams;
	}
}
