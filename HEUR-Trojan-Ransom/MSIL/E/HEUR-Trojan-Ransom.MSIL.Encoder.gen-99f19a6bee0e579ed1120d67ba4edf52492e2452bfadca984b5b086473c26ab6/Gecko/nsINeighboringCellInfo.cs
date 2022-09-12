using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("87dc222e-abb3-4342-95bf-626aa19fa20e")]
public interface nsINeighboringCellInfo
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNetworkTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aNetworkType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetGsmLocationAreaCodeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetGsmCellIdAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetWcdmaPscAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetSignalStrengthAttribute();
}
