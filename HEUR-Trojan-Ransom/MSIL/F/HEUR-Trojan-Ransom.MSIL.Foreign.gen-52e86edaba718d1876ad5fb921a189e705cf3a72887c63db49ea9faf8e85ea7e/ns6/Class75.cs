using System.Runtime.CompilerServices;
using MySqlX.Protocol.X;
using Mysqlx.Crud;
using Mysqlx.Expr;
using ns10;

namespace ns6;

internal sealed class Class75
{
	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private UpdateOperation.Class34.Enum20 enum20_0;

	[CompilerGenerated]
	private object object_0;

	public string Path
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		private set
		{
			string_0 = value;
		}
	}

	public UpdateOperation.Class34.Enum20 Type
	{
		[CompilerGenerated]
		get
		{
			return enum20_0;
		}
		[CompilerGenerated]
		private set
		{
			enum20_0 = value;
		}
	}

	public object Value
	{
		[CompilerGenerated]
		get
		{
			return object_0;
		}
		[CompilerGenerated]
		private set
		{
			object_0 = value;
		}
	}

	public bool HasValue => Value != null;

	public Class75(UpdateOperation.Class34.Enum20 enum20_1, string string_1)
	{
		Type = enum20_1;
		Path = string_1;
	}

	public Expr method_0()
	{
		return Class103.smethod_23(Value, bool_0: false);
	}

	public ColumnIdentifier method_1(bool bool_0)
	{
		string path = Path;
		if (path.Length > 0 && path[0] == '@')
		{
			path = path.Substring(1);
		}
		ExprParser exprParser = new ExprParser(Path, allowRelationalColumns: false);
		if (bool_0)
		{
			return exprParser.method_36();
		}
		return exprParser.method_16().Identifier;
	}

	public Class75 method_2(object object_1)
	{
		Value = object_1;
		return this;
	}
}
