using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("aa7c95f6-d3b5-44b3-9597-1d9f19b9c5f2")]
public interface nsIListenerChangeListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void ListenersChanged([MarshalAs(UnmanagedType.Interface)] nsIArray aEventListenerChanges);
}
