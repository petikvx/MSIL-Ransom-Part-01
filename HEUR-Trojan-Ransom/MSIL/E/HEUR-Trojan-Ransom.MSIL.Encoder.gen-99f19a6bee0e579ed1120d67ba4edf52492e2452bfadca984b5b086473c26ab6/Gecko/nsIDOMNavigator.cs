using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("f1101fbb-d119-4cb8-845b-6bbae8a151c7")]
public interface nsIDOMNavigator
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAppCodeNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAppCodeName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAppNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAppName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAppVersionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAppVersion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetLanguageAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLanguage);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPlatformAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPlatform);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetOscpuAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aOscpu);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetVendorAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aVendor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetVendorSubAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aVendorSub);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetProductAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aProduct);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetProductSubAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aProductSub);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetUserAgentAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aUserAgent);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetBuildIDAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aBuildID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDoNotTrackAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDoNotTrack);
}
