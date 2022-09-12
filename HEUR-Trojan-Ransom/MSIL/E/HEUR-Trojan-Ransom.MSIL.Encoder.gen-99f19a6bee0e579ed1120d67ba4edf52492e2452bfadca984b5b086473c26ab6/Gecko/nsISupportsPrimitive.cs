using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("d0d4b136-1dd1-11b2-9371-f0727ef827c0")]
public interface nsISupportsPrimitive
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetTypeAttribute();
}
