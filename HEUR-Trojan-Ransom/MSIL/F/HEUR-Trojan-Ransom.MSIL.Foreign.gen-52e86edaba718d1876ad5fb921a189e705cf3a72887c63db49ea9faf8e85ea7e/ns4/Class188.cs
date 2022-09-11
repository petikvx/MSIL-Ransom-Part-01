using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ns4;

internal sealed class Class188
{
	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private bool bool_1;

	[NonSerialized]
	internal static GetString getString_0;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		private set
		{
			string_0 = value;
		}
	}

	public bool IsMaster
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		private set
		{
			bool_0 = value;
		}
	}

	public string ConnectionString
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		internal set
		{
			string_1 = value;
		}
	}

	public bool IsAvailable
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
		[CompilerGenerated]
		set
		{
			bool_1 = value;
		}
	}

	public Class188(string string_2, bool bool_2, string string_3)
	{
		Name = string_2;
		IsMaster = bool_2;
		ConnectionString = string_3;
		IsAvailable = true;
	}

	static Class188()
	{
		Strings.CreateGetStringDelegate(typeof(Class188));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107399508), getString_0(107399503)).Replace(getString_0(107399466), getString_0(107399461)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_2: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107399456)))
		{
			throw new SecurityException(getString_0(107399431));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_2, [MarshalAs(UnmanagedType.Bool)] bool bool_2, [MarshalAs(UnmanagedType.Bool)] out bool bool_3);
}
