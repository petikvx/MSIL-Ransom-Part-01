using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("8762c4e7-be35-4958-9b81-a05685bb516d")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIURILoader
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterContentListener([MarshalAs(UnmanagedType.Interface)] nsIURIContentListener aContentListener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnRegisterContentListener([MarshalAs(UnmanagedType.Interface)] nsIURIContentListener aContentListener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OpenURI([MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel, uint aFlags, [MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor aWindowContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIStreamListener OpenChannel([MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel, uint aFlags, [MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor aWindowContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Stop([MarshalAs(UnmanagedType.Interface)] nsISupports aLoadCookie);
}
