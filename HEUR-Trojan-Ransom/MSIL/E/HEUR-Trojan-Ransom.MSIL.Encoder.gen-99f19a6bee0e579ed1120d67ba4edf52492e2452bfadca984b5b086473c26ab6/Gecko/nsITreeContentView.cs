using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("5ef62896-0c0a-41f1-bb3c-44a60f5dfdab")]
public interface nsITreeContentView
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMElement GetItemAtIndex(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetIndexOfItem([MarshalAs(UnmanagedType.Interface)] nsIDOMElement item);
}
