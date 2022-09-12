using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("083aebb0-7790-43b2-ae81-9e404e626236")]
public interface nsIJSON
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Encode(ref JsVal value, IntPtr jsContext, int argc, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EncodeToStream([MarshalAs(UnmanagedType.Interface)] nsIOutputStream stream, [MarshalAs(UnmanagedType.LPStr)] string charset, [MarshalAs(UnmanagedType.U1)] bool writeBOM, ref JsVal value, IntPtr jsContext, int argc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal Decode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase str, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal DecodeFromStream([MarshalAs(UnmanagedType.Interface)] nsIInputStream stream, int contentLength, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EncodeFromJSVal(IntPtr value, IntPtr cx, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal DecodeToJSVal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase str, IntPtr cx);
}
