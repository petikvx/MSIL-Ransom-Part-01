using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("51d59b08-1dd2-11b2-ad4a-a51b92f8a184")]
public interface nsICertPickDialogs
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void PickCertificate([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor ctx, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] IntPtr[] certNickList, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] IntPtr[] certDetailsList, uint count, ref int selectedIndex, [MarshalAs(UnmanagedType.U1)] ref bool canceled);
}
