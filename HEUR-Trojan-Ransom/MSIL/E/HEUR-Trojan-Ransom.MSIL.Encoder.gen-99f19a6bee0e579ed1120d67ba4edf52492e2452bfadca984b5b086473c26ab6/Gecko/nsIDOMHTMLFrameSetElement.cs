using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("14b29269-c387-4cff-8463-b0871ca0be3a")]
public interface nsIDOMHTMLFrameSetElement
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetColsAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCols);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetColsAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCols);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetRowsAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aRows);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetRowsAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aRows);
}
