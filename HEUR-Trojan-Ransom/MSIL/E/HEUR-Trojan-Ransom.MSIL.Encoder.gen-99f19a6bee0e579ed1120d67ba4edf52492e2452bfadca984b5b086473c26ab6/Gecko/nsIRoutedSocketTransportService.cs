using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("c5204623-5b58-4a16-8b2e-67c34dd02e3f")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIRoutedSocketTransportService : nsISocketTransportService
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
	nsISocketTransport CreateRoutedTransport([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] string[] aSocketTypes, uint aTypeCount, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHost, int aPort, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHostRoute, int aPortRoute, [MarshalAs(UnmanagedType.Interface)] nsIProxyInfo aProxyInfo);
}
