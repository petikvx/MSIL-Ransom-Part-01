using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("85255CC3-07BA-49FD-BC9B-18D2963DAF7F")]
public interface nsIDOMGeoPositionError
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	short GetCodeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetMessageAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aMessage);
}
