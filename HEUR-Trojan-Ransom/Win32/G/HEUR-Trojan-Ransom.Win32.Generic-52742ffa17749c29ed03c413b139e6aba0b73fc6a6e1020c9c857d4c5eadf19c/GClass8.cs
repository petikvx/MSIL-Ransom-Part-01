using System;
using System.Runtime.InteropServices;

[GClass3.InterfaceVersion("CLIENTFRIENDS_INTERFACE_VERSION001")]
public class GClass8 : GClass3.GClass4<GClass15>
{
	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	private delegate void Delegate12(IntPtr thisptr, ref ulong retarg, int iFriend, GEnum1 iFriendFlags);

	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	[return: MarshalAs(UnmanagedType.I1)]
	private delegate bool Delegate13(IntPtr thisptr, ulong steamIDFriend, GEnum0 eChatEntryType, byte[] pvMsgBody, int cubMsgBody);

	public GClass14 method_2(int int_0, GEnum1 genum1_0)
	{
		ulong retarg = 0uL;
		method_1<Delegate12>(gparam_0.intptr_8)(intptr_0, ref retarg, int_0, genum1_0);
		return new GClass14(retarg);
	}

	public bool method_3(GClass14 gclass14_0, GEnum0 genum0_0, byte[] byte_0)
	{
		return method_1<Delegate13>(gparam_0.intptr_57)(intptr_0, gclass14_0.method_1(), genum0_0, byte_0, byte_0.Length);
	}
}
