using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("57a66a60-d43a-11d3-8cc2-00609792278c")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDirectoryService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterProvider([MarshalAs(UnmanagedType.Interface)] nsIDirectoryServiceProvider prov);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnregisterProvider([MarshalAs(UnmanagedType.Interface)] nsIDirectoryServiceProvider prov);
}
