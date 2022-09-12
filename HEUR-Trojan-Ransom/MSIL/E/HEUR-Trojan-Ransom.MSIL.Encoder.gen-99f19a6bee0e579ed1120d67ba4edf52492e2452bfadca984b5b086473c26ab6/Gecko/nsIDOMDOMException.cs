using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("5bd766d3-57a9-4833-995d-dbe21da29595")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMDOMException
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetCodeAttribute();
}
