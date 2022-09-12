using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("45686299-ae2b-46bc-9502-c56c35691ab9")]
public interface nsISelectionListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void NotifySelectionChanged([MarshalAs(UnmanagedType.Interface)] nsIDOMDocument doc, [MarshalAs(UnmanagedType.Interface)] nsISelection sel, short reason);
}
