using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("508d5469-9e1e-4a08-b5b0-7cfebba1e51a")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsISocketProvider
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void NewSocket(int aFamily, [MarshalAs(UnmanagedType.LPStr)] string aHost, int aPort, [MarshalAs(UnmanagedType.Interface)] nsIProxyInfo aProxy, uint aFlags, ref IntPtr aFileDesc, [MarshalAs(UnmanagedType.Interface)] ref nsISupports aSecurityInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddToSocket(int aFamily, [MarshalAs(UnmanagedType.LPStr)] string aHost, int aPort, [MarshalAs(UnmanagedType.Interface)] nsIProxyInfo aProxy, uint aFlags, IntPtr aFileDesc, [MarshalAs(UnmanagedType.Interface)] ref nsISupports aSecurityInfo);
}
