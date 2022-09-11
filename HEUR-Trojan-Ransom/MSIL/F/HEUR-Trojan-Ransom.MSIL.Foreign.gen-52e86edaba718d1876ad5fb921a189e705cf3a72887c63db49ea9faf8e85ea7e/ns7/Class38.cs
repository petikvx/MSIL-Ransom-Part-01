using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using MySqlX.XDevAPI;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns19;

namespace ns7;

internal abstract class Class38
{
	[CompilerGenerated]
	private Class41 class41_0;

	[CompilerGenerated]
	private string string_0;

	[NonSerialized]
	internal static GetString getString_0;

	public BaseSession Session => Schema.Session;

	public Class41 Schema
	{
		[CompilerGenerated]
		get
		{
			return class41_0;
		}
		[CompilerGenerated]
		internal set
		{
			class41_0 = value;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		internal set
		{
			string_0 = value;
		}
	}

	internal Class38(Class41 class41_1, string string_1)
	{
		Schema = class41_1;
		Name = string_1;
	}

	public abstract bool vmethod_0();

	static Class38()
	{
		Strings.CreateGetStringDelegate(typeof(Class38));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397643), getString_0(107397638)).Replace(getString_0(107397601), getString_0(107397596)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397591)))
		{
			throw new SecurityException(getString_0(107397566));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_1, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
