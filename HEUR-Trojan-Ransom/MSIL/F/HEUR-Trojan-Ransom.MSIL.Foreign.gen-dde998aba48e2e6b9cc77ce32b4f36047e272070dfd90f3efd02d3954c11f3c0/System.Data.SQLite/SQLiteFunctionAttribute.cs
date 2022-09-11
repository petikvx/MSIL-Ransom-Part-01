namespace System.Data.SQLite;

[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
public sealed class SQLiteFunctionAttribute : Attribute
{
	private string _name;

	private int _argumentCount;

	private FunctionType _functionType;

	private Type _instanceType;

	private Delegate _callback1;

	private Delegate _callback2;

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
			return _argumentCount;
		}
		set
		{
			_argumentCount = value;
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

	internal Type InstanceType
	{
		get
		{
			return _instanceType;
		}
		set
		{
			_instanceType = value;
		}
	}

	internal Delegate Callback1
	{
		get
		{
			return _callback1;
		}
		set
		{
			_callback1 = value;
		}
	}

	internal Delegate Callback2
	{
		get
		{
			return _callback2;
		}
		set
		{
			_callback2 = value;
		}
	}

	public SQLiteFunctionAttribute()
		: this(null, -1, FunctionType.Scalar)
	{
	}

	public SQLiteFunctionAttribute(string name, int argumentCount, FunctionType functionType)
	{
		_name = name;
		_argumentCount = argumentCount;
		_functionType = functionType;
		_instanceType = null;
		_callback1 = null;
		_callback2 = null;
	}
}
