using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("b0e7c156-d00c-4605-a77d-27c7418f23ae")]
public interface nsIBrowserGlue
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Sanitize([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aParentWindow);
}
