using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("35d104a6-d252-4fd4-8a56-3c14657cad3b")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsICacheStorage
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void AsyncOpenURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aIdExtension, uint aFlags, [MarshalAs(UnmanagedType.Interface)] nsICacheEntryOpenCallback aCallback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsICacheEntry OpenTruncate([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aIdExtension);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Exists([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aIdExtension);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AsyncDoomURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aIdExtension, [MarshalAs(UnmanagedType.Interface)] nsICacheEntryDoomCallback aCallback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AsyncEvictStorage([MarshalAs(UnmanagedType.Interface)] nsICacheEntryDoomCallback aCallback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AsyncVisitStorage([MarshalAs(UnmanagedType.Interface)] nsICacheStorageVisitor aVisitor, [MarshalAs(UnmanagedType.U1)] bool aVisitEntries);
}
