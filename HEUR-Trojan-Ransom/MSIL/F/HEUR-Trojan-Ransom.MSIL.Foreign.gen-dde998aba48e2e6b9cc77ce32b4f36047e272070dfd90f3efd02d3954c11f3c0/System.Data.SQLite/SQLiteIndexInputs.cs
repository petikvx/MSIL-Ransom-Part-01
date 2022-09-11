using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

public sealed class SQLiteIndexInputs
{
	private SQLiteIndexConstraint[] constraints;

	private SQLiteIndexOrderBy[] orderBys;

	[NonSerialized]
	internal static GetString _0081;

	public SQLiteIndexConstraint[] Constraints => constraints;

	public SQLiteIndexOrderBy[] OrderBys => orderBys;

	internal SQLiteIndexInputs(int nConstraint, int nOrderBy)
	{
		constraints = new SQLiteIndexConstraint[nConstraint];
		orderBys = new SQLiteIndexOrderBy[nOrderBy];
	}

	static SQLiteIndexInputs()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteIndexInputs));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0081(107401362), _0081(107401325)), _0081(107401320), _0081(107401315)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0081(107401342)))
		{
			return;
		}
		throw new SecurityException(_0081(107401285));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
