using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("6a5d2ce7-2c45-43c1-bdab-9df7a06caed1")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMHTMLHtmlElement
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetVersionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aVersion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetVersionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aVersion);
}
