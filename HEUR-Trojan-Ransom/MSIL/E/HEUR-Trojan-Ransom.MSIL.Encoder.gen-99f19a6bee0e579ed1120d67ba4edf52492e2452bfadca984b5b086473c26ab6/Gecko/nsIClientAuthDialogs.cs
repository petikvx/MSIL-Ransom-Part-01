using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("fa4c7520-1433-11d5-ba24-00108303b117")]
public interface nsIClientAuthDialogs
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void ChooseCertificate([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor ctx, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string cn, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string organization, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string issuer, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] IntPtr[] certNickList, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] IntPtr[] certDetailsList, uint count, ref int selectedIndex, [MarshalAs(UnmanagedType.U1)] ref bool canceled);
}
