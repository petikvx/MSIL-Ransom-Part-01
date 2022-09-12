using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("78b65e8c-68e7-4510-9a05-65bba12b283e")]
public interface nsIRadioInterfaceLayer
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetNumRadioInterfacesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIRadioInterface GetRadioInterface(uint clientId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetClientIdForEmergencyCall();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMicrophoneMuted([MarshalAs(UnmanagedType.U1)] bool muted);
}
