using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("2571cbb5-550d-4400-8038-75df9b553f98")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface extIExtensionsCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Callback([MarshalAs(UnmanagedType.Interface)] nsIVariant extensions);
}
