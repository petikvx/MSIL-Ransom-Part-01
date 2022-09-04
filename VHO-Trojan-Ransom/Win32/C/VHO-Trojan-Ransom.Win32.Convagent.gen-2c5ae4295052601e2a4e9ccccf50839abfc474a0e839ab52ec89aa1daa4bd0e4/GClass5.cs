using System;
using System.Runtime.InteropServices;

[GClass3.InterfaceVersion("CLIENTENGINE_INTERFACE_VERSION003")]
public class GClass5 : GClass3.GClass4<GClass2>
{
	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	private delegate IntPtr Delegate5(IntPtr thisptr, int hSteamUser, int hSteamPipe, string pchVersion);

	public TClass method_2<TClass>(int int_0, int int_1) where TClass : GClass3.GInterface0, new()
	{
		return GClass3.smethod_1<TClass>(method_1<Delegate5>(gparam_0.intptr_12)(intptr_0, int_0, int_1, Class2.smethod_0(typeof(TClass))));
	}
}
