using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("a71aee68-dd38-4736-bd79-035fea1a1ec6")]
public interface nsISecurityEventSink
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnSecurityChange([MarshalAs(UnmanagedType.Interface)] nsISupports i_Context, uint state);
}
