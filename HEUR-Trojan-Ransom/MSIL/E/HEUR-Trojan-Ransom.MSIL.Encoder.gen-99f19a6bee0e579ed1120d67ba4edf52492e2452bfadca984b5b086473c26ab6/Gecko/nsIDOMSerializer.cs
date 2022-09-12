using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("9fd4ba15-e67c-4c98-b52c-7715f62c9196")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMSerializer
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void SerializeToString([MarshalAs(UnmanagedType.Interface)] nsIDOMNode root, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SerializeToStream([MarshalAs(UnmanagedType.Interface)] nsIDOMNode root, [MarshalAs(UnmanagedType.Interface)] nsIOutputStream stream, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase charset);
}
