using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("3ce03a2f-97f7-4375-b6bb-1788a60cad3b")]
public interface nsIPartialFileInputStream
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.Interface)] nsIFile file, ulong start, ulong length, int ioFlags, int perm, int behaviorFlags);
}
