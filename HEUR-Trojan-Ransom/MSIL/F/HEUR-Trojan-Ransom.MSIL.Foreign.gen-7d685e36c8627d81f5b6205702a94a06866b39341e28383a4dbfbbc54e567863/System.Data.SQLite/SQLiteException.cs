using System.Data.Common;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security.Permissions;
using _0002;
using _0011;
using _0080;

namespace System.Data.SQLite;

[Serializable]
public sealed class SQLiteException : DbException, ISerializable
{
	private _0080._0017 m__0001;

	public _0080._0017 ResultCode => ((SQLiteException)/*Error near IL_0007: Stack underflow*/).m__0001;

	public override int ErrorCode => (int)((SQLiteException)/*Error near IL_0007: Stack underflow*/).m__0001;

	private SQLiteException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		this.m__0001 = (_0080._0017)info.GetInt32(_0080._0014._0001(107364182));
	}

	public SQLiteException(_0080._0017 errorCode, string message)
		: base(_0011._0018._0001(message, errorCode))
	{
		this.m__0001 = errorCode;
	}

	public SQLiteException(string message)
		: this(_0080._0017._0001, message)
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
		//IL_0031: Incompatible stack heights: 0 vs 1
		//IL_0034: Incompatible stack heights: 0 vs 2
		//IL_003b: Incompatible stack heights: 0 vs 1
		if ((int)/*Error near IL_0004: Stack underflow*/ != 0)
		{
			_ = _0083_0004._007E_0092_0008;
			_0080._0014._0001(107364182);
			object obj = this.m__0001;
			/*Error near IL_0022: Stack underflow*/((object)/*Error near IL_0022: Stack underflow*/, (string)/*Error near IL_0022: Stack underflow*/, obj);
		}
		_0094_0004._001C_000E(this, _0002, _0003);
	}

	internal static string _0001(_0080._0017 _0002)
	{
		//IL_0046: Incompatible stack heights: 0 vs 2
		//IL_004d: Incompatible stack heights: 0 vs 1
		BindingFlags bindingFlags = BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.InvokeMethod;
		_ = _0095_0004._001D_000E;
		_0091._0080_0004(typeof(global::_0002._0019).TypeHandle);
		_0080._0014._0001(107364137);
		object[] array = new object[1] { _0002 };
		return /*Error near IL_0038: Stack underflow*/((object)/*Error near IL_0038: Stack underflow*/, (string)/*Error near IL_0038: Stack underflow*/, bindingFlags, null, null, array) as string;
	}
}
