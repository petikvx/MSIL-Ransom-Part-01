using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("286a96fe-5519-459b-9ef8-2e34b9c1f9f2")]
public interface nsIMobileCellInfo
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetGsmLocationAreaCodeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetGsmCellIdAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetCdmaBaseStationIdAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetCdmaBaseStationLatitudeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetCdmaBaseStationLongitudeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetCdmaSystemIdAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetCdmaNetworkIdAttribute();
}
