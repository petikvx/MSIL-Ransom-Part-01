using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("96e4c264-2065-4ce9-93bb-43734c62c4eb")]
public interface nsIApplicationCacheNamespace
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init(uint itemType, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase namespaceSpec, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase data);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetItemTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNamespaceSpecAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aNamespaceSpec);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDataAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aData);
}
