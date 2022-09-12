using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("31f7f4ae-6916-4f2d-a81e-926a4e3022ee")]
public interface nsIDirectoryEnumerator
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFile GetNextFileAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Close();
}
