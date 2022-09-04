using System;
using System.Runtime.InteropServices;

[GClass3.InterfaceVersion("SteamClient012")]
public class GClass6 : GClass3.GClass4<GClass11>
{
	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	private delegate int Delegate6(IntPtr thisptr);

	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	private delegate int Delegate7(IntPtr thisptr, int hSteamPipe);

	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	private delegate IntPtr Delegate8(IntPtr thisptr, int hSteamUser, int hSteamPipe, string pchVersion);

	public int method_2()
	{
		return method_1<Delegate6>(gparam_0.intptr_0)(intptr_0);
	}

	public int method_3(int int_0)
	{
		return method_1<Delegate7>(gparam_0.intptr_2)(intptr_0, int_0);
	}

	public TClass method_4<TClass>(int int_0, int int_1) where TClass : new()
	{
		return GClass3.smethod_1<TClass>(method_1<Delegate8>(gparam_0.intptr_8)(intptr_0, int_0, int_1, Class2.smethod_0(typeof(TClass))));
	}
}
