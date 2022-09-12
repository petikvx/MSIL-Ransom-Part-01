using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("048e5ca1-0eb7-4bb1-a9a2-a36f7d4e0e3c")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIProfileStartup
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFile GetDirectoryAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DoStartup();
}
