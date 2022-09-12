using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("82cf605a-8393-4550-83ab-43cd5578e006")]
public interface nsIFileStream
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.Interface)] nsIFile file, int ioFlags, int perm, int behaviorFlags);
}
