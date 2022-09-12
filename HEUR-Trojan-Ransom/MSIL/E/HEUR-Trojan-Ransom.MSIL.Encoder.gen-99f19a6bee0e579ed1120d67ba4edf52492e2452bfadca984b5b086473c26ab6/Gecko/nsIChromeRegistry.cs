using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("249fb5ad-ae29-4e2c-a728-ba5cf464d188")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIChromeRegistry
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI ConvertChromeURL([MarshalAs(UnmanagedType.Interface)] nsIURI aChromeURL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CheckForNewChrome();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool WrappersEnabled([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
}
