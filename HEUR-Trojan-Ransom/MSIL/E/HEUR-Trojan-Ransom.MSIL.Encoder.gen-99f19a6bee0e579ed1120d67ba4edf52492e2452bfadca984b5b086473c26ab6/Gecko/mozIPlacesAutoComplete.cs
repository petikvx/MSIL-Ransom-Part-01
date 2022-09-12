using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("61b6348a-09e1-4810-8057-f8cb3cec6ef8")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface mozIPlacesAutoComplete
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterOpenPage([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnregisterOpenPage([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
}
