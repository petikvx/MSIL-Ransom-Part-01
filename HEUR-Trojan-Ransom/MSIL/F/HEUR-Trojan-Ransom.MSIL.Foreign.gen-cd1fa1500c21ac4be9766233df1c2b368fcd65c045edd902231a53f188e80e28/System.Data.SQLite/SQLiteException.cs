using System.Data.Common;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security.Permissions;
using _0007;
using _0018;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using _007F;

namespace System.Data.SQLite;

[Serializable]
public sealed class SQLiteException : DbException, ISerializable
{
	private _0007._0018 m__0001;

	[NonSerialized]
	internal static GetString _0018;

	public _0007._0018 ResultCode => ((SQLiteException)/*Error near IL_0007: Stack underflow*/).m__0001;

	public override int ErrorCode => (int)((SQLiteException)/*Error near IL_0007: Stack underflow*/).m__0001;

	private SQLiteException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		this.m__0001 = (_0007._0018)info.GetInt32(_0018(107380955));
	}

	public SQLiteException(_0007._0018 errorCode, string message)
		: base(global::_0018._007F._0001(errorCode, message))
	{
		this.m__0001 = errorCode;
	}

	public SQLiteException(string message)
		: this(_0007._0018._0001, message)
	{
	}

	public SQLiteException()
	{
	}

	public SQLiteException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
	public override void _0001(SerializationInfo _0002, StreamingContext _0003)
	{
		//IL_003f: Incompatible stack heights: 0 vs 1
		//IL_0042: Incompatible stack heights: 0 vs 2
		//IL_0049: Incompatible stack heights: 0 vs 1
		//IL_004c: Incompatible stack heights: 0 vs 1
		//IL_0056: Incompatible stack heights: 0 vs 2
		//IL_0059: Incompatible stack heights: 0 vs 1
		//IL_005c: Incompatible stack heights: 0 vs 1
		while (true)
		{
			if ((int)/*Error near IL_0004: Stack underflow*/ != 0)
			{
				_ = _0018_0004._007E_008C_0008;
				_0018(107380955);
				object obj = ((SQLiteException)/*Error near IL_001e: Stack underflow*/).m__0001;
				/*Error near IL_0053: Stack underflow*/((object)/*Error near IL_0053: Stack underflow*/, (string)/*Error near IL_0053: Stack underflow*/, obj);
			}
			if (3u != 0)
			{
				_ = _0014_0007._0004_0011;
				if (0 == 0)
				{
					/*Error near IL_0063: Stack underflow*/((object)/*Error near IL_0063: Stack underflow*/, (SerializationInfo)/*Error near IL_0063: Stack underflow*/, (StreamingContext)/*Error near IL_0063: Stack underflow*/);
				}
				if (7u != 0)
				{
					break;
				}
			}
		}
	}

	internal static string _0001(_0007._0018 _0002)
	{
		//IL_004f: Incompatible stack heights: 0 vs 2
		//IL_0056: Incompatible stack heights: 0 vs 1
		//IL_0059: Incompatible stack heights: 0 vs 1
		//IL_005c: Incompatible stack heights: 0 vs 2
		//IL_005f: Incompatible stack heights: 0 vs 1
		//IL_0062: Incompatible stack heights: 0 vs 2
		//IL_0065: Incompatible stack heights: 0 vs 1
		//IL_006c: Incompatible stack heights: 0 vs 1
		if (0 == 0)
		{
			BindingFlags bindingFlags = BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.InvokeMethod;
		}
		_ = _0015_0007._0005_0011;
		_0091._0080_0004(typeof(_007F._0014).TypeHandle);
		_0018(107381422);
		_ = null;
		_ = null;
		object[] array = new object[1];
		_ = 0;
		object obj = (_0007._0018)/*Error near IL_003c: Stack underflow*/;
		((object[])/*Error near IL_003d: Stack underflow*/)[/*Error near IL_003d: Stack underflow*/] = obj;
		/*Error near IL_006c: Stack underflow*/((object)/*Error near IL_006c: Stack underflow*/, (string)/*Error near IL_006c: Stack underflow*/, (BindingFlags)/*Error near IL_006c: Stack underflow*/, (Binder)/*Error near IL_006c: Stack underflow*/, (object)/*Error near IL_006c: Stack underflow*/, (object[])/*Error near IL_006c: Stack underflow*/);
		return /*Error near IL_0042: Stack underflow*/as string;
	}

	static SQLiteException()
	{
		//IL_000f: Incompatible stack heights: 0 vs 1
		_ = typeof(SQLiteException);
		Strings.CreateGetStringDelegate((Type)/*Error near IL_0016: Stack underflow*/);
	}
}
