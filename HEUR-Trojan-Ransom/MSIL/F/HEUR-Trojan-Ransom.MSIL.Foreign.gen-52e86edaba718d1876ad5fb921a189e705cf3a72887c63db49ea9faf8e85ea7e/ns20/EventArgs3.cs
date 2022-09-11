using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ns20;

internal class EventArgs3 : EventArgs
{
	[CompilerGenerated]
	private ScriptStatement scriptStatement_0;

	[NonSerialized]
	internal static GetString getString_0;

	internal ScriptStatement Statement
	{
		[CompilerGenerated]
		get
		{
			return scriptStatement_0;
		}
		[CompilerGenerated]
		set
		{
			scriptStatement_0 = value;
		}
	}

	public string StatementText => Statement.string_0;

	public int Line => Statement.int_0;

	public int Position => Statement.int_1;

	static EventArgs3()
	{
		Strings.CreateGetStringDelegate(typeof(EventArgs3));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107399316), getString_0(107399311)).Replace(getString_0(107399274), getString_0(107399269)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107399264)))
		{
			throw new SecurityException(getString_0(107399239));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
