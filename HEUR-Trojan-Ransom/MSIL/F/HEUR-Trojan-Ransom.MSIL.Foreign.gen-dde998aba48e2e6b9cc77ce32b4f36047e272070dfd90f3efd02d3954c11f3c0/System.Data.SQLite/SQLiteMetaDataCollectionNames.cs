using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

public static class SQLiteMetaDataCollectionNames
{
	public static readonly string Catalogs;

	public static readonly string Columns;

	public static readonly string Indexes;

	public static readonly string IndexColumns;

	public static readonly string Tables;

	public static readonly string Views;

	public static readonly string ViewColumns;

	public static readonly string ForeignKeys;

	public static readonly string Triggers;

	[NonSerialized]
	internal static GetString _008D;

	static SQLiteMetaDataCollectionNames()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteMetaDataCollectionNames));
		bool flag = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(_008D(107401204), _008D(107401167)).Replace(_008D(107401162), _008D(107401157)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, true, out flag) || !flag || !executingAssembly.FullName!.EndsWith(_008D(107401184)))
		{
			throw new SecurityException(_008D(107401127));
		}
		Catalogs = _008D(107363022);
		Columns = _008D(107356874);
		Indexes = _008D(107356024);
		IndexColumns = _008D(107353729);
		Tables = _008D(107354636);
		Views = _008D(107354891);
		ViewColumns = _008D(107353968);
		ForeignKeys = _008D(107353911);
		Triggers = _008D(107355381);
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
