using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

public sealed class SQLiteDataReaderValue
{
	public SQLiteBlob BlobValue;

	public bool? BooleanValue;

	public byte? ByteValue;

	public byte[] BytesValue;

	public char? CharValue;

	public char[] CharsValue;

	public DateTime? DateTimeValue;

	public decimal? DecimalValue;

	public double? DoubleValue;

	public float? FloatValue;

	public Guid? GuidValue;

	public short? Int16Value;

	public int? Int32Value;

	public long? Int64Value;

	public string StringValue;

	public object Value;

	[NonSerialized]
	internal static GetString _0093;

	static SQLiteDataReaderValue()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteDataReaderValue));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0093(107400731), _0093(107400694)), _0093(107400689), _0093(107400684)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0093(107400711)))
		{
			return;
		}
		throw new SecurityException(_0093(107400654));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
