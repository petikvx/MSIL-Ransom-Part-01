using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("1b9d7d8a-6dd0-11dc-8314-0800200c9a66")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIAutoCompletePopup
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAutoCompleteInput GetInputAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetOverrideValueAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aOverrideValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetSelectedIndexAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSelectedIndexAttribute(int aSelectedIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetPopupOpenAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OpenAutocompletePopup([MarshalAs(UnmanagedType.Interface)] nsIAutoCompleteInput input, [MarshalAs(UnmanagedType.Interface)] nsIDOMElement element);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ClosePopup();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Invalidate();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SelectBy([MarshalAs(UnmanagedType.U1)] bool reverse, [MarshalAs(UnmanagedType.U1)] bool page);
}
