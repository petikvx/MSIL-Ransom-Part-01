using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("bbf8cab0-d43a-11d3-8cc2-00609792278c")]
public interface nsIDirectoryServiceProvider
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFile GetFile([MarshalAs(UnmanagedType.LPStr)] string prop, [MarshalAs(UnmanagedType.U1)] ref bool persistent);
}
