using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns11;

namespace ns4;

internal class Class146
{
	[CompilerGenerated]
	private Class139 class139_0;

	[NonSerialized]
	internal static GetString getString_0;

	public Class139 Connection
	{
		[CompilerGenerated]
		get
		{
			return class139_0;
		}
		[CompilerGenerated]
		private set
		{
			class139_0 = value;
		}
	}

	public Class146(Class139 class139_1)
	{
		Connection = class139_1;
	}

	public virtual void vmethod_0()
	{
	}

	public virtual void vmethod_1()
	{
	}

	static Class146()
	{
		Strings.CreateGetStringDelegate(typeof(Class146));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107398377), getString_0(107398372)).Replace(getString_0(107398335), getString_0(107398330)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107398325)))
		{
			throw new SecurityException(getString_0(107398300));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
