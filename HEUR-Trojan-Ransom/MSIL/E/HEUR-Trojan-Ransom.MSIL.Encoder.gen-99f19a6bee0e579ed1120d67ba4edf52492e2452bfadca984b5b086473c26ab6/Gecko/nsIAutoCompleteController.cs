using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("ff9f8465-204a-47a6-b3c9-0628b3856684")]
public interface nsIAutoCompleteController
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAutoCompleteInput GetInputAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetInputAttribute([MarshalAs(UnmanagedType.Interface)] nsIAutoCompleteInput aInput);

	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetSearchStatusAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetMatchCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StartSearch([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase searchString);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StopSearch();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleText();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool HandleEnter([MarshalAs(UnmanagedType.U1)] bool aIsPopupSelection);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool HandleEscape();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleStartComposition();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleEndComposition();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleTab();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool HandleKeyNavigation(uint key);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool HandleDelete();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetValueAt(int index, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetLabelAt(int index, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCommentAt(int index, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetStyleAt(int index, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetImageAt(int index, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetFinalCompleteValueAt(int index, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSearchStringAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSearchString);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSearchStringAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSearchString);
}
