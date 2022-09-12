using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("8cbf2dc2-91e0-44bc-984f-553638412071")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface mozIStorageCompletionCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Complete(int status, [MarshalAs(UnmanagedType.Interface)] nsISupports value);
}
