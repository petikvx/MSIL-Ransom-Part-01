using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("5b515449-ab64-4dba-b3cd-da8fc2f83064")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIHttpUpgradeListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnTransportAvailable([MarshalAs(UnmanagedType.Interface)] nsISocketTransport aTransport, [MarshalAs(UnmanagedType.Interface)] nsIAsyncInputStream aSocketIn, [MarshalAs(UnmanagedType.Interface)] nsIAsyncOutputStream aSocketOut);
}
