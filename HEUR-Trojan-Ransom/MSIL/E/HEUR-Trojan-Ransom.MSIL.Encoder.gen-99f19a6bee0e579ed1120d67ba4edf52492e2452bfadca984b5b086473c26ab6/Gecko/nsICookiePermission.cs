using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("11ddd4ed-8f5b-40b3-b2a0-27c20ea1c88d")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsICookiePermission
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAccess([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, IntPtr aAccess);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr CanAccess([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CanSetCookie([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel, [MarshalAs(UnmanagedType.Interface)] nsICookie2 aCookie, [MarshalAs(UnmanagedType.U1)] ref bool aIsSession, ref long aExpiry);
}
