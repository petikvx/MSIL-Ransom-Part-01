using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("c1b3d6df-5373-4606-8494-8bcf14a7fc62")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIContentPrefCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnResult([MarshalAs(UnmanagedType.Interface)] nsIVariant aResult);
}
