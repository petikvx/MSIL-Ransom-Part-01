using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns11;

namespace MySql.Data.MySqlClient.Interceptors;

public abstract class BaseExceptionInterceptor
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

	public abstract Exception vmethod_0(Exception exception_0);

	public virtual void vmethod_1(Class139 class139_1)
	{
		ActiveConnection = class139_1;
	}

	static BaseExceptionInterceptor()
	{
		Strings.CreateGetStringDelegate(typeof(BaseExceptionInterceptor));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107399575), getString_0(107399570)).Replace(getString_0(107399533), getString_0(107399528)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107399523)))
		{
			throw new SecurityException(getString_0(107399498));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
