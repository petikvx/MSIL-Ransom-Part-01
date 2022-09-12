using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("5f914307-5c34-4e1f-8e32-ec749d25b27a")]
public interface nsISafeOutputStream
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Finish();
}
