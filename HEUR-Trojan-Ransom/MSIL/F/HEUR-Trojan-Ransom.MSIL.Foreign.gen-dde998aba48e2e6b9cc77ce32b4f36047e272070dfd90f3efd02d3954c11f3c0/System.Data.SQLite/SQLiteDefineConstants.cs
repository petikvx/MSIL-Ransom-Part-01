using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

internal static class SQLiteDefineConstants
{
	public static readonly IList<string> OptionList;

	[NonSerialized]
	internal static GetString _0086;

	static SQLiteDefineConstants()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteDefineConstants));
		bool flag = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(_0086(107401017), _0086(107400980)).Replace(_0086(107400975), _0086(107400970)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, true, out flag) || !flag || !executingAssembly.FullName!.EndsWith(_0086(107400997)))
		{
			throw new SecurityException(_0086(107400940));
		}
		OptionList = new List<string>(new string[20]
		{
			_0086(107383561),
			_0086(107383540),
			_0086(107383503),
			_0086(107383982),
			_0086(107383949),
			_0086(107383940),
			_0086(107383907),
			_0086(107383874),
			_0086(107383841),
			_0086(107383812),
			_0086(107383803),
			_0086(107383770),
			_0086(107383233),
			_0086(107383224),
			_0086(107383203),
			_0086(107383154),
			_0086(107383165),
			_0086(107383112),
			_0086(107383091),
			null
		});
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
