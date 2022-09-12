using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("60a38ca7-ca62-4384-aa07-eac7d4893786")]
public interface nsICdmaCellInfo : nsICellInfo
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetRegisteredAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetTimestampTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new long GetTimestampAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetNetworkIdAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetSystemIdAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetBaseStationIdAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetLongitudeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetLatitudeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetCdmaDbmAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetCdmaEcioAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetEvdoDbmAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetEvdoEcioAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetEvdoSnrAttribute();
}
