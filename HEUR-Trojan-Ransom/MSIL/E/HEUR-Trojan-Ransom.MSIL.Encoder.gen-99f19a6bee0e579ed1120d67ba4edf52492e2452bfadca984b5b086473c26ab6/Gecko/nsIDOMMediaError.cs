using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("7bd8c29f-8a76-453f-9373-79f820f2dc01")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMMediaError
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetCodeAttribute();
}
