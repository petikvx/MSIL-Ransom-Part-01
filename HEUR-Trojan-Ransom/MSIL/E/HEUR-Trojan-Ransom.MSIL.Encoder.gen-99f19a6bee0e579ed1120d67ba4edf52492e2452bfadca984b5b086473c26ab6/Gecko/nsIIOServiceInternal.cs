using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("6633c0bf-d97a-428f-8ece-cb6a655fb95a")]
public interface nsIIOServiceInternal
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetConnectivity([MarshalAs(UnmanagedType.U1)] bool connectivity);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NotifyWakeup();
}
