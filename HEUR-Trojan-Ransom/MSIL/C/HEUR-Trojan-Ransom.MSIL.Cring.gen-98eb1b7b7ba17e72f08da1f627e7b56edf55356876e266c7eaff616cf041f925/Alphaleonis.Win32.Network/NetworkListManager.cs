using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Alphaleonis.Win32.Network;

[ComImport]
[Guid("DCB00C01-570F-4A9B-8D69-199FDBA5723B")]
[ClassInterface(0)]
[TypeLibType(2)]
[ComSourceInterfaces("Microsoft.Windows.NetworkList.Internal.INetworkEvents\0Microsoft.Windows.NetworkList.Internal.INetworkConnectionEvents\0Microsoft.Windows.NetworkList.Internal.INetworkListManagerEvents")]
internal sealed class NetworkListManager : INetworkListManager
{
	[DispId(6)]
	public extern bool IsConnected
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(6)]
		get;
	}

	[DispId(5)]
	public extern bool IsConnectedToInternet
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(5)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(7)]
	public extern ConnectivityStates GetConnectivity();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public extern INetwork GetNetwork([In] Guid gdNetworkId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(4)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public extern INetworkConnection GetNetworkConnection([In] Guid gdNetworkConnectionId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(3)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public extern IEnumerable GetNetworkConnections();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public extern IEnumerable GetNetworks([In] NetworkConnectivityLevels flags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	public extern NetworkListManager();
}
