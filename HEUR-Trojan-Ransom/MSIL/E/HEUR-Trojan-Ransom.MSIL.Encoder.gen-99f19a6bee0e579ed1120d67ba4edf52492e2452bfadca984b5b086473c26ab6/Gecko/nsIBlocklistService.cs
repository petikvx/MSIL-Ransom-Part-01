using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("a6dcc76e-9f62-4cc1-a470-b483a1a6f096")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIBlocklistService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsAddonBlocklisted(ref JsVal addon, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase appVersion, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase toolkitVersion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetAddonBlocklistState(ref JsVal addon, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase appVersion, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase toolkitVersion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetPluginBlocklistState([MarshalAs(UnmanagedType.Interface)] nsIPluginTag plugin, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase appVersion, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase toolkitVersion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAddonBlocklistURL(ref JsVal addon, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase appVersion, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase toolkitVersion, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPluginBlocklistURL([MarshalAs(UnmanagedType.Interface)] nsIPluginTag plugin, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPluginInfoURL([MarshalAs(UnmanagedType.Interface)] nsIPluginTag plugin, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
}
