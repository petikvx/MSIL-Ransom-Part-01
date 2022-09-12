using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("c5f583f0-ae53-4e39-8af9-2c2d0d7af093")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsICacheInfoChannel
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetCacheTokenExpirationTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCacheTokenCachedCharsetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aCacheTokenCachedCharset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCacheTokenCachedCharsetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aCacheTokenCachedCharset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsFromCache();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetCacheKeyAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCacheKeyAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports aCacheKey);
}
