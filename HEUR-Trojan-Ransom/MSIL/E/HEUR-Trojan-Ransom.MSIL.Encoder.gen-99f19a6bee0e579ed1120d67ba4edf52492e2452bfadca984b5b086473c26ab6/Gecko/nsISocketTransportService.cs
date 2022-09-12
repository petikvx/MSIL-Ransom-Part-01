using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("ad56b25f-e6bb-4db3-9f7b-5b7db33fd2b1")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsISocketTransportService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISocketTransport CreateTransport([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] string[] aSocketTypes, uint aTypeCount, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHost, int aPort, [MarshalAs(UnmanagedType.Interface)] nsIProxyInfo aProxyInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISocketTransport CreateUnixDomainTransport([MarshalAs(UnmanagedType.Interface)] nsIFile aPath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AttachSocket(IntPtr aFd, IntPtr aHandler);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NotifyWhenCanAttachSocket([MarshalAs(UnmanagedType.Interface)] nsIRunnable aEvent);
}
