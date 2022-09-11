using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace MySql.Data.Types;

[Serializable]
public sealed class MySqlConversionException : Exception
{
	[NonSerialized]
	internal static GetString getString_0;

	public MySqlConversionException(string msg)
		: base(msg)
	{
	}

	static MySqlConversionException()
	{
		Strings.CreateGetStringDelegate(typeof(MySqlConversionException));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107398046), getString_0(107398041)).Replace(getString_0(107398004), getString_0(107397999)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397994)))
		{
			throw new SecurityException(getString_0(107397969));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
