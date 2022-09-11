using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

public class SQLiteModuleCommon : SQLiteModuleNoop
{
	private static readonly string declareSql;

	private bool objectIdentity;

	private bool disposed;

	[NonSerialized]
	internal static GetString _0007;

	public SQLiteModuleCommon(string name)
		: this(name, objectIdentity: false)
	{
	}

	public SQLiteModuleCommon(string name, bool objectIdentity)
		: base(name)
	{
		this.objectIdentity = objectIdentity;
	}

	protected virtual string GetSqlForDeclareTable()
	{
		return declareSql;
	}

	protected virtual SQLiteErrorCode CursorTypeMismatchError(SQLiteVirtualTableCursor cursor, Type type)
	{
		if ((object)type != null)
		{
			SetCursorError(cursor, HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0007(107379093), type));
		}
		else
		{
			SetCursorError(cursor, _0007(107379036));
		}
		return SQLiteErrorCode.Error;
	}

	protected virtual string GetStringFromObject(SQLiteVirtualTableCursor cursor, object value)
	{
		if (value == null)
		{
			return null;
		}
		if (value is string)
		{
			return (string)value;
		}
		return value.ToString();
	}

	protected virtual long MakeRowId(int rowIndex, int hashCode)
	{
		long num = rowIndex;
		num <<= 32;
		return num | (uint)hashCode;
	}

	protected virtual long GetRowIdFromObject(SQLiteVirtualTableCursor cursor, object value)
	{
		int rowIndex = cursor?.GetRowIndex() ?? 0;
		int hashCode = SQLiteMarshal.GetHashCode(value, objectIdentity);
		return MakeRowId(rowIndex, hashCode);
	}

	private void CheckDisposed()
	{
		if (disposed)
		{
			throw new ObjectDisposedException(typeof(SQLiteModuleCommon).Name);
		}
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			_ = disposed;
		}
		finally
		{
			base.Dispose(disposing);
			disposed = true;
		}
	}

	static SQLiteModuleCommon()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteModuleCommon));
		bool flag = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(_0007(107401420), _0007(107401383)).Replace(_0007(107401378), _0007(107401373)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, true, out flag) || !flag || !executingAssembly.FullName!.EndsWith(_0007(107401400)))
		{
			throw new SecurityException(_0007(107401343));
		}
		declareSql = HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0007(107378495), typeof(SQLiteModuleCommon).Name);
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
