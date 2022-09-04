namespace System.Data.SQLite;

[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
public sealed class SQLiteFunctionAttribute : Attribute
{
	private string _name;

	private int _arguments;

	private FunctionType _functionType;

	internal Type _instanceType;

	public string Name
	{
		get
		{
			return _name;
		}
		set
		{
			_name = value;
		}
	}

	public int Arguments
	{
		get
		{
			return _arguments;
		}
		set
		{
			_arguments = value;
		}
	}

	public FunctionType FuncType
	{
		get
		{
			return _functionType;
		}
		set
		{
			_functionType = value;
		}
	}

	public SQLiteFunctionAttribute()
	{
		Name = "";
		Arguments = -1;
		FuncType = FunctionType.Scalar;
	}
}
