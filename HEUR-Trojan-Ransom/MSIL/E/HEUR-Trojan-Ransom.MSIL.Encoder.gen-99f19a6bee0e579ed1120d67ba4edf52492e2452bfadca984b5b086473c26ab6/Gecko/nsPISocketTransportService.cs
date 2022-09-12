using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("18f73bf1-b35b-4b7b-aa9a-11bcbdbc389c")]
public interface nsPISocketTransportService : nsISocketTransportService, nsIRoutedSocketTransportService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsISocketTransport CreateTransport([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] string[] aSocketTypes, uint aTypeCount, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHost, int aPort, [MarshalAs(UnmanagedType.Interface)] nsIProxyInfo aProxyInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsISocketTransport CreateUnixDomainTransport([MarshalAs(UnmanagedType.Interface)] nsIFile aPath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void AttachSocket(IntPtr aFd, IntPtr aHandler);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void NotifyWhenCanAttachSocket([MarshalAs(UnmanagedType.Interface)] nsIRunnable aEvent);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsISocketTransport CreateRoutedTransport([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] string[] aSocketTypes, uint aTypeCount, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHost, int aPort, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHostRoute, int aPortRoute, [MarshalAs(UnmanagedType.Interface)] nsIProxyInfo aProxyInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Shutdown();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAutodialEnabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAutodialEnabledAttribute([MarshalAs(UnmanagedType.U1)] bool aAutodialEnabled);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetSendBufferSizeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetOfflineAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOfflineAttribute([MarshalAs(UnmanagedType.U1)] bool aOffline);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetKeepaliveIdleTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetKeepaliveRetryIntervalAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetKeepaliveProbeCountAttribute();
}
