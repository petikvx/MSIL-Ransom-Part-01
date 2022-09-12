using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("207edb28-eb5e-424e-a862-b0e97C8de866")]
public interface fuelIWindow
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIVariant GetTabsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	fuelIBrowserTab GetActiveTabAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	fuelIBrowserTab Open([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	extIEvents GetEventsAttribute();
}
