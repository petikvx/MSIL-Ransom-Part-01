using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

public sealed class SQLiteIndexOrderBy
{
	public int iColumn;

	public byte desc;

	[NonSerialized]
	internal static GetString _0016;

	internal SQLiteIndexOrderBy(UnsafeNativeMethods.sqlite3_index_orderby orderBy)
		: this(orderBy.iColumn, orderBy.desc)
	{
	}

	private SQLiteIndexOrderBy(int iColumn, byte desc)
	{
		this.iColumn = iColumn;
		this.desc = desc;
	}

	static SQLiteIndexOrderBy()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteIndexOrderBy));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0016(107401357), _0016(107401320)), _0016(107401315), _0016(107401310)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0016(107401337)))
		{
			return;
		}
		throw new SecurityException(_0016(107401280));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
