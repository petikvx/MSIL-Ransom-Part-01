using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("5ecaa593-7660-4a3a-957a-92d5770671c7")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsICommandLineValidator
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Validate([MarshalAs(UnmanagedType.Interface)] nsICommandLine aCommandLine);
}
