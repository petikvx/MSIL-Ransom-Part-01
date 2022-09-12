using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("a3a6fcd4-bf89-4208-a837-bf2a73afd30c")]
public interface mozIStorageProgressHandler
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool OnProgress(mozIStorageConnection aConnection);
}
