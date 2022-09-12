using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("ca7b0bc7-c67c-4b79-8270-ed7ba002af08")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIGfxInfoDebug
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void SpoofVendorID([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aVendorID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SpoofDeviceID([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDeviceID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SpoofDriverVersion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDriverVersion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SpoofOSVersion(uint aVersion);
}
