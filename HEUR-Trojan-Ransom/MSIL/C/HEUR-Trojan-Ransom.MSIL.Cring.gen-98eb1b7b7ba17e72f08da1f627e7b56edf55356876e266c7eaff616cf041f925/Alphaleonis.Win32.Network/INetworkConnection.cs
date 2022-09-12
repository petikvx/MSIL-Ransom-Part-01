using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Alphaleonis.Win32.Network;

[ComImport]
[TypeLibType(4160)]
[Guid("DCB00005-570F-4A9B-8D69-199FDBA5723B")]
internal interface INetworkConnection
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
	INetwork GetNetwork();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ConnectivityStates GetConnectivity();

	[MethodImpl(MethodImplOptions.InternalCall)]
	Guid GetConnectionId();

	[MethodImpl(MethodImplOptions.InternalCall)]
	Guid GetAdapterId();

	[MethodImpl(MethodImplOptions.InternalCall)]
	DomainType GetDomainType();
}
