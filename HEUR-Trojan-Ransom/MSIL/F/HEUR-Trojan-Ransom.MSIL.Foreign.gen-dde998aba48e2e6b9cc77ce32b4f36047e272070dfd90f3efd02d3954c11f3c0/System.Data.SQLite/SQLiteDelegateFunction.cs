using System.Globalization;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

public sealed class SQLiteDelegateFunction : SQLiteFunction
{
	private const string NoCallbackError = "No \"{0}\" callback is set.";

	private const string ResultInt32Error = "\"{0}\" result must be Int32.";

	private Delegate callback1;

	private Delegate callback2;

	[NonSerialized]
	internal static GetString _0002;

	public virtual Delegate Callback1
	{
		get
		{
			return callback1;
		}
		set
		{
			callback1 = value;
		}
	}

	public virtual Delegate Callback2
	{
		get
		{
			return callback2;
		}
		set
		{
			callback2 = value;
		}
	}

	public SQLiteDelegateFunction()
		: this(null, null)
	{
	}

	public SQLiteDelegateFunction(Delegate callback1, Delegate callback2)
	{
		this.callback1 = callback1;
		this.callback2 = callback2;
	}

	protected virtual object[] GetInvokeArgs(object[] args, bool earlyBound)
	{
		object[] array = new object[2]
		{
			_0002(107382940),
			args
		};
		if (!earlyBound)
		{
			array = new object[1] { array };
		}
		return array;
	}

	protected virtual object[] GetStepArgs(object[] args, int stepNumber, object contextData, bool earlyBound)
	{
		object[] array = new object[4]
		{
			_0002(107382931),
			args,
			stepNumber,
			contextData
		};
		if (!earlyBound)
		{
			array = new object[1] { array };
		}
		return array;
	}

	protected virtual void UpdateStepArgs(object[] args, ref object contextData, bool earlyBound)
	{
		object[] array = ((!earlyBound) ? (args[0] as object[]) : args);
		if (array != null)
		{
			contextData = array[^1];
		}
	}

	protected virtual object[] GetFinalArgs(object contextData, bool earlyBound)
	{
		object[] array = new object[2]
		{
			_0002(107382890),
			contextData
		};
		if (!earlyBound)
		{
			array = new object[1] { array };
		}
		return array;
	}

	protected virtual object[] GetCompareArgs(string param1, string param2, bool earlyBound)
	{
		object[] array = new object[3]
		{
			_0002(107382881),
			param1,
			param2
		};
		if (!earlyBound)
		{
			array = new object[1] { array };
		}
		return array;
	}

	public override object Invoke(object[] args)
	{
		if ((object)callback1 == null)
		{
			throw new InvalidOperationException(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0002(107382900), _0002(107382940)));
		}
		if (callback1 is SQLiteInvokeDelegate sQLiteInvokeDelegate)
		{
			return sQLiteInvokeDelegate(_0002(107382940), args);
		}
		return callback1.DynamicInvoke(GetInvokeArgs(args, earlyBound: false));
	}

	public override void Step(object[] args, int stepNumber, ref object contextData)
	{
		if ((object)callback1 == null)
		{
			throw new InvalidOperationException(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0002(107382900), _0002(107382931)));
		}
		if (callback1 is SQLiteStepDelegate sQLiteStepDelegate)
		{
			sQLiteStepDelegate(_0002(107382931), args, stepNumber, ref contextData);
			return;
		}
		object[] stepArgs = GetStepArgs(args, stepNumber, contextData, earlyBound: false);
		callback1.DynamicInvoke(stepArgs);
		UpdateStepArgs(stepArgs, ref contextData, earlyBound: false);
	}

	public override object Final(object contextData)
	{
		if ((object)callback2 == null)
		{
			throw new InvalidOperationException(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0002(107382900), _0002(107382890)));
		}
		if (callback2 is SQLiteFinalDelegate sQLiteFinalDelegate)
		{
			return sQLiteFinalDelegate(_0002(107382890), contextData);
		}
		return callback1.DynamicInvoke(GetFinalArgs(contextData, earlyBound: false));
	}

	public override int Compare(string param1, string param2)
	{
		if ((object)callback1 == null)
		{
			throw new InvalidOperationException(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0002(107382900), _0002(107382881)));
		}
		if (callback1 is SQLiteCompareDelegate sQLiteCompareDelegate)
		{
			return sQLiteCompareDelegate(_0002(107382881), param1, param2);
		}
		object obj = callback1.DynamicInvoke(GetCompareArgs(param1, param2, earlyBound: false));
		if (obj is int)
		{
			return (int)obj;
		}
		throw new InvalidOperationException(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0002(107382863), _0002(107382881)));
	}

	static SQLiteDelegateFunction()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteDelegateFunction));
	}
}
