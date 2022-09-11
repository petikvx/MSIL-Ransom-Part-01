using System.Data.Common;
using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security.Permissions;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

[Serializable]
public sealed class SQLiteException : DbException, ISerializable
{
	private SQLiteErrorCode _errorCode;

	[NonSerialized]
	internal static GetString _0094;

	public SQLiteErrorCode ResultCode => _errorCode;

	public override int ErrorCode => (int)_errorCode;

	private SQLiteException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		_errorCode = (SQLiteErrorCode)info.GetInt32(_0094(107383112));
	}

	public SQLiteException(SQLiteErrorCode errorCode, string message)
		: base(GetStockErrorMessage(errorCode, message))
	{
		_errorCode = errorCode;
	}

	public SQLiteException(string message)
		: this(SQLiteErrorCode.Unknown, message)
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
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info?.AddValue(_0094(107383112), _errorCode);
		base.GetObjectData(info, context);
	}

	private static string GetErrorString(SQLiteErrorCode errorCode)
	{
		BindingFlags invokeAttr = BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.InvokeMethod;
		return typeof(SQLite3).InvokeMember(_0094(107383099), invokeAttr, null, null, new object[1] { errorCode }) as string;
	}

	private static string GetStockErrorMessage(SQLiteErrorCode errorCode, string message)
	{
		return HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0094(107383078), GetErrorString(errorCode), Environment.NewLine, message).Trim();
	}

	static SQLiteException()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteException));
	}
}
