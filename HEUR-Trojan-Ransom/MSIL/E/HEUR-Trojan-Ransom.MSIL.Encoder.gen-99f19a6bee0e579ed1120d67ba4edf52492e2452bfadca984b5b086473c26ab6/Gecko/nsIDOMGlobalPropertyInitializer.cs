using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("6368a821-d3e2-4cbd-9699-5a8ba569e2f3")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMGlobalPropertyInitializer
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal Init([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window);
}
