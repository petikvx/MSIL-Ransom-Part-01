using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("c664aae7-0d67-4155-a2dd-a3861778626f")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIStructuredCloneContainer
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void InitFromJSVal(ref JsVal aData, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InitFromBase64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aData, uint aFormatVersion, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal DeserializeToJsval(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIVariant DeserializeToVariant(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDataAsBase64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetSerializedNBytesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetFormatVersionAttribute();
}
