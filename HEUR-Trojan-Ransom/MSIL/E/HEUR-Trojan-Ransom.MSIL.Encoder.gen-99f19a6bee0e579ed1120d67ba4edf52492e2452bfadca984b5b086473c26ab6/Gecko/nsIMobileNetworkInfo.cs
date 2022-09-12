using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("d7e1364c-61a0-4cf1-bae3-a960e87064e1")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIMobileNetworkInfo
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetShortNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aShortName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetLongNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLongName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetMccAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aMcc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetMncAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aMnc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetStateAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aState);
}
