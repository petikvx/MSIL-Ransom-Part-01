using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Alphaleonis.Win32.Network;

[ComImport]
[Guid("DCB00000-570F-4A9B-8D69-199FDBA5723B")]
[TypeLibType(4160)]
internal interface INetworkListManager
{
	bool IsConnected
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
	}

	bool IsConnectedToInternet
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IEnumerable GetNetworks([In] NetworkConnectivityLevels flags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	INetwork GetNetwork([In] Guid gdNetworkId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IEnumerable GetNetworkConnections();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	INetworkConnection GetNetworkConnection([In] Guid gdNetworkConnectionId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	ConnectivityStates GetConnectivity();
}
