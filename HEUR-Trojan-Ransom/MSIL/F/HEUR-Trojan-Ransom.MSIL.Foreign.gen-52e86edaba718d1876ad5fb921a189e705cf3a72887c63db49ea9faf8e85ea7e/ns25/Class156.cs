using System;
using System.Data;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns11;
using ns6;

namespace ns25;

internal abstract class Class156
{
	[CompilerGenerated]
	private Class139 class139_0;

	[NonSerialized]
	internal static GetString getString_0;

	protected Class139 ActiveConnection
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

	public virtual bool vmethod_0(string string_0, ref object object_0)
	{
		return false;
	}

	public virtual bool vmethod_1(string string_0, ref int int_0)
	{
		return false;
	}

	public virtual bool vmethod_2(string string_0, CommandBehavior commandBehavior_0, ref Class142 class142_0)
	{
		return false;
	}

	public virtual void vmethod_3(Class139 class139_1)
	{
		ActiveConnection = class139_1;
	}

	static Class156()
	{
		Strings.CreateGetStringDelegate(typeof(Class156));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107398437), getString_0(107398432)).Replace(getString_0(107398395), getString_0(107398390)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107398385)))
		{
			throw new SecurityException(getString_0(107398360));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
