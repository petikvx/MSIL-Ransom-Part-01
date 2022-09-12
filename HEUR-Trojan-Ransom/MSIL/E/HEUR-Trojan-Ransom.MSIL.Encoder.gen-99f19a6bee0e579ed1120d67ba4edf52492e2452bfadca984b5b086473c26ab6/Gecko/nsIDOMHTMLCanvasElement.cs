using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("4e8f1316-b601-471d-8f44-3c650d91ee9b")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMHTMLCanvasElement
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetWidthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetWidthAttribute(uint aWidth);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetHeightAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHeightAttribute(uint aHeight);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetMozOpaqueAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMozOpaqueAttribute([MarshalAs(UnmanagedType.U1)] bool aMozOpaque);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ToDataURL([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase type, ref JsVal @params, IntPtr jsContext, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports MozGetAsFile([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports MozGetIPCContext([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase contextId);
}
