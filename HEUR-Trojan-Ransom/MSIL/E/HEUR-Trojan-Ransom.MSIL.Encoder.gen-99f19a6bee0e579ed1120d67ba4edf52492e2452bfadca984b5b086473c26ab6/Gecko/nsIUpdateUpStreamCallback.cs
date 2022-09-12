using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("4f08cc30-46ad-11e3-8f96-0800200c9a66")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIUpdateUpStreamCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void UpdateUpStreamResult([MarshalAs(UnmanagedType.U1)] bool success, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase externalIfname);
}
