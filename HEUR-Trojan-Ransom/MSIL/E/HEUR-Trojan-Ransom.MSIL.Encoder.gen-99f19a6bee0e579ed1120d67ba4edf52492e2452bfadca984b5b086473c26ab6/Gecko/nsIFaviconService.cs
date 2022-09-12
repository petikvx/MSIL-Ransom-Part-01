using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("e81e0b0c-b9f1-4c2e-8f3c-b809933cf73c")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIFaviconService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetFaviconLinkForIcon([MarshalAs(UnmanagedType.Interface)] nsIURI aFaviconURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ExpireAllFavicons();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddFailedFavicon([MarshalAs(UnmanagedType.Interface)] nsIURI aFaviconURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveFailedFavicon([MarshalAs(UnmanagedType.Interface)] nsIURI aFaviconURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsFailedFavicon([MarshalAs(UnmanagedType.Interface)] nsIURI aFaviconURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetDefaultFaviconAttribute();
}
