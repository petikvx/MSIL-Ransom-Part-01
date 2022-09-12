using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("7c58c703-d245-4864-8d75-9648ca4a6139")]
public interface nsIProfileLock
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFile GetDirectoryAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFile GetLocalDirectoryAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetReplacedLockTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Unlock();
}
