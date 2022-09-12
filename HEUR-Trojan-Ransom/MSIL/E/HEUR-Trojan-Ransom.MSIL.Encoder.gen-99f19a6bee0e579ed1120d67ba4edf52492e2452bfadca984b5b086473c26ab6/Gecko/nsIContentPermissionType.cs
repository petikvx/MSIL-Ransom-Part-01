using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("ef4db3b8-ca9c-4b1d-8f81-fd88ec32af13")]
public interface nsIContentPermissionType
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAccessAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aAccess);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIArray GetOptionsAttribute();
}
