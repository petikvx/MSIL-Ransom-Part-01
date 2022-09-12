using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Alphaleonis.Win32.Network;

[ComImport]
[Guid("DCB00002-570F-4A9B-8D69-199FDBA5723B")]
[TypeLibType(4160)]
internal interface INetwork
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
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetName();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetName([In][MarshalAs(UnmanagedType.BStr)] string szNetworkNewName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetDescription();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDescription([In][MarshalAs(UnmanagedType.BStr)] string szDescription);

	[MethodImpl(MethodImplOptions.InternalCall)]
	Guid GetNetworkId();

	[MethodImpl(MethodImplOptions.InternalCall)]
	DomainType GetDomainType();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IEnumerable GetNetworkConnections();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTimeCreatedAndConnected(out uint pdwLowDateTimeCreated, out uint pdwHighDateTimeCreated, out uint pdwLowDateTimeConnected, out uint pdwHighDateTimeConnected);

	[MethodImpl(MethodImplOptions.InternalCall)]
	ConnectivityStates GetConnectivity();

	[MethodImpl(MethodImplOptions.InternalCall)]
	NetworkCategory GetCategory();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCategory([In] NetworkCategory newCategory);
}
