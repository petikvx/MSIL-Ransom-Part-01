using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("fe96dc1c-40e4-4974-9354-e3fce663c3d5")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMHTMLScriptElement
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSrcAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSrc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSrcAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSrc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAsyncAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAsyncAttribute([MarshalAs(UnmanagedType.U1)] bool aAsync);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetDeferAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDeferAttribute([MarshalAs(UnmanagedType.U1)] bool aDefer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCharsetAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCharset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCharsetAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCharset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTextAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aText);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTextAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aText);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetHtmlForAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHtmlFor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHtmlForAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHtmlFor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetEventAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aEvent);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEventAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aEvent);
}
