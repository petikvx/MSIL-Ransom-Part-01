using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("31adb439-0055-402d-9b1d-d5ca94f3f55b")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMCounter
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetIdentifierAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aIdentifier);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetListStyleAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aListStyle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSeparatorAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSeparator);
}
