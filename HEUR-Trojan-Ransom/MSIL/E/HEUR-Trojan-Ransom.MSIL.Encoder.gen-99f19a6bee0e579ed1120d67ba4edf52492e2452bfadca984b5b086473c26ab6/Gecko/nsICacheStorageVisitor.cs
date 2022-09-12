using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("6cc7c253-93b6-482b-8e9d-1e04d8e9d655")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsICacheStorageVisitor
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnCacheStorageInfo(uint aEntryCount, ulong aConsumption, ulong aCapacity, [MarshalAs(UnmanagedType.Interface)] nsIFile aDiskDirectory);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnCacheEntryInfo([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aIdEnhance, long aDataSize, int aFetchCount, uint aLastModifiedTime, uint aExpirationTime, [MarshalAs(UnmanagedType.U1)] bool aPinned);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnCacheEntryVisitCompleted();
}
