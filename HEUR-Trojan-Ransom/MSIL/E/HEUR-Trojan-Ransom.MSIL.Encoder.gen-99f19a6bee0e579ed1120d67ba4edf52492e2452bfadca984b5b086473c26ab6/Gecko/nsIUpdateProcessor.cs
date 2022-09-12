using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("74439497-d796-4915-8cef-3dfe43027e4d")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIUpdateProcessor
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void ProcessUpdate([MarshalAs(UnmanagedType.Interface)] nsIUpdate update);
}
