using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("9479c864-d1f9-45ab-b7b9-28b907bd2ba9")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIScriptableBase64Encoder
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void EncodeToCString([MarshalAs(UnmanagedType.Interface)] nsIInputStream stream, uint length, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EncodeToString([MarshalAs(UnmanagedType.Interface)] nsIInputStream stream, uint length, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
}
