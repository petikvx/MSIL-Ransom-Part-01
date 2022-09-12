using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("b6c44689-f97e-4f32-a723-29eeddfbdc53")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIWindowCreator2 : nsIWindowCreator
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIWebBrowserChrome CreateChromeWindow([MarshalAs(UnmanagedType.Interface)] nsIWebBrowserChrome parent, uint chromeFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIWebBrowserChrome CreateChromeWindow2([MarshalAs(UnmanagedType.Interface)] nsIWebBrowserChrome parent, uint chromeFlags, uint contextFlags, [MarshalAs(UnmanagedType.Interface)] nsIURI uri, [MarshalAs(UnmanagedType.Interface)] nsITabParent aOpeningTab, [MarshalAs(UnmanagedType.U1)] ref bool cancel);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetScreenId(uint aScreenId);
}
