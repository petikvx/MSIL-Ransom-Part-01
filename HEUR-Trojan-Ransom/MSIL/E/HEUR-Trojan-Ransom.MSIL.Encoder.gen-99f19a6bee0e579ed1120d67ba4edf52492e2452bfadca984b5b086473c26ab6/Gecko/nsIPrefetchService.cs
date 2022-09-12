using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("2df8b475-f536-4a1a-afea-b39843df8005")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIPrefetchService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void PrefetchURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIURI aReferrerURI, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aSource, [MarshalAs(UnmanagedType.U1)] bool aExplicit);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool HasMoreElements();
}
