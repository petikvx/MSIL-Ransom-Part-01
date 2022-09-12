using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("3203c36f-33fd-4628-8c88-77e82d38df1e")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMHTMLTableCellElement
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetCellIndexAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAbbrAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAbbr);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAbbrAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAbbr);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAlignAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAlign);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAlignAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAlign);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAxisAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAxis);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAxisAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAxis);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetBgColorAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aBgColor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetBgColorAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aBgColor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetChAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCh);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetChAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCh);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetChOffAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aChOff);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetChOffAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aChOff);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetColSpanAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetColSpanAttribute(int aColSpan);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetHeadersAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHeaders);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHeadersAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHeaders);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetHeightAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHeight);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHeightAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHeight);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetNoWrapAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetNoWrapAttribute([MarshalAs(UnmanagedType.U1)] bool aNoWrap);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetRowSpanAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetRowSpanAttribute(int aRowSpan);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetScopeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aScope);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetScopeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aScope);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetVAlignAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aVAlign);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetVAlignAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aVAlign);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetWidthAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aWidth);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetWidthAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aWidth);
}
