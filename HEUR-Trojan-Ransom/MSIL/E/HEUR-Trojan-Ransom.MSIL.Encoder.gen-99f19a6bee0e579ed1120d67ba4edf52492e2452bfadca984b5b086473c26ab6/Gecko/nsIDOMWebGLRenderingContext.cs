using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("f1a2fd3a-c6ac-4ee2-a700-5d285d5e3fff")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMWebGLRenderingContext
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void MozGetUnderlyingParamString(uint pname, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
}
