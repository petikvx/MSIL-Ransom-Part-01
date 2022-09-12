using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("a1cbc159-468c-495d-8068-61dd538cbcca")]
public interface nsITokenDialogs
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void ChooseToken([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor ctx, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] IntPtr[] tokenNameList, uint count, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] ref string tokenName, [MarshalAs(UnmanagedType.U1)] ref bool canceled);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DisplayProtectedAuth([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor ctx, [MarshalAs(UnmanagedType.Interface)] nsIProtectedAuthThread runnable);
}
