using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("06568DAE-C374-4383-A122-0CC96C7177F2")]
public interface nsIApplicationCache
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void InitAsHandle([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase groupId, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase clientId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetManifestURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetGroupIDAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGroupID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetClientIDAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aClientID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetActiveAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetUsageAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Activate();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Discard();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MarkEntry([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase key, uint typeBits);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnmarkEntry([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase key, uint typeBits);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetTypes([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase key);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GatherEntries(uint typeBits, ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ref string[] keys);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddNamespaces([MarshalAs(UnmanagedType.Interface)] nsIArray namespaces);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIApplicationCacheNamespace GetMatchingNamespace([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase key);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFile GetProfileDirectoryAttribute();
}
