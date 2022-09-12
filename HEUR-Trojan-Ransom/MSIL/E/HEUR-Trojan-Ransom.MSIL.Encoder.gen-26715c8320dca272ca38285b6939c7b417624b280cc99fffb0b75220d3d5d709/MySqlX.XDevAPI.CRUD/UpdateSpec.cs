using System;
using MySqlX.Protocol.X;
using MySqlX.Serialization;
using Mysqlx.Crud;
using Mysqlx.Expr;

namespace MySqlX.XDevAPI.CRUD;

internal class UpdateSpec
{
	public string Path { get; private set; }

	public UpdateOperation.Types.UpdateType Type { get; private set; }

	public object Value { get; private set; }

	public bool HasValue => Value != null;

	public UpdateSpec(UpdateOperation.Types.UpdateType updateType, string docPath)
	{
		Type = updateType;
		Path = docPath;
	}

	public Expr GetValue(UpdateOperation.Types.UpdateType operationType)
	{
		bool evaluateStringExpresssion = true;
		if (operationType == UpdateOperation.Types.UpdateType.ArrayAppend || operationType == UpdateOperation.Types.UpdateType.ArrayInsert || operationType == UpdateOperation.Types.UpdateType.ItemSet)
		{
			Value = ExprUtil.ParseAnonymousObject(Value) ?? Value;
			if (Value is string)
			{
				try
				{
					JsonParser.Parse(Value as string);
				}
				catch (Exception)
				{
					evaluateStringExpresssion = false;
				}
			}
		}
		return ExprUtil.ArgObjectToExpr(Value, allowRelationalColumns: false, evaluateStringExpresssion);
	}

	public ColumnIdentifier GetSource(bool isRelational)
	{
		string path = Path;
		if (path.Length > 0 && path[0] == '@')
		{
			path = path.Substring(1);
		}
		ExprParser exprParser = new ExprParser(Path, allowRelationalColumns: false);
		ColumnIdentifier result = ((!isRelational) ? exprParser.DocumentField().Identifier : exprParser.ParseTableUpdateField());
		if (exprParser.tokenPos < exprParser.tokens.Count)
		{
			throw new ArgumentException("Invalid document path.");
		}
		return result;
	}

	public UpdateSpec SetValue(object o)
	{
		Value = o;
		return this;
	}
}
