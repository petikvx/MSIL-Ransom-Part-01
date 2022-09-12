using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("AA9DEF4E-2E59-412d-A6DF-B76F52167795")]
public interface nsIListBoxObject
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetRowCount();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMElement GetItemAtIndex(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetIndexOfItem([MarshalAs(UnmanagedType.Interface)] nsIDOMElement item);
}
