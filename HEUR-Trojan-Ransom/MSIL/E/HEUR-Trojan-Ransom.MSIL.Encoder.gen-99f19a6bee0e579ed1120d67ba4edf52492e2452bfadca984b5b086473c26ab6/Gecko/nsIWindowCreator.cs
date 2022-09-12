using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("30465632-A777-44cc-90F9-8145475EF999")]
public interface nsIWindowCreator
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIWebBrowserChrome CreateChromeWindow([MarshalAs(UnmanagedType.Interface)] nsIWebBrowserChrome parent, uint chromeFlags);
}
