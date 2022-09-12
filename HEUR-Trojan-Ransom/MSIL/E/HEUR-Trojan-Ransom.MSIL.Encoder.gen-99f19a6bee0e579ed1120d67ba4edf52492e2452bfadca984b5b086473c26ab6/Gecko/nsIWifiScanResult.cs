using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("cf1ac02b-1f39-446e-815b-651ac78d2233")]
public interface nsIWifiScanResult
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSsidAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSsid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetBssidAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aBssid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetCapabilitiesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetSignalStrengthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetRelSignalStrengthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetConnectedAttribute();
}
