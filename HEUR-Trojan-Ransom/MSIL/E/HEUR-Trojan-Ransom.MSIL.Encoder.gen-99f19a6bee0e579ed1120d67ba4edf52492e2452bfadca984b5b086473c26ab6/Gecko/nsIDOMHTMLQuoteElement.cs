using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("f02502b5-32a6-4df7-8a57-1416553a3188")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMHTMLQuoteElement
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCiteAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCite);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCiteAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCite);
}
