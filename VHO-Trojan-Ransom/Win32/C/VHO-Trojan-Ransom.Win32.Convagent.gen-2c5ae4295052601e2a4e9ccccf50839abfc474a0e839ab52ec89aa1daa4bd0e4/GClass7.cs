using System;
using System.Runtime.InteropServices;

[GClass3.InterfaceVersion("SteamFriends013")]
public class GClass7 : GClass3.GClass4<GClass12>
{
	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	private delegate int Delegate9(IntPtr thisptr, int iFriendFlags);

	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	private delegate void Delegate10(IntPtr thisptr, ref ulong retarg, int iFriend, int iFriendFlags);

	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	private delegate IntPtr Delegate11(IntPtr thisptr, ulong steamIDFriend);

	public int method_2(int int_0)
	{
		return method_1<Delegate9>(gparam_0.intptr_3)(intptr_0, int_0);
	}

	public GClass14 method_3(int int_0, int int_1)
	{
		ulong retarg = 0uL;
		method_1<Delegate10>(gparam_0.intptr_4)(intptr_0, ref retarg, int_0, int_1);
		return new GClass14(retarg);
	}

	public string method_4(GClass14 gclass14_0)
	{
		return GClass3.smethod_0(Marshal.PtrToStringAnsi(method_1<Delegate11>(gparam_0.intptr_7)(intptr_0, gclass14_0.method_1())));
	}
}
