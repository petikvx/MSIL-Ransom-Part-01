using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("068630db-2c00-43dd-b167-495757a88236")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMHTMLBodyElement
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetALinkAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aALink);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetALinkAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aALink);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetBackgroundAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aBackground);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetBackgroundAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aBackground);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetBgColorAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aBgColor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetBgColorAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aBgColor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetLinkAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLink);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLinkAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLink);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTextAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aText);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTextAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aText);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetVLinkAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aVLink);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetVLinkAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aVLink);
}
