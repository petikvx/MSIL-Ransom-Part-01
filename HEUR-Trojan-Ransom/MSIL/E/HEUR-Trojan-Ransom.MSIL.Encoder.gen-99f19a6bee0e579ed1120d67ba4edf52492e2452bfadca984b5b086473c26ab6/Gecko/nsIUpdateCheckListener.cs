using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("4aa2b4bb-39ea-407b-98ff-89f19134d4c0")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIUpdateCheckListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnCheckComplete([MarshalAs(UnmanagedType.Interface)] nsIXMLHttpRequest request, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] nsIUpdate[] updates, uint updateCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnError([MarshalAs(UnmanagedType.Interface)] nsIXMLHttpRequest request, [MarshalAs(UnmanagedType.Interface)] nsIUpdate update);
}
