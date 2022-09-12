using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("79251626-387c-4531-89f3-680d31d6cf05")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIAccessibleApplication
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAppNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAppName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAppVersionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAppVersion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPlatformNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPlatformName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPlatformVersionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPlatformVersion);
}
