using System.Runtime.InteropServices;
using System.Security;

namespace Alphaleonis.Win32.Filesystem;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[SuppressUnmanagedCodeSecurity]
[Guid("79427A2B-F895-40e0-BE79-B57DC82ED231")]
internal interface IKernelTransaction
{
	void GetHandle(out SafeKernelTransactionHandle handle);
}
