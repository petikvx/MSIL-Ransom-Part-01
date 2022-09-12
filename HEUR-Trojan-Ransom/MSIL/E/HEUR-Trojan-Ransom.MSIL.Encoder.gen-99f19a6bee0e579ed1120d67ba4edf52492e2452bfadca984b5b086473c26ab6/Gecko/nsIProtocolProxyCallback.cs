using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("fbb6eff6-0cc2-4d99-8d6f-0a12b462bdeb")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIProtocolProxyCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnProxyAvailable([MarshalAs(UnmanagedType.Interface)] nsICancelable aRequest, [MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel, [MarshalAs(UnmanagedType.Interface)] nsIProxyInfo aProxyInfo, int aStatus);
}
