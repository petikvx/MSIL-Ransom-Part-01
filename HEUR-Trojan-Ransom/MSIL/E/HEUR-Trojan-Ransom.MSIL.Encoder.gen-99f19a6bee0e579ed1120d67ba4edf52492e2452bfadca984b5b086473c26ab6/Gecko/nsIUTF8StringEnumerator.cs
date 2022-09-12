using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("9bdf1010-3695-4907-95ed-83d0410ec307")]
public interface nsIUTF8StringEnumerator
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool HasMore();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNext([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);
}
