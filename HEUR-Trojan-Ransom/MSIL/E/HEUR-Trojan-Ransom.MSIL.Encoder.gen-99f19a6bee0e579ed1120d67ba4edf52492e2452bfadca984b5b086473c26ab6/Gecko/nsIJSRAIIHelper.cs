using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("52e5a996-d0a9-4efc-a6fa-24489c532b19")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIJSRAIIHelper
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Destruct();
}
