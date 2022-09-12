using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("9475a6af-6352-4251-90f9-d65b1cd2ea15")]
public interface nsIHttpEventSink
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnRedirect([MarshalAs(UnmanagedType.Interface)] nsIHttpChannel httpChannel, [MarshalAs(UnmanagedType.Interface)] nsIChannel newChannel);
}
