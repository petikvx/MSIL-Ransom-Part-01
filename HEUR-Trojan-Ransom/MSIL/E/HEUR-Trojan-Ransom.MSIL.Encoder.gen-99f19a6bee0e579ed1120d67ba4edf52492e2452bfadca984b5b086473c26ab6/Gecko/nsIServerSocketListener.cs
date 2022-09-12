using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("836d98ec-fee2-4bde-b609-abd5e966eabd")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIServerSocketListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnSocketAccepted([MarshalAs(UnmanagedType.Interface)] nsIServerSocket aServ, [MarshalAs(UnmanagedType.Interface)] nsISocketTransport aTransport);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnStopListening([MarshalAs(UnmanagedType.Interface)] nsIServerSocket aServ, int aStatus);
}
