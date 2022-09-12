using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("0ccbcf19-d1b4-489e-984c-cd8c43672bb9")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMDOMConstructor
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void ToString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
}
