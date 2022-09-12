using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("11bf5cdc-1dd2-11b2-ba6a-c76afb326fa1")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIGeneratingKeypairInfoDialogs
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void DisplayGeneratingKeypairInfo([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor ctx, [MarshalAs(UnmanagedType.Interface)] nsIKeygenThread runnable);
}
