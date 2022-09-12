using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("dd1d6122-5ecf-4fe4-8f0f-995e7ab3121a")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsICachingChannel : nsICacheInfoChannel
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint GetCacheTokenExpirationTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetCacheTokenCachedCharsetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aCacheTokenCachedCharset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetCacheTokenCachedCharsetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aCacheTokenCachedCharset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsFromCache();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsISupports GetCacheKeyAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetCacheKeyAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports aCacheKey);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetCacheTokenAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCacheTokenAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports aCacheToken);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetOfflineCacheTokenAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOfflineCacheTokenAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports aOfflineCacheToken);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCacheOnlyMetadataAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCacheOnlyMetadataAttribute([MarshalAs(UnmanagedType.U1)] bool aCacheOnlyMetadata);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetPinAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPinAttribute([MarshalAs(UnmanagedType.U1)] bool aPin);
}
