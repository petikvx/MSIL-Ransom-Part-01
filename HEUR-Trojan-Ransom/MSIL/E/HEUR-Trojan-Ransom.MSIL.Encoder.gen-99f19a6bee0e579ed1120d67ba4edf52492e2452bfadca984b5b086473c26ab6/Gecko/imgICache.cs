using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("bfdf23ff-378e-402e-8a6c-840f0c82b6c3")]
public interface imgICache
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void ClearCache([MarshalAs(UnmanagedType.U1)] bool chrome);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIProperties FindEntryProperties([MarshalAs(UnmanagedType.Interface)] nsIURI uri, [MarshalAs(UnmanagedType.Interface)] nsIDOMDocument doc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RespectPrivacyNotifications();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ClearCacheForControlledDocument(IntPtr doc);
}
